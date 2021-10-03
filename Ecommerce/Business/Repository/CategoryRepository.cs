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
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Category> Create(Category category)
        {
            var addedCategory = await _context.Categories.AddAsync(category);

            await _context.Categories.AddAsync(category);
            return addedCategory.Entity;
        }

        public async Task<int> Delete(int id, string userId)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category is null)
                return null;

            return category;

        }

        public async Task<Category> Update(int id, Category category)
        {
            var CategoryInDb = await _context.Categories.FindAsync(id);
            var updatedCategory = _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return updatedCategory.Entity;
        }
    }
}
