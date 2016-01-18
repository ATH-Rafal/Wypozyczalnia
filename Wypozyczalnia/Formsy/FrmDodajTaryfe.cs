using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmDodajTaryfe : Form
    {
        string connString = "Data Source = baza.db; Version = 3";

        private void btn_dodaj_control()
        {
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

        public FrmDodajTaryfe()
        {
            InitializeComponent();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_dni.Text) && !String.IsNullOrWhiteSpace(txt_cena.Text))
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
        }

        private void txt_cena_TextChanged(object sender, EventArgs e)
        {
            btn_dodaj_control();

            string temp = null;
            foreach (char c in txt_cena.Text)
            {
                if (char.IsControl(c) || char.IsNumber(c) || c == '.')
                {
                    temp += c;
                }
            }
            txt_cena.Text = temp;
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

        private void btn_usun_Click(object sender, EventArgs e)
        {
            lb_zasady.Items.Remove(lb_zasady.SelectedItem);
            btn_dodaj_control();
        }

        private void lb_zasady_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_zasady.SelectedItems.Count > 0)
            {
                string[] words = lb_zasady.SelectedItem.ToString().Split(' ');
                txt_dni.Text = words[0];
                txt_cena.Text = words[3].Trim(new Char[] { 'z', 'ł' }); ;
            }
        }

        private void txt_cena_za_dzien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_cena_za_dzien_TextChanged(object sender, EventArgs e)
        {
            string temp = null;
            foreach (char c in txt_cena_za_dzien.Text)
            {
                if (char.IsControl(c) || char.IsNumber(c) || c == '.')
                {
                    temp += c;
                }
            }
            txt_cena_za_dzien.Text = temp;

        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_cena_za_dzien.Text) && !string.IsNullOrWhiteSpace(txt_nazwa.Text))
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();

                    SQLiteCommand command1 = new SQLiteCommand(conn);
                    command1.CommandText = @"
                                INSERT INTO Taryfy (nazwa, cena_za_dzien)
                                VALUES (@nazwa, @cena_za_dzien);
                                SELECT last_insert_rowid()";

                    command1.Parameters.Add(new SQLiteParameter("@nazwa", txt_nazwa.Text));
                    command1.Parameters.Add(new SQLiteParameter("@cena_za_dzien", txt_cena_za_dzien.Text));
                    string id = command1.ExecuteScalar().ToString();

                    foreach (string s in lb_zasady.Items)
                    {
                        string[] words = s.Split(' ');

                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = @"
                                INSERT INTO TaryfyZasady (id, dni, cena)
                                VALUES (@id, @dni, @cena);
                                ;";
                        command2.Parameters.Add(new SQLiteParameter("@id", id));
                        command2.Parameters.Add(new SQLiteParameter("@dni", words[0]));
                        command2.Parameters.Add(new SQLiteParameter("@cena", words[3]));
                        command2.ExecuteNonQuery();
                    }

                    conn.Close();
                    this.Close();

                }
            }
            else MessageBox.Show("Uzupełnij wymagane pola", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
