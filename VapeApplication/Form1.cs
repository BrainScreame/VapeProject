using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBVape dBVape = new DBVape();
            dBVape.openConnection();

            DataTable tableCategory = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `category`");
            command.Connection = dBVape.GetConnection();

            adapter.SelectCommand = command;
            adapter.Fill(tableCategory);

            dataGridView1.DataSource = tableCategory;


            dBVape.closeConnection();
        }

    }
}
