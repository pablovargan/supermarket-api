using Microsoft.EntityFrameworkCore;
using Supermarket.Api.Domain.Models;
using Supermarket.Api.Domain.Repositories;
using Supermarket.Api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Api.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddAsync(Category category)
        {
            // Add the model to our set, but data won't be saved (in-memory db)
            await _context.Categories.AddAsync(category);
        }
    }
}
