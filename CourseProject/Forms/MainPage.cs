using CourseProject.Forms;
using CourseProject.Info;
using CourseProject.Services;
using CourseProject.UserInfo;
using Microsoft.Data.SqlClient;

namespace CourseProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            //User.Role = "Admin";
            GetConnections();
            LoadLabels();
            CreateDynamicControls();
        }
        
        private void LoadLabels()
        {
            reviewButton.Visible = false;
            
            if (User.Role != null)
            {
                roleLabel.Text = $"Вітаю, {User.UName}";
                roleLabel.Visible = true;
                authLink.Visible = false;
                logOutLinkLabel.Visible = true;
                if (User.Role == "Revisor")
                {
                    reviewButton.Visible = true;
                }
            }
            else
            {
                roleLabel.Visible = false;
                logOutLinkLabel.Visible = false;
                authLink.Visible = true;
            }
        }
        private void AuthLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminAuthorization authorization = new();
            authorization.Show();
            this.Hide();
        }
        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти з акаунту?", "Вихід", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                User.Role = null;
                this.Close();
                MainPage mainPage = new();
                mainPage.Show();
            }
        }
        private void CreateDynamicControls()
        {
            QueryDepartmentInfo departament = new();
            Dictionary<int, string> deps = departament.GetDepartaments();
            int topMargin = 230;

            foreach (var department in deps)
            {
                LinkLabel label = new()
                {
                    Text = department.Value,
                    Location = new System.Drawing.Point(50, topMargin),
                    AutoSize = true,
                    Tag = department.Key,
                    LinkColor = Color.FromArgb(105, 51, 7)
                };
                label.Click += LinkLabel_Click;
                Controls.Add(label);
                topMargin += label.Height + 10;
            }
        }

        private void LinkLabel_Click(object? sender, EventArgs e)
        {
            DepartmentInfo.DepartmentId = (int)((LinkLabel)sender).Tag;
            DepartamentPage departamentPage = new();
            departamentPage.Show();
            this.Hide();
        }


        private void ReviewButton_Click(object sender, EventArgs e)
        {
            ReviewPage reviewPage = new ReviewPage();
            reviewPage.Show();
            this.Hide();
        }
        private static void GetConnections()
        {
            SqlConnectionStringBuilder authConnectionStringBuilder = new()
            {
                ["Data Source"] = @".\SQLEXPRESS",
                ["Initial Catalog"] = "Authorisation",
                ["TrustServerCertificate"] = true,
                ["Integrated Security"] = true
            };
            SqlConnectionStringBuilder departamentsConnectionStringBuilder = new()
            {
                ["Data Source"] = @".\SQLEXPRESS",
                ["Initial Catalog"] = "Study_Departament",
                ["TrustServerCertificate"] = true,
                ["Integrated Security"] = true
            };
            AuthConnectionString.connectionString = authConnectionStringBuilder.ConnectionString;
            DepartmantConnectionString.connectionString = departamentsConnectionStringBuilder.ConnectionString;
        }
    }
}
