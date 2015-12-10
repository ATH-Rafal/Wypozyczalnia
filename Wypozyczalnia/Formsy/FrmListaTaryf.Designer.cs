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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pokaz_taryfe
            // 
            this.btn_pokaz_taryfe.Location = new System.Drawing.Point(399, 12);
            this.btn_pokaz_taryfe.Name = "btn_pokaz_taryfe";
            this.btn_pokaz_taryfe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pokaz_taryfe.Size = new System.Drawing.Size(108, 70);
            this.btn_pokaz_taryfe.TabIndex = 1;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(381, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(399, 88);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dodaj.Size = new System.Drawing.Size(108, 50);
            this.btn_dodaj.TabIndex = 2;
            this.btn_dodaj.Text = "DODAJ TARYFĘ";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_edytuj
            // 
            this.btn_edytuj.Location = new System.Drawing.Point(399, 144);
            this.btn_edytuj.Name = "btn_edytuj";
            this.btn_edytuj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_edytuj.Size = new System.Drawing.Size(108, 50);
            this.btn_edytuj.TabIndex = 3;
            this.btn_edytuj.Text = "EDYTUJ TARYFĘ";
            this.btn_edytuj.UseVisualStyleBackColor = true;
            this.btn_edytuj.Click += new System.EventHandler(this.btn_edytuj_Click);
            // 
            // btn_usun
            // 
            this.btn_usun.Location = new System.Drawing.Point(399, 200);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_usun.Size = new System.Drawing.Size(108, 50);
            this.btn_usun.TabIndex = 4;
            this.btn_usun.Text = "USUŃ TARYFĘ";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(399, 337);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_zamknij.Size = new System.Drawing.Size(108, 50);
            this.btn_zamknij.TabIndex = 5;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // FrmListaTaryf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(519, 399);
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

        }

        #endregion

        private System.Windows.Forms.Button btn_pokaz_taryfe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_edytuj;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.Button btn_zamknij;
    }
}