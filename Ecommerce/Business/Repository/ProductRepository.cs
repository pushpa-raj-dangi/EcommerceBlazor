using Business.Repository.IRepository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Create(Product product)
        {
            product.CreatedDate = DateTime.UtcNow;
            var addedProduct = await _context.Products.AddAsync(product);

            await _context.Products.AddAsync(product);
            return addedProduct.Entity;
        }

        public async Task<int> Delete(int id, string userId)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public  async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product is null)
                return null;

            return product;

        }



        public async Task<Product> Update(int id, Product product)
        {
            var productInDb = await _context.Products.FindAsync(id);
            productInDb.DateUpdate = DateTime.UtcNow;
            var updatedproduct = _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return updatedproduct.Entity;
        }
    }
}
