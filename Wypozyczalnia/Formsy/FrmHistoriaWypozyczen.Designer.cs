namespace Wypozyczalnia.Formsy
{
    partial class FrmHistoriaWypozyczen
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
            this.dtg_historia = new System.Windows.Forms.DataGridView();
            this.cb_spoznione = new System.Windows.Forms.CheckBox();
            this.cmb_porownanie = new System.Windows.Forms.ComboBox();
            this.cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.txt_filtr = new System.Windows.Forms.TextBox();
            this.cmb_typ = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_historia
            // 
            this.dtg_historia.AllowUserToAddRows = false;
            this.dtg_historia.AllowUserToDeleteRows = false;
            this.dtg_historia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_historia.Location = new System.Drawing.Point(12, 35);
            this.dtg_historia.MultiSelect = false;
            this.dtg_historia.Name = "dtg_historia";
            this.dtg_historia.ReadOnly = true;
            this.dtg_historia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_historia.Size = new System.Drawing.Size(663, 405);
            this.dtg_historia.TabIndex = 5;
            // 
            // cb_spoznione
            // 
            this.cb_spoznione.AutoSize = true;
            this.cb_spoznione.Location = new System.Drawing.Point(599, 12);
            this.cb_spoznione.Name = "cb_spoznione";
            this.cb_spoznione.Size = new System.Drawing.Size(76, 17);
            this.cb_spoznione.TabIndex = 4;
            this.cb_spoznione.Text = "Spóźnione";
            this.cb_spoznione.UseVisualStyleBackColor = true;
            this.cb_spoznione.CheckedChanged += new System.EventHandler(this.cb_spoznione_CheckedChanged);
            // 
            // cmb_porownanie
            // 
            this.cmb_porownanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_porownanie.Enabled = false;
            this.cmb_porownanie.FormattingEnabled = true;
            this.cmb_porownanie.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.cmb_porownanie.Location = new System.Drawing.Point(266, 7);
            this.cmb_porownanie.Name = "cmb_porownanie";
            this.cmb_porownanie.Size = new System.Drawing.Size(53, 21);
            this.cmb_porownanie.TabIndex = 2;
            this.cmb_porownanie.SelectedIndexChanged += new System.EventHandler(this.cmb_porownanie_SelectedIndexChanged);
            // 
            // cmb_kolumna
            // 
            this.cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kolumna.FormattingEnabled = true;
            this.cmb_kolumna.Items.AddRange(new object[] {
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
            this.cmb_kolumna.Location = new System.Drawing.Point(139, 8);
            this.cmb_kolumna.Name = "cmb_kolumna";
            this.cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.cmb_kolumna.TabIndex = 1;
            this.cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.cmb_kolumna_SelectedIndexChanged);
            // 
            // txt_filtr
            // 
            this.txt_filtr.Location = new System.Drawing.Point(325, 8);
            this.txt_filtr.Name = "txt_filtr";
            this.txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.txt_filtr.TabIndex = 3;
            this.txt_filtr.TextChanged += new System.EventHandler(this.txt_filtr_TextChanged);
            this.txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtr_KeyPress);
            // 
            // cmb_typ
            // 
            this.cmb_typ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_typ.FormattingEnabled = true;
            this.cmb_typ.Items.AddRange(new object[] {
            "Wszystkie",
            "Zwrócone",
            "Niezwrócone"});
            this.cmb_typ.Location = new System.Drawing.Point(12, 8);
            this.cmb_typ.Name = "cmb_typ";
            this.cmb_typ.Size = new System.Drawing.Size(121, 21);
            this.cmb_typ.TabIndex = 0;
            this.cmb_typ.SelectedIndexChanged += new System.EventHandler(this.cmb_typ_SelectedIndexChanged);
            // 
            // FrmHistoriaWypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(687, 452);
            this.Controls.Add(this.cmb_typ);
            this.Controls.Add(this.cmb_porownanie);
            this.Controls.Add(this.cmb_kolumna);
            this.Controls.Add(this.txt_filtr);
            this.Controls.Add(this.cb_spoznione);
            this.Controls.Add(this.dtg_historia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmHistoriaWypozyczen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIA WYPOZYCZEN";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_historia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_historia;
        private System.Windows.Forms.CheckBox cb_spoznione;
        private System.Windows.Forms.ComboBox cmb_porownanie;
        private System.Windows.Forms.ComboBox cmb_kolumna;
        private System.Windows.Forms.TextBox txt_filtr;
        private System.Windows.Forms.ComboBox cmb_typ;
    }
}