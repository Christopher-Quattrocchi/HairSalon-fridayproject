using System;
using System.Timers;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId {get; set;}
    public string Name {get; set; }
    public int StylistId {get; set;} //foreign key
    public List<Stylist> Stylists { get; set; } = new List<Stylist>(); 


  }
}