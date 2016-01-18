namespace Wypozyczalnia.Formsy
{
    partial class FrmFormularzOsoby
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_zamknij = new System.Windows.Forms.Button();
            this.lb_filmy = new System.Windows.Forms.ListBox();
            this.txt_nazwa = new System.Windows.Forms.TextBox();
            this.PanelTekst.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTekst
            // 
            this.PanelTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelTekst.Controls.Add(this.label2);
            this.PanelTekst.Controls.Add(this.label3);
            this.PanelTekst.Location = new System.Drawing.Point(0, 0);
            this.PanelTekst.Name = "PanelTekst";
            this.PanelTekst.Size = new System.Drawing.Size(153, 368);
            this.PanelTekst.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Imię i nazwisko";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filmy w których produkcji brała udział osoba";
            // 
            // btn_zamknij
            // 
            this.btn_zamknij.Location = new System.Drawing.Point(388, 308);
            this.btn_zamknij.Name = "btn_zamknij";
            this.btn_zamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_zamknij.Size = new System.Drawing.Size(88, 47);
            this.btn_zamknij.TabIndex = 2;
            this.btn_zamknij.Text = "ZAMKNIJ";
            this.btn_zamknij.UseVisualStyleBackColor = true;
            this.btn_zamknij.Click += new System.EventHandler(this.btn_zamknij_Click);
            // 
            // lb_filmy
            // 
            this.lb_filmy.FormattingEnabled = true;
            this.lb_filmy.Location = new System.Drawing.Point(159, 34);
            this.lb_filmy.Name = "lb_filmy";
            this.lb_filmy.Size = new System.Drawing.Size(317, 264);
            this.lb_filmy.TabIndex = 1;
            // 
            // txt_nazwa
            // 
            this.txt_nazwa.Location = new System.Drawing.Point(159, 8);
            this.txt_nazwa.Name = "txt_nazwa";
            this.txt_nazwa.ReadOnly = true;
            this.txt_nazwa.Size = new System.Drawing.Size(317, 20);
            this.txt_nazwa.TabIndex = 0;
            // 
            // FrmFormularzOsoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(488, 367);
            this.Controls.Add(this.PanelTekst);
            this.Controls.Add(this.btn_zamknij);
            this.Controls.Add(this.lb_filmy);
            this.Controls.Add(this.txt_nazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFormularzOsoby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SZCZEGÓŁY OSOBY";
            this.PanelTekst.ResumeLayout(false);
            this.PanelTekst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTekst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_zamknij;
        private System.Windows.Forms.ListBox lb_filmy;
        private System.Windows.Forms.TextBox txt_nazwa;
    }
}