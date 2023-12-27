using CourseProject.Models;
using CourseProject.Info;
using CourseProject.Services;
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

namespace CourseProject.Forms
{
    public partial class ProfessorPage : Form
    {
        private readonly ProfessorModel professorModel;
        private readonly DepartmentModel departmentModel;
        private readonly int professorId;
        public ProfessorPage()
        {
            InitializeComponent();
            professorId = DepartmentInfo.ProfessorId;
            QueryDepartmentInfo getDepartmentInfo = new ();
            GetProfessorsInfo getProfessorsInfo = new(professorId);
            departmentModel = getDepartmentInfo.GetDepartmentById(DepartmentInfo.DepartmentId);
            professorModel = getProfessorsInfo.GetInfo();
            LoadLabels();
            CreateDynamicControls();
        }
        private void LoadLabels()
        {
            professorName.Text = professorModel.Surname + " " + professorModel.Name + " " + professorModel.Patronymic;
            contact.Text = professorModel.Contact;
            position.Text = professorModel.Position;
            linkLabel1.Text = departmentModel.Name;
            if (professorModel.Handlership)
            {
                handlership.Text = "Наявне";
            }
            else { handlership.Text = "Відсутнє"; }
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
        private void OpenMainPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            MainPage mainPage = new();
            mainPage.ShowDialog();
        }

        private void OpenDepartmentPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartamentPage departamentPage = new ();
            departamentPage.Show();
            this.Close();
        }
        private void CreateDynamicControls()
        {
            var dict = professorModel.Events;
            int topMargin = 100;

            foreach (var e in dict)
            {
                LinkLabel label = new()
                {
                    Text = e.Value,
                    Location = new System.Drawing.Point(340, topMargin),
                    AutoSize = false,
                    Width = 360, 
                    Height = 60,
                    Tag = e.Key,
                    LinkColor = Color.FromArgb(105, 51, 7)
                };
                label.Click += LinkLabel_Click;
                Controls.Add(label);
                topMargin += label.Height + 7;
            }
        }
        private void LinkLabel_Click(object? sender, EventArgs e)
        {
            int evnt = (int)((LinkLabel)sender).Tag;
            EventPage event_Page = new EventPage(evnt);
            event_Page.Show();
            this.Close();
        }

       
    }
}
