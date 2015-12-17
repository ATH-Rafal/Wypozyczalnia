﻿using System;
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
        string parent_form;
        bool czy_wybrano = false;

        public bool czy_wybrano_prop
        {
            get
            {
                return czy_wybrano;
            }
            set
            {
                czy_wybrano = value;
            }
        }

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
                FrmFormularzFilmu FrmWysFilmu = new FrmFormularzFilmu(id, parent_form);
                FrmWysFilmu.ShowDialog(this);
                if (parent_form == "FrmWypozyczenieFilmu")
                    if (czy_wybrano == true) wybierzDoWypozyczenia();
            }
        }

        private void wybierzDoWypozyczenia()
        {
            id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            ((FrmWypozyczenieFilmu)this.Owner).txt_id_filmu_text = id.ToString();
            this.Close();
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

            if (parent_form == "FrmWypozyczenieFilmu")
            {
                btn_pokaz_film.Text = "WYBIERZ";
            }
            odswiez();

            cmb_kolumna.SelectedIndex = 0;
            cmb_porownanie.SelectedIndex = 0;
        }

        private void btn_pokaz_film_Click(object sender, EventArgs e)
        {
            if (parent_form == "FrmWypozyczenieFilmu")
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
                    else wybierzDoWypozyczenia();
                }
            }
            else przejdzDoFilmu();
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
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć film numer " + id + "?\nUsuniętę zostaną również wypożyczenia filmu.\n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command1 = new SQLiteCommand(conn);
                        command1.CommandText = "DELETE FROM Filmy WHERE id = @id";
                        command1.Parameters.Add(new SQLiteParameter("@id", id));
                        command1.ExecuteNonQuery();
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "DELETE FROM Wypozyczenia WHERE id_filmu = @id";
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

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_filtr_TextChanged(object sender, EventArgs e)
        {
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
