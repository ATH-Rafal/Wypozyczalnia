﻿namespace Wypozyczalnia.Formsy
{
    partial class FrmFormularzKlienta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_ulica = new System.Windows.Forms.TextBox();
            this.txt_nr_telefonu = new System.Windows.Forms.TextBox();
            this.txt_kod_pocztowy = new System.Windows.Forms.MaskedTextBox();
            this.txt_pesel = new System.Windows.Forms.MaskedTextBox();
            this.txt_nr_dowodu = new System.Windows.Forms.MaskedTextBox();
            this.txt_nr_domu = new System.Windows.Forms.TextBox();
            this.txt_miejscowosc = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.PanelTekst = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_zwroc = new System.Windows.Forms.Button();
            this.btn_wypozycz = new System.Windows.Forms.Button();
            this.dth_dane_wypozyczenia = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelTekst.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dth_dane_wypozyczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage1.Controls.Add(this.txt_ulica);
            this.tabPage1.Controls.Add(this.txt_nr_telefonu);
            this.tabPage1.Controls.Add(this.txt_kod_pocztowy);
            this.tabPage1.Controls.Add(this.txt_pesel);
            this.tabPage1.Controls.Add(this.txt_nr_dowodu);
            this.tabPage1.Controls.Add(this.txt_nr_domu);
            this.tabPage1.Controls.Add(this.txt_miejscowosc);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.txt_nazwisko);
            this.tabPage1.Controls.Add(this.txt_imie);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.btn_zamknij);
            this.tabPage1.Controls.Add(this.PanelTekst);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dane osobowe";
            // 
            // txt_ulica
            // 
            this.txt_ulica.Location = new System.Drawing.Point(159, 261);
            this.txt_ulica.Name = "txt_ulica";
            this.txt_ulica.ReadOnly = true;
            this.txt_ulica.Size = new System.Drawing.Size(449, 20);
            this.txt_ulica.TabIndex = 9;
            // 
            // txt_nr_telefonu
            // 
            this.txt_nr_telefonu.Location = new System.Drawing.Point(159, 142);
            this.txt_nr_telefonu.Name = "txt_nr_telefonu";
            this.txt_nr_telefonu.ReadOnly = true;
            this.txt_nr_telefonu.Size = new System.Drawing.Size(449, 20);
            this.txt_nr_telefonu.TabIndex = 5;
            // 
            // txt_kod_pocztowy
            // 
            this.txt_kod_pocztowy.Location = new System.Drawing.Point(159, 232);
            this.txt_kod_pocztowy.Mask = "00-000";
            this.txt_kod_pocztowy.Name = "txt_kod_pocztowy";
            this.txt_kod_pocztowy.ReadOnly = true;
            this.txt_kod_pocztowy.Size = new System.Drawing.Size(449, 20);
            this.txt_kod_pocztowy.TabIndex = 8;
            // 
            // txt_pesel
            // 
            this.txt_pesel.Location = new System.Drawing.Point(159, 90);
            this.txt_pesel.Mask = "00000000000";
            this.txt_pesel.Name = "txt_pesel";
            this.txt_pesel.ReadOnly = true;
            this.txt_pesel.Size = new System.Drawing.Size(449, 20);
            this.txt_pesel.TabIndex = 3;
            // 
            // txt_nr_dowodu
            // 
            this.txt_nr_dowodu.Location = new System.Drawing.Point(159, 116);
            this.txt_nr_dowodu.Mask = "AAA000000";
            this.txt_nr_dowodu.Name = "txt_nr_dowodu";
            this.txt_nr_dowodu.ReadOnly = true;
            this.txt_nr_dowodu.Size = new System.Drawing.Size(449, 20);
            this.txt_nr_dowodu.TabIndex = 4;
            // 
            // txt_nr_domu
            // 
            this.txt_nr_domu.Location = new System.Drawing.Point(159, 291);
            this.txt_nr_domu.Name = "txt_nr_domu";
            this.txt_nr_domu.ReadOnly = true;
            this.txt_nr_domu.Size = new System.Drawing.Size(449, 20);
            this.txt_nr_domu.TabIndex = 10;
            // 
            // txt_miejscowosc
            // 
            this.txt_miejscowosc.Location = new System.Drawing.Point(159, 201);
            this.txt_miejscowosc.Name = "txt_miejscowosc";
            this.txt_miejscowosc.ReadOnly = true;
            this.txt_miejscowosc.Size = new System.Drawing.Size(449, 20);
            this.txt_miejscowosc.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(159, 172);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(449, 20);
            this.txt_email.TabIndex = 6;
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(159, 64);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.ReadOnly = true;
            this.txt_nazwisko.Size = new System.Drawing.Size(449, 20);
            this.txt_nazwisko.TabIndex = 2;
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(159, 38);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.ReadOnly = true;
            this.txt_imie.Size = new System.Drawing.Size(449, 20);
            this.txt_imie.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(159, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(449, 20);
            this.txt_id.TabIndex = 0;
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(514, 347);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_zamknij.Size = new System.Drawing.Size(88, 47);
            this.btn_zamknij.TabIndex = 11;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label11);
            this.PanelTekst.Controls.Add(this.label1);
            this.PanelTekst.Controls.Add(this.label10);
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Controls.Add(this.label9);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Controls.Add(this.label8);
            this.PanelTekst.Controls.Add(this.label4);
            this.PanelTekst.Controls.Add(this.label7);
            this.PanelTekst.Controls.Add(this.label5);
            this.PanelTekst.Controls.Add(this.label6);
            this.PanelTekst.Location = new System.Drawing.Point(0, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 404);
            this.PanelTekst.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label11.Location = new System.Drawing.Point(10, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nr. domu/mieszkania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nr. klienta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label10.Location = new System.Drawing.Point(12, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ulica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "lmię";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label9.Location = new System.Drawing.Point(10, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kod pocztowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label8.Location = new System.Drawing.Point(9, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Miejscowość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "PESEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label7.Location = new System.Drawing.Point(10, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(9, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nr. dowodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(10, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nr. telefonu";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_zwroc);
            this.tabPage2.Controls.Add(this.btn_wypozycz);
            this.tabPage2.Controls.Add(this.dth_dane_wypozyczenia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wypożyczenia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 347);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "ZAMKNIJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_zwroc
            // 
            this.btn_zwroc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.btn_zwroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zwroc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_zwroc.Location = new System.Drawing.Point(352, 303);
            this.btn_zwroc.Name = "btn_zwroc";
            this.btn_zwroc.Size = new System.Drawing.Size(84, 23);
            this.btn_zwroc.TabIndex = 1;
            this.btn_zwroc.Text = "ZWRÓĆ";
            this.btn_zwroc.UseVisualStyleBackColor = true;
            this.btn_zwroc.Click += new System.EventHandler(this.btn_zwroc_Click);
            // 
            // btn_wypozycz
            // 
            this.btn_wypozycz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_wypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wypozycz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_wypozycz.Location = new System.Drawing.Point(442, 303);
            this.btn_wypozycz.Name = "btn_wypozycz";
            this.btn_wypozycz.Size = new System.Drawing.Size(160, 23);
            this.btn_wypozycz.TabIndex = 2;
            this.btn_wypozycz.Text = "WYPOŻYCZ";
            this.btn_wypozycz.UseVisualStyleBackColor = true;
            this.btn_wypozycz.Click += new System.EventHandler(this.btn_wypozycz_Click);
            // 
            // dth_dane_wypozyczenia
            // 
            this.dth_dane_wypozyczenia.AllowUserToAddRows = false;
            this.dth_dane_wypozyczenia.AllowUserToDeleteRows = false;
            this.dth_dane_wypozyczenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dth_dane_wypozyczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dth_dane_wypozyczenia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.dth_dane_wypozyczenia.Location = new System.Drawing.Point(6, 6);
            this.dth_dane_wypozyczenia.MultiSelect = false;
            this.dth_dane_wypozyczenia.Name = "dth_dane_wypozyczenia";
            this.dth_dane_wypozyczenia.ReadOnly = true;
            this.dth_dane_wypozyczenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dth_dane_wypozyczenia.Size = new System.Drawing.Size(596, 291);
            this.dth_dane_wypozyczenia.TabIndex = 0;
            // 
            // FrmFormularzKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(617, 427);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmFormularzKlienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFIL KLIENTA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dth_dane_wypozyczenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_ulica;
        private System.Windows.Forms.TextBox txt_nr_telefonu;
        private System.Windows.Forms.MaskedTextBox txt_kod_pocztowy;
        private System.Windows.Forms.MaskedTextBox txt_pesel;
        private System.Windows.Forms.MaskedTextBox txt_nr_dowodu;
        private System.Windows.Forms.TextBox txt_nr_domu;
        private System.Windows.Forms.TextBox txt_miejscowosc;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Panel PanelTekst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_zwroc;
        private System.Windows.Forms.Button btn_wypozycz;
        private System.Windows.Forms.DataGridView dth_dane_wypozyczenia;
        private System.Windows.Forms.Button button1;
    }
}

