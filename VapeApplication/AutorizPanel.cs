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

        public AutorizPanel(EventHandler eventHandler)
        {
            InitializeComponent();

            FlowDirection = FlowDirection.TopDown;
            AutoSize = true;
            Anchor = AnchorStyles.None;

            labelTitle = new Label()
            {
                Text = "Авторизация"
            };
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.AutoSize = false;
            labelTitle.TextAlign = ContentAlignment.TopCenter;

            login = new TextBox();
            login.Size = new Size(login.Size.Width * 2, login.Size.Height);


            password = new TextBox();
            password.Size = new Size(password.Size.Width * 2, password.Size.Height);
            password.PasswordChar = '*';
            btnAutorization = new Button()
            {
                Text = "Войти"
            };
            btnAutorization.Anchor = AnchorStyles.None;
            btnAutorization.Click += eventHandler;

            this.Controls.Add(labelTitle);
            this.Controls.Add(login);
            this.Controls.Add(password);
            this.Controls.Add(btnAutorization);
        }

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
    }
}
