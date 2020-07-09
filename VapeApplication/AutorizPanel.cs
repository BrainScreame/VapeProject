using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeApplication
{
    public partial class AutorizPanel : FlowLayoutPanel
    {
        private Label labelTitle;
        private TextBox login;
        private TextBox password;
        private Button btnAutorization;
        private Action method;

        public String Login
        {
            get
            { return login.Text; }
        }

        public String Password
        {
            get
            { return password.Text; }
        }

        public AutorizPanel(Action method)
        {
            InitializeComponent();

            this.method = method;

            BorderStyle = BorderStyle.Fixed3D;
            FlowDirection = FlowDirection.TopDown;
            AutoSize = true;
            Anchor = AnchorStyles.None;

            labelTitle = new Label()
            {
                Text = "Авторизация"
            };
            labelTitle.Font = new Font(labelTitle.Font.Name, 14, labelTitle.Font.Style);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.AutoSize = false;
            labelTitle.TextAlign = ContentAlignment.TopCenter;

            login = new TextBox();
            login.Size = new Size(300, login.Size.Height);
            login.Font = new Font(login.Font.Name, 14, login.Font.Style);


            password = new TextBox();
            password.Size = new Size(300, password.Size.Height);
            password.PasswordChar = '*';
            password.Font = new Font(password.Font.Name, 14, password.Font.Style);

            btnAutorization = new Button()
            {
                Text = "Войти"
            };
            btnAutorization.Font = new Font(btnAutorization.Font.Name, 14, btnAutorization.Font.Style);
            btnAutorization.Anchor = AnchorStyles.None;
            btnAutorization.Click += btnAutoriz_click;
            btnAutorization.Padding = new Padding(15, 10, 15, 10);
            btnAutorization.AutoSize = true;


            this.Controls.Add(labelTitle);
            this.Controls.Add(login);
            this.Controls.Add(password);
            this.Controls.Add(btnAutorization);
        }

        private void btnAutoriz_click(object sender, EventArgs e)
        {
            DBVape dbVape = DBVape.getDBVape();
            if (dbVape == null)
            {
                MessageBox.Show("Ошибка работы с БД");
                return;
            }

            dbVape.getSaller(Login, Password);
            if (Seller.getSeller() != null)
            {
                method();
            }
            else
                MessageBox.Show("Пользователь не найден");
        }
    }
}
