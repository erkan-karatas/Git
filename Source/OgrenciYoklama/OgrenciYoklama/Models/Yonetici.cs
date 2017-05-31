using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using OgrenciYoklama.Models;

namespace OgrenciYoklama.Models
{
    public class Yonetici
    {
        public virtual int yonetici_id { get; set; }
        [DisplayName("Yönetici adı")]
        public virtual string yonetici_ad { get; set; }
        [DisplayName("Yönetici soyadı")]
        public virtual string yonetici_soyad { get; set; }
        [DisplayName("Kullanıcı adı")]
        public virtual string kullanici_adi { get; set; }
        [DisplayName("Şifre")]
        public virtual string sifre { get; set; }

        public virtual void SetPassword(string password)
        {
            sifre = BCrypt.Net.BCrypt.HashString(password, 13);
        }

        public virtual Boolean checkPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, sifre);
        }

    }

    

    public class YoneticiMap : ClassMapping<Yonetici>
    {
        public YoneticiMap()
        {
            Table("yonetici");
            Id(x => x.yonetici_id, x => x.Generator(Generators.Identity));
            Property(x => x.yonetici_ad, x => x.NotNullable(true));
            Property(x => x.yonetici_soyad, x => x.NotNullable(true));
            Property(x => x.kullanici_adi, x => x.NotNullable(true));
            Property(x => x.sifre, x => x.NotNullable(true));



        }
    }
}