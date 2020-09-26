using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bored.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Bored.Mocks;
using BoredTests.Mocks;
using System.Threading.Tasks;
using System.Threading;
using Nito.AsyncEx;

namespace Bored.ViewModels.Tests
{
    [TestClass()]
    public class MainPageViewModelTests
    {

        [TestMethod()]
        public async Task Load_Should_Fetch_Random_From_Api()
        {
            //Arrange
            var sut = sutFactory();

            //Act
            //Calling a method is pretty straight forward
            await sut.Load();

            //Assert
            Assert.AreEqual(sut.Activity.Substring(0,8), "Go fish!");
        }

        [TestMethod()]
        public void GoToAbout_Should_Call_NavigationService_Once()
        {
            //Arrange
            var sut = sutFactory();

            //Act
            //Testing async command is harder than it looks
            AsyncContext.Run(() =>
            {
                sut.GoToAboutCommand.Execute(null);
            });

            //Assert
            Assert.AreEqual((sut.NavigationService as NavigationServiceMock).GoToAboutCallCount, 1);
        }

        private MainPageViewModel sutFactory()
        {
            var sut = new MainPageViewModel();
            sut.ApiService = new ApiServiceMock();
            sut.NavigationService = new NavigationServiceMock();

            return sut;
        }
    }
}