using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeApplication
{
    public partial class ListCart : UserControl
    {
        Cart cart;
        Panel panel;
        public ListCart(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            cart = Cart.getCart();
            populateItems();
        }

        public void populateItems()
        {
            List<ListItem> listItems = new List<ListItem>();

            for (int i = 0; i < cart.Lines.Count; i++)
            {
                listItems.Add(new ListItem(panel, showListProductAndUpdateList, 1));
                listItems[i].Product = cart.Lines[i].Product;
                listItems[i].CountCart = cart.Lines[i].Quantity;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
            labelSum.Text = "Общая стоимось " + Math.Round(cart.ComputeTotalValue(), 2).ToString();
        }

        private void showListProductAndUpdateList()
        {
            flowLayoutPanel1.Controls.Clear();
            populateItems();
            panel.Controls.Add(this);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            cart.Lines.Clear();
            labelSum.Text = "Общая стоимось 0";
            flowLayoutPanel1.Controls.Clear();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (DBVape.getDBVape().addOrder())
            {
                MessageBox.Show("Заказ оформлен");
                clearAll();
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }
        }
    }
}
