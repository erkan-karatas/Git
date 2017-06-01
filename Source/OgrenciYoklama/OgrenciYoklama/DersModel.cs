using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama
{
    public class DersModel
    {
        public int ders_id { get; set; }
      
        public string ders_adi { get; set; }
        
        public DateTime baslangic_tarihi { get; set; }
  
        public DateTime bitis_tarihi { get; set; }
 
        public int haftalik_saat { get; set; }
    }
}