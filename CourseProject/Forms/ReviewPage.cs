using CourseProject.Info;
using CourseProject.Models;
using CourseProject.Repository;
using CourseProject.Services;
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
    public partial class ReviewPage : Form
    {
        public ReviewPage()
        {
            InitializeComponent();
            FillDepartments();
            unameLabel.Text = User.UName;
        }
        private void FillDepartments()
        {
            QueryDepartmentInfo departament = new();
            Dictionary<int, string> deps = departament.GetDepartaments();
            departmentCombo.DataSource = new BindingSource(deps, null);
            departmentCombo.DisplayMember = "Value";
            departmentCombo.ValueMember = "Key";
        }
        private void SendReview(object sender, EventArgs e)
        {
            ReviewModel reviewModel = new ReviewModel();
            reviewModel.Title = title.Text;
            reviewModel.Text = reviewText.Text;
            reviewModel.Time = DateTime.Now;
            reviewModel.Department = int.Parse(departmentCombo.SelectedValue.ToString());
            reviewModel.Revisor = (int)User.UId;
            try
            {
                QueryReviews queryReviews = new();
                queryReviews.SendReview(reviewModel);
                MessageBox.Show("Відгук успішно надіслано.");
            }
            catch (Exception) { MessageBox.Show("При відправленні відгуку виникла помилка."); }
        }

        private void GoToMain(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете скасувати написання відгуку?", "Скасування", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Close();
            }
        }
    }
}
