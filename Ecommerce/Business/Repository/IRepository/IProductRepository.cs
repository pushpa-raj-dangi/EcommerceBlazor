using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> Create(Product product);
        public Task<Product> Update(int id, Product product);
        public Task<int> Delete(int id, string userId);
        public Task<IEnumerable<Product>> GetAllProducts();
        public Task<Product> GetProduct(int id);


    }
}
