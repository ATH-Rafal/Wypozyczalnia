﻿using System;
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
    public partial class FrmListaTaryf : Form
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
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Taryfy;", conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dataGridView1.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void przejdzDoTaryfy()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FrmFormularzTaryfy frmFormularzTaryfy = new FrmFormularzTaryfy(id);
                frmFormularzTaryfy.ShowDialog(this);               
            }
        }

        public FrmListaTaryf()
        {
            InitializeComponent();
            odswiez();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = dataGridView1.RowCount;
            if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;

            FrmDodajTaryfe frmDodajTaryfe = new FrmDodajTaryfe();
            frmDodajTaryfe.ShowDialog();
            odswiez();

            if (dataGridView1.RowCount != 0)
            {
                if (dataGridView1.RowCount != liczba_wierszy)
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                else dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                index = dataGridView1.SelectedRows[0].Index;
                FrmEdyfujTaryfe frmEdyfujTaryfe = new FrmEdyfujTaryfe(id);
                frmEdyfujTaryfe.ShowDialog();
                odswiez();
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {              
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command1 = new SQLiteCommand(conn);                   
                    command1.CommandText = "SELECT Count(*) FROM Filmy WHERE id_taryfy = @id";
                    command1.Parameters.Add(new SQLiteParameter("@id", id));                    
                    if (command1.ExecuteScalar().ToString() != "0")
                    {
                        MessageBox.Show("Dana taryfa jest przypisana do przynajmniej jednego filmu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Czy na pewno chcesz taryfę numer " + id + "?\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                            SQLiteCommand command2 = new SQLiteCommand(conn);
                            command2.CommandText = "DELETE FROM Taryfy WHERE id = @id";
                            command2.Parameters.Add(new SQLiteParameter("@id", id));
                            command2.ExecuteNonQuery();
                            SQLiteCommand command3 = new SQLiteCommand(conn);
                            command3.CommandText = "DELETE FROM TaryfyZasady WHERE id = @id";
                            command3.Parameters.Add(new SQLiteParameter("@id", id));
                            command3.ExecuteNonQuery();
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
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoTaryfy();
        }

        private void btn_pokaz_taryfe_Click(object sender, EventArgs e)
        {
            przejdzDoTaryfy();
        }
    }
}