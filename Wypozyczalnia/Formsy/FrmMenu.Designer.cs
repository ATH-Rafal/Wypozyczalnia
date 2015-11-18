namespace Wypozyczalnia.Formsy
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
            this.Lista_Klientów = new System.Windows.Forms.Button();
            this.Lista_Filmow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista_Klientów
            // 
            this.Lista_Klientów.Location = new System.Drawing.Point(12, 12);
            this.Lista_Klientów.Name = "Lista_Klientów";
            this.Lista_Klientów.Size = new System.Drawing.Size(113, 39);
            this.Lista_Klientów.TabIndex = 0;
            this.Lista_Klientów.Text = "LISTA KLIENTÓW";
            this.Lista_Klientów.UseVisualStyleBackColor = true;
            this.Lista_Klientów.Click += new System.EventHandler(this.Lista_Klientów_Click);
            // 
            // Lista_Filmow
            // 
            this.Lista_Filmow.Location = new System.Drawing.Point(131, 12);
            this.Lista_Filmow.Name = "Lista_Filmow";
            this.Lista_Filmow.Size = new System.Drawing.Size(113, 39);
            this.Lista_Filmow.TabIndex = 1;
            this.Lista_Filmow.Text = "LISTA FILMÓW";
            this.Lista_Filmow.UseVisualStyleBackColor = true;
            this.Lista_Filmow.Click += new System.EventHandler(this.Lista_Filmow_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(255, 62);
            this.Controls.Add(this.Lista_Filmow);
            this.Controls.Add(this.Lista_Klientów);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU GŁÓWNE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lista_Klientów;
        private System.Windows.Forms.Button Lista_Filmow;
    }
}