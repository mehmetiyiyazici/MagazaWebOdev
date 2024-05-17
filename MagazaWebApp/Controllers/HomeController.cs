using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MagazaWebApp.Models;

namespace MagazaWebApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var posts = getAllPosts();
    
        return View(posts);
       
    }
    public List<Post> getAllPosts()
    {
        var posts = new List<Post>();
        using StreamReader reader = new StreamReader("AppData/posts/index.txt");
        var postsTxt = reader.ReadToEnd();
        var postsLines = postsTxt.Split('\n');
        foreach (var postLine in postsLines)
        {
            var postParts = postLine.Split('|');
            posts.Add(
                new Post()
                {
                    Title = postParts[0],
                    Summary = postParts[1],
                    ImgUrl = postParts[2],
                    Slug = postParts[3]
                }
            );
        }
        return posts;
    }

    
}