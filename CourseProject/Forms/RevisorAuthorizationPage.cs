using CourseProject.AuthServices;
using CourseProject.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseProject.Forms
{
    public partial class RevisorAuthorizationPage : Form
    {
        private readonly string connection;
        private string username;
        private string password;
        public RevisorAuthorizationPage(string connectionString)
        {
            InitializeComponent();
            this.connection = connectionString;
            this.username = "";
            this.password = "";
        }

        private void MainPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainPage mainPage = new();
            mainPage.ShowDialog();
        }

        private void AdminLogInButton_Click(object sender, EventArgs e)
        {
            username = revisorLog.Text;
            password = revisorPassword.Text;
            RevisorLogIn revisorLogIn = new(username, password, connection);
            bool res = revisorLogIn.TryLogIn();
            if (res)
            {
                User.Role = "Revisor";
                User.UName = username;
                this.Close();
                MainPage mainPage = new();
                mainPage.ShowDialog();
            }

            else { MessageBox.Show("Введено неправильний логін чи пароль. Спробуйте ще.\nЯкщо ви вважаєте, що сталася помилка, зверніться до адміністрації сервісу."); }
        }

        private void AdminAuthLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            AdminAuthorization adminAuth = new();
            adminAuth.Show();
        }

       
    }
}
