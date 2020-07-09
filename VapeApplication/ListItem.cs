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
    public partial class ListItem : UserControl
    {
        Panel control;
        Action method;
        public ListItem(Panel control, Action method)
        {
            this.control = control;
            this.method = method;
            //textBoxDescription.ReadOnly = true;
            InitializeComponent();
        }


        private Product product;

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                pictureBox.Image = product.Image;
                labelName.Text = product.Name;
                textBoxDescription.Text = product.Description;
                if(product.Discount == 0)
                {
                    labelNewPrice.Visible = false;
                    labelPrice.Text = "ЦЕНА " + product.Price;
                } else
                {
                    labelPrice.Text = "ЦЕНА " + product.Price;
                    labelPrice.Font = new Font(labelPrice.Font, FontStyle.Strikeout);

                    labelNewPrice.Text = "Новая цена " + Math.Round(product.Price - product.Price * product.Discount * 0.01, 2).ToString();

                }
                labelQantity.Text = "В наличии " + product.Quantity.ToString();

            }
        }

        /*
        #region Propperties

        private String name;
        private String description;
        private float price;
        private int qantity;
        private Image image;

        [Category("Custom Props")]
        public String Name
        {
            get { return name; }
            set { name = value; labelName.Text = value; }
        }

        [Category("Custom Props")]
        public String Description
        {
            get { return description; }
            set { description = value; textBoxDescription.Text = value; }
        }

        [Category("Custom Props")]
        public float Price
        {
            get { return price; }
            set { price = value; labelPrice.Text = "ЦЕНА " + value.ToString(); }
        }

        [Category("Custom Props")]
        public int Qantity
        {
            get { return qantity; }
            set { qantity = value; labelQantity.Text = "В наличии " + value.ToString(); }
        }

        [Category("Custom Props")]
        public Image Image
        {
            get { return image; }
            set { image = value; pictureBox.Image = value; }
        }

        #endregion
        */

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AddProductPanel addProductPanel = new AddProductPanel(product, method);
            control.Controls.Clear();
            control.Controls.Add(addProductPanel);
        }

        private void buttonAddBasket_Click(object sender, EventArgs e)
        {
            Cart cart = Cart.getCart();
            cart.AddItem(product, Convert.ToInt32(textBoxCount.Text.ToString()));
        }
    }
}
