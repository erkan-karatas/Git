using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Migrations
{
    [Migration(1)]
    public class _001_Tablolar : Migration
    {
        public override void Down()
        {
            Delete.Table("hocalar");
            Delete.Table("yonetici");
            Delete.Table("ogrenci");
            Delete.Table("dersler");
            Delete.Table("bolumler");

        }

        public override void Up()
        {
            Create.Table("bolumler")
                .WithColumn("bolum_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("bolum_adi").AsString(128);

            Create.Table("dersler")
                .WithColumn("ders_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("ders_adi").AsString(128);

            Create.Table("ogrenci")
                .WithColumn("ogrenci_no").AsInt32().PrimaryKey().Identity()
                .WithColumn("ogrenci_ad").AsString(128)
                .WithColumn("ogrenci_soyad").AsString(128)
                .WithColumn("ogrenci_bolum").AsInt32().ForeignKey("bolumler", "bolum_id")
                .WithColumn("ogrenci_ders").AsInt32().ForeignKey("dersler", "ders_id")
                .WithColumn("devamsizlik").AsInt32()
                .WithColumn("ogrenim_tipi").AsString(128);            

            Create.Table("yonetici")
                .WithColumn("yonetici_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("kullanici_adi").AsString(128)
                .WithColumn("sifre").AsString(128);

            Create.Table("hocalar")
                .WithColumn("hoca_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("hoca_adi").AsString(128)
                .WithColumn("hoca_soyadi").AsString(128)
                .WithColumn("hoca_ders").AsInt32().ForeignKey("dersler", "ders_id");
        }
    }
}