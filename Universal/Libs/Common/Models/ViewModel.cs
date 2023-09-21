using System;
using System.Threading.Tasks;
using Core.Interfaces;


namespace Core.Models
{
    public class ViewModel : IViewModel
    {

        protected static IxServer xServer;

        protected IHitPackage data;

        public ViewModel()
        {
         
        }

        public virtual async Task GetDataAsync()
        {
            data = await xServer.GetHitDataAsync();
        }

        public event Action OnChange;

        protected void NotifyStateChanged() => OnChange?.Invoke();
    }
}
