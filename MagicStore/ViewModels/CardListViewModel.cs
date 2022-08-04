using MagicStore.Models;

namespace MagicStore.ViewModels;

public class CardListViewModel
{
    public IEnumerable<Card> Cards { get; set; }
    public string CategoryRoot { get; set; }
}