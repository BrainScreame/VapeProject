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
    public partial class ListProducts : UserControl
    {
        DBVape dBVape;
        List<Product> products;
        int selectId = 1;
        int startPos = 0;
        int count = 2;

        public ListProducts()
        {
            InitializeComponent();
            dBVape = DBVape.getDBVape();
            createCategotyBox();

            products = dBVape.getProdycts(selectId, startPos, count);
            button2.Visible = false;
            if(buttonVisible())
            {
                button3.Visible = false;
            }

            populateItems();
        }

        private void populateItems()
        {
            List<ListItem> listItems = new List<ListItem>();

            for (int i = 0; i < products.Count; i++)
            {
                listItems.Add(new ListItem());
                listItems[i].Image = products[i].Image;
                listItems[i].Name = products[i].Name;
                listItems[i].Description = products[i].Description;
                listItems[i].Price = products[i].Price;
                listItems[i].Qantity = products[i].Quantitye;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }


        private bool buttonVisible()
        {
            return products.Count < count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            startPos += count;
            products = dBVape.getProdycts(selectId, startPos, count);
            populateItems();
            if (buttonVisible())
            {
                button3.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            startPos -= count;
            products = dBVape.getProdycts(selectId, startPos, count);
            populateItems();
            if(startPos == 0)
            {
                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products = dBVape.getProdycts(selectId, "%"+textBox1.Text.ToString()+"%");
            flowLayoutPanel1.Controls.Clear();
            populateItems();
        }

        private void createCategotyBox()
        {
            // Получаем список категорий и указываем CategoryBox на источник данных
            CategoryBox.DataSource = dBVape.getCategory();
            // указываем что выводить в CategoryBox нужно название категории (name)
            CategoryBox.DisplayMember = "Name";
            // указываем что принимать за значение в CategoryBox нужно поле id
            CategoryBox.ValueMember = "Id";
            // по дефолту выбираем первый элемент
            //CategoryBox.SelectedIndex = 0;
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //selectId = int.Parse(CategoryBox.SelectedValue.ToString());
            products = dBVape.getProdycts(selectId, startPos, count);
            flowLayoutPanel1.Controls.Clear();
            populateItems();
            if (buttonVisible())
            {
                button3.Visible = false;
            }
            else
            {
                button3.Visible = true;
            }
        }
    }
}
