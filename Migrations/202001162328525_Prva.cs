namespace ProjektniCentar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prva : DbMigration
    {
        public override void Up()
        {
            /*
            CreateTable(
                "dbo.Kontakt",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 30),
                        Prezime = c.String(nullable: false, maxLength: 30),
                        PIB = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Preduzece", t => t.PIB, cascadeDelete: true)
                .Index(t => t.PIB);
            
            CreateTable(
                "dbo.MailAdresa",
                c => new
                    {
                        Adresa = c.String(nullable: false, maxLength: 30),
                        OznakaTipa = c.String(nullable: false, maxLength: 30),
                        ID_Kontakt = c.Int(nullable: false),
                        Kontakt_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Adresa)
                .ForeignKey("dbo.Kontakt", t => t.Kontakt_ID)
                .Index(t => t.Kontakt_ID);
            
            CreateTable(
                "dbo.Preduzece",
                c => new
                    {
                        PIB = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 50),
                        Adresa = c.String(nullable: false, maxLength: 30),
                        Opstina = c.String(nullable: false, maxLength: 25),
                        PostanskiBroj = c.Int(nullable: false),
                        MaticniBrojPreduzeca = c.Int(nullable: false),
                        OpisDelatnostiPreduzeca = c.String(nullable: false, unicode: false, storeType: "text"),
                        BrojRacunaPreduzeca = c.String(nullable: false, maxLength: 20),
                        WebStranica = c.String(maxLength: 30),
                        FotografijaPecata = c.Binary(nullable: false),
                        Beleske = c.String(unicode: false, storeType: "text"),
                        Username = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.PIB)
                .ForeignKey("dbo.Korisnik", t => t.Username, cascadeDelete: true)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 20),
                        Ime = c.String(nullable: false, maxLength: 30),
                        Prezime = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Telefon",
                c => new
                    {
                        BrojTelefona = c.String(nullable: false, maxLength: 18),
                        OznakaTipa = c.String(nullable: false, maxLength: 30),
                        Lokal = c.String(maxLength: 20),
                        ID_Kontakt = c.Int(nullable: false),
                        Kontakt_ID = c.Int(),
                        Kontakt1_ID = c.Int(),
                        Kontakt_ID1 = c.Int(),
                        Kontakt_ID2 = c.Int(),
                    })
                .PrimaryKey(t => t.BrojTelefona)
                .ForeignKey("dbo.Kontakt", t => t.Kontakt_ID)
                .ForeignKey("dbo.Kontakt", t => t.Kontakt1_ID)
                .ForeignKey("dbo.Kontakt", t => t.Kontakt_ID1)
                .ForeignKey("dbo.Kontakt", t => t.Kontakt_ID2)
                .Index(t => t.Kontakt_ID)
                .Index(t => t.Kontakt1_ID)
                .Index(t => t.Kontakt_ID1)
                .Index(t => t.Kontakt_ID2);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            */
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Telefon", "Kontakt_ID2", "dbo.Kontakt");
            DropForeignKey("dbo.Telefon", "Kontakt_ID1", "dbo.Kontakt");
            DropForeignKey("dbo.Telefon", "Kontakt1_ID", "dbo.Kontakt");
            DropForeignKey("dbo.Telefon", "Kontakt_ID", "dbo.Kontakt");
            DropForeignKey("dbo.Preduzece", "Username", "dbo.Korisnik");
            DropForeignKey("dbo.Kontakt", "PIB", "dbo.Preduzece");
            DropForeignKey("dbo.MailAdresa", "Kontakt_ID", "dbo.Kontakt");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Telefon", new[] { "Kontakt_ID2" });
            DropIndex("dbo.Telefon", new[] { "Kontakt_ID1" });
            DropIndex("dbo.Telefon", new[] { "Kontakt1_ID" });
            DropIndex("dbo.Telefon", new[] { "Kontakt_ID" });
            DropIndex("dbo.Preduzece", new[] { "Username" });
            DropIndex("dbo.MailAdresa", new[] { "Kontakt_ID" });
            DropIndex("dbo.Kontakt", new[] { "PIB" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Telefon");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Preduzece");
            DropTable("dbo.MailAdresa");
            DropTable("dbo.Kontakt");
        }
    }
}
