using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class Ogrenci
    {
        public virtual int ogrenci_id { get; set; }
        public virtual int ogrenci_no { get; set; }
        public virtual string ogrenci_ad { get; set; }
        public virtual string ogrenci_soyad { get; set; }
        public virtual string ogrenci_bolum { get; set; }
    }

    public class OgrenciMap : ClassMapping<Ogrenci>
    {
        public OgrenciMap()
        {
            Table("ogrenci");
            Id(x => x.ogrenci_id, x => x.Generator(Generators.Identity));
            Property(x => x.ogrenci_no, x => x.NotNullable(true));
            Property(x => x.ogrenci_ad, x => x.NotNullable(true));
            Property(x => x.ogrenci_soyad, x => x.NotNullable(true));
            Property(x => x.ogrenci_bolum, x => x.NotNullable(true));     
        }

       
    }
}