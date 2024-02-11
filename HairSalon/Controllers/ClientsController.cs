using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers;

public class ClientsController : Controller
{
  private readonly HairSalonContext _db;

  public ClientsController(HairSalonContext db)
  {
    _db = db;
  }

  [HttpGet]
  public IActionResult Create()
  {
    ViewBag.Stylists = new SelectList(_db.Stylists, "StylistId", "Name");
    return View();
  }

  [HttpPost]
  public IActionResult Create(Client client)
  {
    if (ModelState.IsValid)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    ViewBag.Stylists = new SelectList(_db.Stylists, "StylistId", "Name", client.StylistId);
    return View(client);
  }
}



