using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.API.Repository;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNLayerProject.DATA.Repositorys
{
    public class CategoryRepository: Repository<Category>,ICategoryRepository
    {
        protected AppDbContext AppDbContext {get => _Context as AppDbContext;}
        public CategoryRepository(AppDbContext Context) : base(Context)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int CategoryId)
        {
            return await AppDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(
                x => x.Id == CategoryId);
        }
    }
}