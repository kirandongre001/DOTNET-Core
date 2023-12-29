using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;
using Org.BouncyCastle.Tls;

using BOL;
using DAL;

namespace MVC_App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
        public IActionResult Welcome()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Login(string uname,string password)
    {
        if(uname=="Tushar" && password=="pass123")
        {
            return this.RedirectToAction("Product");
        }
        Console.WriteLine(uname +" "+password);
        return View();
    }
      public IActionResult Register(string uname,string password,string emailId)
    {  
         User ui=new User(uname,password,emailId);
        DBUser.register(ui);
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
