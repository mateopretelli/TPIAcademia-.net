using ApiClients;
using DTOs;

namespace WindowsForms.TeacherPages
{
    public partial class StudentCourseDetail : Form
    {
        StudentCourseDetailDTO studentCourseDTO;
        public StudentCourseDetail(int idStudentCourse)
        {
            InitializeComponent();
            LoadStudent(idStudentCourse);
        }

        private async void LoadStudent(int id)
        {
            try
            {
                studentCourseDTO = await StudentCourseApiClient.GetStudentCourseByIdAsync(id);

                this.studentNameTextBox.Text = studentCourseDTO.StudentName;
                this.studentLastNameTextBox.Text = studentCourseDTO.StudentLastName;
                this.studentEmailTextBox.Text = studentCourseDTO.StudentEmail;
                this.studentGradeTextBox.Text = studentCourseDTO.Grade.ToString();
                SetCondition(studentCourseDTO.Condition);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles del alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void StudentCourseDetailBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStudentCourse_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                StudentCourseDTO dto = new StudentCourseDTO();
                dto.ID = studentCourseDTO.ID;
                dto.IDstudent = studentCourseDTO.IDStudent;
                dto.State = studentCourseDTO.State;
                dto.IDcourse = studentCourseDTO.IDCourse;
                dto.Grade = Convert.ToInt32(studentGradeTextBox.Text);
                dto.Condition = StudentConditionComboBox.SelectedItem.ToString();

                try
                {
                    StudentCourseApiClient.UpdateAsync(dto);
                    MessageBox.Show("Detalles del alumno en el curso actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar los detalles del alumno en el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(studentGradeTextBox.Text))
            {
                errorProvider1.SetError(studentGradeTextBox, "El campo 'Nota' no puede estar vacío.");
                isValid = false;
            }
            if(!int.TryParse(studentGradeTextBox.Text, out int grade) || grade < 0 || grade > 10)
            {
                errorProvider1.SetError(studentGradeTextBox, "El campo 'Nota' debe ser un número entre 0 y 10.");
                isValid = false;
            }
            if(StudentConditionComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(StudentConditionComboBox, "Debe seleccionar una condición.");
                isValid = false;
            }


            return isValid;
        }

        private async void SetCondition(string StudentCond)
        {
            StudentConditionComboBox.Items.Clear();
            StudentConditionComboBox.Items.Add("Inscripto");
            StudentConditionComboBox.Items.Add("Regular");
            StudentConditionComboBox.Items.Add("Aprobado");
            StudentConditionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (StudentCond)
            {
                case "Inscripto":
                    StudentConditionComboBox.SelectedIndex = 0;
                    break;
                case "Regular":
                    StudentConditionComboBox.SelectedIndex = 1;
                    break;
                case "Aprobado":
                    StudentConditionComboBox.SelectedIndex = 2;
                    break;
                default:
                    StudentConditionComboBox.SelectedIndex = 0;
                    break;
            }
        }

    }
}
