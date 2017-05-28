using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Models
{
    public class Yonetici
    {
        public virtual int yonetici_id { get; set; }
        public virtual string kullanici_adi { get; set; }
        public virtual string sifre { get; set; }
    }

    public class YoneticiMap : ClassMapping<Yonetici>
    {
        public YoneticiMap()
        {
            Table("yonetici");
            Id(x => x.yonetici_id, x => x.Generator(Generators.Identity));
            Property(x => x.kullanici_adi, x => x.NotNullable(true));
            Property(x => x.sifre, x => x.NotNullable(true));

           

        }
    }
}