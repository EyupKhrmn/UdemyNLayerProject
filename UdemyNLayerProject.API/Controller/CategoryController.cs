using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UdemyNLayerProject.API.Controller.BaseController;
using UdemyNLayerProject.API.DTOs;
using UdemyNlayerProject.CORE.Model;
using UdemyNlayerProject.CORE.Services;

namespace UdemyNLayerProject.API.Controller
{
    public class CategoryController : BaseApıController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(category));
        }


        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
           var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
            return Created(string.Empty,_mapper.Map<CategoryDto>(category));
        }


        [HttpPut]
        public IActionResult Update(CategoryDto categoryDto)
        {
            var category = _categoryService.Update(_mapper.Map<Category>(categoryDto));
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleted(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            _categoryService.Remove(category);
            return NoContent();
        }

        [HttpGet("{id}/Products")]
        public async Task<IActionResult> GetWithProductsByIdAsync(int id)
        {
            var category = await _categoryService.GetWithProductsByIdAsync(id);
            return Ok(_mapper.Map<CategoryWithProductDto>(category));
        }
    }
}