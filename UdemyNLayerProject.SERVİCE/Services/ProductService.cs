using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UdemyNlayerProject.CORE.Model;
using UdemyNlayerProject.CORE.Repository;
using UdemyNlayerProject.CORE.Services;
using UdemyNlayerProject.CORE.UnitOfWorks;

namespace UdemyNLayerProject.SERVİCE.Services
{
    public class ProductService: Service<Product>,IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryById(int ProductId)
        {
            return await  _unitOfWork.Products.GetWithCategoryById(ProductId);
        }
    }
}