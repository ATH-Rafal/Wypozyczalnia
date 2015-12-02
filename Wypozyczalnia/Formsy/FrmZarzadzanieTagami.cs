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
    public partial class FrmZarzadzanieTagami : Form
    {
        ListBox.ObjectCollection obiekty;
        string parent_form;

        public ListBox.ObjectCollection obiekty_prop
        {
            get
            {
                return obiekty;
            }
            set
            {
                obiekty = value;
            }
        }

        public FrmZarzadzanieTagami(ListBox.ObjectCollection _obiekty, string _parent_form)
        {
            obiekty = _obiekty;
            parent_form = _parent_form;
            InitializeComponent();
            foreach (object o in obiekty)
            {
                lb_tagi.Items.Add(o);
            }
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btn_dodaj_tag_Click(object sender, EventArgs e)
        {
            obiekty.Clear();
            obiekty.AddRange(lb_tagi.Items);
            FrmListaTagow frmListaTagow = new FrmListaTagow(lb_tagi.Items, this.Name);
            frmListaTagow.ShowDialog(this);
            if (obiekty != lb_tagi.Items)
            {
                lb_tagi.Items.Clear();
                foreach (object o in obiekty)
                {
                    lb_tagi.Items.Add(o);
                }
            }
        }

        private void btn_usun_tag_Click(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedItems.Count > 0)
            {
                lb_tagi.Items.Remove(lb_tagi.SelectedItem);
            }
        }

        private void FrmZarzadzanieTagami_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_form == "FrmDodajFilm") ((FrmDodajFilm)this.Owner).obiekty_prop = lb_tagi.Items;
            if (parent_form == "FrmEdytujFilm") ((FrmEdytujFilm)this.Owner).obiekty_prop = lb_tagi.Items;            
        }

        private void lb_tagi_DoubleClick(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedItems.Count > 0)
            {
                string[] words = lb_tagi.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzTaga frmFormularzTaga = new FrmFormularzTaga(Int32.Parse(id_taga));
                frmFormularzTaga.ShowDialog();
            }
        }
    }
}
