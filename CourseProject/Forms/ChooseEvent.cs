using CourseProject.Info;
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
    public partial class ChooseEvent : Form
    {
        public ChooseEvent()
        {
            InitializeComponent();
            FillGrid();
        }
        private void FillGrid()
        {
            using SqlConnection connection = new SqlConnection(DepartmantConnectionString.connectionString);
            SqlCommand command = new SqlCommand("select event_id, event_name from Event where scedule_id = @SceduleId", connection);
            command.Parameters.AddWithValue("@SceduleId", DepartmentInfo.SceduleId);

            SqlDataAdapter adapter = new(command);

            DataSet ds = new();
            adapter.Fill(ds);
            var data = ds.Tables[0];
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 423;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["event_id"].Value != null)
                {
                    int eventId = int.Parse(selectedRow.Cells["event_id"].Value.ToString());
                    EventPage event_Page = new EventPage(eventId);
                    event_Page.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Оберіть рядок, будь ласка.");
            }
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти?", "Вихід", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                ScedulePage scedulePage = new();
                scedulePage.Show();
            }
        }
    }
}
