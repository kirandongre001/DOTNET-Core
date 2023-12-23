using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shop;
using Shopping.Models;

namespace Shopping.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Pindex()
    {
        Product p=new Product();
        p.Pid=1;
        p.Pname="Coffee";
        p.Qty=20;
        p.Price=60;
        ViewData["Product"]=p;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
