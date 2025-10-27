namespace WindowsForms.FormSection
{
    partial class SectionDetail
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
            components = new System.ComponentModel.Container();
            SubjectIDSpecialtyLabel = new Label();
            IDSpecialtySectionComboBox = new ComboBox();
            IDPlanSectionComboBox = new ComboBox();
            SectionIDTextBox = new TextBox();
            MateriaIDPlanLabel = new Label();
            MateriaStateLabel = new Label();
            MateriaDescriptionLabel = new Label();
            MateriaIDLabel = new Label();
            SectionStateTextBox = new TextBox();
            SectionDescriptionTextBox = new TextBox();
            cancelSectionButton = new Button();
            acceptSectionButton = new Button();
            SectionErrorProvider = new ErrorProvider(components);
            SectionSpecialtyYearTextBox = new TextBox();
            SectionSpecialtyYearLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SectionErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // SubjectIDSpecialtyLabel
            // 
            SubjectIDSpecialtyLabel.AutoSize = true;
            SubjectIDSpecialtyLabel.Location = new Point(32, 165);
            SubjectIDSpecialtyLabel.Name = "SubjectIDSpecialtyLabel";
            SubjectIDSpecialtyLabel.Size = new Size(45, 15);
            SubjectIDSpecialtyLabel.TabIndex = 33;
            SubjectIDSpecialtyLabel.Text = "Carrera";
            // 
            // IDSpecialtySectionComboBox
            // 
            IDSpecialtySectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDSpecialtySectionComboBox.DropDownWidth = 280;
            IDSpecialtySectionComboBox.FormattingEnabled = true;
            IDSpecialtySectionComboBox.Location = new Point(142, 162);
            IDSpecialtySectionComboBox.Name = "IDSpecialtySectionComboBox";
            IDSpecialtySectionComboBox.Size = new Size(287, 23);
            IDSpecialtySectionComboBox.TabIndex = 32;
            IDSpecialtySectionComboBox.SelectedIndexChanged += IDSpecialtySectionComboBox_SelectedIndexChanged;
            // 
            // IDPlanSectionComboBox
            // 
            IDPlanSectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDPlanSectionComboBox.DropDownWidth = 280;
            IDPlanSectionComboBox.Enabled = false;
            IDPlanSectionComboBox.FormattingEnabled = true;
            IDPlanSectionComboBox.Location = new Point(142, 191);
            IDPlanSectionComboBox.Name = "IDPlanSectionComboBox";
            IDPlanSectionComboBox.Size = new Size(287, 23);
            IDPlanSectionComboBox.TabIndex = 31;
            // 
            // SectionIDTextBox
            // 
            SectionIDTextBox.Enabled = false;
            SectionIDTextBox.Location = new Point(142, 42);
            SectionIDTextBox.Name = "SectionIDTextBox";
            SectionIDTextBox.Size = new Size(287, 23);
            SectionIDTextBox.TabIndex = 30;
            // 
            // MateriaIDPlanLabel
            // 
            MateriaIDPlanLabel.AutoSize = true;
            MateriaIDPlanLabel.Location = new Point(32, 194);
            MateriaIDPlanLabel.Name = "MateriaIDPlanLabel";
            MateriaIDPlanLabel.Size = new Size(30, 15);
            MateriaIDPlanLabel.TabIndex = 29;
            MateriaIDPlanLabel.Text = "Plan";
            // 
            // MateriaStateLabel
            // 
            MateriaStateLabel.AutoSize = true;
            MateriaStateLabel.Location = new Point(32, 136);
            MateriaStateLabel.Name = "MateriaStateLabel";
            MateriaStateLabel.Size = new Size(42, 15);
            MateriaStateLabel.TabIndex = 28;
            MateriaStateLabel.Text = "Estado";
            // 
            // MateriaDescriptionLabel
            // 
            MateriaDescriptionLabel.AutoSize = true;
            MateriaDescriptionLabel.Location = new Point(30, 78);
            MateriaDescriptionLabel.Name = "MateriaDescriptionLabel";
            MateriaDescriptionLabel.Size = new Size(69, 15);
            MateriaDescriptionLabel.TabIndex = 25;
            MateriaDescriptionLabel.Text = "Descripcion";
            // 
            // MateriaIDLabel
            // 
            MateriaIDLabel.AutoSize = true;
            MateriaIDLabel.Location = new Point(32, 50);
            MateriaIDLabel.Name = "MateriaIDLabel";
            MateriaIDLabel.Size = new Size(18, 15);
            MateriaIDLabel.TabIndex = 24;
            MateriaIDLabel.Text = "ID";
            // 
            // SectionStateTextBox
            // 
            SectionStateTextBox.Enabled = false;
            SectionStateTextBox.Location = new Point(142, 133);
            SectionStateTextBox.Name = "SectionStateTextBox";
            SectionStateTextBox.Size = new Size(287, 23);
            SectionStateTextBox.TabIndex = 23;
            // 
            // SectionDescriptionTextBox
            // 
            SectionDescriptionTextBox.Location = new Point(142, 75);
            SectionDescriptionTextBox.Name = "SectionDescriptionTextBox";
            SectionDescriptionTextBox.Size = new Size(287, 23);
            SectionDescriptionTextBox.TabIndex = 20;
            // 
            // cancelSectionButton
            // 
            cancelSectionButton.Location = new Point(330, 235);
            cancelSectionButton.Name = "cancelSectionButton";
            cancelSectionButton.Size = new Size(99, 40);
            cancelSectionButton.TabIndex = 19;
            cancelSectionButton.Text = "Cancelar";
            cancelSectionButton.UseVisualStyleBackColor = true;
            cancelSectionButton.Click += cancelSectionButton_Click;
            // 
            // acceptSectionButton
            // 
            acceptSectionButton.Location = new Point(225, 235);
            acceptSectionButton.Name = "acceptSectionButton";
            acceptSectionButton.Size = new Size(99, 40);
            acceptSectionButton.TabIndex = 18;
            acceptSectionButton.Text = "Aceptar";
            acceptSectionButton.UseVisualStyleBackColor = true;
            acceptSectionButton.Click += acceptSectionButton_Click;
            // 
            // SectionErrorProvider
            // 
            SectionErrorProvider.ContainerControl = this;
            // 
            // SectionSpecialtyYearTextBox
            // 
            SectionSpecialtyYearTextBox.Location = new Point(142, 104);
            SectionSpecialtyYearTextBox.Name = "SectionSpecialtyYearTextBox";
            SectionSpecialtyYearTextBox.Size = new Size(287, 23);
            SectionSpecialtyYearTextBox.TabIndex = 34;
            // 
            // SectionSpecialtyYearLabel
            // 
            SectionSpecialtyYearLabel.AutoSize = true;
            SectionSpecialtyYearLabel.Location = new Point(32, 107);
            SectionSpecialtyYearLabel.Name = "SectionSpecialtyYearLabel";
            SectionSpecialtyYearLabel.Size = new Size(70, 15);
            SectionSpecialtyYearLabel.TabIndex = 35;
            SectionSpecialtyYearLabel.Text = "Año Carrera";
            // 
            // SectionDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 298);
            Controls.Add(SectionSpecialtyYearLabel);
            Controls.Add(SectionSpecialtyYearTextBox);
            Controls.Add(SubjectIDSpecialtyLabel);
            Controls.Add(IDSpecialtySectionComboBox);
            Controls.Add(IDPlanSectionComboBox);
            Controls.Add(SectionIDTextBox);
            Controls.Add(MateriaIDPlanLabel);
            Controls.Add(MateriaStateLabel);
            Controls.Add(MateriaDescriptionLabel);
            Controls.Add(MateriaIDLabel);
            Controls.Add(SectionStateTextBox);
            Controls.Add(SectionDescriptionTextBox);
            Controls.Add(cancelSectionButton);
            Controls.Add(acceptSectionButton);
            Name = "SectionDetail";
            Text = "Detalle de Comisión";
            ((System.ComponentModel.ISupportInitialize)SectionErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SubjectIDSpecialtyLabel;
        private ComboBox IDSpecialtySectionComboBox;
        private ComboBox IDPlanSectionComboBox;
        private TextBox SectionIDTextBox;
        private Label MateriaIDPlanLabel;
        private Label MateriaStateLabel;
        private Label MateriaDescriptionLabel;
        private Label MateriaIDLabel;
        private TextBox SectionStateTextBox;
        private TextBox SectionDescriptionTextBox;
        private Button cancelSectionButton;
        private Button acceptSectionButton;
        private ErrorProvider SectionErrorProvider;
        private Label SectionSpecialtyYearLabel;
        private TextBox SectionSpecialtyYearTextBox;
    }
}