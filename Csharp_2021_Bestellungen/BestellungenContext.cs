using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Csharp_2021_Bestellungen
{
	public partial class BestellungenContext : DbContext
	{
		public BestellungenContext()
				: base("name=BestellungenContext")
		{
		}

		public virtual DbSet<Bestellung> Bestellungs { get; set; }
		public virtual DbSet<Kunde> Kundes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Bestellung>()
					.Property(e => e.Text)
					.IsUnicode(false);

			modelBuilder.Entity<Bestellung>()
					.Property(e => e.Preis)
					.HasPrecision(19, 4);

			modelBuilder.Entity<Kunde>()
					.Property(e => e.Name)
					.IsUnicode(false);

			modelBuilder.Entity<Kunde>()
					.Property(e => e.Adresse)
					.IsUnicode(false);

			modelBuilder.Entity<Kunde>()
					.Property(e => e.PLZ)
					.IsUnicode(false);

			modelBuilder.Entity<Kunde>()
					.Property(e => e.Ort)
					.IsUnicode(false);

			modelBuilder.Entity<Kunde>()
					.Property(e => e.Telefon)
					.IsUnicode(false);

			modelBuilder.Entity<Kunde>()
					.HasMany(e => e.Bestellungs)
					.WithRequired(e => e.Kunde)
					.WillCascadeOnDelete(false);
		}
	}
}
