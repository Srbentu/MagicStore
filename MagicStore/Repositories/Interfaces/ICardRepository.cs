using MagicStore.Models;

namespace MagicStore.Repositories.Interfaces;

public interface ICardRepository
{
    IEnumerable<Card> Cards { get; }
    IEnumerable<Card> CardFavorite { get; }
    Card GetCardById(int CardId);

}