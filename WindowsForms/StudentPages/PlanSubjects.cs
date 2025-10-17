using APIAuthWindowsForms;
using DTOs;

namespace WindowsForms.StudentPages
{
    public partial class PlanSubjects : Form
    {
        private Form home;
        public PlanSubjects(Form home)
        {
            InitializeComponent();
            this.home = home;
            SetSubjectList();
        }

        private async void SetSubjectList()
        {
            try
            {
                WindowsFormsAuthService authService = new WindowsFormsAuthService();
                UserDTO user = await authService.GetCurrentUserAsync();
                IEnumerable<SubjectDTO> subjects = await ApiClients.SubjectApiClient.GetAllAsync();
                subjects = subjects.Where(s => s.IDPlan == user.IDPlan).ToList();
                this.SubjectsGridView.DataSource = subjects;

                SubjectDTO subj = subjects.FirstOrDefault();
                if (subj != null)
                {
                    PlanSubjectsLabel.Text = $"Materias del plan: {subj.PlanDescription}";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubjectListBackButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
