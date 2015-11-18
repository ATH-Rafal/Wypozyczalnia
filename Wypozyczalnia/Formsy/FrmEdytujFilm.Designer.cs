namespace Wypozyczalnia.Formsy
{
    partial class FrmEdytujFilm
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
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.PanelTekst = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_zatwierz = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.cmb_nosnik = new System.Windows.Forms.ComboBox();
            this.txt_klas_wiekowa = new System.Windows.Forms.TextBox();
            this.cb_napisy = new System.Windows.Forms.CheckBox();
            this.cb_lektor = new System.Windows.Forms.CheckBox();
            this.txt_dlugosc = new System.Windows.Forms.TextBox();
            this.txt_rok_produkcji = new System.Windows.Forms.MaskedTextBox();
            this.txt_kraj = new System.Windows.Forms.TextBox();
            this.txt_tytul_pol = new System.Windows.Forms.TextBox();
            this.txt_tytul_org = new System.Windows.Forms.TextBox();
            this.PanelTekst.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(388, 327);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_anuluj.Size = new System.Drawing.Size(88, 47);
            this.btn_anuluj.TabIndex = 12;
            this.btn_anuluj.Text = "ANULUJ";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Controls.Add(this.label1);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Controls.Add(this.label4);
            this.PanelTekst.Controls.Add(this.label9);
            this.PanelTekst.Controls.Add(this.label8);
            this.PanelTekst.Controls.Add(this.label6);
            this.PanelTekst.Controls.Add(this.label5);
            this.PanelTekst.Controls.Add(this.label7);
            this.PanelTekst.Location = new System.Drawing.Point(0, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 386);
            this.PanelTekst.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numer filmu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tytuł polski";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tytuł oryginalny";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label9.Location = new System.Drawing.Point(12, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Długość (min.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nośnik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Klasyfikacja wiekowa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rok produkcji";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kraj";
            // 
            // btn_zatwierz
            // 
            this.btn_zatwierz.Location = new System.Drawing.Point(294, 327);
            this.btn_zatwierz.Name = "btn_zatwierz";
            this.btn_zatwierz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_zatwierz.Size = new System.Drawing.Size(88, 47);
            this.btn_zatwierz.TabIndex = 11;
            this.btn_zatwierz.Text = "ZATWIERDŹ ZMIANY";
            this.btn_zatwierz.UseVisualStyleBackColor = true;
            this.btn_zatwierz.Click += new System.EventHandler(this.btn_zatwierz_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(159, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(317, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_cena
            // 
            this.txt_cena.Location = new System.Drawing.Point(159, 217);
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(317, 20);
            this.txt_cena.TabIndex = 7;
            this.txt_cena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cena_KeyPress);
            // 
            // cmb_nosnik
            // 
            this.cmb_nosnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nosnik.FormattingEnabled = true;
            this.cmb_nosnik.Items.AddRange(new object[] {
            "DVD",
            "VCD",
            "Blu-Ray",
            "VHS"});
            this.cmb_nosnik.Location = new System.Drawing.Point(159, 244);
            this.cmb_nosnik.Name = "cmb_nosnik";
            this.cmb_nosnik.Size = new System.Drawing.Size(316, 21);
            this.cmb_nosnik.TabIndex = 8;
            // 
            // txt_klas_wiekowa
            // 
            this.txt_klas_wiekowa.Location = new System.Drawing.Point(159, 129);
            this.txt_klas_wiekowa.Name = "txt_klas_wiekowa";
            this.txt_klas_wiekowa.Size = new System.Drawing.Size(317, 20);
            this.txt_klas_wiekowa.TabIndex = 4;
            this.txt_klas_wiekowa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_klas_wiekowa_KeyPress);
            // 
            // cb_napisy
            // 
            this.cb_napisy.AutoSize = true;
            this.cb_napisy.Location = new System.Drawing.Point(242, 271);
            this.cb_napisy.Name = "cb_napisy";
            this.cb_napisy.Size = new System.Drawing.Size(58, 17);
            this.cb_napisy.TabIndex = 10;
            this.cb_napisy.Text = "Napisy";
            this.cb_napisy.UseVisualStyleBackColor = true;
            // 
            // cb_lektor
            // 
            this.cb_lektor.AutoSize = true;
            this.cb_lektor.Location = new System.Drawing.Point(159, 271);
            this.cb_lektor.Name = "cb_lektor";
            this.cb_lektor.Size = new System.Drawing.Size(56, 17);
            this.cb_lektor.TabIndex = 9;
            this.cb_lektor.Text = "Lektor";
            this.cb_lektor.UseVisualStyleBackColor = true;
            // 
            // txt_dlugosc
            // 
            this.txt_dlugosc.Location = new System.Drawing.Point(159, 159);
            this.txt_dlugosc.Name = "txt_dlugosc";
            this.txt_dlugosc.Size = new System.Drawing.Size(317, 20);
            this.txt_dlugosc.TabIndex = 5;
            this.txt_dlugosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dlugosc_KeyPress);
            // 
            // txt_rok_produkcji
            // 
            this.txt_rok_produkcji.Location = new System.Drawing.Point(159, 98);
            this.txt_rok_produkcji.Mask = "0000";
            this.txt_rok_produkcji.Name = "txt_rok_produkcji";
            this.txt_rok_produkcji.Size = new System.Drawing.Size(317, 20);
            this.txt_rok_produkcji.TabIndex = 3;
            // 
            // txt_kraj
            // 
            this.txt_kraj.Location = new System.Drawing.Point(159, 188);
            this.txt_kraj.Name = "txt_kraj";
            this.txt_kraj.Size = new System.Drawing.Size(317, 20);
            this.txt_kraj.TabIndex = 6;
            // 
            // txt_tytul_pol
            // 
            this.txt_tytul_pol.Location = new System.Drawing.Point(159, 38);
            this.txt_tytul_pol.Name = "txt_tytul_pol";
            this.txt_tytul_pol.Size = new System.Drawing.Size(317, 20);
            this.txt_tytul_pol.TabIndex = 1;
            // 
            // txt_tytul_org
            // 
            this.txt_tytul_org.Location = new System.Drawing.Point(159, 68);
            this.txt_tytul_org.Name = "txt_tytul_org";
            this.txt_tytul_org.Size = new System.Drawing.Size(317, 20);
            this.txt_tytul_org.TabIndex = 2;
            // 
            // FrmEdytujFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(488, 386);
            this.Controls.Add(this.txt_cena);
            this.Controls.Add(this.cmb_nosnik);
            this.Controls.Add(this.txt_klas_wiekowa);
            this.Controls.Add(this.cb_napisy);
            this.Controls.Add(this.cb_lektor);
            this.Controls.Add(this.txt_dlugosc);
            this.Controls.Add(this.txt_rok_produkcji);
            this.Controls.Add(this.txt_kraj);
            this.Controls.Add(this.txt_tytul_pol);
            this.Controls.Add(this.txt_tytul_org);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.PanelTekst);
            this.Controls.Add(this.btn_zatwierz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEdytujFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDYTUJ FILM";
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Panel PanelTekst;
        private System.Windows.Forms.Button btn_zatwierz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cena;
        private System.Windows.Forms.ComboBox cmb_nosnik;
        private System.Windows.Forms.TextBox txt_klas_wiekowa;
        private System.Windows.Forms.CheckBox cb_napisy;
        private System.Windows.Forms.CheckBox cb_lektor;
        private System.Windows.Forms.TextBox txt_dlugosc;
        private System.Windows.Forms.MaskedTextBox txt_rok_produkcji;
        private System.Windows.Forms.TextBox txt_kraj;
        private System.Windows.Forms.TextBox txt_tytul_pol;
        private System.Windows.Forms.TextBox txt_tytul_org;
    }
}