using System;
// using System.Timers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// using System.Windows;
using System.Linq;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId {get; set; }

    [Required]
    public string Name {get; set;}
    [Required]
    public string Specialty {get; set;}
    public List<Client> Clients { get; set; } = new List<Client>(); //nav for ef core

    // public Stylist()
    // {
    //   Clients = new HashSet<Client>();
    // }
  }
}