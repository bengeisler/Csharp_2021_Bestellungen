
namespace Csharp_2021_Bestellungen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bestellungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bestellungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.bestellungDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.kundeDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBestellnummer = new System.Windows.Forms.TextBox();
			this.txtKundennummer = new System.Windows.Forms.TextBox();
			this.txtBestelltext = new System.Windows.Forms.TextBox();
			this.datDatum = new System.Windows.Forms.DateTimePicker();
			this.txtPreis = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAusgewählterKunde = new System.Windows.Forms.TextBox();
			this.btnKundeÜbernehmen = new System.Windows.Forms.Button();
			this.btnAlleBestellungen = new System.Windows.Forms.Button();
			this.btnNachKundeFiltern = new System.Windows.Forms.Button();
			this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bestellungBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bestellungBindingNavigator)).BeginInit();
			this.bestellungBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bestellungDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kundeDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bestellungBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// bestellungBindingNavigator
			// 
			this.bestellungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bestellungBindingNavigator.BindingSource = this.bestellungBindingSource;
			this.bestellungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.bestellungBindingNavigator.DeleteItem = null;
			this.bestellungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bestellungBindingNavigatorSaveItem});
			this.bestellungBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.bestellungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bestellungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bestellungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bestellungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bestellungBindingNavigator.Name = "bestellungBindingNavigator";
			this.bestellungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.bestellungBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.bestellungBindingNavigator.TabIndex = 0;
			this.bestellungBindingNavigator.Text = "bindingNavigator1";
			this.bestellungBindingNavigator.RefreshItems += new System.EventHandler(this.bestellungBindingNavigator_RefreshItems);
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
			this.bindingNavigatorCountItem.Text = "von {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Löschen";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// bestellungBindingNavigatorSaveItem
			// 
			this.bestellungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bestellungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bestellungBindingNavigatorSaveItem.Image")));
			this.bestellungBindingNavigatorSaveItem.Name = "bestellungBindingNavigatorSaveItem";
			this.bestellungBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.bestellungBindingNavigatorSaveItem.Text = "Daten speichern";
			this.bestellungBindingNavigatorSaveItem.Click += new System.EventHandler(this.bestellungBindingNavigatorSaveItem_Click);
			// 
			// bestellungDataGridView
			// 
			this.bestellungDataGridView.AllowUserToAddRows = false;
			this.bestellungDataGridView.AllowUserToDeleteRows = false;
			this.bestellungDataGridView.AutoGenerateColumns = false;
			this.bestellungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bestellungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.bestellungDataGridView.DataSource = this.bestellungBindingSource;
			this.bestellungDataGridView.Location = new System.Drawing.Point(6, 58);
			this.bestellungDataGridView.Name = "bestellungDataGridView";
			this.bestellungDataGridView.ReadOnly = true;
			this.bestellungDataGridView.Size = new System.Drawing.Size(666, 220);
			this.bestellungDataGridView.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnNachKundeFiltern);
			this.groupBox1.Controls.Add(this.btnAlleBestellungen);
			this.groupBox1.Controls.Add(this.btnKundeÜbernehmen);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPreis);
			this.groupBox1.Controls.Add(this.datDatum);
			this.groupBox1.Controls.Add(this.txtBestelltext);
			this.groupBox1.Controls.Add(this.txtKundennummer);
			this.groupBox1.Controls.Add(this.txtBestellnummer);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.bestellungDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 328);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bestellungen";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtAusgewählterKunde);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.kundeDataGridView);
			this.groupBox2.Location = new System.Drawing.Point(12, 380);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(678, 293);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kunden";
			// 
			// kundeDataGridView
			// 
			this.kundeDataGridView.AllowUserToAddRows = false;
			this.kundeDataGridView.AllowUserToDeleteRows = false;
			this.kundeDataGridView.AutoGenerateColumns = false;
			this.kundeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.kundeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
			this.kundeDataGridView.DataSource = this.kundeBindingSource;
			this.kundeDataGridView.Location = new System.Drawing.Point(6, 19);
			this.kundeDataGridView.Name = "kundeDataGridView";
			this.kundeDataGridView.ReadOnly = true;
			this.kundeDataGridView.Size = new System.Drawing.Size(666, 220);
			this.kundeDataGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 285);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Bestell Nr:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 285);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kunden Nr:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(160, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Bestelltext";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(378, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Datum:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(378, 306);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Preis:";
			// 
			// txtBestellnummer
			// 
			this.txtBestellnummer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bestellungBindingSource, "BestellNr", true));
			this.txtBestellnummer.Enabled = false;
			this.txtBestellnummer.Location = new System.Drawing.Point(67, 282);
			this.txtBestellnummer.Name = "txtBestellnummer";
			this.txtBestellnummer.Size = new System.Drawing.Size(86, 20);
			this.txtBestellnummer.TabIndex = 7;
			// 
			// txtKundennummer
			// 
			this.txtKundennummer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bestellungBindingSource, "KundenNr", true));
			this.txtKundennummer.Enabled = false;
			this.txtKundennummer.Location = new System.Drawing.Point(227, 282);
			this.txtKundennummer.Name = "txtKundennummer";
			this.txtKundennummer.Size = new System.Drawing.Size(100, 20);
			this.txtKundennummer.TabIndex = 8;
			// 
			// txtBestelltext
			// 
			this.txtBestelltext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bestellungBindingSource, "Text", true));
			this.txtBestelltext.Location = new System.Drawing.Point(227, 303);
			this.txtBestelltext.Name = "txtBestelltext";
			this.txtBestelltext.Size = new System.Drawing.Size(145, 20);
			this.txtBestelltext.TabIndex = 9;
			// 
			// datDatum
			// 
			this.datDatum.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bestellungBindingSource, "Datum", true));
			this.datDatum.Location = new System.Drawing.Point(438, 282);
			this.datDatum.Name = "datDatum";
			this.datDatum.Size = new System.Drawing.Size(200, 20);
			this.datDatum.TabIndex = 10;
			// 
			// txtPreis
			// 
			this.txtPreis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bestellungBindingSource, "Preis", true));
			this.txtPreis.Location = new System.Drawing.Point(438, 303);
			this.txtPreis.Name = "txtPreis";
			this.txtPreis.Size = new System.Drawing.Size(100, 20);
			this.txtPreis.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(544, 306);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Euro";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Ausgewählter Kunde:";
			// 
			// txtAusgewählterKunde
			// 
			this.txtAusgewählterKunde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KundenNr", true));
			this.txtAusgewählterKunde.Enabled = false;
			this.txtAusgewählterKunde.Location = new System.Drawing.Point(121, 243);
			this.txtAusgewählterKunde.Name = "txtAusgewählterKunde";
			this.txtAusgewählterKunde.Size = new System.Drawing.Size(73, 20);
			this.txtAusgewählterKunde.TabIndex = 2;
			// 
			// btnKundeÜbernehmen
			// 
			this.btnKundeÜbernehmen.Location = new System.Drawing.Point(6, 19);
			this.btnKundeÜbernehmen.Name = "btnKundeÜbernehmen";
			this.btnKundeÜbernehmen.Size = new System.Drawing.Size(111, 23);
			this.btnKundeÜbernehmen.TabIndex = 13;
			this.btnKundeÜbernehmen.Text = "Kunde übernehmen";
			this.btnKundeÜbernehmen.UseVisualStyleBackColor = true;
			this.btnKundeÜbernehmen.Click += new System.EventHandler(this.btnKundeÜbernehmen_Click);
			// 
			// btnAlleBestellungen
			// 
			this.btnAlleBestellungen.Location = new System.Drawing.Point(429, 19);
			this.btnAlleBestellungen.Name = "btnAlleBestellungen";
			this.btnAlleBestellungen.Size = new System.Drawing.Size(100, 23);
			this.btnAlleBestellungen.TabIndex = 14;
			this.btnAlleBestellungen.Text = "Alle Bestellungen";
			this.btnAlleBestellungen.UseVisualStyleBackColor = true;
			this.btnAlleBestellungen.Click += new System.EventHandler(this.btnAlleBestellungen_Click);
			// 
			// btnNachKundeFiltern
			// 
			this.btnNachKundeFiltern.Location = new System.Drawing.Point(535, 19);
			this.btnNachKundeFiltern.Name = "btnNachKundeFiltern";
			this.btnNachKundeFiltern.Size = new System.Drawing.Size(137, 23);
			this.btnNachKundeFiltern.TabIndex = 15;
			this.btnNachKundeFiltern.Text = "Nach Kunde filtern";
			this.btnNachKundeFiltern.UseVisualStyleBackColor = true;
			this.btnNachKundeFiltern.Click += new System.EventHandler(this.btnNachKundeFiltern_Click);
			// 
			// kundeBindingSource
			// 
			this.kundeBindingSource.DataSource = typeof(Csharp_2021_Bestellungen.Kunde);
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "KundenNr";
			this.dataGridViewTextBoxColumn7.HeaderText = "KundenNr";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn8.HeaderText = "Name";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Adresse";
			this.dataGridViewTextBoxColumn9.HeaderText = "Adresse";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "PLZ";
			this.dataGridViewTextBoxColumn10.HeaderText = "PLZ";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Ort";
			this.dataGridViewTextBoxColumn11.HeaderText = "Ort";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "Telefon";
			this.dataGridViewTextBoxColumn12.HeaderText = "Telefon";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			// 
			// bestellungBindingSource
			// 
			this.bestellungBindingSource.DataSource = typeof(Csharp_2021_Bestellungen.Bestellung);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "BestellNr";
			this.dataGridViewTextBoxColumn1.HeaderText = "BestellNr";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "KundenNr";
			this.dataGridViewTextBoxColumn2.HeaderText = "KundenNr";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Text";
			this.dataGridViewTextBoxColumn3.HeaderText = "Text";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Preis";
			this.dataGridViewTextBoxColumn4.HeaderText = "Preis";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Datum";
			this.dataGridViewTextBoxColumn5.HeaderText = "Datum";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 711);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bestellungBindingNavigator);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bestellungBindingNavigator)).EndInit();
			this.bestellungBindingNavigator.ResumeLayout(false);
			this.bestellungBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bestellungDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kundeDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bestellungBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bestellungBindingSource;
		private System.Windows.Forms.BindingNavigator bestellungBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bestellungBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView bestellungDataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView kundeDataGridView;
		private System.Windows.Forms.BindingSource kundeBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPreis;
		private System.Windows.Forms.DateTimePicker datDatum;
		private System.Windows.Forms.TextBox txtBestelltext;
		private System.Windows.Forms.TextBox txtKundennummer;
		private System.Windows.Forms.TextBox txtBestellnummer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.Button btnKundeÜbernehmen;
		private System.Windows.Forms.TextBox txtAusgewählterKunde;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnNachKundeFiltern;
		private System.Windows.Forms.Button btnAlleBestellungen;
	}
}

