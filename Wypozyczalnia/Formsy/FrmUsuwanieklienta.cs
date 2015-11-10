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
    public partial class FrmUsuwanieklienta : Form
    {
        public FrmUsuwanieklienta()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usunklienta_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = baza.db; Version = 3");  // Tworzymy nowe połączenie z bazą, baza.db, to nasza baza danych
            SQLiteCommand command = new SQLiteCommand(conn); // Tworzymy nowe zapytanie
            if (label1 != null)
            {

                conn.Open(); // Otwiarcie połączenia
                command.CommandText = "DELETE FROM Klienci Where id ='" + textBox2.Text + "'"; // Treść zapytania, usuwamy rekord w tabeli
                command.ExecuteNonQuery(); // Wykonanie zapytania
                MessageBox.Show("Klient został usunięty");
                conn.Close(); // Zamyknięcie połączenia
            }
            
        }


    }
}
