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
    public partial class FrmHistoriaWypozyczen : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania

        public FrmHistoriaWypozyczen()
        {
            InitializeComponent();
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Wypozyczenia;", conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dtg_historia.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView 
        }
    }
}