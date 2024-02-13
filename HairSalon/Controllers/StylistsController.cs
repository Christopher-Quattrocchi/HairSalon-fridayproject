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

  public IActionResult Detail(int id)
  {
    var stylist = _db.Stylists.Include(s => s.Clients).FirstOrDefault(s => s.StylistId == id);

    if (stylist == null)
    {
      return NotFound();
    }

    return View(stylist);
  }

  [HttpGet]
  public IActionResult Edit(int id)
  {
    var stylist = _db.Stylists.FirstOrDefault(s => s.StylistId == id);
    if (stylist == null)
    {
      return NotFound();
    }
    return View(stylist);
  }

  [HttpPost]
  public IActionResult Edit(Stylist stylist)
  {
    if (ModelState.IsValid)
    {
      _db.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    return View(stylist);
  }

  [HttpGet]
  public IActionResult Delete(int id)
  {
    Stylist stylist = _db.Stylists.FirstOrDefault(s => s.StylistId == id);
    if (stylist == null)
    {
      return NotFound();
    }
    return View(stylist);
  }

  [HttpPost, ActionName("Delete")]
  public IActionResult DeleteConfirmed(int id)
  {
    Stylist stylist = _db.Stylists.Find(id);
    if (stylist != null)
    {
      _db.Stylists.Remove(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    return NotFound();
  }
}
