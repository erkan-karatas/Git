using OgrenciYoklama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Areas.Admin.ViewModels
{
    public class DerslerDersListele
    {
        public IEnumerable<Ders> Dersler { get; set; }
    }
}