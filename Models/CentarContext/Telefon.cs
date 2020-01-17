namespace ProjektniCentar.Models.CentarContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telefon")]
    public partial class Telefon
    {
        [Required]
        [StringLength(30)]
        public string OznakaTipa { get; set; }

        [Key]
        [StringLength(18)]
        public string BrojTelefona { get; set; }

        [StringLength(20)]
        public string Lokal { get; set; }

        public int ID_Kontakt { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Kontakt Kontakt1 { get; set; }
    }
}
