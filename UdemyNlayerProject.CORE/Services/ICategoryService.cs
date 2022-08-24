using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNlayerProject.CORE.Services
{
    public interface ICategoryService
    {
        Task<Category> GetWithProductsByIdAsync(int CategoryId);
    }
}