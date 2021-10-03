using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Server.Services.IService
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetProducts();

        public Task<Product> GetProductDetail(int productId);

    }
}
