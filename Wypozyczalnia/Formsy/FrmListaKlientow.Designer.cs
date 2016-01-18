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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pokaz_profil = new System.Windows.Forms.Button();
            this.txt_filtr = new System.Windows.Forms.TextBox();
            this.cmb_kolumna = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(716, 394);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(135, 49);
            this.btn_zamknij.TabIndex = 4;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
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
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_pokaz_profil
            // 
            this.btn_pokaz_profil.Location = new System.Drawing.Point(530, 394);
            this.btn_pokaz_profil.Name = "btn_pokaz_profil";
            this.btn_pokaz_profil.Size = new System.Drawing.Size(180, 49);
            this.btn_pokaz_profil.TabIndex = 3;
            this.btn_pokaz_profil.Text = "WYBIERZ";
            this.btn_pokaz_profil.UseVisualStyleBackColor = true;
            this.btn_pokaz_profil.Click += new System.EventHandler(this.btn_pokaz_profil_Click);
            // 
            // txt_filtr
            // 
            this.txt_filtr.Location = new System.Drawing.Point(139, 11);
            this.txt_filtr.Name = "txt_filtr";
            this.txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.txt_filtr.TabIndex = 1;
            this.txt_filtr.TextChanged += new System.EventHandler(this.txt_filtr_TextChanged);
            this.txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtr_KeyPress);
            // 
            // cmb_kolumna
            // 
            this.cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kolumna.FormattingEnabled = true;
            this.cmb_kolumna.Items.AddRange(new object[] {
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
            this.cmb_kolumna.Location = new System.Drawing.Point(12, 10);
            this.cmb_kolumna.Name = "cmb_kolumna";
            this.cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.cmb_kolumna.TabIndex = 0;
            this.cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.cmb_kolumna_SelectedIndexChanged);
            // 
            // FrmListaKlientow
            // 
            this.AcceptButton = this.btn_pokaz_profil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(863, 455);
            this.Controls.Add(this.cmb_kolumna);
            this.Controls.Add(this.txt_filtr);
            this.Controls.Add(this.btn_pokaz_profil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_zamknij);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaKlientow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA KLIENTÓW";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pokaz_profil;
        private System.Windows.Forms.TextBox txt_filtr;
        private System.Windows.Forms.ComboBox cmb_kolumna;
    }
}