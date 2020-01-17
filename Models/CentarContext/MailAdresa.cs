namespace ProjektniCentar.Models.CentarContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MailAdresa")]
    public partial class MailAdresa
    {
        [Required]
        [StringLength(30)]
        public string OznakaTipa { get; set; }

        [Key]
        [StringLength(30)]
        public string Adresa { get; set; }

        public int ID_Kontakt { get; set; }

        public virtual Kontakt Kontakt { get; set; }
    }
}
