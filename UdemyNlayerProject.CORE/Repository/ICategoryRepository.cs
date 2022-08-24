using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNLayerProject.API.Repository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int CategoryId);
    }
}