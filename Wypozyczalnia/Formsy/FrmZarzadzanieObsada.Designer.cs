namespace Wypozyczalnia.Formsy
{
    partial class FrmZarzadzanieObsada
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
            this.PanelTekst = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_aktorzy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dodaj_kompozytora = new System.Windows.Forms.Button();
            this.btn_usun_aktora = new System.Windows.Forms.Button();
            this.lb_muzyka = new System.Windows.Forms.ListBox();
            this.btn_usun_scenarzyste = new System.Windows.Forms.Button();
            this.btn_dodaj_scenarzyste = new System.Windows.Forms.Button();
            this.lb_scenariusz = new System.Windows.Forms.ListBox();
            this.btn_dodaj_rezysera = new System.Windows.Forms.Button();
            this.btn_usun_rezysera = new System.Windows.Forms.Button();
            this.lb_rezyseria = new System.Windows.Forms.ListBox();
            this.btn_dodaj_aktora = new System.Windows.Forms.Button();
            this.btn_usun_kompozytora = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.btn_usun_zdjeciowcaczyjaksienanichmowi = new System.Windows.Forms.Button();
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi = new System.Windows.Forms.Button();
            this.lb_zdjecia = new System.Windows.Forms.ListBox();
            this.btn_gora = new System.Windows.Forms.Button();
            this.btn_dol = new System.Windows.Forms.Button();
            this.PanelTekst.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label5);
            this.PanelTekst.Controls.Add(this.label4);
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Location = new System.Drawing.Point(0, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 423);
            this.PanelTekst.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(12, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Zdjęcia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Muzyka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Scenariusz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Reżyseria";
            // 
            // lb_aktorzy
            // 
            this.lb_aktorzy.FormattingEnabled = true;
            this.lb_aktorzy.Location = new System.Drawing.Point(505, 11);
            this.lb_aktorzy.Name = "lb_aktorzy";
            this.lb_aktorzy.Size = new System.Drawing.Size(220, 277);
            this.lb_aktorzy.TabIndex = 64;
            this.lb_aktorzy.SelectedIndexChanged += new System.EventHandler(this.lb_aktorzy_SelectedIndexChanged);
            this.lb_aktorzy.DoubleClick += new System.EventHandler(this.lb_aktorzy_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Aktorzy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(346, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 423);
            this.panel1.TabIndex = 58;
            // 
            // btn_dodaj_kompozytora
            // 
            this.btn_dodaj_kompozytora.Location = new System.Drawing.Point(241, 275);
            this.btn_dodaj_kompozytora.Name = "btn_dodaj_kompozytora";
            this.btn_dodaj_kompozytora.Size = new System.Drawing.Size(99, 23);
            this.btn_dodaj_kompozytora.TabIndex = 69;
            this.btn_dodaj_kompozytora.Text = "DODAJ";
            this.btn_dodaj_kompozytora.UseVisualStyleBackColor = true;
            this.btn_dodaj_kompozytora.Click += new System.EventHandler(this.btn_dodaj_kompozytora_Click);
            // 
            // btn_usun_aktora
            // 
            this.btn_usun_aktora.Enabled = false;
            this.btn_usun_aktora.Location = new System.Drawing.Point(505, 294);
            this.btn_usun_aktora.Name = "btn_usun_aktora";
            this.btn_usun_aktora.Size = new System.Drawing.Size(75, 23);
            this.btn_usun_aktora.TabIndex = 70;
            this.btn_usun_aktora.Text = "USUŃ";
            this.btn_usun_aktora.UseVisualStyleBackColor = true;
            this.btn_usun_aktora.Click += new System.EventHandler(this.btn_usun_aktora_Click);
            // 
            // lb_muzyka
            // 
            this.lb_muzyka.FormattingEnabled = true;
            this.lb_muzyka.Location = new System.Drawing.Point(159, 213);
            this.lb_muzyka.Name = "lb_muzyka";
            this.lb_muzyka.Size = new System.Drawing.Size(181, 56);
            this.lb_muzyka.TabIndex = 63;
            this.lb_muzyka.SelectedIndexChanged += new System.EventHandler(this.lb_muzyka_SelectedIndexChanged);
            this.lb_muzyka.DoubleClick += new System.EventHandler(this.lb_muzyka_DoubleClick);
            // 
            // btn_usun_scenarzyste
            // 
            this.btn_usun_scenarzyste.Enabled = false;
            this.btn_usun_scenarzyste.Location = new System.Drawing.Point(160, 174);
            this.btn_usun_scenarzyste.Name = "btn_usun_scenarzyste";
            this.btn_usun_scenarzyste.Size = new System.Drawing.Size(75, 23);
            this.btn_usun_scenarzyste.TabIndex = 68;
            this.btn_usun_scenarzyste.Text = "USUŃ";
            this.btn_usun_scenarzyste.UseVisualStyleBackColor = true;
            this.btn_usun_scenarzyste.Click += new System.EventHandler(this.btn_usun_scenarzyste_Click);
            // 
            // btn_dodaj_scenarzyste
            // 
            this.btn_dodaj_scenarzyste.Location = new System.Drawing.Point(241, 174);
            this.btn_dodaj_scenarzyste.Name = "btn_dodaj_scenarzyste";
            this.btn_dodaj_scenarzyste.Size = new System.Drawing.Size(99, 23);
            this.btn_dodaj_scenarzyste.TabIndex = 67;
            this.btn_dodaj_scenarzyste.Text = "DODAJ";
            this.btn_dodaj_scenarzyste.UseVisualStyleBackColor = true;
            this.btn_dodaj_scenarzyste.Click += new System.EventHandler(this.btn_dodaj_scenarzyste_Click);
            // 
            // lb_scenariusz
            // 
            this.lb_scenariusz.FormattingEnabled = true;
            this.lb_scenariusz.Location = new System.Drawing.Point(159, 112);
            this.lb_scenariusz.Name = "lb_scenariusz";
            this.lb_scenariusz.Size = new System.Drawing.Size(181, 56);
            this.lb_scenariusz.TabIndex = 61;
            this.lb_scenariusz.SelectedIndexChanged += new System.EventHandler(this.lb_scenariusz_SelectedIndexChanged);
            this.lb_scenariusz.DoubleClick += new System.EventHandler(this.lb_scenariusz_DoubleClick);
            // 
            // btn_dodaj_rezysera
            // 
            this.btn_dodaj_rezysera.Location = new System.Drawing.Point(241, 73);
            this.btn_dodaj_rezysera.Name = "btn_dodaj_rezysera";
            this.btn_dodaj_rezysera.Size = new System.Drawing.Size(99, 23);
            this.btn_dodaj_rezysera.TabIndex = 65;
            this.btn_dodaj_rezysera.Text = "DODAJ";
            this.btn_dodaj_rezysera.UseVisualStyleBackColor = true;
            this.btn_dodaj_rezysera.Click += new System.EventHandler(this.btn_dodaj_rezysera_Click);
            // 
            // btn_usun_rezysera
            // 
            this.btn_usun_rezysera.Enabled = false;
            this.btn_usun_rezysera.Location = new System.Drawing.Point(160, 73);
            this.btn_usun_rezysera.Name = "btn_usun_rezysera";
            this.btn_usun_rezysera.Size = new System.Drawing.Size(75, 23);
            this.btn_usun_rezysera.TabIndex = 66;
            this.btn_usun_rezysera.Text = "USUŃ";
            this.btn_usun_rezysera.UseVisualStyleBackColor = true;
            this.btn_usun_rezysera.Click += new System.EventHandler(this.btn_usun_rezysera_Click);
            // 
            // lb_rezyseria
            // 
            this.lb_rezyseria.FormattingEnabled = true;
            this.lb_rezyseria.Location = new System.Drawing.Point(159, 11);
            this.lb_rezyseria.Name = "lb_rezyseria";
            this.lb_rezyseria.Size = new System.Drawing.Size(181, 56);
            this.lb_rezyseria.TabIndex = 59;
            this.lb_rezyseria.SelectedIndexChanged += new System.EventHandler(this.lb_rezyseria_SelectedIndexChanged);
            this.lb_rezyseria.DoubleClick += new System.EventHandler(this.lb_rezyseria_DoubleClick);
            // 
            // btn_dodaj_aktora
            // 
            this.btn_dodaj_aktora.Location = new System.Drawing.Point(626, 294);
            this.btn_dodaj_aktora.Name = "btn_dodaj_aktora";
            this.btn_dodaj_aktora.Size = new System.Drawing.Size(99, 23);
            this.btn_dodaj_aktora.TabIndex = 71;
            this.btn_dodaj_aktora.Text = "DODAJ";
            this.btn_dodaj_aktora.UseVisualStyleBackColor = true;
            this.btn_dodaj_aktora.Click += new System.EventHandler(this.btn_dodaj_aktora_Click);
            // 
            // btn_usun_kompozytora
            // 
            this.btn_usun_kompozytora.Enabled = false;
            this.btn_usun_kompozytora.Location = new System.Drawing.Point(159, 275);
            this.btn_usun_kompozytora.Name = "btn_usun_kompozytora";
            this.btn_usun_kompozytora.Size = new System.Drawing.Size(75, 23);
            this.btn_usun_kompozytora.TabIndex = 74;
            this.btn_usun_kompozytora.Text = "USUŃ";
            this.btn_usun_kompozytora.UseVisualStyleBackColor = true;
            this.btn_usun_kompozytora.Click += new System.EventHandler(this.btn_usun_kompozytora_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(657, 367);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_anuluj.Size = new System.Drawing.Size(99, 47);
            this.btn_anuluj.TabIndex = 75;
            this.btn_anuluj.Text = "ZAMKNIJ";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // btn_usun_zdjeciowcaczyjaksienanichmowi
            // 
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.Enabled = false;
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.Location = new System.Drawing.Point(159, 379);
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.Name = "btn_usun_zdjeciowcaczyjaksienanichmowi";
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.Size = new System.Drawing.Size(75, 23);
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.TabIndex = 79;
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.Text = "USUŃ";
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.UseVisualStyleBackColor = true;
            this.btn_usun_zdjeciowcaczyjaksienanichmowi.Click += new System.EventHandler(this.btn_usun_zdjeciowcaczyjaksienanichmowi_Click);
            // 
            // btn_dodaj_zdjeciowcaczyjaksienanichmowi
            // 
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.Location = new System.Drawing.Point(241, 379);
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.Name = "btn_dodaj_zdjeciowcaczyjaksienanichmowi";
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.Size = new System.Drawing.Size(99, 23);
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.TabIndex = 78;
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.Text = "DODAJ";
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.UseVisualStyleBackColor = true;
            this.btn_dodaj_zdjeciowcaczyjaksienanichmowi.Click += new System.EventHandler(this.btn_dodaj_zdjeciowcaczyjaksienanichmowi_Click);
            // 
            // lb_zdjecia
            // 
            this.lb_zdjecia.FormattingEnabled = true;
            this.lb_zdjecia.Location = new System.Drawing.Point(159, 317);
            this.lb_zdjecia.Name = "lb_zdjecia";
            this.lb_zdjecia.Size = new System.Drawing.Size(181, 56);
            this.lb_zdjecia.TabIndex = 77;
            this.lb_zdjecia.SelectedIndexChanged += new System.EventHandler(this.lb_zdjecia_SelectedIndexChanged);
            this.lb_zdjecia.DoubleClick += new System.EventHandler(this.lb_zdjecia_DoubleClick);
            // 
            // btn_gora
            // 
            this.btn_gora.Location = new System.Drawing.Point(731, 11);
            this.btn_gora.Name = "btn_gora";
            this.btn_gora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_gora.Size = new System.Drawing.Size(25, 25);
            this.btn_gora.TabIndex = 80;
            this.btn_gora.Text = "↑";
            this.btn_gora.UseVisualStyleBackColor = true;
            this.btn_gora.Click += new System.EventHandler(this.btn_gora_Click);
            // 
            // btn_dol
            // 
            this.btn_dol.Location = new System.Drawing.Point(731, 42);
            this.btn_dol.Name = "btn_dol";
            this.btn_dol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dol.Size = new System.Drawing.Size(25, 25);
            this.btn_dol.TabIndex = 81;
            this.btn_dol.Text = "↓";
            this.btn_dol.UseVisualStyleBackColor = true;
            this.btn_dol.Click += new System.EventHandler(this.btn_dol_Click);
            // 
            // FrmZarzadzanieObsada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.btn_dol);
            this.Controls.Add(this.btn_gora);
            this.Controls.Add(this.btn_usun_zdjeciowcaczyjaksienanichmowi);
            this.Controls.Add(this.btn_dodaj_zdjeciowcaczyjaksienanichmowi);
            this.Controls.Add(this.lb_zdjecia);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.btn_usun_kompozytora);
            this.Controls.Add(this.btn_dodaj_aktora);
            this.Controls.Add(this.btn_usun_aktora);
            this.Controls.Add(this.btn_dodaj_kompozytora);
            this.Controls.Add(this.btn_usun_scenarzyste);
            this.Controls.Add(this.btn_dodaj_scenarzyste);
            this.Controls.Add(this.btn_usun_rezysera);
            this.Controls.Add(this.btn_dodaj_rezysera);
            this.Controls.Add(this.lb_aktorzy);
            this.Controls.Add(this.lb_muzyka);
            this.Controls.Add(this.lb_scenariusz);
            this.Controls.Add(this.lb_rezyseria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTekst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmZarzadzanieObsada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZARZĄDZANIE OBSADĄ FILMU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmZarzadzanieObsada_FormClosing);
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTekst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_aktorzy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dodaj_kompozytora;
        private System.Windows.Forms.Button btn_usun_aktora;
        private System.Windows.Forms.ListBox lb_muzyka;
        private System.Windows.Forms.Button btn_usun_scenarzyste;
        private System.Windows.Forms.Button btn_dodaj_scenarzyste;
        private System.Windows.Forms.ListBox lb_scenariusz;
        private System.Windows.Forms.Button btn_dodaj_rezysera;
        private System.Windows.Forms.Button btn_usun_rezysera;
        private System.Windows.Forms.ListBox lb_rezyseria;
        private System.Windows.Forms.Button btn_dodaj_aktora;
        private System.Windows.Forms.Button btn_usun_kompozytora;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_usun_zdjeciowcaczyjaksienanichmowi;
        private System.Windows.Forms.Button btn_dodaj_zdjeciowcaczyjaksienanichmowi;
        private System.Windows.Forms.ListBox lb_zdjecia;
        private System.Windows.Forms.Button btn_gora;
        private System.Windows.Forms.Button btn_dol;
    }
}