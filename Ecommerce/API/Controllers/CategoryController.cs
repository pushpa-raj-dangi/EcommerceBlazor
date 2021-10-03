using Business.Repository.IRepository;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            await _categoryRepository.Create(category);
            return Ok(category);

        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var category = await _categoryRepository.GetAllCategories();
            return Ok(category);

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            await _categoryRepository.Update(id, category);
            return Ok(category);

        }

    }
}
