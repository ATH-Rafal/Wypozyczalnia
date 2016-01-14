namespace Wypozyczalnia.Formsy
{
    partial class FrmListaOsob
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
            this.cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.txt_filtr = new System.Windows.Forms.TextBox();
            this.txt_edytuj = new System.Windows.Forms.TextBox();
            this.txt_nowy = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.btn_usun_osobe = new System.Windows.Forms.Button();
            this.btn_edytuj_osobe = new System.Windows.Forms.Button();
            this.btn_nowa_osoba = new System.Windows.Forms.Button();
            this.btn_dodaj_osobe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_kolumna
            // 
            this.cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kolumna.FormattingEnabled = true;
            this.cmb_kolumna.Items.AddRange(new object[] {
            "ID",
            "Imię i nazwisko"});
            this.cmb_kolumna.Location = new System.Drawing.Point(12, 8);
            this.cmb_kolumna.Name = "cmb_kolumna";
            this.cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.cmb_kolumna.TabIndex = 10;
            this.cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.cmb_kolumna_SelectedIndexChanged);
            // 
            // txt_filtr
            // 
            this.txt_filtr.Location = new System.Drawing.Point(139, 9);
            this.txt_filtr.Name = "txt_filtr";
            this.txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.txt_filtr.TabIndex = 11;
            this.txt_filtr.TextChanged += new System.EventHandler(this.txt_filtr_TextChanged);
            this.txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtr_KeyPress);
            // 
            // txt_edytuj
            // 
            this.txt_edytuj.Location = new System.Drawing.Point(12, 329);
            this.txt_edytuj.Name = "txt_edytuj";
            this.txt_edytuj.Size = new System.Drawing.Size(381, 20);
            this.txt_edytuj.TabIndex = 15;
            this.txt_edytuj.TextChanged += new System.EventHandler(this.txt_edytuj_TextChanged);
            // 
            // txt_nowy
            // 
            this.txt_nowy.Location = new System.Drawing.Point(12, 303);
            this.txt_nowy.Name = "txt_nowy";
            this.txt_nowy.Size = new System.Drawing.Size(381, 20);
            this.txt_nowy.TabIndex = 13;
            this.txt_nowy.TextChanged += new System.EventHandler(this.txt_nowy_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(523, 262);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(399, 355);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(136, 49);
            this.btn_zamknij.TabIndex = 19;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // btn_usun_osobe
            // 
            this.btn_usun_osobe.Enabled = false;
            this.btn_usun_osobe.Location = new System.Drawing.Point(198, 355);
            this.btn_usun_osobe.Name = "btn_usun_osobe";
            this.btn_usun_osobe.Size = new System.Drawing.Size(136, 49);
            this.btn_usun_osobe.TabIndex = 18;
            this.btn_usun_osobe.Text = "USUŃ Z BAZY";
            this.btn_usun_osobe.UseVisualStyleBackColor = true;
            this.btn_usun_osobe.Click += new System.EventHandler(this.btn_usun_osobe_Click);
            // 
            // btn_edytuj_osobe
            // 
            this.btn_edytuj_osobe.Enabled = false;
            this.btn_edytuj_osobe.Location = new System.Drawing.Point(399, 327);
            this.btn_edytuj_osobe.Name = "btn_edytuj_osobe";
            this.btn_edytuj_osobe.Size = new System.Drawing.Size(136, 23);
            this.btn_edytuj_osobe.TabIndex = 16;
            this.btn_edytuj_osobe.Text = "EDYTUJ FILMOWCA";
            this.btn_edytuj_osobe.UseVisualStyleBackColor = true;
            this.btn_edytuj_osobe.Click += new System.EventHandler(this.btn_edytuj_osobe_Click);
            // 
            // btn_nowa_osoba
            // 
            this.btn_nowa_osoba.Enabled = false;
            this.btn_nowa_osoba.Location = new System.Drawing.Point(399, 301);
            this.btn_nowa_osoba.Name = "btn_nowa_osoba";
            this.btn_nowa_osoba.Size = new System.Drawing.Size(136, 23);
            this.btn_nowa_osoba.TabIndex = 14;
            this.btn_nowa_osoba.Text = "NOWY FILMOWIEC";
            this.btn_nowa_osoba.UseVisualStyleBackColor = true;
            this.btn_nowa_osoba.Click += new System.EventHandler(this.btn_nowa_osoba_Click);
            // 
            // btn_dodaj_osobe
            // 
            this.btn_dodaj_osobe.Enabled = false;
            this.btn_dodaj_osobe.Location = new System.Drawing.Point(12, 355);
            this.btn_dodaj_osobe.Name = "btn_dodaj_osobe";
            this.btn_dodaj_osobe.Size = new System.Drawing.Size(180, 49);
            this.btn_dodaj_osobe.TabIndex = 17;
            this.btn_dodaj_osobe.Text = "DODAJ DO FILMU";
            this.btn_dodaj_osobe.UseVisualStyleBackColor = true;
            this.btn_dodaj_osobe.Click += new System.EventHandler(this.btn_dodaj_osobe_Click);
            // 
            // FrmListaOsob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(547, 416);
            this.Controls.Add(this.cmb_kolumna);
            this.Controls.Add(this.txt_filtr);
            this.Controls.Add(this.txt_edytuj);
            this.Controls.Add(this.txt_nowy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_usun_osobe);
            this.Controls.Add(this.btn_edytuj_osobe);
            this.Controls.Add(this.btn_nowa_osoba);
            this.Controls.Add(this.btn_dodaj_osobe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListaOsob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA FILMOWCÓW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaOsob_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_kolumna;
        private System.Windows.Forms.TextBox txt_filtr;
        private System.Windows.Forms.TextBox txt_edytuj;
        private System.Windows.Forms.TextBox txt_nowy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Button btn_usun_osobe;
        private System.Windows.Forms.Button btn_edytuj_osobe;
        private System.Windows.Forms.Button btn_nowa_osoba;
        private System.Windows.Forms.Button btn_dodaj_osobe;
    }
}