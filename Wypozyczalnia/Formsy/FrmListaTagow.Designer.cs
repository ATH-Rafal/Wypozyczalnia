namespace Wypozyczalnia.Formsy
{
    partial class FrmListaTagow
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
            this.btn_dodaj_tag = new System.Windows.Forms.Button();
            this.btn_nowy_tag = new System.Windows.Forms.Button();
            this.btn_edytuj_tag = new System.Windows.Forms.Button();
            this.btn_usun_tag = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_nowy = new System.Windows.Forms.TextBox();
            this.txt_edytuj = new System.Windows.Forms.TextBox();
            this.cmb_kolumna = new System.Windows.Forms.ComboBox();
            this.txt_filtr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dodaj_tag
            // 
            this.btn_dodaj_tag.Enabled = false;
            this.btn_dodaj_tag.Location = new System.Drawing.Point(12, 355);
            this.btn_dodaj_tag.Name = "btn_dodaj_tag";
            this.btn_dodaj_tag.Size = new System.Drawing.Size(180, 49);
            this.btn_dodaj_tag.TabIndex = 7;
            this.btn_dodaj_tag.Text = "DODAJ DO FILMU";
            this.btn_dodaj_tag.UseVisualStyleBackColor = true;
            this.btn_dodaj_tag.Click += new System.EventHandler(this.btn_dodaj_tag_Click);
            // 
            // btn_nowy_tag
            // 
            this.btn_nowy_tag.Enabled = false;
            this.btn_nowy_tag.Location = new System.Drawing.Point(399, 301);
            this.btn_nowy_tag.Name = "btn_nowy_tag";
            this.btn_nowy_tag.Size = new System.Drawing.Size(136, 23);
            this.btn_nowy_tag.TabIndex = 4;
            this.btn_nowy_tag.Text = "NOWY TAG";
            this.btn_nowy_tag.UseVisualStyleBackColor = true;
            this.btn_nowy_tag.Click += new System.EventHandler(this.btn_nowy_tag_Click);
            // 
            // btn_edytuj_tag
            // 
            this.btn_edytuj_tag.Enabled = false;
            this.btn_edytuj_tag.Location = new System.Drawing.Point(399, 327);
            this.btn_edytuj_tag.Name = "btn_edytuj_tag";
            this.btn_edytuj_tag.Size = new System.Drawing.Size(136, 23);
            this.btn_edytuj_tag.TabIndex = 6;
            this.btn_edytuj_tag.Text = "EDYTUJ TAG";
            this.btn_edytuj_tag.UseVisualStyleBackColor = true;
            this.btn_edytuj_tag.Click += new System.EventHandler(this.btn_edytuj_tag_Click);
            // 
            // btn_usun_tag
            // 
            this.btn_usun_tag.Enabled = false;
            this.btn_usun_tag.Location = new System.Drawing.Point(198, 355);
            this.btn_usun_tag.Name = "btn_usun_tag";
            this.btn_usun_tag.Size = new System.Drawing.Size(136, 49);
            this.btn_usun_tag.TabIndex = 8;
            this.btn_usun_tag.Text = "USUŃ Z BAZY";
            this.btn_usun_tag.UseVisualStyleBackColor = true;
            this.btn_usun_tag.Click += new System.EventHandler(this.btn_usun_tag_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(399, 355);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(136, 49);
            this.btn_zamknij.TabIndex = 9;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(523, 262);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_nowy
            // 
            this.txt_nowy.Location = new System.Drawing.Point(12, 303);
            this.txt_nowy.Name = "txt_nowy";
            this.txt_nowy.Size = new System.Drawing.Size(381, 20);
            this.txt_nowy.TabIndex = 3;
            this.txt_nowy.TextChanged += new System.EventHandler(this.txt_nowy_TextChanged);
            // 
            // txt_edytuj
            // 
            this.txt_edytuj.Location = new System.Drawing.Point(12, 329);
            this.txt_edytuj.Name = "txt_edytuj";
            this.txt_edytuj.Size = new System.Drawing.Size(381, 20);
            this.txt_edytuj.TabIndex = 5;
            this.txt_edytuj.TextChanged += new System.EventHandler(this.txt_edytuj_TextChanged);
            // 
            // cmb_kolumna
            // 
            this.cmb_kolumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kolumna.FormattingEnabled = true;
            this.cmb_kolumna.Items.AddRange(new object[] {
            "ID",
            "Nazwa"});
            this.cmb_kolumna.Location = new System.Drawing.Point(12, 8);
            this.cmb_kolumna.Name = "cmb_kolumna";
            this.cmb_kolumna.Size = new System.Drawing.Size(121, 21);
            this.cmb_kolumna.TabIndex = 0;
            this.cmb_kolumna.SelectedIndexChanged += new System.EventHandler(this.cmb_kolumna_SelectedIndexChanged);
            // 
            // txt_filtr
            // 
            this.txt_filtr.Location = new System.Drawing.Point(139, 9);
            this.txt_filtr.Name = "txt_filtr";
            this.txt_filtr.Size = new System.Drawing.Size(214, 20);
            this.txt_filtr.TabIndex = 1;
            this.txt_filtr.TextChanged += new System.EventHandler(this.txt_filtr_TextChanged);
            this.txt_filtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtr_KeyPress);
            // 
            // FrmListaTagow
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
            this.Controls.Add(this.btn_usun_tag);
            this.Controls.Add(this.btn_edytuj_tag);
            this.Controls.Add(this.btn_nowy_tag);
            this.Controls.Add(this.btn_dodaj_tag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListaTagow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA TAGÓW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaTagow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_dodaj_tag;
        private System.Windows.Forms.Button btn_nowy_tag;
        private System.Windows.Forms.Button btn_edytuj_tag;
        private System.Windows.Forms.Button btn_usun_tag;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_nowy;
        private System.Windows.Forms.TextBox txt_edytuj;
        private System.Windows.Forms.ComboBox cmb_kolumna;
        private System.Windows.Forms.TextBox txt_filtr;
    }
}