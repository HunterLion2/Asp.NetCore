namespace dotnet_basics.Models;

public class Product
{
    public string Title { get; set; } // ÜrünBaslık
    public string Description { get; set; } // ÜrünAcıklama
    public int Price { get; set; } // ÜrünFiyat
    public string Image { get; set; } // ÜrünResim
    public bool IsOnSale { get; set; } // ÜrünSatıstamı
    public int StockQuantity { get; set; } // StokAdedi
    public int Id
    {
        get; set;
    }
}