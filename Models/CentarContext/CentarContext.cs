namespace ProjektniCentar.Models.CentarContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CentarContext : DbContext
    {
        public CentarContext()
            : base("name=CentarContext")
        {
        }

        public virtual DbSet<Kontakt> Kontakts { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<MailAdresa> MailAdresas { get; set; }
        public virtual DbSet<Preduzece> Preduzeces { get; set; }
        public virtual DbSet<Telefon> Telefons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kontakt>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Kontakt>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Kontakt>()
                .HasMany(e => e.Telefons)
                .WithRequired(e => e.Kontakt)
                .HasForeignKey(e => e.ID_Kontakt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kontakt>()
                .HasMany(e => e.MailAdresas)
                .WithRequired(e => e.Kontakt)
                .HasForeignKey(e => e.ID_Kontakt);

            modelBuilder.Entity<Kontakt>()
                .HasMany(e => e.Telefons1)
                .WithRequired(e => e.Kontakt1)
                .HasForeignKey(e => e.ID_Kontakt);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<MailAdresa>()
                .Property(e => e.OznakaTipa)
                .IsUnicode(false);

            modelBuilder.Entity<MailAdresa>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.Opstina)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.OpisDelatnostiPreduzeca)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.BrojRacunaPreduzeca)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.WebStranica)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.Beleske)
                .IsUnicode(false);

            modelBuilder.Entity<Preduzece>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Telefon>()
                .Property(e => e.OznakaTipa)
                .IsUnicode(false);

            modelBuilder.Entity<Telefon>()
                .Property(e => e.BrojTelefona)
                .IsUnicode(false);

            modelBuilder.Entity<Telefon>()
                .Property(e => e.Lokal)
                .IsUnicode(false);
        }
    }
}
