//in stylistscontroller
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Salon.Controllers
{
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
      _context.Stylists.Add(stylist);
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    return View(stylist);
  }
}