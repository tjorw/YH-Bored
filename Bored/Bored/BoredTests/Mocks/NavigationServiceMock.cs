using Bored.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoredTests.Mocks
{
    class NavigationServiceMock : INavigationService
    {
        public int GoBackCallCount { get; set; }
        public int GoToAboutCallCount { get; set; }

        public async Task GoBack()
        {
            await Task.Run(() => { });
            GoBackCallCount++;
        }

        public async Task GoToAbout(string about)
        {
            await Task.Run(() => { });
            GoToAboutCallCount++;
        }
    }
}
