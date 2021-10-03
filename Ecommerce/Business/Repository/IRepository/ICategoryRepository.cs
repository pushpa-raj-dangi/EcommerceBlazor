using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<Category> Create(Category category);
        public Task<Category> Update(int id, Category category);
        public Task<int> Delete(int id, string userId);
        public Task<IEnumerable<Category>> GetAllCategories();
        public Task<Category> GetCategory(int id);
    }
}
