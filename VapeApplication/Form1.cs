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
        DBVape dbVape;
        AddProductPanel addProductPanel;
        ListCart listCart;

        public Form1()
        {
            InitializeComponent();
            dbVape = DBVape.getDBVape();

            menuStrip1.Visible = false;
            showAutorizPanel();
            
        }

        private void showAutorizPanel()
        {
            panel1.Visible = false;
            AutorizPanel autorizPanel = new AutorizPanel(new Action(btnAutoriz_click));
            autorizPanel.Location = new Point((this.ClientSize.Width - autorizPanel.Width) / 2 - 55, 
                                   (this.ClientSize.Height - autorizPanel.Height) / 2 - 55);
            this.Controls.Add(autorizPanel);
        }

        private void btnAutoriz_click()
        {
            menuStrip1.Visible = true;
            panel1.Visible = true;
            listProducts = new ListProducts(panel1);
            addProductPanel = new AddProductPanel();
            panel1.Controls.Add(listProducts);

        }

        private void товырыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listProducts.update();
            panel1.Controls.Add(listProducts);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(addProductPanel);
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCart = new ListCart(panel1);
            panel1.Controls.Clear();
            panel1.Controls.Add(listCart);
        }
    }
}
