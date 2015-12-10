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
    public partial class FrmListaTagow : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int id;
        int index;
        string parent_form;
        ListBox.ObjectCollection obiekty;

        private void odswiez()
        {
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Tagi;", conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dataGridView1.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void przejdzDoTaga()
        {
            id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            FrmFormularzTaga frmFormularzTaga = new FrmFormularzTaga(id);
            frmFormularzTaga.ShowDialog();
        }

        public FrmListaTagow(ListBox.ObjectCollection _obiekty, string _parent_form)
        {
            obiekty = _obiekty;
            parent_form = _parent_form;
            InitializeComponent();
            odswiez();
        }

        public FrmListaTagow(string _parent_form)
        {
            InitializeComponent();           
            btn_dodaj_tag.Text = "SZCZEGÓŁY TAGA";
            odswiez();
        }

        private void btn_nowy_tag_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                INSERT INTO Tagi (nazwa)
                                VALUES (@nazwa)
                                ";

                command.Parameters.Add(new SQLiteParameter("@nazwa", txt_nowy.Text));

                command.ExecuteNonQuery();
                conn.Close();
            }
            odswiez();

            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
            txt_nowy.Text = "";
            txt_nowy.Focus();
        }

        private void btn_edytuj_tag_Click(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedRows[0].Index;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                UPDATE Tagi
                                SET
                                nazwa = @nazwa
                                WHERE id = @id
                                ";

                command.Parameters.Add(new SQLiteParameter("@nazwa", txt_edytuj.Text));
                command.Parameters.Add(new SQLiteParameter("@id", Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));                
                command.ExecuteNonQuery();
                conn.Close();
            }
            odswiez();
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
        }

        private void btn_usun_tag_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tag numer " + id + "?\nTag zostanie również usunięty z powiązanych filmów.\n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (parent_form == "FrmZarzadzanieTagami")
                        obiekty.Remove(dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " [" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "]");
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command1 = new SQLiteCommand(conn);
                        command1.CommandText = "DELETE FROM Tagi WHERE id = @id";
                        command1.Parameters.Add(new SQLiteParameter("@id", id));
                        command1.ExecuteNonQuery();
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "DELETE FROM TagiFilmy WHERE id_taga = @id";
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
            if (string.IsNullOrWhiteSpace(txt_nowy.Text)) btn_nowy_tag.Enabled = false;
            else btn_nowy_tag.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btn_dodaj_tag.Enabled = true;
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = "SELECT * FROM Tagi WHERE id=@id";
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
                btn_dodaj_tag.Enabled = false;
                txt_edytuj.Text = "";
            }
        }

        private void txt_edytuj_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txt_edytuj.Text) || txt_edytuj.Text == dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) btn_edytuj_tag.Enabled = false;
                else btn_edytuj_tag.Enabled = true;
            }
            else btn_edytuj_tag.Enabled = false;
        }

        private void btn_dodaj_tag_Click(object sender, EventArgs e)
        {
            if (parent_form == "FrmZarzadzanieTagami")
            {
                string nowy_obiekt = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " [" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "]";
                if (!obiekty.Contains(nowy_obiekt))
                {
                    obiekty.Add(nowy_obiekt);
                }
                this.Close();
            }
            else przejdzDoTaga();
        }

        private void FrmListaTagow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_form == "FrmZarzadzanieTagami")
            {
                ((FrmZarzadzanieTagami)this.Owner).obiekty_prop.Clear();
                ((FrmZarzadzanieTagami)this.Owner).obiekty_prop.AddRange(obiekty);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoTaga();
        }
    }
}
