namespace WindowsForms.FormSection
{
    partial class SectionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            SectionsDataGridView = new DataGridView();
            SectionHomeButton = new Button();
            updateSectionButton = new Button();
            deleteSectionButton = new Button();
            addSectionButton = new Button();
            SearchSectionTextBox = new TextBox();
            SearchSectionButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SectionsDataGridView);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 331);
            panel1.TabIndex = 0;
            // 
            // SectionsDataGridView
            // 
            SectionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SectionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SectionsDataGridView.Dock = DockStyle.Fill;
            SectionsDataGridView.Location = new Point(0, 0);
            SectionsDataGridView.MultiSelect = false;
            SectionsDataGridView.Name = "SectionsDataGridView";
            SectionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SectionsDataGridView.Size = new Size(776, 331);
            SectionsDataGridView.TabIndex = 0;
            // 
            // SectionHomeButton
            // 
            SectionHomeButton.Location = new Point(12, 384);
            SectionHomeButton.Name = "SectionHomeButton";
            SectionHomeButton.Size = new Size(144, 54);
            SectionHomeButton.TabIndex = 1;
            SectionHomeButton.Text = "Volver al Menú";
            SectionHomeButton.UseVisualStyleBackColor = true;
            SectionHomeButton.Click += SectionHomeButton_Click;
            // 
            // updateSectionButton
            // 
            updateSectionButton.Location = new Point(704, 384);
            updateSectionButton.Name = "updateSectionButton";
            updateSectionButton.Size = new Size(84, 54);
            updateSectionButton.TabIndex = 2;
            updateSectionButton.Text = "Modificar";
            updateSectionButton.UseVisualStyleBackColor = true;
            updateSectionButton.Click += updateSectionButton_Click;
            // 
            // deleteSectionButton
            // 
            deleteSectionButton.Location = new Point(614, 384);
            deleteSectionButton.Name = "deleteSectionButton";
            deleteSectionButton.Size = new Size(84, 54);
            deleteSectionButton.TabIndex = 3;
            deleteSectionButton.Text = "Eliminar";
            deleteSectionButton.UseVisualStyleBackColor = true;
            deleteSectionButton.Click += deleteSectionButton_Click;
            // 
            // addSectionButton
            // 
            addSectionButton.Location = new Point(524, 384);
            addSectionButton.Name = "addSectionButton";
            addSectionButton.Size = new Size(84, 54);
            addSectionButton.TabIndex = 4;
            addSectionButton.Text = "Agregar";
            addSectionButton.UseVisualStyleBackColor = true;
            addSectionButton.Click += AddSectionButton_Click;
            // 
            // SearchSectionTextBox
            // 
            SearchSectionTextBox.Location = new Point(12, 11);
            SearchSectionTextBox.Name = "SearchSectionTextBox";
            SearchSectionTextBox.PlaceholderText = "Buscar Comision por descripción";
            SearchSectionTextBox.Size = new Size(338, 23);
            SearchSectionTextBox.TabIndex = 5;
            // 
            // SearchSectionButton
            // 
            SearchSectionButton.Location = new Point(356, 11);
            SearchSectionButton.Name = "SearchSectionButton";
            SearchSectionButton.Size = new Size(75, 24);
            SearchSectionButton.TabIndex = 6;
            SearchSectionButton.Text = "Buscar";
            SearchSectionButton.UseVisualStyleBackColor = true;
            // 
            // SectionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchSectionButton);
            Controls.Add(SearchSectionTextBox);
            Controls.Add(addSectionButton);
            Controls.Add(deleteSectionButton);
            Controls.Add(updateSectionButton);
            Controls.Add(SectionHomeButton);
            Controls.Add(panel1);
            Name = "SectionList";
            Text = "Lista de Comisiones";
            Load += Sections_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SectionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView SectionsDataGridView;
        private Button SectionHomeButton;
        private Button updateSectionButton;
        private Button deleteSectionButton;
        private Button addSectionButton;
        private TextBox SearchSectionTextBox;
        private Button SearchSectionButton;
    }
}