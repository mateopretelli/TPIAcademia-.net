using DTOs;
using ApiClients;

namespace WindowsForms.FormSection
{
    public partial class SectionList : Form
    {
        private AdminHome home;
        public SectionList(AdminHome home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void AddSectionButton_Click(object sender, EventArgs e)
        {
            SectionDetail sectionDetail = new SectionDetail();

            SectionDTO sectionDTO = new SectionDTO();

            sectionDetail.Section = sectionDTO;

            sectionDetail.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteSectionButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.SelectedItem().ID;
            await SectionApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void updateSectionButton_Click(object sender, EventArgs e)
        {
            SectionDetail sectionDetail = new SectionDetail();

            int id;

            id = this.SelectedItem().ID;

            SectionDTO section= await SectionApiClient.GetAsync(id);

            sectionDetail.EditMode = true;
            sectionDetail.Section = section;

            sectionDetail.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            SectionApiClient client = new SectionApiClient();

            this.SectionsDataGridView.DataSource = null;
            this.SectionsDataGridView.DataSource = await SectionApiClient.GetAllAsync();

            if (this.SectionsDataGridView.Rows.Count > 0)
            {
                this.SectionsDataGridView.Rows[0].Selected = true;
                this.deleteSectionButton.Enabled = true;
                this.updateSectionButton.Enabled = true;

                this.SectionsDataGridView.Columns["State"].Visible = false;
                this.SectionsDataGridView.Columns["Description"].HeaderText = "Descripcion";
                this.SectionsDataGridView.Columns["SpecialtyYear"].HeaderText = "AñoEspecialidad";
            }
            else
            {
                this.deleteSectionButton.Enabled = false;
                this.updateSectionButton.Enabled = false;
            }
        }

        private SectionDTO SelectedItem()
        {
            SectionDTO section;

            section = (SectionDTO)SectionsDataGridView.SelectedRows[0].DataBoundItem;

            return section;
        }

        private void SectionHomeButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

    }
}
