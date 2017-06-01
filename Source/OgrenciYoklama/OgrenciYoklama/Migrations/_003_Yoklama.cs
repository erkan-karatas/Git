using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Migrations
{
    [Migration(3)]
    public class _003_Yoklama : Migration
    {
        public override void Down()
        {
            Delete.Table("yoklama");
        }

        public override void Up()
        {
            Create.Table("yoklama")
                 .WithColumn("yoklama_id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("yoklama_tarih").AsDate()
                 .WithColumn("ogrenci_id").AsString(256)
                 .WithColumn("ders_id").AsString(128)
                 .WithColumn("durum").AsBoolean();
        }
    }
}