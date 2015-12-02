namespace Wypozyczalnia.Formsy
{
    partial class FrmHistoriaWypozyczen
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
            this.dtg_historia = new System.Windows.Forms.DataGridView();
            this.btn_szukaj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_historia
            // 
            this.dtg_historia.AllowUserToAddRows = false;
            this.dtg_historia.AllowUserToDeleteRows = false;
            this.dtg_historia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_historia.Location = new System.Drawing.Point(-3, -1);
            this.dtg_historia.MultiSelect = false;
            this.dtg_historia.Name = "dtg_historia";
            this.dtg_historia.ReadOnly = true;
            this.dtg_historia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_historia.Size = new System.Drawing.Size(655, 396);
            this.dtg_historia.TabIndex = 0;
            // 
            // btn_szukaj
            // 
            this.btn_szukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btn_szukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_szukaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_szukaj.Location = new System.Drawing.Point(-3, 393);
            this.btn_szukaj.Name = "btn_szukaj";
            this.btn_szukaj.Size = new System.Drawing.Size(94, 26);
            this.btn_szukaj.TabIndex = 1;
            this.btn_szukaj.Text = "SZUKAJ";
            this.btn_szukaj.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(88, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 26);
            this.textBox1.TabIndex = 2;
            // 
            // FrmHistoriaWypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(653, 435);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_szukaj);
            this.Controls.Add(this.dtg_historia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmHistoriaWypozyczen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIA WYPOZYCZEN";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_historia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_historia;
        private System.Windows.Forms.Button btn_szukaj;
        private System.Windows.Forms.TextBox textBox1;
    }
}