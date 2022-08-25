using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UdemyNLayerProject.API.Controller.BaseController;
using UdemyNlayerProject.CORE.Services;

namespace UdemyNLayerProject.API.Controller
{
    public class CategoryController : BaseApıController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = _categoryService.GetAllAsync();
            return Ok(categories);
        }
    }
}