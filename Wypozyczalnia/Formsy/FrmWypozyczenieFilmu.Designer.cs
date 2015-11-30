namespace Wypozyczalnia.Formsy
{
    partial class FrmWypozyczenieFilmu
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
            this.PanelLista = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.btn_pokaz = new System.Windows.Forms.Button();
            this.btn_wyjscie = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_imie_nazwisko = new System.Windows.Forms.TextBox();
            this.text_tytul = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.PanelLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLista
            // 
            this.PanelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelLista.Controls.Add(this.label4);
            this.PanelLista.Controls.Add(this.label3);
            this.PanelLista.Controls.Add(this.label2);
            this.PanelLista.Controls.Add(this.label1);
            this.PanelLista.Location = new System.Drawing.Point(1, 1);
            this.PanelLista.Name = "PanelLista";
            this.PanelLista.Size = new System.Drawing.Size(152, 165);
            this.PanelLista.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SZUKAJ klienta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imię i Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Klienta *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TYTUŁ";
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_zatwierdz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_zatwierdz.Location = new System.Drawing.Point(1, 162);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(152, 41);
            this.btn_zatwierdz.TabIndex = 1;
            this.btn_zatwierdz.Text = "ZATWIERDŹ";
            this.btn_zatwierdz.UseVisualStyleBackColor = false;
            // 
            // btn_pokaz
            // 
            this.btn_pokaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_pokaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_pokaz.Location = new System.Drawing.Point(150, 162);
            this.btn_pokaz.Name = "btn_pokaz";
            this.btn_pokaz.Size = new System.Drawing.Size(130, 41);
            this.btn_pokaz.TabIndex = 2;
            this.btn_pokaz.Text = "POKAŻ PROFIL";
            this.btn_pokaz.UseVisualStyleBackColor = false;
            // 
            // btn_wyjscie
            // 
            this.btn_wyjscie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_wyjscie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_wyjscie.Location = new System.Drawing.Point(278, 162);
            this.btn_wyjscie.Name = "btn_wyjscie";
            this.btn_wyjscie.Size = new System.Drawing.Size(115, 41);
            this.btn_wyjscie.TabIndex = 3;
            this.btn_wyjscie.Text = "WYJŚCIE";
            this.btn_wyjscie.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.txt_id.Location = new System.Drawing.Point(150, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(243, 20);
            this.txt_id.TabIndex = 5;
            // 
            // txt_imie_nazwisko
            // 
            this.txt_imie_nazwisko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.txt_imie_nazwisko.Location = new System.Drawing.Point(150, 86);
            this.txt_imie_nazwisko.Name = "txt_imie_nazwisko";
            this.txt_imie_nazwisko.Size = new System.Drawing.Size(243, 20);
            this.txt_imie_nazwisko.TabIndex = 6;
            // 
            // text_tytul
            // 
            this.text_tytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.text_tytul.Location = new System.Drawing.Point(150, 13);
            this.text_tytul.Multiline = true;
            this.text_tytul.Name = "text_tytul";
            this.text_tytul.Size = new System.Drawing.Size(243, 20);
            this.text_tytul.TabIndex = 4;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.txt_szukaj.Location = new System.Drawing.Point(150, 124);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(243, 20);
            this.txt_szukaj.TabIndex = 7;
            // 
            // FrmWypozyczenieFilmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(392, 202);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_imie_nazwisko);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.text_tytul);
            this.Controls.Add(this.btn_wyjscie);
            this.Controls.Add(this.btn_pokaz);
            this.Controls.Add(this.btn_zatwierdz);
            this.Controls.Add(this.PanelLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmWypozyczenieFilmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WYPOŻYCZENIE FILMU";
            this.Load += new System.EventHandler(this.FrmWypozyczenieFilmu_Load);
            this.PanelLista.ResumeLayout(false);
            this.PanelLista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_zatwierdz;
        private System.Windows.Forms.Button btn_pokaz;
        private System.Windows.Forms.Button btn_wyjscie;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_imie_nazwisko;
        private System.Windows.Forms.TextBox text_tytul;
        private System.Windows.Forms.TextBox txt_szukaj;
    }
}