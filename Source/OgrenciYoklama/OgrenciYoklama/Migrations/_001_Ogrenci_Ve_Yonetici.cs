using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Migrations
{
    [Migration(1)]
    public class _001_Ogrenci_Ve_Yonetici : Migration
    {
        public override void Down()
        {
            
            Delete.Table("yonetici");
            Delete.Table("ogrenci");

        }

        public override void Up()
        {

            Create.Table("ogrenci")
                  .WithColumn("ogrenci_id").AsInt32().PrimaryKey().Identity()
                  .WithColumn("ogrenci_no").AsInt32()
                  .WithColumn("ogrenci_ad").AsString(128)
                  .WithColumn("ogrenci_soyad").AsString(128)
                  .WithColumn("ogrenci_bolum").AsString(128);
                
           Create.Table("yonetici")
                .WithColumn("yonetici_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("yonetici_ad").AsString(128)
                .WithColumn("yonetici_soyad").AsString(128)
                .WithColumn("kullanici_adi").AsString(128)
                .WithColumn("sifre").AsString(128);

            
        }
    }
}