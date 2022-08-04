using MagicStore.Repositories.Interfaces;
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
        var cards = _cardRepository.Cards;
        return View(cards);
    }
}