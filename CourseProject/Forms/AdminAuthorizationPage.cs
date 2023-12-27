using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.AuthServices;
using CourseProject.Forms;
using CourseProject.Info;
using CourseProject.Info;

namespace CourseProject
{
    public partial class AdminAuthorization : Form
    {
        private readonly string connection;
        private string username;
        private string password;
        public AdminAuthorization()
        {
            InitializeComponent();
            this.connection = AuthConnectionString.connectionString;
            this.username = "";
            this.password = "";
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            MainPage mainPage = new();
            mainPage.ShowDialog();
        }

        private void AdminLogInButton_Click(object sender, EventArgs e)
        {
            username = adminLog.Text;
            password = adminPassword.Text;
            AdminLogIn adminLogIn = new(username, password, connection);
            bool res = adminLogIn.TryLogIn();
            if (res)
            {
                User.Role = "Admin";
                User.UName = username;
                this.Close();
                MainPage mainPage = new();
                mainPage.ShowDialog();
            }

            else
            { MessageBox.Show("Введено неправильний логін чи пароль. Спробуйте ще.\nЯкщо ви вважаєте, що сталася помилка, зверніться до адміністрації сервісу."); }
        }

        private void RevisorAuthLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            RevisorAuthorizationPage revisorAuth = new(connection);
            revisorAuth.Show();
        }

        private void AdminLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
