using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmListaFilmow : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int id;
        string parent_form;

        private void odswiez()
        {
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Filmy;", conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dataGridView1.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void wybierzDoWypozyczenia()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string command_output;

                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = @"
                            SELECT (COUNT(id_filmu) = COUNT(data_zwrotu))
                            FROM Wypozyczenia
                            WHERE id_filmu = @id
                            ";
                    command.Parameters.Add(new SQLiteParameter("@id", id));
                    command_output = command.ExecuteScalar().ToString();
                    conn.Close();
                }

                if (command_output == "0") MessageBox.Show("Ten film jest aktualnie wypożyczony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    ((FrmWypozyczenieFilmu)this.Owner).txt_id_filmu_text = id.ToString();
                    this.Close();
                }
            }
            
        }

        private void filtruj()
        {
            switch (cmb_kolumna.Text)
            {
                case "ID":
                    table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", txt_filtr.Text); break;
                case "Tytuł polski":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "tytul_pol", txt_filtr.Text); break;
                case "Tytuł oryginalny":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "tytul_org", txt_filtr.Text); break;
                case "Rok produkcji":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text))
                        table.DefaultView.RowFilter = "rok_produkcji " + cmb_porownanie.Text + " " + txt_filtr.Text;
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Gatunek":
                    table.DefaultView.RowFilter = string.Format("([{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%')", "gatunek", txt_filtr.Text, "gatunek2"); break;
                case "Dystrybutor":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dystrybutor", txt_filtr.Text); break;
                case "Kraj":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "kraj", txt_filtr.Text); break;
                case "Długość":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text))
                        table.DefaultView.RowFilter = "dlugosc " + cmb_porownanie.Text + " " + txt_filtr.Text;
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Nośnik":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nosnik", txt_filtr.Text); break;
                case "ID taryfy":
                    table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id_taryfy], System.String)", txt_filtr.Text); break;
            }
            if (cb_lektor.Checked == true) table.DefaultView.RowFilter += " AND lektor = true";
            if (cb_napisy.Checked == true) table.DefaultView.RowFilter += " AND napisy = true";
        }

        public FrmListaFilmow(string _parent_form)
        {
            parent_form = _parent_form;
            InitializeComponent();

            odswiez();
            cmb_kolumna.SelectedIndex = 0;
            cmb_porownanie.SelectedIndex = 0;
        }

        private void btn_pokaz_film_Click(object sender, EventArgs e)
        {
            wybierzDoWypozyczenia();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            wybierzDoWypozyczenia();
        }
    

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_filtr_TextChanged(object sender, EventArgs e)
        {
            if (cmb_kolumna.Text == "ID" || cmb_kolumna.Text == "Rok produkcji" || cmb_kolumna.Text == "Długość" || cmb_kolumna.Text == "ID taryfy")
            {
                string temp = null;
                foreach (char c in txt_filtr.Text)
                {
                    if (char.IsControl(c) || char.IsNumber(c))
                    {
                        temp += c;
                    }
                }
                txt_filtr.Text = temp;
            }

            filtruj();
        }

        private void cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_filtr.Text = "";
            if (cmb_kolumna.Text == "Długość" || cmb_kolumna.Text == "Rok produkcji") cmb_porownanie.Enabled = true;
            else cmb_porownanie.Enabled = false;
        }

        private void cb_lektor_CheckedChanged(object sender, EventArgs e)
        {
            filtruj();
        }

        private void cb_napisy_CheckedChanged(object sender, EventArgs e)
        {
            filtruj();
        }

        private void txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_kolumna.Text == "ID" || cmb_kolumna.Text == "Rok produkcji" || cmb_kolumna.Text == "Długość" || cmb_kolumna.Text == "ID taryfy")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cmb_porownanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtruj();
        }
    }
}
