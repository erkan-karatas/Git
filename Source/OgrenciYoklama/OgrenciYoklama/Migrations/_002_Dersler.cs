using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OgrenciYoklama.Migrations
{
    [Migration(2)]
    public class _002_Dersler : Migration
    {
        public override void Down()
        {
            Delete.Table("dersler");
        }

        public override void Up()
        {
            Create.Table("dersler")
                 .WithColumn("ders_id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("ders_adi").AsString(128)
                 .WithColumn("baslangic_tarihi").AsDate()
                 .WithColumn("bitis_tarihi").AsDate()
                 .WithColumn("haftalik_saat").AsInt32();
        }
    }
}