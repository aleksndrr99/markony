using Microsoft.AspNet.Identity.EntityFramework;
using ProjektniCentar.Migrations;
using ProjektniCentar.Models.CentarContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektniCentar.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<Kontakt> Kontakts { get; set; }
        IDbSet<Korisnik> Korisniks { get; set; }
        IDbSet<MailAdresa> MailAdresas { get; set; }
        IDbSet<Preduzece> Preduzeces { get; set; }
        IDbSet<Telefon> Telefons { get; set; }

        int SaveChanges();
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("CentarContext", throwIfV1Schema: false)
        {
        }

        public IDbSet<Kontakt> Kontakts { get; set; }
        public IDbSet<Korisnik> Korisniks { get; set; }
        public IDbSet<MailAdresa> MailAdresas { get; set; }
        public IDbSet<Preduzece> Preduzeces { get; set; }
        public IDbSet<Telefon> Telefons { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
