using System.Reflection.Metadata.Ecma335;
using MagicStore.Context;
using MagicStore.Models;
using MagicStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicStore.Repositories;

public class CartaRepository : ICartaRepository
{
    private readonly AppDbContext _context;
    public CartaRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Carta> Cartas => _context.Cartas.Include(c=> c.Categoria);
    public IEnumerable<Carta> CartasPreferidas => _context.Cartas.Where(f=> f.IsCartaPreferida).Include(c=> c.Categoria);
    

    public Carta GetCardById(int CartaId)
    {
        return _context.Cartas.FirstOrDefault(l => l.CartaId == CartaId);
    }
}