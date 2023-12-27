using CourseProject.Models;
using CourseProject.Repository;
using CourseProject.Services;
using CourseProject.UserInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class AddEventPage : Form
    {
        private readonly Dictionary<int, ProfessorModel> professors;
        private readonly Dictionary<int, SectionModel> sections;
        private GetSectionInfo sectionInfo;
        private QueryDepartmentInfo departmentInfo;
        private QueryEventInfo queryEvent;

        public AddEventPage()
        {
            departmentInfo = new();
            sectionInfo = new();
            queryEvent = new QueryEventInfo();
            professors = departmentInfo.GetProffesors(DepartmentInfo.DepartmentId);
            sections = sectionInfo.GetAllSections();
            InitializeComponent();
            FillProfessors();
            FillSections();


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
        private void FillProfessors()
        {
            Dictionary<int, string> prof = new();
            foreach (var p in professors)
            {
                string fullName = p.Value.Surname + " " + p.Value.Name + " " + p.Value.Patronymic;
                prof.Add(p.Key, fullName);
            }
            prof = prof.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            professorsCombo.DataSource = new BindingSource(prof, null);
            professorsCombo.DisplayMember = "Value";
            professorsCombo.ValueMember = "Key";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете перервати операцію додання події?", "Скасування", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                ScedulePage scedulePage = new();
                scedulePage.Show();
            }
        }

        private void addProfButton_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedProfessor = (KeyValuePair<int, string>)professorsCombo.SelectedItem;
            if (!checkedListBox1.Items.Contains(selectedProfessor))
            {
                checkedListBox1.Items.Add(selectedProfessor);
                checkedListBox1.DisplayMember = "Value";
                checkedListBox1.ValueMember = "Key";
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1 && checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex))
            {
                MessageBox.Show(checkedListBox1.SelectedItem.ToString());
                DialogResult result = MessageBox.Show("Ви точно хочете звільнити цього викладача від відповідальності за захід?", "Звільнення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, false);
                    checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                    checkedListBox1.Items.Remove(checkedListBox1.SelectedIndex);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventModel eventModel = new EventModel();
            eventModel.ExecutersId = new();
            eventModel.Name = eventName.Text;
            eventModel.Result = eventResult.Text;
            eventModel.Date = dateTimePicker1.Value;
            eventModel.Description = richTextBox1.Text;
            eventModel.SectionId = (int)sectionCombo.SelectedValue;
           
            Regex regex = new Regex(@"(\d+)");
            foreach (var item in checkedListBox1.Items) 
            {
                Match match = regex.Match(item.ToString());
                string numericValue = match.Value;
                int num = int.Parse(numericValue);
                eventModel.ExecutersId.Add(num);
            }
            try { queryEvent.AddEvent(eventModel);
                this.Close();
                ScedulePage page = new ScedulePage();
                page.Show();
            }
            catch (Exception) { MessageBox.Show("При доданні виникла помилка."); }
            
        }
          
            
    }
}

