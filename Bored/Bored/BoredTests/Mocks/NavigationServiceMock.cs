
using Bored.Services.Navigation;
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
        public int GoToTimesCallCount { get; set; }

        public async Task GoBack()
        {
            GoBackCallCount++;
            await Task.Run(() => { });
        }

        public async Task GoToAbout(string about)
        {
            await Task.Run(() => { });
            GoToAboutCallCount++;
        }

        public async Task GoToTimes()
        {
            await Task.Run(() => { });
            GoToTimesCallCount++;
        }
    }
}
