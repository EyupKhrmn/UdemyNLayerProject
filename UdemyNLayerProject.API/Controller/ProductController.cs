using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UdemyNLayerProject.API.Controller.BaseController;
using UdemyNLayerProject.API.DTOs;
using UdemyNlayerProject.CORE.Services;

namespace UdemyNLayerProject.API.Controller
{
    public class ProductController : BaseApıController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var product = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(product));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(product));
        }
    }
}