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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.txt_klient = new System.Windows.Forms.TextBox();
            this.txt_id_filmu = new System.Windows.Forms.TextBox();
            this.txt_id_klienta = new System.Windows.Forms.TextBox();
            this.txt_film = new System.Windows.Forms.TextBox();
            this.btn_wybierz_klienta = new System.Windows.Forms.Button();
            this.btn_wybierz_film = new System.Windows.Forms.Button();
            this.txt_dni = new System.Windows.Forms.NumericUpDown();
            this.label_cena = new System.Windows.Forms.Label();
            this.PanelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dni)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLista
            // 
            this.PanelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.PanelLista.Controls.Add(this.label1);
            this.PanelLista.Controls.Add(this.label4);
            this.PanelLista.Controls.Add(this.label2);
            this.PanelLista.Location = new System.Drawing.Point(0, 0);
            this.PanelLista.Name = "PanelLista";
            this.PanelLista.Size = new System.Drawing.Size(152, 299);
            this.PanelLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(11, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ile dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Filmu*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Klienta *";
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.btn_zatwierdz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_zatwierdz.Location = new System.Drawing.Point(242, 239);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(88, 47);
            this.btn_zatwierdz.TabIndex = 1;
            this.btn_zatwierdz.Text = "ZATWIERDŹ";
            this.btn_zatwierdz.UseVisualStyleBackColor = true;
            this.btn_zatwierdz.Click += new System.EventHandler(this.btn_zatwierdz_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.btn_anuluj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_anuluj.Location = new System.Drawing.Point(336, 239);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(88, 47);
            this.btn_anuluj.TabIndex = 3;
            this.btn_anuluj.Text = "ANULUJ";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // txt_klient
            // 
            this.txt_klient.BackColor = System.Drawing.SystemColors.Control;
            this.txt_klient.Location = new System.Drawing.Point(159, 48);
            this.txt_klient.Name = "txt_klient";
            this.txt_klient.ReadOnly = true;
            this.txt_klient.Size = new System.Drawing.Size(265, 20);
            this.txt_klient.TabIndex = 5;
            // 
            // txt_id_filmu
            // 
            this.txt_id_filmu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id_filmu.Location = new System.Drawing.Point(159, 87);
            this.txt_id_filmu.Name = "txt_id_filmu";
            this.txt_id_filmu.Size = new System.Drawing.Size(146, 20);
            this.txt_id_filmu.TabIndex = 6;
            this.txt_id_filmu.TextChanged += new System.EventHandler(this.txt_id_filmu_TextChanged);
            this.txt_id_filmu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_filmu_KeyPress);
            // 
            // txt_id_klienta
            // 
            this.txt_id_klienta.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id_klienta.Location = new System.Drawing.Point(159, 12);
            this.txt_id_klienta.Multiline = true;
            this.txt_id_klienta.Name = "txt_id_klienta";
            this.txt_id_klienta.Size = new System.Drawing.Size(146, 20);
            this.txt_id_klienta.TabIndex = 4;
            this.txt_id_klienta.TextChanged += new System.EventHandler(this.txt_id_klienta_TextChanged);
            this.txt_id_klienta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_klienta_KeyPress);
            // 
            // txt_film
            // 
            this.txt_film.BackColor = System.Drawing.SystemColors.Control;
            this.txt_film.Location = new System.Drawing.Point(159, 122);
            this.txt_film.Name = "txt_film";
            this.txt_film.ReadOnly = true;
            this.txt_film.Size = new System.Drawing.Size(265, 20);
            this.txt_film.TabIndex = 7;
            // 
            // btn_wybierz_klienta
            // 
            this.btn_wybierz_klienta.Location = new System.Drawing.Point(311, 10);
            this.btn_wybierz_klienta.Name = "btn_wybierz_klienta";
            this.btn_wybierz_klienta.Size = new System.Drawing.Size(112, 23);
            this.btn_wybierz_klienta.TabIndex = 8;
            this.btn_wybierz_klienta.Text = "WYBIERZ Z LISTY";
            this.btn_wybierz_klienta.UseVisualStyleBackColor = true;
            this.btn_wybierz_klienta.Click += new System.EventHandler(this.btn_wybierz_klienta_Click);
            // 
            // btn_wybierz_film
            // 
            this.btn_wybierz_film.Location = new System.Drawing.Point(311, 85);
            this.btn_wybierz_film.Name = "btn_wybierz_film";
            this.btn_wybierz_film.Size = new System.Drawing.Size(112, 23);
            this.btn_wybierz_film.TabIndex = 9;
            this.btn_wybierz_film.Text = "WYBIERZ Z LISTY";
            this.btn_wybierz_film.UseVisualStyleBackColor = true;
            this.btn_wybierz_film.Click += new System.EventHandler(this.btn_wybierz_film_Click);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(159, 164);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(86, 20);
            this.txt_dni.TabIndex = 10;
            this.txt_dni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cena.Location = new System.Drawing.Point(158, 200);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(73, 20);
            this.label_cena.TabIndex = 11;
            this.label_cena.Text = "CENA: ...";
            // 
            // FrmWypozyczenieFilmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(435, 298);
            this.Controls.Add(this.label_cena);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.btn_wybierz_film);
            this.Controls.Add(this.btn_wybierz_klienta);
            this.Controls.Add(this.txt_film);
            this.Controls.Add(this.txt_id_filmu);
            this.Controls.Add(this.txt_klient);
            this.Controls.Add(this.txt_id_klienta);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.btn_zatwierdz);
            this.Controls.Add(this.PanelLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmWypozyczenieFilmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WYPOŻYCZENIE FILMU";
            this.PanelLista.ResumeLayout(false);
            this.PanelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_zatwierdz;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.TextBox txt_klient;
        private System.Windows.Forms.TextBox txt_id_filmu;
        private System.Windows.Forms.TextBox txt_id_klienta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_film;
        private System.Windows.Forms.Button btn_wybierz_klienta;
        private System.Windows.Forms.Button btn_wybierz_film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_dni;
        private System.Windows.Forms.Label label_cena;
    }
}