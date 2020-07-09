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

        AddProductPanel addProductPanel;

        public Form1()
        {
            InitializeComponent();
            dbVape = DBVape.getDBVape();

            showAutorizPanel();
            
        }

        private void showAutorizPanel()
        {
            autorizPanel = new AutorizPanel(new Action(btnAutoriz_click));
            autorizPanel.Location = new Point((this.ClientSize.Width - autorizPanel.Width) / 2 - 55, 
                                   (this.ClientSize.Height - autorizPanel.Height) / 2 - 55);
            this.Controls.Add(autorizPanel);
        }


        private void btnAutoriz_click()
        {
                this.Controls.RemoveAt(0);
                autorizPanel.Dispose();

                Seller sel = Seller.getSeller();

                //Для проверки удаления, следи за id. Если будет не корректный то ничего не удалится
                //Product product = new Product(7, "name", 2, 100, 100f, 0.5f, "desc", null);
                //addProductPanel = new AddProductPanel(product, new Action(() => { MessageBox.Show("Работает"); }));

                addProductPanel = new AddProductPanel();
                this.Controls.Add(addProductPanel);

        
        private void showListProducts()
        {
            listProducts = new ListProducts();
            listProducts.Location =
            new Point(0,
                    30);

            this.Controls.Add(listProducts);
        }

        }
    }
}
