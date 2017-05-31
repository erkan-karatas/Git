using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class ogrenciders
    {
        public IEnumerable<Ogrenci> Ogrenciler { get; set; }
        public IEnumerable<Ders> Dersler { get; set; }
    }
}