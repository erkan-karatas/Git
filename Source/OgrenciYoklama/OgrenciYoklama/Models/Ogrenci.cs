using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using OgrenciYoklama.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class Ogrenci
    {
        public virtual int OgrenciNo { get; set; }
        public virtual string OgrenciAd { get; set; }
        public virtual string OgrenciSoyad { get; set; }
        public virtual int OgrenciBolum { get; set; }
        public virtual int Devamsizlik { get; set; }
        public virtual int OgrenciDers { get; set; }
        public virtual string OgrenimTipi { get; set; }

    }
}