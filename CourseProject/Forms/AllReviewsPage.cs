using CourseProject.Info;
using CourseProject.Models;
using CourseProject.Repository;
using CourseProject.Services;
using CourseProject.UserInfo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AllReviewsPage : Form
    {
        private readonly DepartmentModel departmentModel;
        public AllReviewsPage()
        {
            InitializeComponent();
            QueryDepartmentInfo getDepartmentInfo = new();
            departmentModel = getDepartmentInfo.GetDepartmentById(DepartmentInfo.DepartmentId);
            FillGrid();
            LoadLabels();
        }
        private void LoadLabels()
        {
            linkLabel1.Text = departmentModel.Name;
            if (User.Role != null)
            {
                roleLabel.Text = $"Вітаю, {User.UName}";
                roleLabel.Visible = true;
            }
            else
            {
                roleLabel.Visible = false;
            }
        }
        private void FillGrid()
        {
            using SqlConnection connection = new SqlConnection(DepartmantConnectionString.connectionString);
            SqlCommand command = new SqlCommand("GetReviewsByDepartment", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DepId", DepartmentInfo.DepartmentId);
            SqlDataAdapter adapter = new(command);
            DataSet ds = new();
            adapter.Fill(ds);
            var data = ds.Tables[0];
            
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 647;
            dataGridView1.Columns[2].Width = 150;

        }
        private void GoToMainPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage mainPage = new();
            this.Close();
            mainPage.Show();
        }

        private void GoToDepartmentPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartamentPage departamentPage = new DepartamentPage();
            departamentPage.Show();
            this.Close();
        }
    }
}
