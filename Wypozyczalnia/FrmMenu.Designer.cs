namespace Wypozyczalnia
{
    partial class FrmMenu
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
            this.btnKlienci = new System.Windows.Forms.Button();
            this.BtnFilmy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlienci
            // 
            this.btnKlienci.Location = new System.Drawing.Point(-4, 0);
            this.btnKlienci.Name = "btnKlienci";
            this.btnKlienci.Size = new System.Drawing.Size(97, 47);
            this.btnKlienci.TabIndex = 0;
            this.btnKlienci.Text = "Klienci";
            this.btnKlienci.UseVisualStyleBackColor = true;
            // 
            // BtnFilmy
            // 
            this.BtnFilmy.Location = new System.Drawing.Point(359, 0);
            this.BtnFilmy.Name = "BtnFilmy";
            this.BtnFilmy.Size = new System.Drawing.Size(97, 47);
            this.BtnFilmy.TabIndex = 1;
            this.BtnFilmy.Text = "Filmy";
            this.BtnFilmy.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(455, 419);
            this.Controls.Add(this.BtnFilmy);
            this.Controls.Add(this.btnKlienci);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlienci;
        private System.Windows.Forms.Button BtnFilmy;
    }
}