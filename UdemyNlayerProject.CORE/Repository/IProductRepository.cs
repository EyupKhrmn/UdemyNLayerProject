using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;
using UdemyNlayerProject.CORE.Repository;

namespace UdemyNLayerProject.API.Repository
{
    public interface IProductRepository: IRepository<Product>
    {
        Task<Product> GetWithCategoryById(int ProductId);
    }
}