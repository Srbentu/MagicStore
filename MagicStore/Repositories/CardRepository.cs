using System.Reflection.Metadata.Ecma335;
using MagicStore.Context;
using MagicStore.Models;
using MagicStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicStore.Repositories;

public class CardRepository : ICardRepository
{
    private readonly AppDbContext _context;
    public CardRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Card> Cards => _context.Cards.Include(c=> c.Category);
    public IEnumerable<Card> CardFavorite => _context.Cards.Where(f=> f.CardFavorite).Include(c=> c.Category);
    

    public Card GetCardById(int CardId)
    {
        return _context.Cards.FirstOrDefault(l => l.CardId == CardId);
    }
}