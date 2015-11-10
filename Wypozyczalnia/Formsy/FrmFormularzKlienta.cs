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
    public partial class FrmAddKlient : Form
    {
        public FrmAddKlient()
        {
            
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxbNoKlient_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddKlient_Load(object sender, EventArgs e)
        {

        }

        private void editklient_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void usunklient_Click(object sender, EventArgs e)
        {
            FrmUsuwanieklienta FrmUsuwanieklienta = new FrmUsuwanieklienta();
            FrmUsuwanieklienta.Show();
        }

        private void dodajklient_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = baza.db; Version = 3");  // Tworzymy nowe połączenie z bazą, baza.db, to nasza baza danych
            SQLiteCommand command = new SQLiteCommand(conn); // Tworzymy nowe zapytanie
         //  if (TxbName || textBox3 || textBox4 || textBox5 || textBox6 || textBox7 || textBox8 || textBox9 || textBox10 != null)
            {
                conn.Open(); // Otwiarcie połączenia
                command.CommandText = "INSERT INTO Klienci(imie, nazwisko, pesel, Nr_dowodu, email, Miejscowość, Kod_pocztowy, Ulica, Nr_domu)"
                + " Values('" + TxbName.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "');"; // Treść zapytania
                command.ExecuteNonQuery(); // Wykonanie zapytania
                MessageBox.Show("Nowy Klient został utworzony");
                conn.Close(); // Zamyknięcie połączenia
            }
        }


    }
}
