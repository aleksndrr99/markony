namespace ProjektniCentar.Models.CentarContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Preduzece")]
    public partial class Preduzece
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Preduzece()
        {
            Kontakts = new HashSet<Kontakt>();
        }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(30)]
        public string Adresa { get; set; }

        [Required]
        [StringLength(25)]
        public string Opstina { get; set; }

        public int PostanskiBroj { get; set; }

        public int MaticniBrojPreduzeca { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PIB { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string OpisDelatnostiPreduzeca { get; set; }

        [Required]
        [StringLength(20)]
        public string BrojRacunaPreduzeca { get; set; }

        [StringLength(30)]
        public string WebStranica { get; set; }

        [Required]
        public byte[] FotografijaPecata { get; set; }

        [Column(TypeName = "text")]
        public string Beleske { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontakt> Kontakts { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
