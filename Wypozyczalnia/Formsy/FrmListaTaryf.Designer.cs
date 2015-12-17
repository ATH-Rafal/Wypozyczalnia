namespace Wypozyczalnia.Formsy
{
    partial class FrmListaTaryf
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
            this.btn_pokaz_taryfe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_edytuj = new System.Windows.Forms.Button();
            this.btn_usun = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.txt_filtr = new System.Windows.Forms.TextBox();
            this.cmb_porownanie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pokaz_taryfe
            // 
            this.btn_pokaz_taryfe.Location = new System.Drawing.Point(399, 30);
            this.btn_pokaz_taryfe.Name = "btn_pokaz_taryfe";
            this.btn_pokaz_taryfe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pokaz_taryfe.Size = new System.Drawing.Size(108, 70);
            this.btn_pokaz_taryfe.TabIndex = 4;
            this.btn_pokaz_taryfe.Text = "POKAŻ TARYFĘ";
            this.btn_pokaz_taryfe.UseVisualStyleBackColor = true;
            this.btn_pokaz_taryfe.Click += new System.EventHandler(this.btn_pokaz_taryfe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(381, 389);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(399, 106);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dodaj.Size = new System.Drawing.Size(108, 50);
            this.btn_dodaj.TabIndex = 5;
            this.btn_dodaj.Text = "DODAJ TARYFĘ";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_edytuj
            // 
            this.btn_edytuj.Location = new System.Drawing.Point(399, 162);
            this.btn_edytuj.Name = "btn_edytuj";
            this.btn_edytuj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_edytuj.Size = new System.Drawing.Size(108, 50);
            this.btn_edytuj.TabIndex = 6;
            this.btn_edytuj.Text = "EDYTUJ TARYFĘ";
            this.btn_edytuj.UseVisualStyleBackColor = true;
            this.btn_edytuj.Click += new System.EventHandler(this.btn_edytuj_Click);
            // 
            // btn_usun
            // 
            this.btn_usun.Location = new System.Drawing.Point(399, 218);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_usun.Size = new System.Drawing.Size(108, 50);
            this.btn_usun.TabIndex = 7;
            this.btn_usun.Text = "USUŃ TARYFĘ";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(399, 369);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_zamknij.Size = new System.Drawing.Size(108, 50);
            this.btn_zamknij.TabIndex = 8;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // cmb_kolumna
            // 
            this.cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kolumna.FormattingEnabled = true;
            this.cmb_kolumna.Items.AddRange(new object[] {
            "ID",
            "Nazwa",
            "Cena za dzień"});
            this.cmb_kolumna.Location = new System.Drawing.Point(12, 3);
            this.cmb_kolumna.Name = "cmb_kolumna";
            this.cmb_kolumna.Size = new System.Drawing.Size(107, 21);
            this.cmb_kolumna.TabIndex = 0;
            this.cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.cmb_kolumna_SelectedIndexChanged);
            // 
            // txt_filtr
            // 
            this.txt_filtr.Location = new System.Drawing.Point(184, 3);
            this.txt_filtr.Name = "txt_filtr";
            this.txt_filtr.Size = new System.Drawing.Size(209, 20);
            this.txt_filtr.TabIndex = 2;
            this.txt_filtr.TextChanged += new System.EventHandler(this.txt_filtr_TextChanged);
            this.txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtr_KeyPress);
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
            this.cmb_porownanie.Location = new System.Drawing.Point(125, 3);
            this.cmb_porownanie.Name = "cmb_porownanie";
            this.cmb_porownanie.Size = new System.Drawing.Size(53, 21);
            this.cmb_porownanie.TabIndex = 1;
            this.cmb_porownanie.SelectedIndexChanged += new System.EventHandler(this.cmb_porownanie_SelectedIndexChanged);
            // 
            // FrmListaTaryf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(519, 431);
            this.Controls.Add(this.cmb_porownanie);
            this.Controls.Add(this.cmb_kolumna);
            this.Controls.Add(this.txt_filtr);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.btn_edytuj);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_pokaz_taryfe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaTaryf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA TARYF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pokaz_taryfe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_edytuj;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.ComboBox cmb_kolumna;
        private System.Windows.Forms.TextBox txt_filtr;
        private System.Windows.Forms.ComboBox cmb_porownanie;
    }
}