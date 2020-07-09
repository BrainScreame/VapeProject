using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeApplication
{
    public class Product
    {
        private int id;
        private String name;
        private int categoryId;
        private int quantity;
        private float price;
        private float discount;
        private String description;
        private Image image;

        public Product(int id, String name, int categoryId, int quantity, float price, float discount, String description, Image image)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
            this.quantity = quantity;
            this.price = price;
            this.discount = discount;
            this.description = description;
            this.image = image;
        }

        public int Id
        {
            get { return id; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public String Description
        {

            get { return description; }
            set { description = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}