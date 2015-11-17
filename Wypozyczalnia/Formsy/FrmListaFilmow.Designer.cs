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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dodaj_film
            // 
            this.btn_dodaj_film.Location = new System.Drawing.Point(382, 362);
            this.btn_dodaj_film.Name = "btn_dodaj_film";
            this.btn_dodaj_film.Size = new System.Drawing.Size(125, 60);
            this.btn_dodaj_film.TabIndex = 0;
            this.btn_dodaj_film.Text = "Dodaj film";
            this.btn_dodaj_film.UseVisualStyleBackColor = true;
            this.btn_dodaj_film.Click += new System.EventHandler(this.btn_dodaj_film_Click);
            // 
            // btn_usun_film
            // 
            this.btn_usun_film.Location = new System.Drawing.Point(645, 362);
            this.btn_usun_film.Name = "btn_usun_film";
            this.btn_usun_film.Size = new System.Drawing.Size(107, 60);
            this.btn_usun_film.TabIndex = 1;
            this.btn_usun_film.Text = "Usun film";
            this.btn_usun_film.UseVisualStyleBackColor = true;
            this.btn_usun_film.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edytuj_film
            // 
            this.btn_edytuj_film.Location = new System.Drawing.Point(513, 362);
            this.btn_edytuj_film.Name = "btn_edytuj_film";
            this.btn_edytuj_film.Size = new System.Drawing.Size(126, 60);
            this.btn_edytuj_film.TabIndex = 2;
            this.btn_edytuj_film.Text = "Edytuj film";
            this.btn_edytuj_film.UseVisualStyleBackColor = true;
            this.btn_edytuj_film.Click += new System.EventHandler(this.btn_edytuj_film_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_pokaz_film
            // 
            this.btn_pokaz_film.Location = new System.Drawing.Point(251, 362);
            this.btn_pokaz_film.Name = "btn_pokaz_film";
            this.btn_pokaz_film.Size = new System.Drawing.Size(125, 60);
            this.btn_pokaz_film.TabIndex = 4;
            this.btn_pokaz_film.Text = "Pokaż Film";
            this.btn_pokaz_film.UseVisualStyleBackColor = true;
            this.btn_pokaz_film.Click += new System.EventHandler(this.btn_pokaz_film_Click);
            // 
            // FrmListaFilmow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.btn_pokaz_film);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_edytuj_film);
            this.Controls.Add(this.btn_usun_film);
            this.Controls.Add(this.btn_dodaj_film);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaFilmow";
            this.Text = "LISTA FILMOW";
            this.Load += new System.EventHandler(this.FrmListaFilmow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dodaj_film;
        private System.Windows.Forms.Button btn_usun_film;
        private System.Windows.Forms.Button btn_edytuj_film;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pokaz_film;
    }
}