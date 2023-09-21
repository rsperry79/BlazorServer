using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IViewModel
    {
        event Action OnChange;

        Task GetDataAsync();
    }
}
