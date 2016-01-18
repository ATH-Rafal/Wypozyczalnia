using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmListaKlientow : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int id;

        private void odswiez()
        {
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Klienci;", conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dataGridView1.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void wybierzDoWypozyczenia()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                ((FrmWypozyczenieFilmu)this.Owner).txt_id_klienta_text = id.ToString();
                this.Close();
            }
        }

        public FrmListaKlientow(string _parent_form)
        {
            InitializeComponent();            
            odswiez();
            cmb_kolumna.SelectedIndex = 0;
        }

        private void btn_pokaz_profil_Click(object sender, EventArgs e)
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
            if (cmb_kolumna.Text == "ID" || cmb_kolumna.Text == "PESEL" || cmb_kolumna.Text == "Nr. telefonu")
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

            switch (cmb_kolumna.Text)
            {
                case "ID": table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", txt_filtr.Text); break;
                case "Imię": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "imie", txt_filtr.Text); break;
                case "Nazwisko": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nazwisko", txt_filtr.Text); break;
                case "PESEL": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "pesel", txt_filtr.Text); break;
                case "Nr. dowodu": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nr_dowodu", txt_filtr.Text); break;
                case "Nr. telefonu": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nr_telefonu", txt_filtr.Text); break;
                case "E-Mail": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "email", txt_filtr.Text); break;
                case "Miejscowość": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "miejscowosc", txt_filtr.Text); break;
                case "Kod pocztowy": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "kod_pocztowy", txt_filtr.Text); break;
                case "Ulica": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "ulica", txt_filtr.Text); break;
                case "Nr. domu": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nr_domu", txt_filtr.Text); break;
            }

        }

        private void cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_filtr.Text = "";
        }

        private void txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_kolumna.Text == "ID" || cmb_kolumna.Text == "PESEL" || cmb_kolumna.Text == "Nr. telefonu")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (cmb_kolumna.Text == "Nr. dowodu")
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (cmb_kolumna.Text == "Kod pocztowy")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
