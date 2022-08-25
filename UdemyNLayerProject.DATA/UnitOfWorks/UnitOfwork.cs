using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using UdemyNLayerProject.API.Repository;
using UdemyNlayerProject.CORE.UnitOfWorks;
using UdemyNLayerProject.DATA.Repositorys;

namespace UdemyNLayerProject.DATA.UnitOfWorks
{
    public class UnitOfwork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        
        public IProductRepository Products
        {
            get => _productRepository = _productRepository ?? new ProductRepository(_context);
        }
        public ICategoryRepository Categories
        {
            get => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        }

        public UnitOfwork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}