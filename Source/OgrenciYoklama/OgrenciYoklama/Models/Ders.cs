using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using OgrenciYoklama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class Ders
    {
        public virtual int ders_id { get; set; }
        public virtual string ders_adi { get; set; }
        public virtual DateTime baslangic_tarihi { get; set; }
        public virtual DateTime bitis_tarihi { get; set; }
        public virtual int haftalik_saat { get; set; }
    }

    public class DersMap : ClassMapping<Ders>
    {
        public DersMap()
        {
            Table("dersler");
            Id(x => x.ders_id, x => x.Generator(Generators.Identity));
            Property(x => x.ders_adi, x => x.NotNullable(true));
            Property(x => x.baslangic_tarihi, x => x.NotNullable(true));
            Property(x => x.bitis_tarihi, x => x.NotNullable(true));
            Property(x => x.haftalik_saat, x => x.NotNullable(true));
        }
    }
}