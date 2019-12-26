namespace MVC_Haber_Portalı.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVC_Haber_Portalı.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Haber_Portalı.DAL.MVC_Haber_Portalı_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_Haber_Portalı_Context context)
        {

            if (!context.AboutPage.Any())
            {
                var aboutPage = new AboutPage
                {
                    TitleName = "Örnek Başlık",
                    AboutDescription = "Seed ile gelen içerik bu şekilde kullanılabilir."
                };
                context.AboutPage.Add(aboutPage);
                context.SaveChanges();

            }



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
