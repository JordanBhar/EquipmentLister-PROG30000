using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EquipmentLister.Models;

namespace EquipmentLister.Controllers;

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

    public IActionResult AllEquipmentListing()
    {
        return View(EquipmentListingsRepository.GetAllListings());
    }

    public IActionResult AvaliableEquipmentListing()
    {
        return View(EquipmentListingsRepository.GetAllAvaliableListings());
    }

    public IActionResult RequestForm()
    {
        return View();
    }


    [HttpPost]

    public IActionResult SaveListing(EquipmentListing listing)
    {

        if(ModelState.IsValid)
        {
            EquipmentListingsRepository.AddListing(listing);
            return View("index", listing);
        }

        return View("RequestForm");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
