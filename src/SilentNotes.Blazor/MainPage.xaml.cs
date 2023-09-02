﻿using CommunityToolkit.Mvvm.Messaging;

namespace SilentNotes;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Loaded += LoadedEventHandler;
	}

    private async void LoadedEventHandler(object sender, EventArgs e)
    {
        Loaded -= LoadedEventHandler;
#if (WINDOWS && !DEBUG)
        var webView2 = (blazorWebView.Handler.PlatformView as Microsoft.UI.Xaml.Controls.WebView2);
        await webView2.EnsureCoreWebView2Async();
        var settings = webView2.CoreWebView2.Settings;
        settings.AreBrowserAcceleratorKeysEnabled = false; // In debug mode we need ctrl-shift-i to open the developer view
        settings.IsPasswordAutosaveEnabled = false;
#else
        await Task.CompletedTask;
#endif
    }
}
