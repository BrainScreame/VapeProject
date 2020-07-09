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
        int selectId = 0;
        int startPos = 0;
        int count = 5;
        int countProducts = 0;

        public ListProducts()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dBVape = DBVape.getDBVape();
            createCategotyBox();
        }

        private void populateItems()
        {
            List<ListItem> listItems = new List<ListItem>();

            for (int i = 0; i < products.Count; i++)
            {
                listItems.Add(new ListItem());
                listItems[i].Product = products[i];
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startPos += count;
            products = dBVape.getProdycts(selectId, startPos, count);
            flowLayoutPanel1.Controls.Clear();
            populateItems();
            if(startPos + count >= countProducts)
            {
                button3.Visible = false;
            }
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startPos -= count;
            products = dBVape.getProdycts(selectId, startPos, count);
            flowLayoutPanel1.Controls.Clear();
            populateItems();
            if (startPos == 0)
            {
                button2.Visible = false;
            }
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startPos = 0;
            countProducts = dBVape.getCountProdycts(selectId, "%" + textBox1.Text.ToString() + "%");
            products = dBVape.getProdycts(selectId, "%"+textBox1.Text.ToString()+"%");
            flowLayoutPanel1.Controls.Clear();
            populateItems();
            button2.Visible = false;
            if (countProducts <= count)
            {
                button3.Visible = false;
            }
            else
            {
                button3.Visible = true;

            }
        }

        private void createCategotyBox()
        {
            // Получаем список категорий и указываем CategoryBox на источник данных
            CategoryBox.DataSource = dBVape.getCategory();
            // указываем что выводить в CategoryBox нужно название категории (name)
            CategoryBox.DisplayMember = "name";
            // указываем что принимать за значение в CategoryBox нужно поле id
            CategoryBox.ValueMember = "id";
            // по дефолту выбираем первый элемент
            CategoryBox.SelectedIndex = 0;
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectId = (int)CategoryBox.SelectedValue;
            }
            catch
            {
                selectId = 0;
            }
            startPos = 0;
            countProducts = dBVape.getCountProdycts(selectId);
            products = dBVape.getProdycts(selectId, startPos, count);
            flowLayoutPanel1.Controls.Clear();
            populateItems();
            button2.Visible = false;
            if (countProducts <= count)
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
