using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace VapeApplication
{
    public class Cart
    {
        private static Cart cart;
        private List<CartLine> lineCollection;

        private Cart() {
            lineCollection = new List<CartLine>();
        }

        public static Cart getCart()
        {
            if (cart == null)
            {
                cart = new Cart();
            }
            return cart;
        }

        public List<CartLine> Lines { get { return lineCollection; } }

        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(b => b.Product.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                if (product.Quantity >= quantity)
                {
                    lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
                }
                else
                {
                    System.Windows.MessageBox.Show("Такого количества нет в наличии");
                }
            }
            else
            {
                if (product.Quantity >= quantity + line.Quantity)
                {
                    line.Quantity += quantity;
                }
                else
                {
                    System.Windows.MessageBox.Show("Такого количества нет в наличии");
                }
            }
        }

        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.Id == product.Id);
        }


        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => (decimal)(e.Product.Price - e.Product.Price * e.Product.Discount * 0.01) * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
