namespace Csharp_2021_Bestellungen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bestellung")]
    public partial class Bestellung
    {
        [Key]
        public int BestellNr { get; set; }

        public int KundenNr { get; set; }

        [Required]
        [StringLength(1024)]
        public string Text { get; set; }

        [Column(TypeName = "money")]
        public decimal Preis { get; set; }

        public DateTime Datum { get; set; }

        public virtual Kunde Kunde { get; set; }
    }
}
