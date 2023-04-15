using Microsoft.AspNetCore.Mvc;
using Muziker.Models;

namespace Muziker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["baselist"] = ParseCSV.Parse();
        ViewData["artists"] = ParseCSV.Parse().DistinctBy(x => x.artist).ToList();
        ViewData["songs"] = ParseCSV.Parse().DistinctBy(x => x.song).ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
}