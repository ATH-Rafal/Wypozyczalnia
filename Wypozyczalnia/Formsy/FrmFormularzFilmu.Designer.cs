namespace Wypozyczalnia.Formsy
{
    partial class FrmFormularzFilmu
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
            this.txt_taryfa = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_wypozycz = new System.Windows.Forms.Button();
            this.txt_nosnik = new System.Windows.Forms.TextBox();
            this.lb_tagi = new System.Windows.Forms.ListBox();
            this.txt_uwagi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dlugosc = new System.Windows.Forms.TextBox();
            this.txt_dystrybutor = new System.Windows.Forms.TextBox();
            this.txt_tytul_org = new System.Windows.Forms.TextBox();
            this.txt_gatunek2 = new System.Windows.Forms.TextBox();
            this.txt_rok_produkcji = new System.Windows.Forms.MaskedTextBox();
            this.cb_lektor = new System.Windows.Forms.CheckBox();
            this.txt_kraj = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.PanelTekst = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gatunek = new System.Windows.Forms.TextBox();
            this.cb_napisy = new System.Windows.Forms.CheckBox();
            this.txt_tytul_pol = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_zdjecia = new System.Windows.Forms.ListBox();
            this.lb_scenariusz = new System.Windows.Forms.ListBox();
            this.lb_rezyseria = new System.Windows.Forms.ListBox();
            this.lb_aktorzy = new System.Windows.Forms.ListBox();
            this.lb_muzyka = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelTekst.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage1.Controls.Add(this.txt_taryfa);
            this.tabPage1.Controls.Add(this.lb_status);
            this.tabPage1.Controls.Add(this.btn_wypozycz);
            this.tabPage1.Controls.Add(this.txt_nosnik);
            this.tabPage1.Controls.Add(this.lb_tagi);
            this.tabPage1.Controls.Add(this.txt_uwagi);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txt_dlugosc);
            this.tabPage1.Controls.Add(this.txt_dystrybutor);
            this.tabPage1.Controls.Add(this.txt_tytul_org);
            this.tabPage1.Controls.Add(this.txt_gatunek2);
            this.tabPage1.Controls.Add(this.txt_rok_produkcji);
            this.tabPage1.Controls.Add(this.cb_lektor);
            this.tabPage1.Controls.Add(this.txt_kraj);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.btn_zamknij);
            this.tabPage1.Controls.Add(this.PanelTekst);
            this.tabPage1.Controls.Add(this.txt_gatunek);
            this.tabPage1.Controls.Add(this.cb_napisy);
            this.tabPage1.Controls.Add(this.txt_tytul_pol);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Strona główna";
            // 
            // txt_taryfa
            // 
            this.txt_taryfa.Location = new System.Drawing.Point(160, 307);
            this.txt_taryfa.Name = "txt_taryfa";
            this.txt_taryfa.ReadOnly = true;
            this.txt_taryfa.Size = new System.Drawing.Size(317, 20);
            this.txt_taryfa.TabIndex = 10;
            // 
            // lb_status
            // 
            this.lb_status.Location = new System.Drawing.Point(668, 282);
            this.lb_status.Name = "lb_status";
            this.lb_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_status.Size = new System.Drawing.Size(243, 48);
            this.lb_status.TabIndex = 109;
            this.lb_status.Text = "Ten film nie jest aktualnie wypożyczony";
            // 
            // btn_wypozycz
            // 
            this.btn_wypozycz.Location = new System.Drawing.Point(820, 333);
            this.btn_wypozycz.Name = "btn_wypozycz";
            this.btn_wypozycz.Size = new System.Drawing.Size(88, 23);
            this.btn_wypozycz.TabIndex = 15;
            this.btn_wypozycz.Text = "WYPOŻYCZ";
            this.btn_wypozycz.UseVisualStyleBackColor = true;
            this.btn_wypozycz.Click += new System.EventHandler(this.btn_wypozycz_Click);
            // 
            // txt_nosnik
            // 
            this.txt_nosnik.Location = new System.Drawing.Point(160, 278);
            this.txt_nosnik.Name = "txt_nosnik";
            this.txt_nosnik.ReadOnly = true;
            this.txt_nosnik.Size = new System.Drawing.Size(317, 20);
            this.txt_nosnik.TabIndex = 9;
            // 
            // lb_tagi
            // 
            this.lb_tagi.FormattingEnabled = true;
            this.lb_tagi.Location = new System.Drawing.Point(646, 100);
            this.lb_tagi.Name = "lb_tagi";
            this.lb_tagi.Size = new System.Drawing.Size(265, 121);
            this.lb_tagi.TabIndex = 14;
            this.lb_tagi.DoubleClick += new System.EventHandler(this.lb_tagi_DoubleClick);
            this.lb_tagi.Leave += new System.EventHandler(this.lb_tagi_Leave);
            // 
            // txt_uwagi
            // 
            this.txt_uwagi.Location = new System.Drawing.Point(646, 13);
            this.txt_uwagi.Multiline = true;
            this.txt_uwagi.Name = "txt_uwagi";
            this.txt_uwagi.ReadOnly = true;
            this.txt_uwagi.Size = new System.Drawing.Size(265, 84);
            this.txt_uwagi.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(487, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 417);
            this.panel1.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label10.Location = new System.Drawing.Point(12, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tagi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label11.Location = new System.Drawing.Point(12, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Uwagi";
            // 
            // txt_dlugosc
            // 
            this.txt_dlugosc.Location = new System.Drawing.Point(160, 249);
            this.txt_dlugosc.Name = "txt_dlugosc";
            this.txt_dlugosc.ReadOnly = true;
            this.txt_dlugosc.Size = new System.Drawing.Size(317, 20);
            this.txt_dlugosc.TabIndex = 8;
            // 
            // txt_dystrybutor
            // 
            this.txt_dystrybutor.Location = new System.Drawing.Point(160, 191);
            this.txt_dystrybutor.Name = "txt_dystrybutor";
            this.txt_dystrybutor.ReadOnly = true;
            this.txt_dystrybutor.Size = new System.Drawing.Size(317, 20);
            this.txt_dystrybutor.TabIndex = 6;
            // 
            // txt_tytul_org
            // 
            this.txt_tytul_org.Location = new System.Drawing.Point(160, 71);
            this.txt_tytul_org.Name = "txt_tytul_org";
            this.txt_tytul_org.ReadOnly = true;
            this.txt_tytul_org.Size = new System.Drawing.Size(317, 20);
            this.txt_tytul_org.TabIndex = 2;
            // 
            // txt_gatunek2
            // 
            this.txt_gatunek2.Location = new System.Drawing.Point(160, 162);
            this.txt_gatunek2.Name = "txt_gatunek2";
            this.txt_gatunek2.ReadOnly = true;
            this.txt_gatunek2.Size = new System.Drawing.Size(317, 20);
            this.txt_gatunek2.TabIndex = 5;
            // 
            // txt_rok_produkcji
            // 
            this.txt_rok_produkcji.Location = new System.Drawing.Point(160, 101);
            this.txt_rok_produkcji.Mask = "0000";
            this.txt_rok_produkcji.Name = "txt_rok_produkcji";
            this.txt_rok_produkcji.ReadOnly = true;
            this.txt_rok_produkcji.Size = new System.Drawing.Size(317, 20);
            this.txt_rok_produkcji.TabIndex = 3;
            // 
            // cb_lektor
            // 
            this.cb_lektor.AutoSize = true;
            this.cb_lektor.Enabled = false;
            this.cb_lektor.Location = new System.Drawing.Point(160, 335);
            this.cb_lektor.Name = "cb_lektor";
            this.cb_lektor.Size = new System.Drawing.Size(56, 17);
            this.cb_lektor.TabIndex = 11;
            this.cb_lektor.Text = "Lektor";
            this.cb_lektor.UseVisualStyleBackColor = true;
            // 
            // txt_kraj
            // 
            this.txt_kraj.Location = new System.Drawing.Point(160, 220);
            this.txt_kraj.Name = "txt_kraj";
            this.txt_kraj.ReadOnly = true;
            this.txt_kraj.Size = new System.Drawing.Size(317, 20);
            this.txt_kraj.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(160, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(317, 20);
            this.txt_id.TabIndex = 0;
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(820, 362);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_zamknij.Size = new System.Drawing.Size(88, 47);
            this.btn_zamknij.TabIndex = 16;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label6);
            this.PanelTekst.Controls.Add(this.label13);
            this.PanelTekst.Controls.Add(this.label12);
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Controls.Add(this.label1);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Controls.Add(this.label4);
            this.PanelTekst.Controls.Add(this.label9);
            this.PanelTekst.Controls.Add(this.label8);
            this.PanelTekst.Controls.Add(this.label5);
            this.PanelTekst.Controls.Add(this.label7);
            this.PanelTekst.Location = new System.Drawing.Point(1, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 417);
            this.PanelTekst.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dystrybutor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label13.Location = new System.Drawing.Point(12, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Gatunek 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label12.Location = new System.Drawing.Point(12, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Gatunek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Taryfa";
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
            this.label9.Location = new System.Drawing.Point(12, 247);
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
            this.label8.Location = new System.Drawing.Point(12, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nośnik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(12, 98);
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
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kraj";
            // 
            // txt_gatunek
            // 
            this.txt_gatunek.Location = new System.Drawing.Point(160, 132);
            this.txt_gatunek.Name = "txt_gatunek";
            this.txt_gatunek.ReadOnly = true;
            this.txt_gatunek.Size = new System.Drawing.Size(317, 20);
            this.txt_gatunek.TabIndex = 4;
            // 
            // cb_napisy
            // 
            this.cb_napisy.AutoSize = true;
            this.cb_napisy.Enabled = false;
            this.cb_napisy.Location = new System.Drawing.Point(233, 335);
            this.cb_napisy.Name = "cb_napisy";
            this.cb_napisy.Size = new System.Drawing.Size(58, 17);
            this.cb_napisy.TabIndex = 12;
            this.cb_napisy.Text = "Napisy";
            this.cb_napisy.UseVisualStyleBackColor = true;
            // 
            // txt_tytul_pol
            // 
            this.txt_tytul_pol.Location = new System.Drawing.Point(160, 41);
            this.txt_tytul_pol.Name = "txt_tytul_pol";
            this.txt_tytul_pol.ReadOnly = true;
            this.txt_tytul_pol.Size = new System.Drawing.Size(317, 20);
            this.txt_tytul_pol.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lb_zdjecia);
            this.tabPage2.Controls.Add(this.lb_scenariusz);
            this.tabPage2.Controls.Add(this.lb_rezyseria);
            this.tabPage2.Controls.Add(this.lb_aktorzy);
            this.tabPage2.Controls.Add(this.lb_muzyka);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obsada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 362);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "ZAMKNIJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(458, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 417);
            this.panel2.TabIndex = 104;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label21.Location = new System.Drawing.Point(12, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 16);
            this.label21.TabIndex = 29;
            this.label21.Text = "Aktorzy";
            // 
            // lb_zdjecia
            // 
            this.lb_zdjecia.FormattingEnabled = true;
            this.lb_zdjecia.Location = new System.Drawing.Point(159, 317);
            this.lb_zdjecia.Name = "lb_zdjecia";
            this.lb_zdjecia.Size = new System.Drawing.Size(293, 82);
            this.lb_zdjecia.TabIndex = 3;
            this.lb_zdjecia.DoubleClick += new System.EventHandler(this.lb_zdjecia_DoubleClick);
            this.lb_zdjecia.Leave += new System.EventHandler(this.lb_zdjecia_Leave);
            // 
            // lb_scenariusz
            // 
            this.lb_scenariusz.FormattingEnabled = true;
            this.lb_scenariusz.Location = new System.Drawing.Point(159, 112);
            this.lb_scenariusz.Name = "lb_scenariusz";
            this.lb_scenariusz.Size = new System.Drawing.Size(293, 82);
            this.lb_scenariusz.TabIndex = 1;
            this.lb_scenariusz.DoubleClick += new System.EventHandler(this.lb_scenariusz_DoubleClick);
            this.lb_scenariusz.Leave += new System.EventHandler(this.lb_scenariusz_Leave);
            // 
            // lb_rezyseria
            // 
            this.lb_rezyseria.FormattingEnabled = true;
            this.lb_rezyseria.Location = new System.Drawing.Point(159, 11);
            this.lb_rezyseria.Name = "lb_rezyseria";
            this.lb_rezyseria.Size = new System.Drawing.Size(293, 82);
            this.lb_rezyseria.TabIndex = 0;
            this.lb_rezyseria.DoubleClick += new System.EventHandler(this.lb_rezyseria_DoubleClick);
            this.lb_rezyseria.Leave += new System.EventHandler(this.lb_rezyseria_Leave);
            // 
            // lb_aktorzy
            // 
            this.lb_aktorzy.FormattingEnabled = true;
            this.lb_aktorzy.Location = new System.Drawing.Point(617, 5);
            this.lb_aktorzy.Name = "lb_aktorzy";
            this.lb_aktorzy.Size = new System.Drawing.Size(294, 329);
            this.lb_aktorzy.TabIndex = 4;
            this.lb_aktorzy.DoubleClick += new System.EventHandler(this.lb_aktorzy_DoubleClick);
            this.lb_aktorzy.Leave += new System.EventHandler(this.lb_aktorzy_Leave);
            // 
            // lb_muzyka
            // 
            this.lb_muzyka.FormattingEnabled = true;
            this.lb_muzyka.Location = new System.Drawing.Point(159, 213);
            this.lb_muzyka.Name = "lb_muzyka";
            this.lb_muzyka.Size = new System.Drawing.Size(293, 82);
            this.lb_muzyka.TabIndex = 2;
            this.lb_muzyka.DoubleClick += new System.EventHandler(this.lb_muzyka_DoubleClick);
            this.lb_muzyka.Leave += new System.EventHandler(this.lb_muzyka_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 417);
            this.panel3.TabIndex = 98;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label22.Location = new System.Drawing.Point(12, 317);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 16);
            this.label22.TabIndex = 32;
            this.label22.Text = "Zdjęcia";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label23.Location = new System.Drawing.Point(12, 213);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 16);
            this.label23.TabIndex = 31;
            this.label23.Text = "Muzyka";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label24.Location = new System.Drawing.Point(12, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 16);
            this.label24.TabIndex = 30;
            this.label24.Text = "Scenariusz";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label25.Location = new System.Drawing.Point(12, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 16);
            this.label25.TabIndex = 29;
            this.label25.Text = "Reżyseria";
            // 
            // FrmFormularzFilmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(927, 441);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmFormularzFilmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFIL FILMU";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_taryfa;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_wypozycz;
        private System.Windows.Forms.TextBox txt_nosnik;
        private System.Windows.Forms.ListBox lb_tagi;
        private System.Windows.Forms.TextBox txt_uwagi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dlugosc;
        private System.Windows.Forms.TextBox txt_dystrybutor;
        private System.Windows.Forms.TextBox txt_tytul_org;
        private System.Windows.Forms.TextBox txt_gatunek2;
        private System.Windows.Forms.MaskedTextBox txt_rok_produkcji;
        private System.Windows.Forms.CheckBox cb_lektor;
        private System.Windows.Forms.TextBox txt_kraj;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Panel PanelTekst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gatunek;
        private System.Windows.Forms.CheckBox cb_napisy;
        private System.Windows.Forms.TextBox txt_tytul_pol;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lb_zdjecia;
        private System.Windows.Forms.ListBox lb_scenariusz;
        private System.Windows.Forms.ListBox lb_rezyseria;
        private System.Windows.Forms.ListBox lb_aktorzy;
        private System.Windows.Forms.ListBox lb_muzyka;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
    }
}