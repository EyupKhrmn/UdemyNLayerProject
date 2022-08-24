using System.Threading.Tasks;
using UdemyNLayerProject.API.Repository;

namespace UdemyNlayerProject.CORE.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        
        ICategoryRepository Categories { get; }
        
        Task CommitAsync();

        void Commit();
    }
}