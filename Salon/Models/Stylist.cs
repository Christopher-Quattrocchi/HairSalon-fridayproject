using System;
using System.Timers;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId {get; set; }
    public string Name {get; set;}
    public string Specialty {get; set;}
    public virtual ICollection<Client> Clients { get; set; } //nav for ef core

    public Stylist()
    {
      Clients = new HashSet<Client>();
    }
  }
}