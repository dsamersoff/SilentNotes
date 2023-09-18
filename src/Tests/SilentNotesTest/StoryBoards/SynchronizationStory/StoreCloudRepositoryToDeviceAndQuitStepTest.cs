﻿using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using SilentNotes.Models;
using SilentNotes.Services;
using SilentNotes.Stories;
using SilentNotes.Stories.SynchronizationStory;

namespace SilentNotesTest.Stories.SynchronizationStory
{
    [TestFixture]
    public class StoreCloudRepositoryToDeviceAndQuitStepTest
    {
        [Test]
        public async Task StoresRepositoryToDevice()
        {
            NoteRepositoryModel repositoryModel = new NoteRepositoryModel();
            var model = new SynchronizationStoryModel
            {
                CloudRepository = repositoryModel,
            };

            Mock<IRepositoryStorageService> repositoryStorageService = new Mock<IRepositoryStorageService>();

            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddSingleton<IRepositoryStorageService>(repositoryStorageService.Object)
                .AddSingleton<ILanguageService>(CommonMocksAndStubs.LanguageService());

            // Run step
            var step = new StoreCloudRepositoryToDeviceAndQuitStep();
            var result = await step.RunStep(model, serviceCollection.BuildServiceProvider(), StoryMode.Silent);

            // repository is stored to the local device
            repositoryStorageService.Verify(m => m.TrySaveRepository(It.Is<NoteRepositoryModel>(r => r == repositoryModel)), Times.Once);

            // Next step is called
            Assert.IsInstanceOf<StopAndShowRepositoryStep>(result.NextStep);
        }
    }
}
