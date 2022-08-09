using MagicStore.Context;
using MagicStore.Models;
using MagicStore.Repositories.Interfaces;

namespace MagicStore.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Categoria> Categorias => _context.Categorias;
}