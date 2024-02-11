//in stylistscontroller
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
// using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers;

public class StylistsController : Controller
{
 
  private readonly HairSalonContext _db;

  public StylistsController(HairSalonContext db)
  {
    _db = db;
  }

  [HttpGet]
  public IActionResult Create()
  {
    return View();
  }
  [HttpPost]
  public IActionResult Create(Stylist stylist)
  {
    if (ModelState.IsValid)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    return View(stylist);
  }

  public ActionResult Index()
  {
    var stylists = _db.Stylists.ToList();
    return View(stylists);
  }

}
  