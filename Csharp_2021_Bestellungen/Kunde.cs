namespace Csharp_2021_Bestellungen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kunde")]
    public partial class Kunde
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kunde()
        {
            Bestellungs = new HashSet<Bestellung>();
        }

        [Key]
        public int KundenNr { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Adresse { get; set; }

        [Required]
        [StringLength(5)]
        public string PLZ { get; set; }

        [Required]
        [StringLength(50)]
        public string Ort { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bestellung> Bestellungs { get; set; }
    }
}
