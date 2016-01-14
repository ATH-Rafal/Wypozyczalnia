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
    public partial class FrmWyswietlanieObsady : Form
    {
        List<osoba> osoby = new List<osoba>();
        string connString = "Data Source = baza.db; Version = 3";


        public string ImieNazwisko(int id)
        {
            string imie_nazwisko = null;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT imie_nazwisko FROM Osoby WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                imie_nazwisko = command.ExecuteScalar().ToString();
                conn.Close();
            }
            return imie_nazwisko;
        }

        public void odswiez()
        {
            lb_rezyseria.Items.Clear();
            lb_scenariusz.Items.Clear();
            lb_muzyka.Items.Clear();
            lb_zdjecia.Items.Clear();
            lb_aktorzy.Items.Clear();

            foreach (osoba o in osoby)
            {
                switch (o._id_roli)
                {
                    case 1:
                        lb_rezyseria.Items.Add(ImieNazwisko(o._id_osoby) + " [" + o._id_osoby + "]");
                        break;
                    case 2:
                        lb_scenariusz.Items.Add(ImieNazwisko(o._id_osoby) + " [" + o._id_osoby + "]");
                        break;
                    case 3:
                        lb_muzyka.Items.Add(ImieNazwisko(o._id_osoby) + " [" + o._id_osoby + "]");
                        break;
                    case 4:
                        lb_zdjecia.Items.Add(ImieNazwisko(o._id_osoby) + " [" + o._id_osoby + "]");
                        break;
                    case 5:
                        lb_aktorzy.Items.Add(ImieNazwisko(o._id_osoby) + " [" + o._id_osoby + "]");
                        break;
                }
            }
        }

        public FrmWyswietlanieObsady(List<osoba> _osoby)
        {
            osoby = _osoby;
            InitializeComponent();
            odswiez();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_rezyseria_DoubleClick(object sender, EventArgs e)
        {
            if (lb_rezyseria.SelectedItems.Count > 0)
            {
                string[] words = lb_rezyseria.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(Int32.Parse(id_taga));
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_scenariusz_DoubleClick(object sender, EventArgs e)
        {
            if (lb_scenariusz.SelectedItems.Count > 0)
            {
                string[] words = lb_scenariusz.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(Int32.Parse(id_taga));
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_muzyka_DoubleClick(object sender, EventArgs e)
        {
            if (lb_muzyka.SelectedItems.Count > 0)
            {
                string[] words = lb_muzyka.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(Int32.Parse(id_taga));
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_zdjecia_DoubleClick(object sender, EventArgs e)
        {
            if (lb_zdjecia.SelectedItems.Count > 0)
            {
                string[] words = lb_zdjecia.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(Int32.Parse(id_taga));
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_aktorzy_DoubleClick(object sender, EventArgs e)
        {
            if (lb_aktorzy.SelectedItems.Count > 0)
            {
                string[] words = lb_aktorzy.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(Int32.Parse(id_taga));
                frmFormularzOsoby.ShowDialog();
            }
        }
    }
}
