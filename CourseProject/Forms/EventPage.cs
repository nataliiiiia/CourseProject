using CourseProject.Models;
using CourseProject.Info;
using CourseProject.Repository;
using CourseProject.Services;
using CourseProject.UserInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class EventPage : Form
    {
        private readonly int _id;
        private readonly EventModel EventModel;
        private readonly SectionModel SectionModel;
        private readonly DepartmentModel DepartmentModel;
        private readonly Dictionary<int, SectionModel> sections;
        QueryEventInfo eventInfo;

        public EventPage(int event_id)
        {
            _id = event_id;
            InitializeComponent();
            eventInfo = new();
            GetSectionInfo getSectionInfo = new();
            QueryDepartmentInfo getDepartmentInfo = new();
            EventModel = eventInfo.GetEventById(event_id);
            SectionModel = getSectionInfo.GetSection(EventModel.SectionId);
            sections = getSectionInfo.GetAllSections();
            DepartmentModel = getDepartmentInfo.GetDepartmentById(DepartmentInfo.DepartmentId);
            LoadLabels();

        }
        private void LoadLabels()
        {
            eventName.Text = EventModel.Name;
            if (EventModel.Description != "") { descriptionBox.Text = EventModel.Description; }
            else { descriptionBox.Text = "Опис відсутній."; }
            
            if (EventModel.Status != "") 
            { 
                if(bool.Parse(EventModel.Status) == true)
                {
                    statusBox.Text = "Виконано";
                }
                else { statusBox.Text = "Не виконано"; }
                 
            }
            else 
            { 
                statusBox.Text = "Статус відсутній."; 
            }
           
            if (EventModel.Result != "") 
            { 
                resultBox.Text = EventModel.Result; 
            }
            else 
            { 
                resultBox.Text = "Очікуваний результат відсутній."; 
            }
            dueBox.Text = EventModel.Date.ToString();
            sectionBox.Text = SectionModel.Name;
            sectionBox.MouseEnter += SectionBoxMouseEnter;
            sectionCombo.Visible = false;
            dateTimePicker1.Visible = false;
            editButton.Visible = false;
            statusCombo.Visible = false;
            linkLabel1.Text = DepartmentModel.Name;
            if (User.Role != null)
            {
                if(User.Role == "Admin") { editButton.Visible = true; }
                roleLabel.Text = $"Вітаю, {User.UName}";
                roleLabel.Visible = true;
            }
            else
            {
                roleLabel.Visible = false;
            }
            CreateDynamicControls();
        }

        private void SectionBoxMouseEnter(object? sender, EventArgs e)
        {
            if (SectionModel.Description != "")
            { MessageBox.Show(SectionModel.Description, SectionModel.Name); }
        }

        private void CreateDynamicControls()
        {
            int rowMargin = 186; //208; 367

            foreach (var e in EventModel.ExecutersId)
            {
                GetProfessorsInfo professorsInfo = new(e);
                ProfessorModel professor = professorsInfo.GetInfo();
                LinkLabel label = new()
                {
                    Text = professor.Surname + " " + professor.Name[0] + ". " + professor.Patronymic[0] + ".",
                    Location = new System.Drawing.Point(rowMargin, 351),
                    AutoSize = false,
                    Width = 150,
                    Height = 30,
                    Tag = e,
                    LinkColor = Color.FromArgb(105, 51, 7)
                };
                label.Click += LinkLabel_Click;
                Controls.Add(label);
                rowMargin += label.Width + 10;
            }
        }
        private void LinkLabel_Click(object? sender, EventArgs e)
        {
            DepartmentInfo.ProfessorId = (int)((LinkLabel)sender).Tag;
            ProfessorPage professor_Page = new();
            professor_Page.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            MainPage mainPage = new();
            mainPage.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DepartamentPage departamentPage = new();
            departamentPage.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            dueBox.Visible = false;
            statusBox.Visible = false;
            sectionBox.Visible = false;
            statusCombo.Visible = true;
            sectionCombo.Visible = true;

            eventName.ReadOnly = false;
            eventName.BackColor = Color.White;
            eventName.BorderStyle = BorderStyle.FixedSingle;
            
            descriptionBox.ReadOnly = false;
            descriptionBox.BackColor = Color.White;
            descriptionBox.BorderStyle = BorderStyle.FixedSingle;
            
            dateTimePicker1.Visible = true;
            dateTimePicker1.Value = DateTime.Parse(dueBox.Text);
            
            resultBox.ReadOnly = false;
            resultBox.BackColor = Color.White;
            resultBox.BorderStyle = BorderStyle.FixedSingle;
            
            FillSections();
            FillStatuses();

            CreateButtons();
        }
        private void FillSections()
        {
            Dictionary<int, string> sec = new();
            foreach (var s in sections)
            {
                sec.Add(s.Key, s.Value.Name);
            }
            sectionCombo.DataSource = new BindingSource(sec, null);
            sectionCombo.DisplayMember = "Value";
            sectionCombo.ValueMember = "Key";

        }
        private void FillStatuses()
        {
            Dictionary<int, string> statuses = new Dictionary<int, string> { { 1, "Виконано" }, { 0, "Не виконано" } };
            statusCombo.DataSource = new BindingSource(statuses, null);
            statusCombo.ValueMember = "Key";
            statusCombo.DisplayMember = "Value";
        }

        private void CreateButtons()
        {
            Button saveButton = new()
            {
                BackColor = Color.Linen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204),
                Location = new Point(546, 382),
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
                Location = new Point(400, 382),
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
                EventPage eventPage = new(_id);
                this.Close();
                eventPage.Show();
            }
        }
        private void SaveChanges(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете зберегти зміни?", "Збереження", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EventModel model = new EventModel();
                model.Id = _id;
                model.Name = eventName.Text;
                model.Description = descriptionBox.Text;
                model.Status = statusCombo.SelectedValue.ToString();
                model.SectionId = (int)sectionCombo.SelectedValue;
                model.Result = resultBox.Text;
                model.Date = dateTimePicker1.Value;
                model.SceduleId = DepartmentInfo.SceduleId;
                eventInfo.AlterEvent(model);
                EventPage eventPage = new(_id);
                this.Close();
                eventPage.Show();
            }
        }
    }
}
