namespace ProjektniCentar.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ProjektniCentar.Models;
    using ProjektniCentar.Servisi;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjektniCentar.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjektniCentar.Models.ApplicationDbContext context)
        {

            var userStore = new UserStore<ApplicationUser>(context);

            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(t => t.UserName == "admin@mvcatm.com"))
            {

                var user = new ApplicationUser { UserName = "admin@mvcatm.com", Email = "admin@mvcatm.com" };
                userManager.Create(user, "passW0rd!");

                var service = new Korisnik_Service(context);
                service.NapraviKorisnika("Ado", "User", user.UserName, user.Email);

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });

                context.SaveChanges();

                userManager.AddToRole(user.Id, "Admin");

            }


        }
    }
}
