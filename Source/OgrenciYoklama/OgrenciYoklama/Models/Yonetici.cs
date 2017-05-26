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
        public virtual int YoneticiId { get; set; }
        public virtual string KullaniciAdi { get; set; }
        public virtual string Sifre { get; set; }
    }

    public class YoneticiMap : ClassMapping<Yonetici>
    {
        public YoneticiMap()
        {
            Table("yonetici");
            Id(x => x.YoneticiId, x => x.Generator(Generators.Identity));

            Property(x => x.KullaniciAdi, x => x.NotNullable(true));
            Property(x => x.Sifre, x => x.NotNullable(true));

        }
    }
}