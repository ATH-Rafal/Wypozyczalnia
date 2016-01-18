namespace Wypozyczalnia.Formsy
{
    partial class FrmDodajTaryfe
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.NumericUpDown();
            this.lb_zasady = new System.Windows.Forms.ListBox();
            this.txt_nazwa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cena_za_dzien = new System.Windows.Forms.TextBox();
            this.PanelTekst = new System.Windows.Forms.Panel();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.btn_usun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dni)).BeginInit();
            this.PanelTekst.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(384, 334);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(88, 47);
            this.btn_anuluj.TabIndex = 8;
            this.btn_anuluj.Text = "ANULUJ";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Za dni:";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(373, 247);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(99, 49);
            this.btn_dodaj.TabIndex = 5;
            this.btn_dodaj.Text = "DODAJ ZASADĘ";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // txt_cena
            // 
            this.txt_cena.Location = new System.Drawing.Point(212, 276);
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(155, 20);
            this.txt_cena.TabIndex = 4;
            this.txt_cena.TextChanged += new System.EventHandler(this.txt_cena_TextChanged);
            this.txt_cena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cena_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(212, 250);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(155, 20);
            this.txt_dni.TabIndex = 3;
            this.txt_dni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // lb_zasady
            // 
            this.lb_zasady.FormattingEnabled = true;
            this.lb_zasady.Location = new System.Drawing.Point(159, 68);
            this.lb_zasady.Name = "lb_zasady";
            this.lb_zasady.Size = new System.Drawing.Size(313, 173);
            this.lb_zasady.Sorted = true;
            this.lb_zasady.TabIndex = 2;
            this.lb_zasady.SelectedIndexChanged += new System.EventHandler(this.lb_zasady_SelectedIndexChanged);
            // 
            // txt_nazwa
            // 
            this.txt_nazwa.Location = new System.Drawing.Point(159, 8);
            this.txt_nazwa.Name = "txt_nazwa";
            this.txt_nazwa.Size = new System.Drawing.Size(313, 20);
            this.txt_nazwa.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Zasady dodatkowe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cena za dzień";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nazwa";
            // 
            // txt_cena_za_dzien
            // 
            this.txt_cena_za_dzien.Location = new System.Drawing.Point(159, 38);
            this.txt_cena_za_dzien.Name = "txt_cena_za_dzien";
            this.txt_cena_za_dzien.Size = new System.Drawing.Size(313, 20);
            this.txt_cena_za_dzien.TabIndex = 1;
            this.txt_cena_za_dzien.TextChanged += new System.EventHandler(this.txt_cena_za_dzien_TextChanged);
            this.txt_cena_za_dzien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cena_za_dzien_KeyPress);
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label4);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Location = new System.Drawing.Point(0, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 393);
            this.PanelTekst.TabIndex = 86;
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.Location = new System.Drawing.Point(290, 334);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(88, 47);
            this.btn_zatwierdz.TabIndex = 7;
            this.btn_zatwierdz.Text = "ZATWIERDŹ";
            this.btn_zatwierdz.UseVisualStyleBackColor = true;
            this.btn_zatwierdz.Click += new System.EventHandler(this.btn_zatwierdz_Click);
            // 
            // btn_usun
            // 
            this.btn_usun.Location = new System.Drawing.Point(373, 302);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.Size = new System.Drawing.Size(99, 23);
            this.btn_usun.TabIndex = 6;
            this.btn_usun.Text = "USUŃ ZASADĘ";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // FrmDodajTaryfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.btn_zatwierdz);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.txt_cena);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lb_zasady);
            this.Controls.Add(this.txt_nazwa);
            this.Controls.Add(this.txt_cena_za_dzien);
            this.Controls.Add(this.PanelTekst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDodajTaryfe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAJ TARYFĘ";
            ((System.ComponentModel.ISupportInitialize)(this.txt_dni)).EndInit();
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.TextBox txt_cena;
        private System.Windows.Forms.NumericUpDown txt_dni;
        private System.Windows.Forms.ListBox lb_zasady;
        private System.Windows.Forms.TextBox txt_nazwa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cena_za_dzien;
        private System.Windows.Forms.Panel PanelTekst;
        private System.Windows.Forms.Button btn_zatwierdz;
        private System.Windows.Forms.Button btn_usun;
    }
}