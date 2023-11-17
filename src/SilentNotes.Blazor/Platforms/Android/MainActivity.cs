﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using CommunityToolkit.Mvvm.Messaging;
using SilentNotes.Services;
using static Android.Views.ViewTreeObserver;

namespace SilentNotes
{
	[Activity(
		Label = "SilentNotes",
		Theme = "@style/Maui.SplashTheme",
		MainLauncher = true,
		LaunchMode = LaunchMode.SingleTask,
		Exported = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : MauiAppCompatActivity, IOnPreDrawListener
	{
		public Guid Id { get; } = Guid.NewGuid();
		private Android.Views.View _contentView;
		private bool _splashScreenCanBeClosed = false;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Delay closing of splash screen until app is ready:
			// https://developer.android.com/develop/ui/views/launch/splash-screen#suspend-drawing
			WeakReferenceMessenger.Default.Register<MainLayoutReadyMessage>(
				this, async (recipient, message) => await OnMainLayoutReady());
			_contentView = FindViewById<Android.Views.View>(Android.Resource.Id.Content);
			_contentView.ViewTreeObserver.AddOnPreDrawListener(this);
		}

		private Task OnMainLayoutReady()
		{
			WeakReferenceMessenger.Default.Unregister<MainLayoutReadyMessage>(this);
			_splashScreenCanBeClosed = true;
			return Task.CompletedTask;
		}

		/// <summary>
		/// By overwriting this method, we can keep the splashscreen open until the application is
		/// ready, avoiding unnecessary flickering.
		/// </summary>
		/// <returns>Returns true if the app is ready and the splash screen can be closed.</returns>
		public bool OnPreDraw()
		{
			if (_splashScreenCanBeClosed)
			{
				_contentView.ViewTreeObserver.RemoveOnPreDrawListener(this);
				return true;
			}
			return false;
		}

		/// <inheritdoc/>
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			// Workaround: Unfortunately the back button will automatically navigate back whenever
			// possible, there is no way to intercept it in MainPage.OnBackButtonPressed().
			if ((e.KeyCode == Keycode.Back) && (e.Action == KeyEventActions.Down))
			{
				// Ask the page to close currently open menus and dialogs.
				var message = new BackButtonPressedMessage { Handled = false };
				WeakReferenceMessenger.Default.Send(message);
				if (message.Handled)
					return true;

				// Check whether a backward navigation should take place (the WebView browser history is
				// deactivated, so it would always close the app).
				var navigation = Ioc.Instance.GetService<INavigationService>();
				if (navigation.CanNavigateBack)
				{
					navigation.NavigateBack();
					return true;
				}
			}
			return base.DispatchKeyEvent(e);
		}
	}
}
