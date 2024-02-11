using System;
using System.Timers;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId {get; set;}
    public string Name {get; set; }
    public int StylistId {get; set;} //foreign key
    // public List<Stylist> Stylists { get; set; } = new List<Stylist>(); //this doesn't work?
    public virtual Stylist Stylist { get; set; } //allow Client to store Stylist



  }
}