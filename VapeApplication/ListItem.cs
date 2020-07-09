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
        public ListItem()
        {
            InitializeComponent();
        }

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
    }
}
