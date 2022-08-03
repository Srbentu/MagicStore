using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicStore.Models;

[Table("Cards")]
public class Card
{
    [Key]
    public int CardId { get; set; }
    [Required(ErrorMessage = "O nome do card deve ser informado")]
    [Display(Name = "Nome do Card")]
    public string CardName { get; set; }
    [Required(ErrorMessage = "O tipo do card deve ser informado")]
    public string CardType { get; set; }
    [Required(ErrorMessage = "A cor do card deve ser informado")]
    public string CardColor { get; set; }
    [Required (ErrorMessage = "A Descrição do Card deve ser informada")]
    [Display(Name = "Descrição do Card")]
    [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
    public string CardShortDescripton { get; set; }
    public string CardLongDescription { get; set; }
    [Required(ErrorMessage = "o Preço do card deve ser informado")]
    public decimal CardPrice { get; set; }
    public string CardImageUrl { get; set; }
    public string CardImageThumbnailUrl { get; set; }
    public bool CardFavorite { get; set; }
    public bool CardSoldOut { get; set; }

    [NotMapped]
    public DateTime CardCriationTime { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}