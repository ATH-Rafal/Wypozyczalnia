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
    public partial class FrmZarzadzanieObsada : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        List<osoba> osoby = new List<osoba>();
        string parent_form;
        //string connString = "Data Source = baza.db; Version = 3";

        public List<osoba> osoby_prop
        {
            get
            {
                return osoby;
            }
            set
            {
                osoby = value;
            }
        }

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

        public void przesunAktora(int kierunek)
        {
            if (lb_aktorzy.SelectedItem == null || lb_aktorzy.SelectedIndex < 0)
                return;

            int nowy_index = lb_aktorzy.SelectedIndex + kierunek;

            if (nowy_index < 0 || nowy_index >= lb_aktorzy.Items.Count)
                return;

            object wybrany_obiekt = lb_aktorzy.SelectedItem;

            lb_aktorzy.Items.Remove(wybrany_obiekt);
            lb_aktorzy.Items.Insert(nowy_index, wybrany_obiekt);
            lb_aktorzy.SetSelected(nowy_index, true);
        }

        public FrmZarzadzanieObsada(List<osoba> _osoby, string _parent_form)
        {
            osoby = _osoby;
            parent_form = _parent_form;
            InitializeComponent();
            odswiez();
        }

        private void btn_dodaj_rezysera_Click(object sender, EventArgs e)
        {
            FrmListaOsob frmListaOsob = new FrmListaOsob(osoby, this.Name, 1);
            frmListaOsob.ShowDialog(this);
            odswiez();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dodaj_scenarzyste_Click(object sender, EventArgs e)
        {
            FrmListaOsob frmListaOsob = new FrmListaOsob(osoby, this.Name, 2);
            frmListaOsob.ShowDialog(this);
            odswiez();
        }

        private void btn_dodaj_kompozytora_Click(object sender, EventArgs e)
        {
            FrmListaOsob frmListaOsob = new FrmListaOsob(osoby, this.Name, 3);
            frmListaOsob.ShowDialog(this);
            odswiez();
        }

        private void btn_dodaj_zdjeciowcaczyjaksienanichmowi_Click(object sender, EventArgs e)
        {
            FrmListaOsob frmListaOsob = new FrmListaOsob(osoby, this.Name, 4);
            frmListaOsob.ShowDialog(this);
            odswiez();
        }

        private void btn_dodaj_aktora_Click(object sender, EventArgs e)
        {
            FrmListaOsob frmListaOsob = new FrmListaOsob(osoby, this.Name, 5);
            frmListaOsob.ShowDialog(this);
            odswiez();
        }

        private void btn_gora_Click(object sender, EventArgs e)
        {
            przesunAktora(-1);
        }

        private void btn_dol_Click(object sender, EventArgs e)
        {
            przesunAktora(1);
        }

        private void btn_usun_rezysera_Click(object sender, EventArgs e)
        {
            string[] words = lb_rezyseria.SelectedItem.ToString().Split(' ');
            osoby.Remove(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 1));
            lb_rezyseria.Items.Remove(lb_rezyseria.SelectedItem);            
        }

        private void btn_usun_scenarzyste_Click(object sender, EventArgs e)
        {
            string[] words = lb_scenariusz.SelectedItem.ToString().Split(' ');
            osoby.Remove(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 2));
            lb_scenariusz.Items.Remove(lb_scenariusz.SelectedItem);
        }

        private void btn_usun_kompozytora_Click(object sender, EventArgs e)
        {
            string[] words = lb_muzyka.SelectedItem.ToString().Split(' ');
            osoby.Remove(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 3));
            lb_muzyka.Items.Remove(lb_muzyka.SelectedItem);
        }

        private void btn_usun_zdjeciowcaczyjaksienanichmowi_Click(object sender, EventArgs e)
        {
            string[] words = lb_zdjecia.SelectedItem.ToString().Split(' ');
            osoby.Remove(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 4));
            lb_zdjecia.Items.Remove(lb_zdjecia.SelectedItem);
        }

        private void btn_usun_aktora_Click(object sender, EventArgs e)
        {
            string[] words = lb_aktorzy.SelectedItem.ToString().Split(' ');
            osoby.Remove(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 5));
            lb_aktorzy.Items.Remove(lb_aktorzy.SelectedItem);
        }

        private void lb_rezyseria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_rezyseria.SelectedItems.Count > 0)
                btn_usun_rezysera.Enabled = true;
            else btn_usun_rezysera.Enabled = false;
        }

        private void lb_scenariusz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_scenariusz.SelectedItems.Count > 0)
                btn_usun_scenarzyste.Enabled = true;
            else btn_usun_scenarzyste.Enabled = false;
        }

        private void lb_muzyka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_muzyka.SelectedItems.Count > 0)
                btn_usun_kompozytora.Enabled = true;
            else btn_usun_kompozytora.Enabled = false;
        }

        private void lb_zdjecia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_zdjecia.SelectedItems.Count > 0)
                btn_usun_zdjeciowcaczyjaksienanichmowi.Enabled = true;
            else btn_usun_zdjeciowcaczyjaksienanichmowi.Enabled = false;
        }

        private void lb_aktorzy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_aktorzy.SelectedItems.Count > 0)
                btn_usun_aktora.Enabled = true;
            else btn_usun_aktora.Enabled = false;
        }

        private void FrmZarzadzanieObsada_FormClosing(object sender, FormClosingEventArgs e)
        {
            osoby.Clear();
            foreach (object o in lb_rezyseria.Items)
            {
                string[] words = o.ToString().Split(' ');
                osoby.Add(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 1));
            }
            foreach (object o in lb_scenariusz.Items)
            {
                string[] words = o.ToString().Split(' ');
                osoby.Add(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 2));
            }
            foreach (object o in lb_muzyka.Items)
            {
                string[] words = o.ToString().Split(' ');
                osoby.Add(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 3));
            }
            foreach (object o in lb_zdjecia.Items)
            {
                string[] words = o.ToString().Split(' ');
                osoby.Add(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 4));
            }
            foreach (object o in lb_aktorzy.Items)
            {
                string[] words = o.ToString().Split(' ');
                osoby.Add(new osoba(Int32.Parse(words[words.Length - 1].Trim(new Char[] { '[', ']' })), 5));
            }
            if (parent_form == "FrmDodajFilm") ((FrmDodajFilm)this.Owner).osoby_prop = osoby;
            if (parent_form == "FrmEdytujFilm") ((FrmEdytujFilm)this.Owner).osoby_prop = osoby;
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
<<<<<<< HEAD

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
=======
>>>>>>> origin/master
    }
}
