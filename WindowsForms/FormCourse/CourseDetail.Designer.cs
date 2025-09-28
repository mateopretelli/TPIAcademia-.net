namespace WindowsForms.FormCourse
{
    partial class CourseDetail
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
            SpecialtyLabel = new Label();
            SpecialtyCourseComboBox = new ComboBox();
            PlanCourseComboBox = new ComboBox();
            SectionCourseComboBox = new ComboBox();
            SubjectCourseComboBox = new ComboBox();
            CourseIDTextBox = new TextBox();
            MateriaIDPlanLabel = new Label();
            MateriaStateLabel = new Label();
            MateriaDescriptionLabel = new Label();
            MateriaIDLabel = new Label();
            CourseStateTextBox = new TextBox();
            CourseDescriptionTextBox = new TextBox();
            cancelCourseButton = new Button();
            acceptCourseButton = new Button();
            CourseErrorProvider = new ErrorProvider(components);
            CourseSpecialtyYearTextBox = new TextBox();
            CourseSpecialtyYearLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CourseErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // SpecialtyLabel
            // 
            SpecialtyLabel.AutoSize = true;
            SpecialtyLabel.Location = new Point(32, 165);
            SpecialtyLabel.Name = "SubjectIDSpecialtyLabel";
            SpecialtyLabel.Size = new Size(45, 15);
            SpecialtyLabel.TabIndex = 1;
            SpecialtyLabel.Text = "Carrera";
            // 
            // SpecialtyCourseComboBox
            // 
            SpecialtyCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialtyCourseComboBox.DropDownWidth = 280;
            SpecialtyCourseComboBox.FormattingEnabled = true;
            SpecialtyCourseComboBox.Location = new Point(142, 162);
            SpecialtyCourseComboBox.Name = "SpecialtyCourseComboBox";
            SpecialtyCourseComboBox.Size = new Size(287, 23);
            SpecialtyCourseComboBox.TabIndex = 2;
            SpecialtyCourseComboBox.SelectedIndexChanged += SpecialtyCourseComboBox_SelectedIndexChanged;
            // 
            // PlanCourseComboBox
            // 
            PlanCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlanCourseComboBox.DropDownWidth = 280;
            PlanCourseComboBox.Enabled = false;
            PlanCourseComboBox.FormattingEnabled = true;
            PlanCourseComboBox.Location = new Point(142, 191);
            PlanCourseComboBox.Name = "PlanCourseComboBox";
            PlanCourseComboBox.Size = new Size(287, 23);
            PlanCourseComboBox.TabIndex = 3;
            PlanCourseComboBox.SelectedIndexChanged += PlanCourseComboBox_SelectedIndexChanged;
            // 
            // SectionCourseComboBox
            // 
            SectionCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionCourseComboBox.DropDownWidth = 280;
            SectionCourseComboBox.Enabled = false;
            SectionCourseComboBox.FormattingEnabled = true;
            SectionCourseComboBox.Location = new Point(142, 191);
            SectionCourseComboBox.Name = "PlanCourseComboBox";
            SectionCourseComboBox.Size = new Size(287, 23);
            SectionCourseComboBox.TabIndex = 4;
            // 
            // SubjectCourseComboBox
            // 
            SubjectCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectCourseComboBox.DropDownWidth = 280;
            SubjectCourseComboBox.Enabled = false;
            SubjectCourseComboBox.FormattingEnabled = true;
            SubjectCourseComboBox.Location = new Point(142, 191);
            SubjectCourseComboBox.Name = "SubjectCourseComboBox";
            SubjectCourseComboBox.Size = new Size(287, 23);
            SubjectCourseComboBox.TabIndex = 5;
            // 
            // CourseIDTextBox
            // 
            CourseIDTextBox.Enabled = false;
            CourseIDTextBox.Location = new Point(142, 42);
            CourseIDTextBox.Name = "CourseIDTextBox";
            CourseIDTextBox.Size = new Size(287, 23);
            CourseIDTextBox.TabIndex = 6;
            // 
            // MateriaIDPlanLabel
            // 
            MateriaIDPlanLabel.AutoSize = true;
            MateriaIDPlanLabel.Location = new Point(32, 194);
            MateriaIDPlanLabel.Name = "MateriaIDPlanLabel";
            MateriaIDPlanLabel.Size = new Size(30, 15);
            MateriaIDPlanLabel.TabIndex = 7;
            MateriaIDPlanLabel.Text = "Plan";
            // 
            // MateriaStateLabel
            // 
            MateriaStateLabel.AutoSize = true;
            MateriaStateLabel.Location = new Point(32, 136);
            MateriaStateLabel.Name = "MateriaStateLabel";
            MateriaStateLabel.Size = new Size(42, 15);
            MateriaStateLabel.TabIndex = 8;
            MateriaStateLabel.Text = "Estado";
            // 
            // MateriaDescriptionLabel
            // 
            MateriaDescriptionLabel.AutoSize = true;
            MateriaDescriptionLabel.Location = new Point(30, 78);
            MateriaDescriptionLabel.Name = "MateriaDescriptionLabel";
            MateriaDescriptionLabel.Size = new Size(69, 15);
            MateriaDescriptionLabel.TabIndex = 9;
            MateriaDescriptionLabel.Text = "Descripcion";
            // 
            // MateriaIDLabel
            // 
            MateriaIDLabel.AutoSize = true;
            MateriaIDLabel.Location = new Point(32, 50);
            MateriaIDLabel.Name = "MateriaIDLabel";
            MateriaIDLabel.Size = new Size(18, 15);
            MateriaIDLabel.TabIndex = 10;
            MateriaIDLabel.Text = "ID";
            // 
            // CourseStateTextBox
            // 
            CourseStateTextBox.Enabled = false;
            CourseStateTextBox.Location = new Point(142, 133);
            CourseStateTextBox.Name = "CourseStateTextBox";
            CourseStateTextBox.Size = new Size(287, 23);
            CourseStateTextBox.TabIndex = 11;
            // 
            // CourseDescriptionTextBox
            // 
            CourseDescriptionTextBox.Location = new Point(142, 75);
            CourseDescriptionTextBox.Name = "CourseDescriptionTextBox";
            CourseDescriptionTextBox.Size = new Size(287, 23);
            CourseDescriptionTextBox.TabIndex = 12;
            // 
            // cancelCourseButton
            // 
            cancelCourseButton.Location = new Point(330, 235);
            cancelCourseButton.Name = "cancelCourseButton";
            cancelCourseButton.Size = new Size(99, 40);
            cancelCourseButton.TabIndex = 19;
            cancelCourseButton.Text = "Cancelar";
            cancelCourseButton.UseVisualStyleBackColor = true;
            cancelCourseButton.Click += cancelCourseButton_Click;
            // 
            // acceptCourseButton
            // 
            acceptCourseButton.Location = new Point(225, 235);
            acceptCourseButton.Name = "acceptCourseButton";
            acceptCourseButton.Size = new Size(99, 13);
            acceptCourseButton.TabIndex = 18;
            acceptCourseButton.Text = "Aceptar";
            acceptCourseButton.UseVisualStyleBackColor = true;
            acceptCourseButton.Click += acceptCourseButton_Click;
            // 
            // CourseErrorProvider
            // 
            CourseErrorProvider.ContainerControl = this;
            // 
            // CourseAcademicYearTextBox
            // 
            CourseAcademicYearTextBox.Location = new Point(142, 104);
            CourseAcademicYearTextBox.Name = "CourseSpecialtyYearTextBox";
            CourseAcademicYearTextBox.Size = new Size(287, 23);
            CourseAcademicYearTextBox.TabIndex = 14;
            CourseAcademicYearTextBox.SelectedText = "2025";
            // 
            // CourseAcademicYearLabel
            // 
            CourseAcademicYearLabel.AutoSize = true;
            CourseAcademicYearLabel.Location = new Point(32, 107);
            CourseAcademicYearLabel.Name = "CourseAcademicYearLabel";
            CourseAcademicYearLabel.Size = new Size(70, 15);
            CourseAcademicYearLabel.TabIndex = 15;
            CourseAcademicYearLabel.Text = "Año Académico";
            // 
            // CourseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 298);
            Controls.Add(CourseAcademicYearLabel);
            Controls.Add(CourseAcademicYearTextBox);
            Controls.Add(SpecialtyLabel);
            Controls.Add(SpecialtyCourseComboBox);
            Controls.Add(PlanCourseComboBox);
            Controls.Add(SectionCourseComboBox);
            Controls.Add(SubjectCourseComboBox);
            Controls.Add(CourseIDTextBox);
            Controls.Add(MateriaIDPlanLabel);
            Controls.Add(MateriaStateLabel);
            Controls.Add(MateriaDescriptionLabel);
            Controls.Add(MateriaIDLabel);
            Controls.Add(CourseStateTextBox);
            Controls.Add(CourseDescriptionTextBox);
            Controls.Add(cancelCourseButton);
            Controls.Add(acceptCourseButton);
            Name = "CourseDetail";
            Text = "Detalle de Curso";
            ((System.ComponentModel.ISupportInitialize)CourseErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CourseAcademicYearLabel;
        private TextBox CourseAcademicYearTextBox;
        private Label SpecialtyLabel;
        private ComboBox SpecialtyCourseComboBox;
        private ComboBox PlanCourseComboBox;
        private ComboBox SectionCourseComboBox;
        private ComboBox SubjectCourseComboBox;
        private TextBox CourseIDTextBox;
        private Label MateriaIDPlanLabel;
        private Label MateriaStateLabel;
        private Label MateriaDescriptionLabel;
        private Label MateriaIDLabel;
        private TextBox CourseStateTextBox;
        private TextBox CourseDescriptionTextBox;
        private Button cancelCourseButton;
        private Button acceptCourseButton;
        private ErrorProvider CourseErrorProvider;
        
    }
}