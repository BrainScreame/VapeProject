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
        ListProducts listProducts;
        AutorizPanel autorizPanel;
        DBVape dbVape;

        public Form1()
        {
            InitializeComponent();
            dbVape = DBVape.getDBVape();
            //showAutorizPanel();
            showListProducts();
        }

        private void showAutorizPanel()
        {
            autorizPanel = new AutorizPanel(new EventHandler(btnAutoriz_click));
            autorizPanel.Location =
            new Point(ClientSize.Width / 2 - autorizPanel.Size.Width / 2,
                    ClientSize.Height / 2 - autorizPanel.Size.Height / 2);

            this.Controls.Add(autorizPanel);
        }

        private void showListProducts()
        {
            listProducts = new ListProducts();
            listProducts.Location =
            new Point(0,
                    30);

            this.Controls.Add(listProducts);
        }

        private void btnAutoriz_click(object sender, System.EventArgs e)
        {
            if (dbVape == null)
            {
                MessageBox.Show("Ошибка работы с БД");
                return;
            }
            if (dbVape.getSaller(autorizPanel.Login, autorizPanel.Password) > 0)
            {
                this.Controls.Remove(autorizPanel);
                showListProducts();
            }
            else
                MessageBox.Show("false");
            //this.Controls.Remove(autorizPanel);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
