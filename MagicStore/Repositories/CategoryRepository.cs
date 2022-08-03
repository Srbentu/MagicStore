using MagicStore.Context;
using MagicStore.Models;
using MagicStore.Repositories.Interfaces;

namespace MagicStore.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> Categories => _context.Categories;
}