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
            this.btn_dodaj_film = new System.Windows.Forms.Button();
            this.btn_usun_film = new System.Windows.Forms.Button();
            this.btn_edytuj_film = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pokaz_film = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dodaj_film
            // 
            this.btn_dodaj_film.Location = new System.Drawing.Point(198, 369);
            this.btn_dodaj_film.Name = "btn_dodaj_film";
            this.btn_dodaj_film.Size = new System.Drawing.Size(136, 49);
            this.btn_dodaj_film.TabIndex = 2;
            this.btn_dodaj_film.Text = "DODAJ FILM";
            this.btn_dodaj_film.UseVisualStyleBackColor = true;
            this.btn_dodaj_film.Click += new System.EventHandler(this.btn_dodaj_film_Click);
            // 
            // btn_usun_film
            // 
            this.btn_usun_film.Location = new System.Drawing.Point(340, 369);
            this.btn_usun_film.Name = "btn_usun_film";
            this.btn_usun_film.Size = new System.Drawing.Size(136, 49);
            this.btn_usun_film.TabIndex = 3;
            this.btn_usun_film.Text = "USUN FILM";
            this.btn_usun_film.UseVisualStyleBackColor = true;
            this.btn_usun_film.Click += new System.EventHandler(this.btn_usun_film_Click);
            // 
            // btn_edytuj_film
            // 
            this.btn_edytuj_film.Location = new System.Drawing.Point(482, 369);
            this.btn_edytuj_film.Name = "btn_edytuj_film";
            this.btn_edytuj_film.Size = new System.Drawing.Size(136, 49);
            this.btn_edytuj_film.TabIndex = 4;
            this.btn_edytuj_film.Text = "EDYTUJ FILM";
            this.btn_edytuj_film.UseVisualStyleBackColor = true;
            this.btn_edytuj_film.Click += new System.EventHandler(this.btn_edytuj_film_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(839, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_pokaz_film
            // 
            this.btn_pokaz_film.Location = new System.Drawing.Point(12, 369);
            this.btn_pokaz_film.Name = "btn_pokaz_film";
            this.btn_pokaz_film.Size = new System.Drawing.Size(180, 49);
            this.btn_pokaz_film.TabIndex = 1;
            this.btn_pokaz_film.Text = "POKAŻ FILM";
            this.btn_pokaz_film.UseVisualStyleBackColor = true;
            this.btn_pokaz_film.Click += new System.EventHandler(this.btn_pokaz_film_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(715, 369);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(136, 49);
            this.btn_zamknij.TabIndex = 5;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // FrmListaFilmow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(863, 430);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_pokaz_film);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_edytuj_film);
            this.Controls.Add(this.btn_usun_film);
            this.Controls.Add(this.btn_dodaj_film);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaFilmow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA FILMOW";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dodaj_film;
        private System.Windows.Forms.Button btn_usun_film;
        private System.Windows.Forms.Button btn_edytuj_film;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pokaz_film;
        private System.Windows.Forms.Button btn_zamknij;
    }
}