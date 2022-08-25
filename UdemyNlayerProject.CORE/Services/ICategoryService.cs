using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNlayerProject.CORE.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int CategoryId);
    }
}