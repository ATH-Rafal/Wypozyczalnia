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
    public partial class FrmListaOsob : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int id;
        int index;
        int rola;
        string parent_form;
        List<osoba> osoby = new List<osoba>();

        private void odswiez()
        {
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Osoby;", conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dataGridView1.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void przejdzDoOsoby()
        {
            id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(id);
            frmFormularzOsoby.ShowDialog();
        }

        public FrmListaOsob(List<osoba> _osoby, string _parent_form, int _rola)
        {
            osoby = _osoby;
            parent_form = _parent_form;
            rola = _rola;
            InitializeComponent();
            cmb_kolumna.SelectedIndex = 0;
            odswiez();
        }

        public FrmListaOsob(string _parent_form)
        {
            InitializeComponent();
            btn_dodaj_osobe.Text = "SZCZEGÓŁY TAGA";
            odswiez();
            cmb_kolumna.SelectedIndex = 0;
        }

        private void btn_nowa_osoba_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = @"
                                SELECT Count(*) FROM Osoby
                                WHERE imie_nazwisko LIKE @imie_nazwisko
                                ";
                command1.Parameters.Add(new SQLiteParameter("@imie_nazwisko", txt_nowy.Text));
                int licz = Int32.Parse(command1.ExecuteScalar().ToString());

                if (licz > 0)
                {
                    int rIndex = -1;
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if (r.Cells[1].Value.ToString().ToUpper().Equals(txt_nowy.Text.ToUpper()))
                        {
                            rIndex = r.Index;
                            break;
                        }
                    }
                    dataGridView1.CurrentCell = dataGridView1.Rows[rIndex].Cells[0];
                }
                else
                {
                    SQLiteCommand command2 = new SQLiteCommand(conn);
                    command2.CommandText = @"
                                INSERT INTO Osoby (imie_nazwisko)
                                VALUES (@imie_nazwisko)
                                ";

                    command2.Parameters.Add(new SQLiteParameter("@imie_nazwisko", txt_nowy.Text));
                    command2.ExecuteNonQuery();
                    odswiez();
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                    
                }
                conn.Close();
            }          
            txt_nowy.Text = "";
            txt_nowy.Focus();           
        }

        private void btn_edytuj_osobe_Click(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedRows[0].Index;

            if (parent_form == "FrmZarzadzanieObsada")
            {
                if (osoby.Contains(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 1)))
                {
                    osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 1));
                    osoby.Add(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 1));
                }
                if (osoby.Contains(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 2)))
                {
                    osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 2));
                    osoby.Add(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 2));
                }
                if (osoby.Contains(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 3)))
                {
                    osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 3));
                    osoby.Add(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 3));
                }
                if (osoby.Contains(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 4)))
                {
                    osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 4));
                    osoby.Add(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 4));
                }
                if (osoby.Contains(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 5)))
                {
                    osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 5));
                    osoby.Add(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 5));
                }
            }

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                UPDATE Osoby
                                SET
                                imie_nazwisko = @imie_nazwisko
                                WHERE id = @id
                                ";

                command.Parameters.Add(new SQLiteParameter("@imie_nazwisko", txt_edytuj.Text));
                command.Parameters.Add(new SQLiteParameter("@id", Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));
                command.ExecuteNonQuery();
                conn.Close();

            }
            odswiez();
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
        }

        private void btn_usun_osobe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć osobę numer " + id + " z bazy?\nOsoba zostanie również usunięta z powiązanych filmów.\n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (parent_form == "FrmZarzadzanieObsada")
                    {
                            osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 1));
                            osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 2));
                            osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 3));
                            osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 4));
                            osoby.Remove(new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 5));
                    }

                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command1 = new SQLiteCommand(conn);
                        command1.CommandText = "DELETE FROM Osoby WHERE id = @id";
                        command1.Parameters.Add(new SQLiteParameter("@id", id));
                        command1.ExecuteNonQuery();
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "DELETE FROM Obsada WHERE id_osoby = @id";
                        command2.Parameters.Add(new SQLiteParameter("@id", id));
                        command2.ExecuteNonQuery();
                        conn.Close();
                        odswiez();
                        if (dataGridView1.RowCount != 0)
                        {
                            if (index == dataGridView1.RowCount) dataGridView1.CurrentCell = dataGridView1.Rows[index - 1].Cells[0];
                            else dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
                        }
                    }
                }
            }
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nowy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nowy.Text)) btn_nowa_osoba.Enabled = false;
            else btn_nowa_osoba.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btn_dodaj_osobe.Enabled = true;
                btn_usun_osobe.Enabled = true;
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = "SELECT * FROM Osoby WHERE id=@id";
                    command.Parameters.Add(new SQLiteParameter("@id", id));
                    using (command)
                    {
                        using (SQLiteDataReader rdr = command.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                txt_edytuj.Text = rdr.GetValue(1).ToString();
                            }
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                btn_dodaj_osobe.Enabled = false;
                btn_usun_osobe.Enabled = false;
                txt_edytuj.Text = "";
            }
        }

        private void txt_edytuj_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txt_edytuj.Text) || txt_edytuj.Text == dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) btn_edytuj_osobe.Enabled = false;
                else btn_edytuj_osobe.Enabled = true;
            }
            else btn_edytuj_osobe.Enabled = false;
        }

        private void btn_dodaj_osobe_Click(object sender, EventArgs e)
        {
            if (parent_form == "FrmZarzadzanieObsada")
            {
                osoba nowa_osoba = new osoba(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), rola);
                if (!osoby.Contains(nowa_osoba))
                {
                    osoby.Add(nowa_osoba);
                }
                this.Close();
            }
            else przejdzDoOsoby();
        }

        private void FrmListaOsob_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_form == "FrmZarzadzanieObsada")
            {
                ((FrmZarzadzanieObsada)this.Owner).osoby_prop = osoby;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoOsoby();
        }

        private void txt_filtr_TextChanged(object sender, EventArgs e)
        {
            if (cmb_kolumna.Text == "ID")
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
                case "Imię i nazwisko": table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "imie_nazwisko", txt_filtr.Text); break;
            }
        }

        private void cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_filtr.Text = "";
        }

        private void txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_kolumna.Text == "ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
