using MagicStore.Models;

namespace MagicStore.ViewModels;

public class CartaListViewModel
{
    public IEnumerable<Carta> Cartas { get; set; }
    public string CategoriaAtual { get; set; }
}