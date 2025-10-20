using APIAuthWindowsForms;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.StudentPages
{
    public partial class StudentCourseGrades : Form
    {
        private Form home;
        public StudentCourseGrades(Form home)
        {
            InitializeComponent();
            LoadStudentCoursesGrades();
            this.home = home;
        }

        private async void LoadStudentCoursesGrades()
        {
            try
            {
                WindowsFormsAuthService authService = new WindowsFormsAuthService();
                UserDTO currentUser = await authService.GetCurrentUserAsync();
                int studentId = currentUser.ID;

                var studentCourses = await ApiClients.StudentCourseApiClient.GetByStudentID(studentId);
                studentCourseGradesGrid.DataSource = studentCourses.ToList();

                studentCourseGradesGrid.Columns["ID"].Visible = false;
                studentCourseGradesGrid.Columns["State"].Visible = false;
                studentCourseGradesGrid.Columns["IDStudent"].Visible = false;
                studentCourseGradesGrid.Columns["IDcourse"].Visible = false;

                studentCourseGradesGrid.Columns["SubjectDescription"].DisplayIndex = 0;
                studentCourseGradesGrid.Columns["Condition"].DisplayIndex = 1;
                studentCourseGradesGrid.Columns["Grade"].DisplayIndex = 2;

                studentCourseGradesGrid.Columns["SubjectDescription"].HeaderText = "Materia";
                studentCourseGradesGrid.Columns["Condition"].HeaderText = "Condicion";
                studentCourseGradesGrid.Columns["Grade"].HeaderText = "Nota";

                studentCourseGradesGrid.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student course grades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentCourseGradesBackButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
