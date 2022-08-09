using MagicStore.Context;

namespace MagicStore.Models;

public class ShopCart
{
    private readonly AppDbContext _context;

    public ShopCart(AppDbContext context)
    {
        _context = context;
    }


    public string ShopCartId { get; set; }
    
    public List<ShopCartItem> ShopCartItems { get; set; }

    public static ShopCart GetCart(IServiceProvider services)
    {
        //Define uma sessão
        ISession session =
            services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
        
        //Obtem um serviço do tipo do nosso contexto
        var context = services.GetService<AppDbContext>();
        
        //Obtem ou gera o ID do carrinho
        string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
        
        //Atribui o id do carrinho na Sessão
        session.SetString("CartId", cartId);

        //Retorna o carrino com o contexto e o Id atribuido ou obtido
        return new ShopCart(context)
        {
            ShopCartId = cartId
        };
    }

    public void AddCart(Card card)
    {
        var cartShopItem = _context.ShopCartItens.SingleOrDefault(
            s=> s.Card.CardId == card.CardId &&
                s.shopCartId == ShopCartId);
        if (cartShopItem == null)
        {
            cartShopItem = new ShopCartItem()
            {
                shopCartId = ShopCartId,
                Card = card,
                amount = 1
            };
            _context.ShopCartItens.Add(cartShopItem);
        }
        else
        {
            cartShopItem.amount++;
        }

        _context.SaveChanges();
    }

    public int RemoveCart(Card card)
    {
        var cartShopItem = _context.ShopCartItens.SingleOrDefault(
            s=> s.Card.CardId == card.CardId &&
                s.shopCartId == ShopCartId);

        var LocalAmount = 0;

        if (cartShopItem != null)
        {
            if (cartShopItem.amount > 1)
            {
                cartShopItem.amount--;
                LocalAmount = cartShopItem.amount;
            }
            else
            {
                _context.ShopCartItens.Remove(cartShopItem);
            }
        }

        _context.SaveChanges();
        return LocalAmount;
    }
}