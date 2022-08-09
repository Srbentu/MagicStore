using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicStore.Models;

[Table("Cartas")]
public class Carta
{
    [Key]
    public int CartaId { get; set; }
    [Required(ErrorMessage = "O nome do card deve ser informado")]
    [Display(Name = "Nome do Card")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "o nome deve ter menos de 80 caracteres, e mais de 2 caracteres")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O tipo do card deve ser informado")]
    public string CartaTipo { get; set; }
    [Required(ErrorMessage = "A cor do card deve ser informado")]
    public string CartaCor { get; set; }
    [Required (ErrorMessage = "A Descrição do Card deve ser informada")]
    [Display(Name = "Descrição do Card")]
    [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
    public string DescricaoCurta { get; set; }
    [Required (ErrorMessage = "A Descrição detalhada do Card deve ser informada")]
    [Display(Name = "Descrição detalhada do Card")]
    [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
    public string DescricaoDetalhada { get; set; }
    [Required(ErrorMessage = "o Preço do card deve ser informado")]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(0.1, 1000, ErrorMessage = "O preço deve estar entre 0,10 e 1000")]
    public decimal Preco { get; set; }
    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "a Url deve ter no máximo 200 caracteres")]
    public string ImagemUrl { get; set; }
    [Display(Name = "Caminho Imagem miniatura")]
    [StringLength(200, ErrorMessage = "a Url deve ter no máximo 200 caracteres")]
    public string ImagemThumbnailUrl { get; set; }
    [Display(Name = "Preferido ?")]
    public bool IsCartaPreferida { get; set; }
    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}