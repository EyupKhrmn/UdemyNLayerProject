using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;
using UdemyNlayerProject.CORE.Repository;

namespace UdemyNLayerProject.API.Repository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int CategoryId);
    }
}