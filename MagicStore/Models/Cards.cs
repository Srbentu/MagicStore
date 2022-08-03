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
    [StringLength(80, MinimumLength = 2, ErrorMessage = "o nome deve ter menos de 80 caracteres, e mais de 2 caracteres")]
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
    [Required (ErrorMessage = "A Descrição detalhada do Card deve ser informada")]
    [Display(Name = "Descrição detalhada do Card")]
    [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
    public string CardLongDescription { get; set; }
    [Required(ErrorMessage = "o Preço do card deve ser informado")]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(0.1, 1000, ErrorMessage = "O preço deve estar entre 0,10 e 1000")]
    public decimal CardPrice { get; set; }
    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "a Url deve ter no máximo 200 caracteres")]
    public string CardImageUrl { get; set; }
    [Display(Name = "Caminho Imagem miniatura")]
    [StringLength(200, ErrorMessage = "a Url deve ter no máximo 200 caracteres")]
    public string CardImageThumbnailUrl { get; set; }
    [Display(Name = "Preferido ?")]
    public bool CardFavorite { get; set; }
    [Display(Name = "Estoque")]
    public bool CardSoldOut { get; set; }

    [NotMapped]
    public DateTime CardCriationTime { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}