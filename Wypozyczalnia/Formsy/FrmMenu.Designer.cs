namespace Wypozyczalnia.Formsy
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_dodaj_wyp = new System.Windows.Forms.Button();
            this.btn_pokaz_wyp = new System.Windows.Forms.Button();
            this.wyp_cmb_typ = new System.Windows.Forms.ComboBox();
            this.wyp_cmb_porownanie = new System.Windows.Forms.ComboBox();
            this.wyp_cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.wyp_txt_filtr = new System.Windows.Forms.TextBox();
            this.wyp_cb_spoznione = new System.Windows.Forms.CheckBox();
            this.wyp_dtg_historia = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kli_cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.kli_txt_filtr = new System.Windows.Forms.TextBox();
            this.kli_btn_usun_klienta = new System.Windows.Forms.Button();
            this.kli_btn_dodaj_klienta = new System.Windows.Forms.Button();
            this.kli_btn_pokaz_profil = new System.Windows.Forms.Button();
            this.kli_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kli_btn_edytuj_klienta = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fil_cb_napisy = new System.Windows.Forms.CheckBox();
            this.fil_cb_lektor = new System.Windows.Forms.CheckBox();
            this.fil_cmb_porownanie = new System.Windows.Forms.ComboBox();
            this.fil_cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.fil_txt_filtr = new System.Windows.Forms.TextBox();
            this.fil_btn_pokaz_film = new System.Windows.Forms.Button();
            this.fil_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fil_btn_edytuj_film = new System.Windows.Forms.Button();
            this.fil_btn_usun_film = new System.Windows.Forms.Button();
            this.fil_btn_dodaj_film = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tar_cmb_porownanie = new System.Windows.Forms.ComboBox();
            this.tar_cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.tar_txt_filtr = new System.Windows.Forms.TextBox();
            this.tar_btn_usun = new System.Windows.Forms.Button();
            this.tar_btn_edytuj = new System.Windows.Forms.Button();
            this.tar_btn_dodaj = new System.Windows.Forms.Button();
            this.tar_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tar_btn_pokaz_taryfe = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tag_btn_pokaz = new System.Windows.Forms.Button();
            this.oso_btn_pokaz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oso_txt_filtr = new System.Windows.Forms.TextBox();
            this.tag_txt_filtr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oso_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tag_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wyp_dtg_historia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kli_dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fil_dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tar_dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oso_dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage1.Controls.Add(this.btn_dodaj_wyp);
            this.tabPage1.Controls.Add(this.btn_pokaz_wyp);
            this.tabPage1.Controls.Add(this.wyp_cmb_typ);
            this.tabPage1.Controls.Add(this.wyp_cmb_porownanie);
            this.tabPage1.Controls.Add(this.wyp_cmb_kolumna);
            this.tabPage1.Controls.Add(this.wyp_txt_filtr);
            this.tabPage1.Controls.Add(this.wyp_cb_spoznione);
            this.tabPage1.Controls.Add(this.wyp_dtg_historia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wypożyczenia";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btn_dodaj_wyp
            // 
            this.btn_dodaj_wyp.Location = new System.Drawing.Point(710, 376);
            this.btn_dodaj_wyp.Name = "btn_dodaj_wyp";
            this.btn_dodaj_wyp.Size = new System.Drawing.Size(136, 49);
            this.btn_dodaj_wyp.TabIndex = 7;
            this.btn_dodaj_wyp.Text = "NOWE WYPOŻYCZENIE";
            this.btn_dodaj_wyp.UseVisualStyleBackColor = true;
            this.btn_dodaj_wyp.Click += new System.EventHandler(this.btn_dodaj_wyp_Click);
            // 
            // btn_pokaz_wyp
            // 
            this.btn_pokaz_wyp.Location = new System.Drawing.Point(524, 376);
            this.btn_pokaz_wyp.Name = "btn_pokaz_wyp";
            this.btn_pokaz_wyp.Size = new System.Drawing.Size(180, 49);
            this.btn_pokaz_wyp.TabIndex = 6;
            this.btn_pokaz_wyp.Text = "POKAŻ WYPOŻYCZENIE";
            this.btn_pokaz_wyp.UseVisualStyleBackColor = true;
            this.btn_pokaz_wyp.Click += new System.EventHandler(this.btn_pokaz_wyp_Click);
            // 
            // wyp_cmb_typ
            // 
            this.wyp_cmb_typ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wyp_cmb_typ.FormattingEnabled = true;
            this.wyp_cmb_typ.Items.AddRange(new object[] {
            "Niezwrócone",
            "Zwrócone",
            "Wszystkie"});
            this.wyp_cmb_typ.Location = new System.Drawing.Point(7, 6);
            this.wyp_cmb_typ.Name = "wyp_cmb_typ";
            this.wyp_cmb_typ.Size = new System.Drawing.Size(121, 21);
            this.wyp_cmb_typ.TabIndex = 0;
            this.wyp_cmb_typ.SelectedIndexChanged += new System.EventHandler(this.wyp_cmb_typ_SelectedIndexChanged);
            // 
            // wyp_cmb_porownanie
            // 
            this.wyp_cmb_porownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wyp_cmb_porownanie.Enabled = false;
            this.wyp_cmb_porownanie.FormattingEnabled = true;
            this.wyp_cmb_porownanie.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.wyp_cmb_porownanie.Location = new System.Drawing.Point(261, 6);
            this.wyp_cmb_porownanie.Name = "wyp_cmb_porownanie";
            this.wyp_cmb_porownanie.Size = new System.Drawing.Size(53, 21);
            this.wyp_cmb_porownanie.TabIndex = 2;
            this.wyp_cmb_porownanie.SelectedIndexChanged += new System.EventHandler(this.wyp_cmb_porownanie_SelectedIndexChanged);
            // 
            // wyp_cmb_kolumna
            // 
            this.wyp_cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wyp_cmb_kolumna.FormattingEnabled = true;
            this.wyp_cmb_kolumna.Items.AddRange(new object[] {
            "ID Wypożyczenia",
            "ID Klienta",
            "Nazwisko",
            "Imię",
            "ID Filmu",
            "Tytuł polski",
            "Dni wypożyczenia",
            "Cena",
            "Data wypożyczenia",
            "Termin zwrotu",
            "Data zwrotu"});
            this.wyp_cmb_kolumna.Location = new System.Drawing.Point(134, 6);
            this.wyp_cmb_kolumna.Name = "wyp_cmb_kolumna";
            this.wyp_cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.wyp_cmb_kolumna.TabIndex = 1;
            this.wyp_cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.wyp_cmb_kolumna_SelectedIndexChanged);
            // 
            // wyp_txt_filtr
            // 
            this.wyp_txt_filtr.Location = new System.Drawing.Point(320, 6);
            this.wyp_txt_filtr.Name = "wyp_txt_filtr";
            this.wyp_txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.wyp_txt_filtr.TabIndex = 3;
            this.wyp_txt_filtr.TextChanged += new System.EventHandler(this.wyp_txt_filtr_TextChanged);
            this.wyp_txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wyp_txt_filtr_KeyPress);
            // 
            // wyp_cb_spoznione
            // 
            this.wyp_cb_spoznione.AutoSize = true;
            this.wyp_cb_spoznione.Location = new System.Drawing.Point(770, 8);
            this.wyp_cb_spoznione.Name = "wyp_cb_spoznione";
            this.wyp_cb_spoznione.Size = new System.Drawing.Size(76, 17);
            this.wyp_cb_spoznione.TabIndex = 4;
            this.wyp_cb_spoznione.Text = "Spóźnione";
            this.wyp_cb_spoznione.UseVisualStyleBackColor = true;
            this.wyp_cb_spoznione.CheckedChanged += new System.EventHandler(this.wyp_cb_spoznione_CheckedChanged);
            // 
            // wyp_dtg_historia
            // 
            this.wyp_dtg_historia.AllowUserToAddRows = false;
            this.wyp_dtg_historia.AllowUserToDeleteRows = false;
            this.wyp_dtg_historia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.wyp_dtg_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wyp_dtg_historia.Location = new System.Drawing.Point(7, 33);
            this.wyp_dtg_historia.MultiSelect = false;
            this.wyp_dtg_historia.Name = "wyp_dtg_historia";
            this.wyp_dtg_historia.ReadOnly = true;
            this.wyp_dtg_historia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wyp_dtg_historia.Size = new System.Drawing.Size(839, 337);
            this.wyp_dtg_historia.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage2.Controls.Add(this.kli_cmb_kolumna);
            this.tabPage2.Controls.Add(this.kli_txt_filtr);
            this.tabPage2.Controls.Add(this.kli_btn_usun_klienta);
            this.tabPage2.Controls.Add(this.kli_btn_dodaj_klienta);
            this.tabPage2.Controls.Add(this.kli_btn_pokaz_profil);
            this.tabPage2.Controls.Add(this.kli_dataGridView1);
            this.tabPage2.Controls.Add(this.kli_btn_edytuj_klienta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            // 
            // kli_cmb_kolumna
            // 
            this.kli_cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kli_cmb_kolumna.FormattingEnabled = true;
            this.kli_cmb_kolumna.Items.AddRange(new object[] {
            "ID",
            "Imię",
            "Nazwisko",
            "PESEL",
            "Nr. dowodu",
            "Nr. telefonu",
            "E-Mail",
            "Miejscowość",
            "Kod pocztowy",
            "Ulica",
            "Nr. domu"});
            this.kli_cmb_kolumna.Location = new System.Drawing.Point(7, 6);
            this.kli_cmb_kolumna.Name = "kli_cmb_kolumna";
            this.kli_cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.kli_cmb_kolumna.TabIndex = 0;
            this.kli_cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.kli_cmb_kolumna_SelectedIndexChanged);
            // 
            // kli_txt_filtr
            // 
            this.kli_txt_filtr.Location = new System.Drawing.Point(134, 7);
            this.kli_txt_filtr.Name = "kli_txt_filtr";
            this.kli_txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.kli_txt_filtr.TabIndex = 1;
            this.kli_txt_filtr.TextChanged += new System.EventHandler(this.kli_txt_filtr_TextChanged);
            this.kli_txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kli_txt_filtr_KeyPress);
            // 
            // kli_btn_usun_klienta
            // 
            this.kli_btn_usun_klienta.Location = new System.Drawing.Point(710, 376);
            this.kli_btn_usun_klienta.Name = "kli_btn_usun_klienta";
            this.kli_btn_usun_klienta.Size = new System.Drawing.Size(136, 49);
            this.kli_btn_usun_klienta.TabIndex = 6;
            this.kli_btn_usun_klienta.Text = "USUŃ KLIENTA";
            this.kli_btn_usun_klienta.UseVisualStyleBackColor = true;
            this.kli_btn_usun_klienta.Click += new System.EventHandler(this.kli_btn_usun_klienta_Click);
            // 
            // kli_btn_dodaj_klienta
            // 
            this.kli_btn_dodaj_klienta.Location = new System.Drawing.Point(426, 376);
            this.kli_btn_dodaj_klienta.Name = "kli_btn_dodaj_klienta";
            this.kli_btn_dodaj_klienta.Size = new System.Drawing.Size(136, 49);
            this.kli_btn_dodaj_klienta.TabIndex = 4;
            this.kli_btn_dodaj_klienta.Text = "DODAJ KLIENTA";
            this.kli_btn_dodaj_klienta.UseVisualStyleBackColor = true;
            this.kli_btn_dodaj_klienta.Click += new System.EventHandler(this.kli_btn_dodaj_klienta_Click);
            // 
            // kli_btn_pokaz_profil
            // 
            this.kli_btn_pokaz_profil.Location = new System.Drawing.Point(240, 376);
            this.kli_btn_pokaz_profil.Name = "kli_btn_pokaz_profil";
            this.kli_btn_pokaz_profil.Size = new System.Drawing.Size(180, 49);
            this.kli_btn_pokaz_profil.TabIndex = 3;
            this.kli_btn_pokaz_profil.Text = "POKAŻ PROFIL";
            this.kli_btn_pokaz_profil.UseVisualStyleBackColor = true;
            this.kli_btn_pokaz_profil.Click += new System.EventHandler(this.kli_btn_pokaz_profil_Click);
            // 
            // kli_dataGridView1
            // 
            this.kli_dataGridView1.AllowUserToAddRows = false;
            this.kli_dataGridView1.AllowUserToDeleteRows = false;
            this.kli_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kli_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kli_dataGridView1.Location = new System.Drawing.Point(7, 33);
            this.kli_dataGridView1.MultiSelect = false;
            this.kli_dataGridView1.Name = "kli_dataGridView1";
            this.kli_dataGridView1.ReadOnly = true;
            this.kli_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kli_dataGridView1.Size = new System.Drawing.Size(839, 337);
            this.kli_dataGridView1.TabIndex = 2;
            this.kli_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kli_dataGridView1_CellDoubleClick);
            // 
            // kli_btn_edytuj_klienta
            // 
            this.kli_btn_edytuj_klienta.Location = new System.Drawing.Point(568, 376);
            this.kli_btn_edytuj_klienta.Name = "kli_btn_edytuj_klienta";
            this.kli_btn_edytuj_klienta.Size = new System.Drawing.Size(136, 49);
            this.kli_btn_edytuj_klienta.TabIndex = 5;
            this.kli_btn_edytuj_klienta.Text = "EDYTUJ KLIENTA";
            this.kli_btn_edytuj_klienta.UseVisualStyleBackColor = true;
            this.kli_btn_edytuj_klienta.Click += new System.EventHandler(this.kli_btn_edytuj_klienta_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage3.Controls.Add(this.fil_cb_napisy);
            this.tabPage3.Controls.Add(this.fil_cb_lektor);
            this.tabPage3.Controls.Add(this.fil_cmb_porownanie);
            this.tabPage3.Controls.Add(this.fil_cmb_kolumna);
            this.tabPage3.Controls.Add(this.fil_txt_filtr);
            this.tabPage3.Controls.Add(this.fil_btn_pokaz_film);
            this.tabPage3.Controls.Add(this.fil_dataGridView1);
            this.tabPage3.Controls.Add(this.fil_btn_edytuj_film);
            this.tabPage3.Controls.Add(this.fil_btn_usun_film);
            this.tabPage3.Controls.Add(this.fil_btn_dodaj_film);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(855, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filmy";
            // 
            // fil_cb_napisy
            // 
            this.fil_cb_napisy.AutoSize = true;
            this.fil_cb_napisy.Location = new System.Drawing.Point(788, 8);
            this.fil_cb_napisy.Name = "fil_cb_napisy";
            this.fil_cb_napisy.Size = new System.Drawing.Size(58, 17);
            this.fil_cb_napisy.TabIndex = 4;
            this.fil_cb_napisy.Text = "Napisy";
            this.fil_cb_napisy.UseVisualStyleBackColor = true;
            this.fil_cb_napisy.CheckedChanged += new System.EventHandler(this.fil_cb_napisy_CheckedChanged);
            // 
            // fil_cb_lektor
            // 
            this.fil_cb_lektor.AutoSize = true;
            this.fil_cb_lektor.Location = new System.Drawing.Point(726, 8);
            this.fil_cb_lektor.Name = "fil_cb_lektor";
            this.fil_cb_lektor.Size = new System.Drawing.Size(56, 17);
            this.fil_cb_lektor.TabIndex = 3;
            this.fil_cb_lektor.Text = "Lektor";
            this.fil_cb_lektor.UseVisualStyleBackColor = true;
            this.fil_cb_lektor.CheckedChanged += new System.EventHandler(this.fil_cb_lektor_CheckedChanged);
            // 
            // fil_cmb_porownanie
            // 
            this.fil_cmb_porownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fil_cmb_porownanie.Enabled = false;
            this.fil_cmb_porownanie.FormattingEnabled = true;
            this.fil_cmb_porownanie.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.fil_cmb_porownanie.Location = new System.Drawing.Point(134, 6);
            this.fil_cmb_porownanie.Name = "fil_cmb_porownanie";
            this.fil_cmb_porownanie.Size = new System.Drawing.Size(53, 21);
            this.fil_cmb_porownanie.TabIndex = 1;
            this.fil_cmb_porownanie.SelectedIndexChanged += new System.EventHandler(this.fil_cmb_porownanie_SelectedIndexChanged);
            // 
            // fil_cmb_kolumna
            // 
            this.fil_cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fil_cmb_kolumna.FormattingEnabled = true;
            this.fil_cmb_kolumna.Items.AddRange(new object[] {
            "ID",
            "Tytuł polski",
            "Tytuł oryginalny",
            "Rok produkcji",
            "Gatunek",
            "Dystrybutor",
            "Kraj",
            "Długość",
            "Nośnik",
            "ID taryfy"});
            this.fil_cmb_kolumna.Location = new System.Drawing.Point(7, 6);
            this.fil_cmb_kolumna.Name = "fil_cmb_kolumna";
            this.fil_cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.fil_cmb_kolumna.TabIndex = 0;
            this.fil_cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.fil_cmb_kolumna_SelectedIndexChanged);
            // 
            // fil_txt_filtr
            // 
            this.fil_txt_filtr.Location = new System.Drawing.Point(193, 6);
            this.fil_txt_filtr.Name = "fil_txt_filtr";
            this.fil_txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.fil_txt_filtr.TabIndex = 2;
            this.fil_txt_filtr.TextChanged += new System.EventHandler(this.fil_txt_filtr_TextChanged);
            this.fil_txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fil_txt_filtr_KeyPress);
            // 
            // fil_btn_pokaz_film
            // 
            this.fil_btn_pokaz_film.Location = new System.Drawing.Point(240, 376);
            this.fil_btn_pokaz_film.Name = "fil_btn_pokaz_film";
            this.fil_btn_pokaz_film.Size = new System.Drawing.Size(180, 49);
            this.fil_btn_pokaz_film.TabIndex = 6;
            this.fil_btn_pokaz_film.Text = "POKAŻ FILM";
            this.fil_btn_pokaz_film.UseVisualStyleBackColor = true;
            this.fil_btn_pokaz_film.Click += new System.EventHandler(this.fil_btn_pokaz_film_Click);
            // 
            // fil_dataGridView1
            // 
            this.fil_dataGridView1.AllowUserToAddRows = false;
            this.fil_dataGridView1.AllowUserToDeleteRows = false;
            this.fil_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fil_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fil_dataGridView1.Location = new System.Drawing.Point(7, 33);
            this.fil_dataGridView1.MultiSelect = false;
            this.fil_dataGridView1.Name = "fil_dataGridView1";
            this.fil_dataGridView1.ReadOnly = true;
            this.fil_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fil_dataGridView1.Size = new System.Drawing.Size(839, 337);
            this.fil_dataGridView1.TabIndex = 5;
            this.fil_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fil_dataGridView1_CellDoubleClick);
            // 
            // fil_btn_edytuj_film
            // 
            this.fil_btn_edytuj_film.Location = new System.Drawing.Point(568, 376);
            this.fil_btn_edytuj_film.Name = "fil_btn_edytuj_film";
            this.fil_btn_edytuj_film.Size = new System.Drawing.Size(136, 49);
            this.fil_btn_edytuj_film.TabIndex = 8;
            this.fil_btn_edytuj_film.Text = "EDYTUJ FILM";
            this.fil_btn_edytuj_film.UseVisualStyleBackColor = true;
            this.fil_btn_edytuj_film.Click += new System.EventHandler(this.fil_btn_edytuj_film_Click);
            // 
            // fil_btn_usun_film
            // 
            this.fil_btn_usun_film.Location = new System.Drawing.Point(710, 376);
            this.fil_btn_usun_film.Name = "fil_btn_usun_film";
            this.fil_btn_usun_film.Size = new System.Drawing.Size(136, 49);
            this.fil_btn_usun_film.TabIndex = 9;
            this.fil_btn_usun_film.Text = "USUŃ FILM";
            this.fil_btn_usun_film.UseVisualStyleBackColor = true;
            this.fil_btn_usun_film.Click += new System.EventHandler(this.fil_btn_usun_film_Click);
            // 
            // fil_btn_dodaj_film
            // 
            this.fil_btn_dodaj_film.Location = new System.Drawing.Point(426, 376);
            this.fil_btn_dodaj_film.Name = "fil_btn_dodaj_film";
            this.fil_btn_dodaj_film.Size = new System.Drawing.Size(136, 49);
            this.fil_btn_dodaj_film.TabIndex = 7;
            this.fil_btn_dodaj_film.Text = "DODAJ FILM";
            this.fil_btn_dodaj_film.UseVisualStyleBackColor = true;
            this.fil_btn_dodaj_film.Click += new System.EventHandler(this.fil_btn_dodaj_film_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage4.Controls.Add(this.tar_cmb_porownanie);
            this.tabPage4.Controls.Add(this.tar_cmb_kolumna);
            this.tabPage4.Controls.Add(this.tar_txt_filtr);
            this.tabPage4.Controls.Add(this.tar_btn_usun);
            this.tabPage4.Controls.Add(this.tar_btn_edytuj);
            this.tabPage4.Controls.Add(this.tar_btn_dodaj);
            this.tabPage4.Controls.Add(this.tar_dataGridView1);
            this.tabPage4.Controls.Add(this.tar_btn_pokaz_taryfe);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(855, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Taryfy";
            // 
            // tar_cmb_porownanie
            // 
            this.tar_cmb_porownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tar_cmb_porownanie.Enabled = false;
            this.tar_cmb_porownanie.FormattingEnabled = true;
            this.tar_cmb_porownanie.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.tar_cmb_porownanie.Location = new System.Drawing.Point(134, 6);
            this.tar_cmb_porownanie.Name = "tar_cmb_porownanie";
            this.tar_cmb_porownanie.Size = new System.Drawing.Size(53, 21);
            this.tar_cmb_porownanie.TabIndex = 1;
            this.tar_cmb_porownanie.SelectedIndexChanged += new System.EventHandler(this.tar_cmb_porownanie_SelectedIndexChanged);
            // 
            // tar_cmb_kolumna
            // 
            this.tar_cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tar_cmb_kolumna.FormattingEnabled = true;
            this.tar_cmb_kolumna.Items.AddRange(new object[] {
            "ID",
            "Nazwa",
            "Cena za dzień"});
            this.tar_cmb_kolumna.Location = new System.Drawing.Point(7, 6);
            this.tar_cmb_kolumna.Name = "tar_cmb_kolumna";
            this.tar_cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.tar_cmb_kolumna.TabIndex = 0;
            this.tar_cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.tar_cmb_kolumna_SelectedIndexChanged);
            // 
            // tar_txt_filtr
            // 
            this.tar_txt_filtr.Location = new System.Drawing.Point(193, 6);
            this.tar_txt_filtr.Name = "tar_txt_filtr";
            this.tar_txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.tar_txt_filtr.TabIndex = 2;
            this.tar_txt_filtr.TextChanged += new System.EventHandler(this.tar_txt_filtr_TextChanged);
            this.tar_txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tar_txt_filtr_KeyPress);
            // 
            // tar_btn_usun
            // 
            this.tar_btn_usun.Location = new System.Drawing.Point(710, 376);
            this.tar_btn_usun.Name = "tar_btn_usun";
            this.tar_btn_usun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tar_btn_usun.Size = new System.Drawing.Size(136, 49);
            this.tar_btn_usun.TabIndex = 7;
            this.tar_btn_usun.Text = "USUŃ TARYFĘ";
            this.tar_btn_usun.UseVisualStyleBackColor = true;
            this.tar_btn_usun.Click += new System.EventHandler(this.tar_btn_usun_Click);
            // 
            // tar_btn_edytuj
            // 
            this.tar_btn_edytuj.Location = new System.Drawing.Point(567, 376);
            this.tar_btn_edytuj.Name = "tar_btn_edytuj";
            this.tar_btn_edytuj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tar_btn_edytuj.Size = new System.Drawing.Size(136, 49);
            this.tar_btn_edytuj.TabIndex = 6;
            this.tar_btn_edytuj.Text = "EDYTUJ TARYFĘ";
            this.tar_btn_edytuj.UseVisualStyleBackColor = true;
            this.tar_btn_edytuj.Click += new System.EventHandler(this.tar_btn_edytuj_Click);
            // 
            // tar_btn_dodaj
            // 
            this.tar_btn_dodaj.Location = new System.Drawing.Point(425, 376);
            this.tar_btn_dodaj.Name = "tar_btn_dodaj";
            this.tar_btn_dodaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tar_btn_dodaj.Size = new System.Drawing.Size(136, 49);
            this.tar_btn_dodaj.TabIndex = 5;
            this.tar_btn_dodaj.Text = "DODAJ TARYFĘ";
            this.tar_btn_dodaj.UseVisualStyleBackColor = true;
            this.tar_btn_dodaj.Click += new System.EventHandler(this.tar_btn_dodaj_Click);
            // 
            // tar_dataGridView1
            // 
            this.tar_dataGridView1.AllowUserToAddRows = false;
            this.tar_dataGridView1.AllowUserToDeleteRows = false;
            this.tar_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tar_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tar_dataGridView1.Location = new System.Drawing.Point(7, 33);
            this.tar_dataGridView1.MultiSelect = false;
            this.tar_dataGridView1.Name = "tar_dataGridView1";
            this.tar_dataGridView1.ReadOnly = true;
            this.tar_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tar_dataGridView1.Size = new System.Drawing.Size(839, 337);
            this.tar_dataGridView1.TabIndex = 3;
            this.tar_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tar_dataGridView1_CellDoubleClick);
            // 
            // tar_btn_pokaz_taryfe
            // 
            this.tar_btn_pokaz_taryfe.Location = new System.Drawing.Point(239, 376);
            this.tar_btn_pokaz_taryfe.Name = "tar_btn_pokaz_taryfe";
            this.tar_btn_pokaz_taryfe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tar_btn_pokaz_taryfe.Size = new System.Drawing.Size(180, 49);
            this.tar_btn_pokaz_taryfe.TabIndex = 4;
            this.tar_btn_pokaz_taryfe.Text = "POKAŻ TARYFĘ";
            this.tar_btn_pokaz_taryfe.UseVisualStyleBackColor = true;
            this.tar_btn_pokaz_taryfe.Click += new System.EventHandler(this.tar_btn_pokaz_taryfe_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage5.Controls.Add(this.tag_btn_pokaz);
            this.tabPage5.Controls.Add(this.oso_btn_pokaz);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.oso_txt_filtr);
            this.tabPage5.Controls.Add(this.tag_txt_filtr);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.oso_dataGridView2);
            this.tabPage5.Controls.Add(this.tag_dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(855, 428);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tagi i Filmowcy";
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // tag_btn_pokaz
            // 
            this.tag_btn_pokaz.Location = new System.Drawing.Point(241, 376);
            this.tag_btn_pokaz.Name = "tag_btn_pokaz";
            this.tag_btn_pokaz.Size = new System.Drawing.Size(180, 49);
            this.tag_btn_pokaz.TabIndex = 2;
            this.tag_btn_pokaz.Text = "SZCZEGÓŁY TAGA";
            this.tag_btn_pokaz.UseVisualStyleBackColor = true;
            this.tag_btn_pokaz.Click += new System.EventHandler(this.tag_btn_pokaz_Click);
            // 
            // oso_btn_pokaz
            // 
            this.oso_btn_pokaz.Location = new System.Drawing.Point(669, 376);
            this.oso_btn_pokaz.Name = "oso_btn_pokaz";
            this.oso_btn_pokaz.Size = new System.Drawing.Size(180, 49);
            this.oso_btn_pokaz.TabIndex = 5;
            this.oso_btn_pokaz.Text = "SZCZEGÓŁY FILMOWCA";
            this.oso_btn_pokaz.UseVisualStyleBackColor = true;
            this.oso_btn_pokaz.Click += new System.EventHandler(this.oso_btn_pokaz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Imię i nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nazwa taga:";
            // 
            // oso_txt_filtr
            // 
            this.oso_txt_filtr.Location = new System.Drawing.Point(561, 35);
            this.oso_txt_filtr.Name = "oso_txt_filtr";
            this.oso_txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.oso_txt_filtr.TabIndex = 3;
            this.oso_txt_filtr.TextChanged += new System.EventHandler(this.oso_txt_filtr_TextChanged);
            // 
            // tag_txt_filtr
            // 
            this.tag_txt_filtr.Location = new System.Drawing.Point(83, 35);
            this.tag_txt_filtr.Name = "tag_txt_filtr";
            this.tag_txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.tag_txt_filtr.TabIndex = 0;
            this.tag_txt_filtr.TextChanged += new System.EventHandler(this.tag_txt_filtr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(429, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "FILMOWCY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "TAGI:";
            // 
            // oso_dataGridView2
            // 
            this.oso_dataGridView2.AllowUserToAddRows = false;
            this.oso_dataGridView2.AllowUserToDeleteRows = false;
            this.oso_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.oso_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oso_dataGridView2.Location = new System.Drawing.Point(434, 61);
            this.oso_dataGridView2.MultiSelect = false;
            this.oso_dataGridView2.Name = "oso_dataGridView2";
            this.oso_dataGridView2.ReadOnly = true;
            this.oso_dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oso_dataGridView2.Size = new System.Drawing.Size(414, 309);
            this.oso_dataGridView2.TabIndex = 4;
            this.oso_dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oso_dataGridView2_CellDoubleClick);
            // 
            // tag_dataGridView1
            // 
            this.tag_dataGridView1.AllowUserToAddRows = false;
            this.tag_dataGridView1.AllowUserToDeleteRows = false;
            this.tag_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tag_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tag_dataGridView1.Location = new System.Drawing.Point(7, 61);
            this.tag_dataGridView1.MultiSelect = false;
            this.tag_dataGridView1.Name = "tag_dataGridView1";
            this.tag_dataGridView1.ReadOnly = true;
            this.tag_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tag_dataGridView1.Size = new System.Drawing.Size(414, 309);
            this.tag_dataGridView1.TabIndex = 1;
            this.tag_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tag_dataGridView1_CellDoubleClick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(863, 455);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU GŁÓWNE";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wyp_dtg_historia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kli_dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fil_dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tar_dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oso_dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox wyp_cmb_typ;
        private System.Windows.Forms.ComboBox wyp_cmb_porownanie;
        private System.Windows.Forms.ComboBox wyp_cmb_kolumna;
        private System.Windows.Forms.TextBox wyp_txt_filtr;
        private System.Windows.Forms.CheckBox wyp_cb_spoznione;
        private System.Windows.Forms.DataGridView wyp_dtg_historia;
        private System.Windows.Forms.Button btn_pokaz_wyp;
        private System.Windows.Forms.Button btn_dodaj_wyp;
        private System.Windows.Forms.ComboBox kli_cmb_kolumna;
        private System.Windows.Forms.TextBox kli_txt_filtr;
        private System.Windows.Forms.Button kli_btn_usun_klienta;
        private System.Windows.Forms.Button kli_btn_dodaj_klienta;
        private System.Windows.Forms.Button kli_btn_pokaz_profil;
        private System.Windows.Forms.DataGridView kli_dataGridView1;
        private System.Windows.Forms.Button kli_btn_edytuj_klienta;
        private System.Windows.Forms.CheckBox fil_cb_napisy;
        private System.Windows.Forms.CheckBox fil_cb_lektor;
        private System.Windows.Forms.ComboBox fil_cmb_porownanie;
        private System.Windows.Forms.ComboBox fil_cmb_kolumna;
        private System.Windows.Forms.TextBox fil_txt_filtr;
        private System.Windows.Forms.Button fil_btn_pokaz_film;
        private System.Windows.Forms.DataGridView fil_dataGridView1;
        private System.Windows.Forms.Button fil_btn_edytuj_film;
        private System.Windows.Forms.Button fil_btn_usun_film;
        private System.Windows.Forms.Button fil_btn_dodaj_film;
        private System.Windows.Forms.ComboBox tar_cmb_porownanie;
        private System.Windows.Forms.ComboBox tar_cmb_kolumna;
        private System.Windows.Forms.TextBox tar_txt_filtr;
        private System.Windows.Forms.Button tar_btn_usun;
        private System.Windows.Forms.Button tar_btn_edytuj;
        private System.Windows.Forms.Button tar_btn_dodaj;
        private System.Windows.Forms.DataGridView tar_dataGridView1;
        private System.Windows.Forms.Button tar_btn_pokaz_taryfe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oso_txt_filtr;
        private System.Windows.Forms.TextBox tag_txt_filtr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView oso_dataGridView2;
        private System.Windows.Forms.DataGridView tag_dataGridView1;
        private System.Windows.Forms.Button tag_btn_pokaz;
        private System.Windows.Forms.Button oso_btn_pokaz;
    }
}