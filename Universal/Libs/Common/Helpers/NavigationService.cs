using Microsoft.AspNetCore.Components;
using Core.Interfaces;

namespace Core.Helpers
{
    public class NavigationService : INavigationService
    {
        private NavigationManager _navigationManager;
        public NavigationService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void ChangePage(string page)
        {
            _navigationManager.NavigateTo(page);
        }
    }
}
