using CourseProject.Info;
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
    public partial class DeleteEvent : Form
    {
        private QueryEventInfo queryEventInfo;
        public DeleteEvent()
        {
            queryEventInfo = new QueryEventInfo();
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
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            if (selectedRow.Cells["event_id"].Value != null) {
                int eventId = int.Parse(selectedRow.Cells["event_id"].Value.ToString());
                int rowsAffected = queryEventInfo.DeleteEvent(eventId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запис видалено успішно.");
                    ScedulePage scedulePage = new ScedulePage();
                    scedulePage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Запис з вказаним ідентифікатором не знайдено.");
                }
            }
            else { MessageBox.Show("Ви обрали пустий рядок."); }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете перервати операцію видалення події?", "Скасування", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                ScedulePage scedulePage = new();
                scedulePage.Show();
            }
        }
    }
}
