using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.API.Repository;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNLayerProject.DATA.Repositorys
{
    public class ProductRepository: Repository<Product>,IProductRepository
    {
        protected AppDbContext AppDbContext {get=> _Context as AppDbContext;}
        public ProductRepository(AppDbContext Context) : base(Context)
        {
        }

        public async Task<Product> GetWithCategoryById(int ProductId)
        {
           return await AppDbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(
                x => x.Id == ProductId);
        }
    }
}