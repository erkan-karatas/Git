using OgrenciYoklama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OgrenciYoklama.Areas.Admin.ViewModels
{
    public class OgrencilerOgrenciListele
    {
        public IEnumerable<Ogrenci> Ogrenciler { get; set; }
    }
}