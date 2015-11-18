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
        int index;

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

        private void przejdzDoFilmu()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FrmFormularzFilmu FrmWysFilmu = new FrmFormularzFilmu(id);
                FrmWysFilmu.ShowDialog();
            }
        }

        public FrmListaFilmow()
        {
            InitializeComponent();
            odswiez();
        }

        private void btn_pokaz_film_Click(object sender, EventArgs e)
        {
            przejdzDoFilmu();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoFilmu();
        }

        private void btn_dodaj_film_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = dataGridView1.RowCount;
            if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;

            FrmDodajFilm frmDodajFilm = new FrmDodajFilm();
            frmDodajFilm.ShowDialog();
            odswiez();

            if (dataGridView1.RowCount != 0)
            {
                if (dataGridView1.RowCount != liczba_wierszy)
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                else dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_edytuj_film_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                index = dataGridView1.SelectedRows[0].Index;
                FrmEdytujFilm frmEdytujFilm = new FrmEdytujFilm(id);
                frmEdytujFilm.ShowDialog();
                odswiez();
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_usun_film_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć Film numer " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command = new SQLiteCommand(conn);
                        command.CommandText = "DELETE FROM Filmy WHERE id = @id";
                        command.Parameters.Add(new SQLiteParameter("@id", id));
                        command.ExecuteNonQuery();
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

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
