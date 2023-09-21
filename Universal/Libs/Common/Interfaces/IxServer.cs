using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IxServer
    {
        Task<IHitPackage> GetHitDataAsync();
    }
}
