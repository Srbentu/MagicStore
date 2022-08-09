using MagicStore.Models;

namespace MagicStore.Repositories.Interfaces;

public interface ICartaRepository
{
    IEnumerable<Carta> Cartas { get; }
    IEnumerable<Carta> CartasPreferidas { get; }
    Carta GetCardById(int CartaId);

}