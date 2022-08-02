namespace MagicStore.Models;

public class Cards
{
    public int CardId { get; set; }
    public string CardName { get; set; }
    public string CardType { get; set; }
    public string CardColor { get; set; }
    public string CardShortDescripton { get; set; }
    public string CardLongDescription { get; set; }
    public decimal CardPrice { get; set; }
    public string CardImageUrl { get; set; }
    public string CardImageThumbnailUrl { get; set; }
    public bool CardFavorite { get; set; }
    public bool CardSoldOut { get; set; }
    
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}