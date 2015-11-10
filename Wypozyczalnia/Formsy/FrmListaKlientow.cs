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


namespace Wypozyczalnia
{
    public partial class FrmListaKlientow : Form
    {

        public FrmListaKlientow()
        {

            InitializeComponent();
        }


        private void zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = baza.db; Version = 3");  // Tworzymy nowe połączenie z bazą, baza.db, to nasza baza danych
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Klienci;",conn); // Tworzymy adapter i zapytanie wybierające wszystkie elementy z tabeli "Klienci"
            DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
            adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            dataGridView1.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView
        }




    }
}
