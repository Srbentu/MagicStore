using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicStore.Models;
[Table("ShopCartItem")]
public class ShopCartItem
{
    public int ShopCartItemId { get; set; }
    
    public Card Card { get; set; }
    
    public int Amount { get; set; }
    [StringLength(200)]
    public string ShopCartId { get; set; }
}