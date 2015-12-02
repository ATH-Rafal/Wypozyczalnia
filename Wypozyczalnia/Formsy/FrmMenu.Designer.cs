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
            this.Lista_Tagow = new System.Windows.Forms.Button();
            this.Lista_Wypozyczen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista_Klientów
            // 
            this.Lista_Klientów.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.Lista_Klientów.Location = new System.Drawing.Point(-1, 0);
            this.Lista_Klientów.Name = "Lista_Klientów";
            this.Lista_Klientów.Size = new System.Drawing.Size(144, 39);
            this.Lista_Klientów.TabIndex = 0;
            this.Lista_Klientów.Text = "KLIENCI";
            this.Lista_Klientów.UseVisualStyleBackColor = false;
            this.Lista_Klientów.Click += new System.EventHandler(this.Lista_Klientów_Click);
            // 
            // Lista_Filmow
            // 
            this.Lista_Filmow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.Lista_Filmow.Location = new System.Drawing.Point(279, 0);
            this.Lista_Filmow.Name = "Lista_Filmow";
            this.Lista_Filmow.Size = new System.Drawing.Size(144, 39);
            this.Lista_Filmow.TabIndex = 1;
            this.Lista_Filmow.Text = "FILMY";
            this.Lista_Filmow.UseVisualStyleBackColor = false;
            this.Lista_Filmow.Click += new System.EventHandler(this.Lista_Filmow_Click);
            // 
            // Lista_Tagow
            // 
            this.Lista_Tagow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.Lista_Tagow.Location = new System.Drawing.Point(140, 0);
            this.Lista_Tagow.Name = "Lista_Tagow";
            this.Lista_Tagow.Size = new System.Drawing.Size(144, 39);
            this.Lista_Tagow.TabIndex = 2;
            this.Lista_Tagow.Text = "TAGI";
            this.Lista_Tagow.UseVisualStyleBackColor = false;
            this.Lista_Tagow.Click += new System.EventHandler(this.Lista_Tagow_Click);
            // 
            // Lista_Wypozyczen
            // 
            this.Lista_Wypozyczen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.Lista_Wypozyczen.Location = new System.Drawing.Point(140, 281);
            this.Lista_Wypozyczen.Name = "Lista_Wypozyczen";
            this.Lista_Wypozyczen.Size = new System.Drawing.Size(144, 39);
            this.Lista_Wypozyczen.TabIndex = 5;
            this.Lista_Wypozyczen.Text = "HISTORIA WYPOŻYCZEŃ";
            this.Lista_Wypozyczen.UseVisualStyleBackColor = false;
            this.Lista_Wypozyczen.Click += new System.EventHandler(this.Lista_Wypozyczen_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(420, 319);
            this.Controls.Add(this.Lista_Wypozyczen);
            this.Controls.Add(this.Lista_Tagow);
            this.Controls.Add(this.Lista_Filmow);
            this.Controls.Add(this.Lista_Klientów);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU GŁÓWNE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lista_Klientów;
        private System.Windows.Forms.Button Lista_Filmow;
        private System.Windows.Forms.Button Lista_Tagow;
        private System.Windows.Forms.Button Lista_Wypozyczen;
    }
}