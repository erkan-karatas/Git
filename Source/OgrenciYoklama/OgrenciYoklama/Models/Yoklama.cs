using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class Yoklama
    {
        public virtual int yoklama_id { get; set; }
        public virtual int ogrenci_id { get; set; }
        public virtual int ders_id { get; set; }
        public virtual bool durum { get; set; }
    }

    public class YoklamaMap : ClassMapping<Yoklama>
    {
        public YoklamaMap()
        {
            Table("yoklama");
            Id(x => x.yoklama_id, x => x.Generator(Generators.Identity));
            Property(x => x.ogrenci_id, x => x.NotNullable(true));
            Property(x => x.ders_id, x => x.NotNullable(true));
            Property(x => x.durum, x => x.NotNullable(true));
        }


    }
}