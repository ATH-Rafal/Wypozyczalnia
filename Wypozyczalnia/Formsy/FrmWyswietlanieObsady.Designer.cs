namespace Wypozyczalnia.Formsy
{
    partial class FrmWyswietlanieObsady
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
            this.lb_zdjecia = new System.Windows.Forms.ListBox();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.lb_scenariusz = new System.Windows.Forms.ListBox();
            this.lb_rezyseria = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_aktorzy = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_muzyka = new System.Windows.Forms.ListBox();
            this.PanelTekst = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelTekst.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_zdjecia
            // 
            this.lb_zdjecia.FormattingEnabled = true;
            this.lb_zdjecia.Location = new System.Drawing.Point(160, 317);
            this.lb_zdjecia.Name = "lb_zdjecia";
            this.lb_zdjecia.Size = new System.Drawing.Size(181, 82);
            this.lb_zdjecia.TabIndex = 97;
            this.lb_zdjecia.DoubleClick += new System.EventHandler(this.lb_zdjecia_DoubleClick);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(629, 364);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_anuluj.Size = new System.Drawing.Size(99, 47);
            this.btn_anuluj.TabIndex = 96;
            this.btn_anuluj.Text = "ZAMKNIJ";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // lb_scenariusz
            // 
            this.lb_scenariusz.FormattingEnabled = true;
            this.lb_scenariusz.Location = new System.Drawing.Point(160, 112);
            this.lb_scenariusz.Name = "lb_scenariusz";
            this.lb_scenariusz.Size = new System.Drawing.Size(181, 82);
            this.lb_scenariusz.TabIndex = 85;
            this.lb_scenariusz.DoubleClick += new System.EventHandler(this.lb_scenariusz_DoubleClick);
            // 
            // lb_rezyseria
            // 
            this.lb_rezyseria.FormattingEnabled = true;
            this.lb_rezyseria.Location = new System.Drawing.Point(160, 11);
            this.lb_rezyseria.Name = "lb_rezyseria";
            this.lb_rezyseria.Size = new System.Drawing.Size(181, 82);
            this.lb_rezyseria.TabIndex = 84;
            this.lb_rezyseria.DoubleClick += new System.EventHandler(this.lb_rezyseria_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(347, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 423);
            this.panel1.TabIndex = 83;
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
            // lb_aktorzy
            // 
            this.lb_aktorzy.FormattingEnabled = true;
            this.lb_aktorzy.Location = new System.Drawing.Point(506, 11);
            this.lb_aktorzy.Name = "lb_aktorzy";
            this.lb_aktorzy.Size = new System.Drawing.Size(222, 342);
            this.lb_aktorzy.TabIndex = 87;
            this.lb_aktorzy.DoubleClick += new System.EventHandler(this.lb_aktorzy_DoubleClick);
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
            // lb_muzyka
            // 
            this.lb_muzyka.FormattingEnabled = true;
            this.lb_muzyka.Location = new System.Drawing.Point(160, 213);
            this.lb_muzyka.Name = "lb_muzyka";
            this.lb_muzyka.Size = new System.Drawing.Size(181, 82);
            this.lb_muzyka.TabIndex = 86;
            this.lb_muzyka.DoubleClick += new System.EventHandler(this.lb_muzyka_DoubleClick);
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label5);
            this.PanelTekst.Controls.Add(this.label4);
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Location = new System.Drawing.Point(1, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 423);
            this.PanelTekst.TabIndex = 82;
            // 
            // FrmWyswietlanieObsady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(740, 423);
            this.Controls.Add(this.lb_zdjecia);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.lb_scenariusz);
            this.Controls.Add(this.lb_rezyseria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_aktorzy);
            this.Controls.Add(this.lb_muzyka);
            this.Controls.Add(this.PanelTekst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmWyswietlanieObsady";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OBSADA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_zdjecia;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.ListBox lb_scenariusz;
        private System.Windows.Forms.ListBox lb_rezyseria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_aktorzy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_muzyka;
        private System.Windows.Forms.Panel PanelTekst;
    }
}