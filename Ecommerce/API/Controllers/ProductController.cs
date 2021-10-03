using Business.Repository;
using Business.Repository.IRepository;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePoroduct(Product product )
        {
            await _productRepository.Create(product);
            return Ok(product);

        }

        [HttpGet]
        public async Task<IActionResult> GetPoroducts()
        {
            var product = await _productRepository.GetAllProducts();
            return Ok(product);

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> CreatePoroduct(int id, Product product)
        {
            await _productRepository.Update(id, product);
            return Ok(product);

        }
    }
}
