using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNlayerProject.CORE.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryById(int ProductId);
    }
}