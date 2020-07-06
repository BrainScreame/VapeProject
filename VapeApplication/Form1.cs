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
            autorizPanel = new AutorizPanel(new EventHandler(btnAutoriz_click));
            autorizPanel.Location = new Point((this.ClientSize.Width - autorizPanel.Width) / 2 - 55, 
                                    (this.ClientSize.Height - autorizPanel.Height) / 2 - 55);
            this.Controls.Add(autorizPanel);
        }

        private void btnAutoriz_click(object sender, System.EventArgs e)
        {
            if(dbVape == null) {
                MessageBox.Show("Ошибка работы с БД");
                return; 
            }
            if (dbVape.getSaller(autorizPanel.Login, autorizPanel.Password) > 0)
            {
                this.Controls.Remove(autorizPanel);
                addProductPanel = new AddProductPanel();
                this.Controls.Add(addProductPanel);
            }
            else
                MessageBox.Show("Пользователь не найден");
        }

        
    }
}
