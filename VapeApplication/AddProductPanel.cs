using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Globalization;

namespace VapeApplication
{
    public partial class AddProductPanel : UserControl
    {
        DBVape dbVape;
        Product product = null;

        public AddProductPanel()
        {
            InitializeComponent();
            dbVape = DBVape.getDBVape();
            
            createCategotyBox();
            deleteBtn.Visible = false;
            labelPlus.Visible = false;
            addQuantityTB.Visible = false;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.InitialImage = new Bitmap(new FileStream(@"..\..\..\image\load_image.gif",
                                            FileMode.Open, FileAccess.Read));
            pictureBox.Image = new Bitmap(new FileStream(@"..\..\..\image\error_image.jpg",
                                            FileMode.Open, FileAccess.Read));
            
        }

        public AddProductPanel(Product product)
        {
            InitializeComponent();
            dbVape = DBVape.getDBVape();
            createCategotyBox();

            this.product = product;
            buttonAddProduct.Text = "Обновить";
            buttonAddProduct.Click += new EventHandler(updateProductHandler);
            buttonAddProduct.Click -= buttonAddProduct_Click;
            showProduct();
        }

        private void showProduct()
        {
            if (product == null)
            {
                MessageBox.Show("Упс, товар не найден");
                return;
            }

            nameTB.Text = product.Name;
            CategoryBox.SelectedValue = product.CategoryId;
            priceTB.Text = product.Price.ToString();
            discountTB.Text = (product.Discount * 100).ToString();
            quantityTB.Text = product.Quantity.ToString();
            pictureBox.Image = product.Image;
            descriptionTB.Text = product.Description;
        }

        // категории из бд берем
        private void createCategotyBox()
        {
            CategoryBox.DataSource = dbVape.getCategoryList();
            CategoryBox.DisplayMember = "name";
            CategoryBox.ValueMember = "id";
            CategoryBox.SelectedIndex = 0;
        }


        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        // фоточку добавляем
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    pictureBox.Image = new Bitmap(open_dialog.FileName);
                    pictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // заливаем продукт в бд
        private void buttonAddProduct_Click(object sender, EventArgs e) // 
        {
             if (!checking_for_data_correctness())
                 return;

             Product newProduct = new Product(0, nameTB.Text, (int)CategoryBox.SelectedValue, int.Parse(this.quantityTB.Text)
                                                 , float.Parse(this.priceTB.Text, CultureInfo.InvariantCulture.NumberFormat)
                                                 , int.Parse(this.discountTB.Text) / 100f, descriptionTB.Text, pictureBox.Image);

             if (dbVape.addProduct(newProduct))
                 MessageBox.Show("Добавленно");
             else
                 MessageBox.Show("ERROR!!!");
             clearInput();
            //int id = (int)CategoryBox.SelectedValue;
            //MessageBox.Show(id.ToString());
        }

        private void updateProductHandler(object sender, EventArgs e)
        {
            if (!checking_for_data_correctness())
                return;

            int addQuantity = 0;

            if (addQuantityTB.TextLength > 0)
                addQuantity = int.Parse(this.addQuantityTB.Text);

            product.CategoryId = (int)CategoryBox.SelectedValue;
            product.Name = nameTB.Text;
            product.Price = float.Parse(this.priceTB.Text, CultureInfo.InvariantCulture.NumberFormat);
            product.Discount = int.Parse(this.discountTB.Text) / 100f;
            product.Description = descriptionTB.Text;
            product.Quantity = int.Parse(this.quantityTB.Text) + addQuantity;
            product.Image = pictureBox.Image;

            if (dbVape.updateProduct(product))
            {
                MessageBox.Show("Обновленно");
            }
            else
                MessageBox.Show("ERROR!!!");
            quantityTB.Text = product.Quantity.ToString();
            addQuantityTB.Clear();
        }

        // очищаем все свои старые вводы
        private void clearInput()
        {
            nameTB.Clear();
            priceTB.Clear();
            discountTB.Clear();
            quantityTB.Clear();
            descriptionTB.Clear();
            pictureBox.Image = new Bitmap(new FileStream(@"..\..\..\image\error_image.jpg",
                                            FileMode.Open, FileAccess.Read));
        }

        private bool checking_for_data_correctness()
        {
            if (nameTB.TextLength <= 0)
            {
                MessageBox.Show("Недопустимое название для товара");
                return false;
            }
               

            try
            {
                priceTB.Text = priceTB.Text.Replace(",", ".");
                float price = float.Parse(this.priceTB.Text.Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat);
                if (price < 0)
                {
                    MessageBox.Show("В строке стоимости введено не коректное значение");
                    return false;
                }
            }
            catch { MessageBox.Show("В строке стоимости введено не коректное значение"); return false; }

            try
            {
                float discount = int.Parse(this.discountTB.Text);
                if (discount < 0 || discount > 100)
                {
                    MessageBox.Show("В строке скидка введено не коректное значение");
                    return false;
                }
            }
            catch { MessageBox.Show("В строке скидка введено не коректное значение"); return false; }

            try
            {
                int quantity = int.Parse(this.quantityTB.Text);
                if (quantity < 0)
                {
                    MessageBox.Show("В строке количество введено не коректное значение");
                    return false;
                }
            }
            catch { MessageBox.Show("В строке количество введено не коректное значение"); return false; }

            if(addQuantityTB.Visible == true && addQuantityTB.TextLength > 0)
            {
                try
                {
                    int addQuantity = int.Parse(this.addQuantityTB.Text);
                }
                catch { MessageBox.Show("В строке количество введено не коректное значение"); return false; }
            }

            return true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dbVape.deleteProduct(product))
            {
                MessageBox.Show("Удалено");
                // TODO: Переход на какую то другую панель, так как продукт удален
                this.Dispose();
            }
            else
                MessageBox.Show("ERROR!!!");
        }
    }
}
