using CourseProject.Info;
using CourseProject.Models;
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
    public partial class ScedulePage : Form
    {
        private readonly SceduleModel scedule;
        private readonly DepartmentModel departmentModel;
        public ScedulePage()
        {
            InitializeComponent();
            GetSceduleInfo getSceduleInfo = new();
            QueryDepartmentInfo getDepartmentInfo = new();
            scedule = getSceduleInfo.GetScedule();
            departmentModel = getDepartmentInfo.GetDepartmentById(DepartmentInfo.DepartmentId);
            FillGrid();
            LoadLabels();
        }
        private void FillGrid()
        {
            using SqlConnection connection = new SqlConnection(DepartmantConnectionString.connectionString);
            SqlCommand command = new SqlCommand("GetSceduleData", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SceduleId", scedule.Id);

            SqlDataAdapter adapter = new(command);

            DataSet ds = new();
            adapter.Fill(ds);
            var data = ds.Tables[0];
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 190;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 47;
            dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            List<int> heights = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string text = row.Cells[3].Value.ToString();
                    text = text.Replace("#", "\n");
                    row.Cells[3].Value = text;
                    heights.Add(5 + (int)dataGridView1.Font.GetHeight() * text.Split('\n').Length);
                }
            }
            dataGridView1.RowTemplate.Height = heights.Max();
            
        }

        private void LoadLabels()
        {
            label1.Text = scedule.Name;
            linkLabel1.Text = departmentModel.Name;
            if (User.Role != null)
            {
                roleLabel.Text = $"Вітаю, {User.UName}";
                roleLabel.Visible = true;
                if (User.Role == "Admin") 
                { 
                    addEventButton.Visible = true; 
                    button1.Visible = true; 
                }
            }
            else
            {
                addEventButton.Visible = false; 
                button1.Visible = false;
                roleLabel.Visible = false;
            }
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

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEventPage addEventPage = new();
            addEventPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();
            deleteEvent.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseEvent updateEvent = new ChooseEvent();
            this.Close();
            updateEvent.Show();
        }
    }
}
