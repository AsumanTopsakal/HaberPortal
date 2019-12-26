namespace MVC_Haber_Portalı.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikinci : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kategoriler", "KategoriAdi", c => c.String());
            AlterColumn("dbo.Kategoriler", "KategoriAciklama", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kategoriler", "KategoriAciklama", c => c.String(maxLength: 250));
            AlterColumn("dbo.Kategoriler", "KategoriAdi", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
