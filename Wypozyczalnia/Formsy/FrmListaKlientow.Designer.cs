namespace Wypozyczalnia.Formsy
{
    partial class FrmListaKlientow
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
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.btn_edytuj_klienta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pokaz_profil = new System.Windows.Forms.Button();
            this.btn_dodaj_klienta = new System.Windows.Forms.Button();
            this.btn_usun_klienta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(716, 369);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(135, 49);
            this.btn_zamknij.TabIndex = 5;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // btn_edytuj_klienta
            // 
            this.btn_edytuj_klienta.Location = new System.Drawing.Point(340, 369);
            this.btn_edytuj_klienta.Name = "btn_edytuj_klienta";
            this.btn_edytuj_klienta.Size = new System.Drawing.Size(136, 49);
            this.btn_edytuj_klienta.TabIndex = 3;
            this.btn_edytuj_klienta.Text = "EDYTUJ KLIENTA";
            this.btn_edytuj_klienta.UseVisualStyleBackColor = true;
            this.btn_edytuj_klienta.Click += new System.EventHandler(this.btn_edytuj_klienta_Click);
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
            // btn_pokaz_profil
            // 
            this.btn_pokaz_profil.Location = new System.Drawing.Point(12, 369);
            this.btn_pokaz_profil.Name = "btn_pokaz_profil";
            this.btn_pokaz_profil.Size = new System.Drawing.Size(180, 49);
            this.btn_pokaz_profil.TabIndex = 1;
            this.btn_pokaz_profil.Text = "POKAŻ PROFIL";
            this.btn_pokaz_profil.UseVisualStyleBackColor = true;
            this.btn_pokaz_profil.Click += new System.EventHandler(this.btn_pokaz_profil_Click);
            // 
            // btn_dodaj_klienta
            // 
            this.btn_dodaj_klienta.Location = new System.Drawing.Point(198, 369);
            this.btn_dodaj_klienta.Name = "btn_dodaj_klienta";
            this.btn_dodaj_klienta.Size = new System.Drawing.Size(136, 49);
            this.btn_dodaj_klienta.TabIndex = 2;
            this.btn_dodaj_klienta.Text = "DODAJ KLIENTA";
            this.btn_dodaj_klienta.UseVisualStyleBackColor = true;
            this.btn_dodaj_klienta.Click += new System.EventHandler(this.btn_dodaj_klienta_Click);
            // 
            // btn_usun_klienta
            // 
            this.btn_usun_klienta.Location = new System.Drawing.Point(482, 369);
            this.btn_usun_klienta.Name = "btn_usun_klienta";
            this.btn_usun_klienta.Size = new System.Drawing.Size(136, 49);
            this.btn_usun_klienta.TabIndex = 4;
            this.btn_usun_klienta.Text = "USUŃ KLIENTA";
            this.btn_usun_klienta.UseVisualStyleBackColor = true;
            this.btn_usun_klienta.Click += new System.EventHandler(this.btn_usun_klienta_Click);
            // 
            // FrmListaKlientow
            // 
            this.AcceptButton = this.btn_pokaz_profil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(863, 430);
            this.Controls.Add(this.btn_usun_klienta);
            this.Controls.Add(this.btn_dodaj_klienta);
            this.Controls.Add(this.btn_pokaz_profil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_edytuj_klienta);
            this.Controls.Add(this.btn_zamknij);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaKlientow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA KLIENTÓW";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Button btn_edytuj_klienta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pokaz_profil;
        private System.Windows.Forms.Button btn_dodaj_klienta;
        private System.Windows.Forms.Button btn_usun_klienta;
    }
}