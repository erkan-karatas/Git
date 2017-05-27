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
        public virtual int ogrenci_no { get; set; }
        public virtual string ogrenci_ad { get; set; }
        public virtual string ogrenci_soyad { get; set; }
        public virtual string ogrenci_bolum { get; set; }
        public virtual int devamsizlik { get; set; }
        public virtual string ogrenci_ders { get; set; }
        public virtual string ogrenim_tipi { get; set; }

    }

    public class OgrenciMap : ClassMapping<Ogrenci>
    {
        public OgrenciMap()
        {
            Table("ogrenci");
            Id(x => x.ogrenci_no, x => x.Generator(Generators.Identity));
            Property(x => x.ogrenci_ad, x => x.NotNullable(true));
            Property(x => x.ogrenci_soyad, x => x.NotNullable(true));
            Property(x => x.ogrenci_bolum, x => x.NotNullable(true));
            Property(x => x.ogrenci_ders, x => x.NotNullable(true));
            Property(x => x.devamsizlik, x => x.NotNullable(true));
            Property(x => x.ogrenim_tipi, x => x.NotNullable(true));

            /*Bag(x => x.ogrenci_bolum,
                x => {
                    x.Table("bolumler"); //pivot table name
                    x.Key(k => k.Column("bolum_id")); //which column in pivot table stores user class key value -> user_id
                }, x => x.ManyToMany(k => k.Column("ogrenci_bolum")));*/ //which column in pivot table stores role class key value -> role_id
        }
    }
}