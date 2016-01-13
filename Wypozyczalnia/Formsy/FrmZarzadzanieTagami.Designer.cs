namespace Wypozyczalnia.Formsy
{
    partial class FrmZarzadzanieTagami
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
            this.lb_tagi = new System.Windows.Forms.ListBox();
            this.btn_dodaj_tag = new System.Windows.Forms.Button();
            this.btn_usun_tag = new System.Windows.Forms.Button();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.btn_dol = new System.Windows.Forms.Button();
            this.btn_gora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tagi
            // 
            this.lb_tagi.FormattingEnabled = true;
            this.lb_tagi.Location = new System.Drawing.Point(12, 12);
            this.lb_tagi.Name = "lb_tagi";
            this.lb_tagi.Size = new System.Drawing.Size(180, 264);
            this.lb_tagi.TabIndex = 0;
            this.lb_tagi.DoubleClick += new System.EventHandler(this.lb_tagi_DoubleClick);
            // 
            // btn_dodaj_tag
            // 
            this.btn_dodaj_tag.Location = new System.Drawing.Point(245, 12);
            this.btn_dodaj_tag.Name = "btn_dodaj_tag";
            this.btn_dodaj_tag.Size = new System.Drawing.Size(108, 70);
            this.btn_dodaj_tag.TabIndex = 1;
            this.btn_dodaj_tag.Text = "DODAJ TAG DO FILMU";
            this.btn_dodaj_tag.UseVisualStyleBackColor = true;
            this.btn_dodaj_tag.Click += new System.EventHandler(this.btn_dodaj_tag_Click);
            // 
            // btn_usun_tag
            // 
            this.btn_usun_tag.Location = new System.Drawing.Point(245, 88);
            this.btn_usun_tag.Name = "btn_usun_tag";
            this.btn_usun_tag.Size = new System.Drawing.Size(108, 50);
            this.btn_usun_tag.TabIndex = 2;
            this.btn_usun_tag.Text = "USUŃ TAG";
            this.btn_usun_tag.UseVisualStyleBackColor = true;
            this.btn_usun_tag.Click += new System.EventHandler(this.btn_usun_tag_Click);
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(245, 226);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.Size = new System.Drawing.Size(108, 50);
            this.btn_zamknij.TabIndex = 3;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // btn_dol
            // 
            this.btn_dol.Location = new System.Drawing.Point(198, 43);
            this.btn_dol.Name = "btn_dol";
            this.btn_dol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dol.Size = new System.Drawing.Size(25, 25);
            this.btn_dol.TabIndex = 83;
            this.btn_dol.Text = "↓";
            this.btn_dol.UseVisualStyleBackColor = true;
            this.btn_dol.Click += new System.EventHandler(this.btn_dol_Click);
            // 
            // btn_gora
            // 
            this.btn_gora.Location = new System.Drawing.Point(198, 12);
            this.btn_gora.Name = "btn_gora";
            this.btn_gora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_gora.Size = new System.Drawing.Size(25, 25);
            this.btn_gora.TabIndex = 82;
            this.btn_gora.Text = "↑";
            this.btn_gora.UseVisualStyleBackColor = true;
            this.btn_gora.Click += new System.EventHandler(this.btn_gora_Click);
            // 
            // FrmZarzadzanieTagami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(365, 293);
            this.Controls.Add(this.btn_dol);
            this.Controls.Add(this.btn_gora);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.btn_usun_tag);
            this.Controls.Add(this.btn_dodaj_tag);
            this.Controls.Add(this.lb_tagi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmZarzadzanieTagami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZARZĄDZANIE TAGAMI FILMU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmZarzadzanieTagami_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_tagi;
        private System.Windows.Forms.Button btn_dodaj_tag;
        private System.Windows.Forms.Button btn_usun_tag;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.Button btn_dol;
        private System.Windows.Forms.Button btn_gora;
    }
}