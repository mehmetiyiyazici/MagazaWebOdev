namespace MagazaWebApp.Models;

public class Post
{
    public string Title { get; set; } // başlık
    public string Summary { get; set; } // özet
    public string ImgUrl { get; set; }
    public string Slug { get; set; } // kullanici dostu adres icin kullandigimiz terim
}