using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateShipment()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create()
    {
      ParcelShipment newParcel = new ParcelShipment(ht, wd, lgt, wgt);
      return View("Index", newParcel);
    
    }
  }
}