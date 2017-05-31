using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class Ogrenci
    {
        public virtual int ogrenci_id { get; set; }
        [DisplayName("Öğrenci no")]
        public virtual int ogrenci_no { get; set; }
        [DisplayName("Ad")]
        public virtual string ogrenci_ad { get; set; }
        [DisplayName("Soyad")]
        public virtual string ogrenci_soyad { get; set; }
        [DisplayName("Bölüm")]
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