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
        CategityList categityList;

        public AddProductPanel()
        {
            InitializeComponent();
            dbVape = DBVape.getDBVape();
            
            createCategotyBox();
            this.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.InitialImage = new Bitmap(new FileStream(@"..\..\..\image\load_image.gif",
                                            FileMode.Open, FileAccess.Read));
            pictureBox.Image = new Bitmap(new FileStream(@"..\..\..\image\error_image.jpg",
                                            FileMode.Open, FileAccess.Read));
            
        }

        // категории из бд берем
        private void createCategotyBox()
        {
            categityList = dbVape.getCategityList();
            foreach (string name in categityList.name)
            {
                CategityBox.Items.Add(name);
            }
            CategityBox.SelectedIndex = 0;
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
                    //ImageConverter converter = new ImageConverter();
                    //byteImage = (byte[])converter.ConvertTo(image, typeof(byte[]));
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
            int c = categityList.id[CategityBox.SelectedIndex];
            string stringName = name.Text;
            float p = float.Parse(price.Text, CultureInfo.InvariantCulture.NumberFormat);
            if (p < 0)
            {
                MessageBox.Show("В строке стоимости введено не коректное значение");
                return;
            }
            float dis = int.Parse(discount.Text);
            if (dis < 0 || dis > 100)
            {
                MessageBox.Show("В строке скидка введено не коректное значение");
                return;
            }
            dis /= 100f;

            int q = int.Parse(quantity.Text);
            if (q < 0)
            {
                MessageBox.Show("В строке количество введено не коректное значение");
                return;
            }

            if(dbVape.addProduct(stringName, p, dis, q, c, pictureBox.Image, description.Text))
                MessageBox.Show("Добавленно");
            else
                MessageBox.Show("ERROR!!!");
            clearInput();
        }

        // очищаем все свои старые вводы
        private void clearInput()
        {
            name.Clear();
            price.Clear();
            discount.Clear();
            quantity.Clear();
            description.Clear();
            pictureBox.Image = new Bitmap(new FileStream(@"..\..\..\image\error_image.jpg",
                                            FileMode.Open, FileAccess.Read));
        }
    }
}
