namespace Wypozyczalnia.Formsy
{
    partial class FrmListaFilmow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pokaz_film = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.txt_filtr = new System.Windows.Forms.TextBox();
            this.cmb_porownanie = new System.Windows.Forms.ComboBox();
            this.cb_lektor = new System.Windows.Forms.CheckBox();
            this.cb_napisy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(839, 351);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_pokaz_film
            // 
            this.btn_pokaz_film.Location = new System.Drawing.Point(529, 394);
            this.btn_pokaz_film.Name = "btn_pokaz_film";
            this.btn_pokaz_film.Size = new System.Drawing.Size(180, 49);
            this.btn_pokaz_film.TabIndex = 6;
            this.btn_pokaz_film.Text = "WYBIERZ";
            this.btn_pokaz_film.UseVisualStyleBackColor = true;
            this.btn_pokaz_film.Click += new System.EventHandler(this.btn_pokaz_film_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(715, 394);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(136, 49);
            this.btn_zamknij.TabIndex = 7;
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
            "Tytuł polski",
            "Tytuł oryginalny",
            "Rok produkcji",
            "Gatunek",
            "Dystrybutor",
            "Kraj",
            "Długość",
            "Nośnik",
            "ID taryfy"});
            this.cmb_kolumna.Location = new System.Drawing.Point(12, 10);
            this.cmb_kolumna.Name = "cmb_kolumna";
            this.cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.cmb_kolumna.TabIndex = 0;
            this.cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.cmb_kolumna_SelectedIndexChanged);
            // 
            // txt_filtr
            // 
            this.txt_filtr.Location = new System.Drawing.Point(198, 10);
            this.txt_filtr.Name = "txt_filtr";
            this.txt_filtr.Size = new System.Drawing.Size(214, 20);
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
            this.cmb_porownanie.Location = new System.Drawing.Point(139, 10);
            this.cmb_porownanie.Name = "cmb_porownanie";
            this.cmb_porownanie.Size = new System.Drawing.Size(53, 21);
            this.cmb_porownanie.TabIndex = 1;
            this.cmb_porownanie.SelectedIndexChanged += new System.EventHandler(this.cmb_porownanie_SelectedIndexChanged);
            // 
            // cb_lektor
            // 
            this.cb_lektor.AutoSize = true;
            this.cb_lektor.Location = new System.Drawing.Point(731, 12);
            this.cb_lektor.Name = "cb_lektor";
            this.cb_lektor.Size = new System.Drawing.Size(56, 17);
            this.cb_lektor.TabIndex = 3;
            this.cb_lektor.Text = "Lektor";
            this.cb_lektor.UseVisualStyleBackColor = true;
            this.cb_lektor.CheckedChanged += new System.EventHandler(this.cb_lektor_CheckedChanged);
            // 
            // cb_napisy
            // 
            this.cb_napisy.AutoSize = true;
            this.cb_napisy.Location = new System.Drawing.Point(793, 12);
            this.cb_napisy.Name = "cb_napisy";
            this.cb_napisy.Size = new System.Drawing.Size(58, 17);
            this.cb_napisy.TabIndex = 4;
            this.cb_napisy.Text = "Napisy";
            this.cb_napisy.UseVisualStyleBackColor = true;
            this.cb_napisy.CheckedChanged += new System.EventHandler(this.cb_napisy_CheckedChanged);
            // 
            // FrmListaFilmow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(863, 455);
            this.Controls.Add(this.cb_napisy);
            this.Controls.Add(this.cb_lektor);
            this.Controls.Add(this.cmb_porownanie);
            this.Controls.Add(this.cmb_kolumna);
            this.Controls.Add(this.txt_filtr);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_pokaz_film);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaFilmow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA FILMOW";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pokaz_film;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.ComboBox cmb_kolumna;
        private System.Windows.Forms.TextBox txt_filtr;
        private System.Windows.Forms.ComboBox cmb_porownanie;
        private System.Windows.Forms.CheckBox cb_lektor;
        private System.Windows.Forms.CheckBox cb_napisy;
    }
}