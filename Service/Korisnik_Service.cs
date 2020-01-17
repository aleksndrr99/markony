using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using ProjektniCentar.Models;
using ProjektniCentar.Models.CentarContext;

namespace ProjektniCentar.Servisi
{
    public class Korisnik_Service : IApplicationDbContext
    {
        private IApplicationDbContext db;

        public Korisnik_Service(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public IDbSet<Kontakt> Kontakts { get ; set ; }
        public IDbSet<Korisnik> Korisniks { get; set; }
        public IDbSet<MailAdresa> MailAdresas { get; set; }
        public IDbSet<Preduzece> Preduzeces { get; set; }
        public IDbSet<Telefon> Telefons { get; set; }


        public void NapraviKorisnika(string ime, string prezime, string username, string email)
        {
            var korisnik = new Korisnik
            {
                Ime = ime,
                Prezime = prezime,
                Username = username,
                Email = email,
            };
            //try
            //{
                if (!db.Korisniks.Any(t => t.Username == korisnik.Username))
                {
                    db.Korisniks.Add(korisnik);
                    db.SaveChanges();
                }
            /*}
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }  */ 
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        
    }
}
