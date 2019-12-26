namespace MVC_Haber_Portalı.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galeri",
                c => new
                    {
                        GaleriId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.GaleriId);
            
            CreateTable(
                "dbo.Haber",
                c => new
                    {
                        HaberId = c.Int(nullable: false, identity: true),
                        HaberAdi = c.String(nullable: false, maxLength: 50),
                        HaberAciklama = c.String(),
                        Haberİcerik = c.String(),
                        HaberBaslik = c.String(maxLength: 500),
                        HaberAltBaslik = c.String(),
                        HaberResimYolu = c.String(maxLength: 500),
                        KategoriId = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        YayinlamaTarihi = c.DateTime(nullable: false),
                        aktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HaberId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Yazar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                        KategoriAciklama = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Yazar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                        Soyad = c.String(nullable: false, maxLength: 50),
                        Eposta = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 15),
                        Rol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        HaberId = c.Int(nullable: false),
                        Ad = c.String(nullable: false, maxLength: 50),
                        Soyad = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Message = c.String(nullable: false, maxLength: 500),
                        YorumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Haber", t => t.HaberId, cascadeDelete: true)
                .Index(t => t.HaberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorum", "HaberId", "dbo.Haber");
            DropForeignKey("dbo.Haber", "YazarId", "dbo.Yazar");
            DropForeignKey("dbo.Haber", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Yorum", new[] { "HaberId" });
            DropIndex("dbo.Haber", new[] { "YazarId" });
            DropIndex("dbo.Haber", new[] { "KategoriId" });
            DropTable("dbo.Yorum");
            DropTable("dbo.Yazar");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Haber");
            DropTable("dbo.Galeri");
        }
    }
}
