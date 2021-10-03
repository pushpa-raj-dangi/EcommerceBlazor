using DataAccess.Models;
using Dtos;
using Ecommerce.Server.Services.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecommerce.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Product> GetProductDetail(int productId)
        {
            
                var response = await _client.GetAsync($"api/product/{productId}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var room = JsonConvert.DeserializeObject<Product>(content);
                    return room;
                }
                else
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                    throw new Exception(errorModel.ErrorMessage);
                }

            
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var response = await _client.GetAsync($"api/products");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
            return rooms;
        }
    }
}
