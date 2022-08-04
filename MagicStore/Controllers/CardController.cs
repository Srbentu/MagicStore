using MagicStore.Repositories.Interfaces;
using MagicStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagicStore.Controllers;

public class CardController : Controller
{
    private readonly ICardRepository _cardRepository;
    public CardController(ICardRepository cardRepository)
    {
        _cardRepository = cardRepository;
    }

    public IActionResult List()
    {
        //var cards = _cardRepository.Cards;
        //return View(cards);
        var cardListViewModel = new CardListViewModel();
        cardListViewModel.Cards = _cardRepository.Cards;
        cardListViewModel.CategoryRoot = "Categoria Atual";
        return View(cardListViewModel);
    }
}