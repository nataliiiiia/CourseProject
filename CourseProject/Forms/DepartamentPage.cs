using CourseProject.UserInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.Models;
using CourseProject.Services;
using CourseProject.Info;
using System.Collections;

namespace CourseProject.Forms
{
    public partial class DepartamentPage : Form
    {
        private readonly string ConnectionString;
        private readonly DepartmentModel department;
        private QueryDepartmentInfo departmentInfo;
        private readonly Dictionary<int, ProfessorModel> professors;
        public DepartamentPage()
        {
            InitializeComponent();
            ConnectionString = DepartmantConnectionString.connectionString;
            departmentInfo = new();
            department = departmentInfo.GetDepartmentById(DepartmentInfo.DepartmentId);
            professors = departmentInfo.GetProffesors(DepartmentInfo.DepartmentId);
            LoadLabels();
            FillProfessors();

        }
        private void LoadLabels()
        {
            depName.Text = department.Name;
            descriptionText.Text = department.Description;
            chiefName.Text = department.Chief;
            contact.Text = department.Contact;

            if (User.Role != null)
            {
                roleLabel.Text = $"Вітаю, {User.UName}";
                roleLabel.Visible = true;
                reviews.Visible = true;
                if (User.Role == "Admin") { editButton.Visible = true; }
                else { editButton.Visible = false; }
            }
            else
            {
                reviews.Visible = false;
                roleLabel.Visible = false;
                editButton.Visible = false;
            }
        }
        private void FillProfessors()
        {
            Dictionary<int, string> prof = new();
            foreach (var p in professors)
            {
                string fullName = p.Value.Surname + " " + p.Value.Name + " " + p.Value.Patronymic;
                prof.Add(p.Key, fullName);
            }
            prof = prof.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            listOfProfessors.DataSource = new BindingSource(prof, null);
            listOfProfessors.DisplayMember = "Value";
            listOfProfessors.ValueMember = "Key";
        }
        private void GoToMainPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            MainPage mainPage = new();
            mainPage.ShowDialog();
        }

        private void GoToProfessorPage(object sender, EventArgs e)
        {
            DepartmentInfo.ProfessorId = int.Parse(listOfProfessors.SelectedValue.ToString());
            ProfessorPage professorPage = new();
            professorPage.Show();
            this.Close();
        }

        private void GoToWorkingPlan(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScedulePage sceduleInfo = new ScedulePage();
            sceduleInfo.Show();
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            chiefName.ReadOnly = false;
            chiefName.BackColor = Color.White;
            chiefName.BorderStyle = BorderStyle.FixedSingle;
            contact.ReadOnly = false;
            contact.BackColor = Color.White;
            contact.BorderStyle = BorderStyle.FixedSingle;
            descriptionText.ReadOnly = false;
            descriptionText.BackColor = Color.White;
            CreateButtons();
        }
        private void CreateButtons()
        {
            Button saveButton = new()
            {
                BackColor = Color.Linen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(485, 356),
                Size = new Size(133, 37),
                TabIndex = 21,
                Text = "Зберегти",
                UseVisualStyleBackColor = false
            };
            Controls.Add(saveButton);
            saveButton.Click += SaveChanges;
            Button cancelButton = new()
            {
                BackColor = Color.Linen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(630, 356),
                Size = new Size(133, 37),
                TabIndex = 21,
                Text = "Відмінити",
                UseVisualStyleBackColor = false
            };
            Controls.Add(cancelButton);
            cancelButton.Click += CancelChanges;
        }
        private void CancelChanges(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете скасувати внесені зміни?", "Скасування", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                DepartamentPage departamentPage = new();
                departamentPage.Show();
            }
        }
        private void SaveChanges(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете зберегти зміни?", "Збереження", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DepartmentModel model = new DepartmentModel();
                model.Id = DepartmentInfo.DepartmentId;
                model.Chief = chiefName.Text;
                model.Contact = contact.Text;
                model.Description = descriptionText.Text;
                departmentInfo.AlterDepartmentInfo(model);
                this.Close();
                DepartamentPage departamentPage = new();
                departamentPage.Show();
            }
        }

        private void GetReviews(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllReviewsPage allReviewsPage = new AllReviewsPage();
            allReviewsPage.Show();
            this.Close();
        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
