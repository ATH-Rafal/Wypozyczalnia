﻿using System;
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
        int index;

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

        private void przejdzDoKlienta()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FrmFormularzKlienta FrmFormularzKlienta = new FrmFormularzKlienta(id);
                FrmFormularzKlienta.ShowDialog();
            }
        }

        public FrmListaKlientow()
        {                        
            InitializeComponent();            
            odswiez();
        }

        private void btn_pokaz_profil_Click(object sender, EventArgs e)
        {
            przejdzDoKlienta();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoKlienta();
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dodaj_klienta_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = dataGridView1.RowCount;
            if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;

            FrmDodajKlienta FrmDodajKlienta = new FrmDodajKlienta();
            FrmDodajKlienta.ShowDialog();
            odswiez();

            if (dataGridView1.RowCount != 0)
            {
                if (dataGridView1.RowCount != liczba_wierszy)
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                else dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_usun_klienta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć klienta numer " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command = new SQLiteCommand(conn);
                        command.CommandText = "DELETE FROM Klienci WHERE id = @id";
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

        private void btn_edytuj_klienta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                index = dataGridView1.SelectedRows[0].Index;
                FrmEdytujKlienta FrmEdytujKlienta = new FrmEdytujKlienta(id);
                FrmEdytujKlienta.ShowDialog();
                odswiez();
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }
    }
}