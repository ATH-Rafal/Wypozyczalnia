using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmEdyfujTaryfe : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        int id;

        private void btn_zatwierdz_control()
        {
            if (string.IsNullOrWhiteSpace(txt_cena_za_dzien.Text) || string.IsNullOrWhiteSpace(txt_nazwa.Text)) btn_zatwierdz.Enabled = false;
            else btn_zatwierdz.Enabled = true;
        }

        private void btn_dodaj_control()
        {
            if (String.IsNullOrWhiteSpace(txt_dni.Text) || String.IsNullOrWhiteSpace(txt_cena.Text)) btn_dodaj.Enabled = false;
            else btn_dodaj.Enabled = true;

            foreach (string s in lb_zasady.Items)
            {
                if (s.StartsWith(txt_dni.Text))
                {
                    btn_dodaj.Text = "EDYTUJ ZASADĘ";
                    return;
                }
            }
            btn_dodaj.Text = "DODAJ ZASADĘ";
        }


        public FrmEdyfujTaryfe(int id_)
        {
            id = id_;
            InitializeComponent();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = "SELECT * FROM Taryfy WHERE id=@id";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                using (command1)
                {
                    using (SQLiteDataReader rdr = command1.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_nazwa.Text = rdr.GetValue(1).ToString();
                            txt_cena_za_dzien.Text = rdr.GetValue(2).ToString().Replace(',','.');                           
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = "SELECT * FROM TaryfyZasady WHERE id=@id ";
                command2.Parameters.Add(new SQLiteParameter("@id", id));
                using (command2)
                {
                    using (SQLiteDataReader rdr = command2.ExecuteReader())
                    {
                        while (rdr.Read())
                        {                            
                            lb_zasady.Items.Add(rdr.GetValue(1).ToString() + " dni - " + rdr.GetValue(2).ToString().Replace(',', '.') + "zł");
                        }
                    }
                }
                conn.Close();
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_zasady.Items.Count; i++)
            {
                if (lb_zasady.Items[i].ToString().StartsWith(txt_dni.Text))
                {
                    lb_zasady.Items[i] = txt_dni.Text + " dni - " + txt_cena.Text + "zł";
                    lb_zasady.SelectedItem = txt_dni.Text + " dni - " + txt_cena.Text + "zł";
                    btn_dodaj_control();
                    return;
                }
            }
            lb_zasady.Items.Add(txt_dni.Text + " dni - " + txt_cena.Text + "zł");
            lb_zasady.SelectedItem = txt_dni.Text + " dni - " + txt_cena.Text + "zł";
            btn_dodaj_control();
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            lb_zasady.Items.Remove(lb_zasady.SelectedItem);
            btn_dodaj_control();
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_dni.Value == 0) txt_dni.Value = 1;
            btn_dodaj_control();
        }

        private void txt_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_cena_TextChanged(object sender, EventArgs e)
        {
            btn_dodaj_control();
        }

        private void lb_zasady_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_zasady.SelectedItems.Count > 0)
            {
                string[] words = lb_zasady.SelectedItem.ToString().Split(' ');
                txt_dni.Text = words[0];
                txt_cena.Text = words[3].Trim(new Char[] { 'z', 'ł' });
                btn_usun.Enabled = true;
            }
            else btn_usun.Enabled = false;
        }

        private void txt_cena_za_dzien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_nazwa_TextChanged(object sender, EventArgs e)
        {
            btn_zatwierdz_control();
        }

        private void txt_cena_za_dzien_TextChanged(object sender, EventArgs e)
        {
            btn_zatwierdz_control();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = @"
                                UPDATE Taryfy
                                SET
                                nazwa = @nazwa,
                                cena_za_dzien = @cena_za_dzien
                                WHERE id = @id
                                ";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                command1.Parameters.Add(new SQLiteParameter("@nazwa", txt_nazwa.Text));
                command1.Parameters.Add(new SQLiteParameter("@cena_za_dzien", txt_cena_za_dzien.Text));                
                command1.ExecuteNonQuery();

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = "DELETE FROM TaryfyZasady WHERE id = @id";
                command2.Parameters.Add(new SQLiteParameter("@id", id));
                command2.ExecuteNonQuery();

                foreach (string s in lb_zasady.Items)
                {
                    string[] words = s.Split(' ');
                    SQLiteCommand command3 = new SQLiteCommand(conn);
                    command3.CommandText = @"
                                INSERT INTO TaryfyZasady (id, dni, cena)
                                VALUES (@id, @dni, @cena);
                                ;";
                    command3.Parameters.Add(new SQLiteParameter("@id", id));
                    command3.Parameters.Add(new SQLiteParameter("@dni", words[0]));
                    command3.Parameters.Add(new SQLiteParameter("@cena", words[3]));
                    command3.ExecuteNonQuery();
                }

                conn.Close();
                this.Close();
            }
        }
    }
}
