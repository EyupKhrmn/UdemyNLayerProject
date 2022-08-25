using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;
using UdemyNlayerProject.CORE.Repository;
using UdemyNlayerProject.CORE.Services;
using UdemyNlayerProject.CORE.UnitOfWorks;

namespace UdemyNLayerProject.SERVİCE.Services
{
    public class CategoryService: Service<Category>,ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }  

        public async Task<Category> GetWithProductsByIdAsync(int CategoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsByIdAsync(CategoryId);
        }
    }
}