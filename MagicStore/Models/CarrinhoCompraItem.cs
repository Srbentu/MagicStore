using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicStore.Models;
[Table("CarrinhoCompraItens")]
public class CarrinhoCompraItem
{
    public int CarrinhoCompraItemId { get; set; }
    
    public Carta Carta { get; set; }
    
    public int Quantidade { get; set; }
    [StringLength(200)]
    public string CarrinhoCompraId { get; set; }
}