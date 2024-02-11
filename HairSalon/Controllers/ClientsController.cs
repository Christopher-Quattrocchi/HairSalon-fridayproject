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

public IActionResult Index()
{
    var clients = _db.Clients.Include(c => c.Stylist).ToList(); //stylist MUST BE included for each client or the whole thing doesn't work
    return View(clients);
}

  [HttpGet]
  public IActionResult Create(int? stylistId)
  {
    var stylists = _db.Stylists.Select(s => new { s.StylistId, s.Name});
    ViewBag.Stylists = new SelectList(stylists, "StylistId", "Name", stylistId);
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

  public IActionResult Detail(int id)
  {
    var client = _db.Clients.Include(c => c.Stylist).FirstOrDefault(c => c.ClientId == id);
    if (client == null)
    {
      return NotFound();
    }
    return View(client);
  }
}



