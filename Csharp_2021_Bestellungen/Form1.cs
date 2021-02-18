using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_Bestellungen
{
	public partial class Form1 : Form
	{
		// Globale Eigenschaft: Context zum Zugriff auf die 
		// Datenbank
		BestellungenContext ctx = new BestellungenContext();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// BestellungBindingSource mit Datenbanktabelle "Bestellungen"
			// verknüpfen
			bestellungBindingSource.DataSource = ctx.Bestellungs.ToList();

			// kundenBindingSource mit Datenbanktabelle "Kunden" verknüpfen
			kundeBindingSource.DataSource = ctx.Kundes.ToList();
		}

		private void bestellungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();

			try
			{
				// Aktuelle Auswahl auslesen, casten und in lokaler Variablen speichern
				var bestellung = bestellungBindingSource.Current as Bestellung;

				// Prüfen, ob eine Zeile ausgewählt wurde
				if (bestellung is null) throw new ArgumentException("Bitte Zeile auswählen!");

				// Auf fehlerhafte Benutzereingaben prüfen
				if (txtBestelltext.Text == "") 
					throw new ArgumentException("Bitte Bestelltext eingeben!");
				if (!decimal.TryParse(txtPreis.Text, out decimal preis))
					throw new ArgumentException("Bitte gültigen Preis eingeben!");
				if (preis <= 0) 
					throw new ArgumentException("Bitte Preis > 0€ eingeben!");
				if (!int.TryParse(txtKundennummer.Text, out int kundennummer))
					throw new ArgumentException("Bitte Kunden auswählen!");

				// Dem Objekt "bestellung" diese Eigenschaften zuweisen
				bestellung.KundenNr = kundennummer;
				bestellung.Text = txtBestelltext.Text;
				bestellung.Preis = preis;
				bestellung.Datum = datDatum.Value;

				// Neuen Eintrag der Datenbank hinzufügen, falls die Bestellnummer 0 ist
				// => Die Bestellnummer ist 0, wenn über den Button "Add" im BindingNavigator
				// eine neue Zeile angelegt wurde. Die Bestellnummer wird im neuen Objekt 
				// mit 0 initialisiert.
				if (txtBestellnummer.Text == "0") 
					ctx.Bestellungs.Add(bestellung);

				// Speichern
				ctx.SaveChanges();

				// Aktualisieren der Anzeige
				bestellungDataGridView.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnKundeÜbernehmen_Click(object sender, EventArgs e)
		{
			var bestellung = bestellungBindingSource.Current as Bestellung;
			var kunde = kundeBindingSource.Current as Kunde;

			if (bestellung != null && kunde != null)
			{
				bestellung.KundenNr = kunde.KundenNr;
				bestellungBindingSource.ResetBindings(true);
			}				
		}

		private void bestellungBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			try
			{
				// Aktuell ausgewähltes Objekt auslesen und casten
				var bestellung = bestellungBindingSource.Current as Bestellung;

				// Prüfen, ob ein Objekt ausgewählt wurde
				if (bestellung is null) return;

				// Objekt aus der Datenbank löschen
				ctx.Bestellungs.Remove(bestellung);

				// Speichern
				ctx.SaveChanges();

				// DataGridView updaten
				bestellungBindingSource.DataSource = ctx.Bestellungs.ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnNachKundeFiltern_Click(object sender, EventArgs e)
		{
			try
			{
				// Prüfen, ob Kunde ausgewählt ist
				if (!int.TryParse(txtAusgewählterKunde.Text, out int kunde))
					throw new ArgumentException("Bitte Kunde auswählen.");

				// Filtern
				bestellungBindingSource.DataSource = ctx.Bestellungs
					.Where(b => b.KundenNr == kunde)
					.ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAlleBestellungen_Click(object sender, EventArgs e)
		{
			bestellungBindingSource.DataSource = ctx.Bestellungs.ToList();
		}
	}
}
