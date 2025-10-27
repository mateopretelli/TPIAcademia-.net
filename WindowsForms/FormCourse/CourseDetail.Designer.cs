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
            PlanLabel = new Label();
            PlanCourseComboBox = new ComboBox();
            SectionLabel = new Label();
            SectionCourseComboBox = new ComboBox();
            SubjectLabel = new Label();
            SubjectCourseComboBox = new ComboBox();
            CourseIDLabel = new Label();
            CourseIDTextBox = new TextBox();
            CourseStateLabel = new Label();
            CourseStateTextBox = new TextBox();
            CourseCapacityLabel = new Label();
            CourseCapacityTextBox = new TextBox();
            cancelCourseButton = new Button();
            acceptCourseButton = new Button();
            CourseErrorProvider = new ErrorProvider(components);
            CourseAcademicYearTextBox = new TextBox();
            CourseAcademicYearLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CourseErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // SpecialtyLabel
            // 
            SpecialtyLabel.AutoSize = true;
            SpecialtyLabel.Location = new Point(38, 162);
            SpecialtyLabel.Name = "SpecialtyLabel";
            SpecialtyLabel.Size = new Size(72, 15);
            SpecialtyLabel.TabIndex = 1;
            SpecialtyLabel.Text = "Especialidad";
            // 
            // SpecialtyCourseComboBox
            // 
            SpecialtyCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialtyCourseComboBox.DropDownWidth = 280;
            SpecialtyCourseComboBox.FormattingEnabled = true;
            SpecialtyCourseComboBox.Location = new Point(116, 159);
            SpecialtyCourseComboBox.Name = "SpecialtyCourseComboBox";
            SpecialtyCourseComboBox.Size = new Size(166, 23);
            SpecialtyCourseComboBox.TabIndex = 2;
            SpecialtyCourseComboBox.SelectedIndexChanged += SpecialtyCourseComboBox_SelectedIndexChanged;
            // 
            // PlanLabel
            // 
            PlanLabel.AutoSize = true;
            PlanLabel.Location = new Point(300, 162);
            PlanLabel.Name = "PlanLabel";
            PlanLabel.Size = new Size(30, 15);
            PlanLabel.TabIndex = 8;
            PlanLabel.Text = "Plan";
            // 
            // PlanCourseComboBox
            // 
            PlanCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlanCourseComboBox.DropDownWidth = 280;
            PlanCourseComboBox.Enabled = false;
            PlanCourseComboBox.FormattingEnabled = true;
            PlanCourseComboBox.Location = new Point(336, 159);
            PlanCourseComboBox.Name = "PlanCourseComboBox";
            PlanCourseComboBox.Size = new Size(67, 23);
            PlanCourseComboBox.TabIndex = 3;
            PlanCourseComboBox.SelectedIndexChanged += PlanCourseComboBox_SelectedIndexChanged;
            // 
            // SectionLabel
            // 
            SectionLabel.AutoSize = true;
            SectionLabel.Location = new Point(52, 220);
            SectionLabel.Name = "SectionLabel";
            SectionLabel.Size = new Size(58, 15);
            SectionLabel.TabIndex = 9;
            SectionLabel.Text = "Comisión";
            // 
            // SectionCourseComboBox
            // 
            SectionCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionCourseComboBox.DropDownWidth = 280;
            SectionCourseComboBox.Enabled = false;
            SectionCourseComboBox.FormattingEnabled = true;
            SectionCourseComboBox.Location = new Point(116, 217);
            SectionCourseComboBox.Name = "SectionCourseComboBox";
            SectionCourseComboBox.Size = new Size(287, 23);
            SectionCourseComboBox.TabIndex = 4;
            // 
            // SubjectLabel
            // 
            SubjectLabel.AutoSize = true;
            SubjectLabel.Location = new Point(63, 191);
            SubjectLabel.Name = "SubjectLabel";
            SubjectLabel.Size = new Size(47, 15);
            SubjectLabel.TabIndex = 10;
            SubjectLabel.Text = "Materia";
            // 
            // SubjectCourseComboBox
            // 
            SubjectCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectCourseComboBox.DropDownWidth = 280;
            SubjectCourseComboBox.Enabled = false;
            SubjectCourseComboBox.FormattingEnabled = true;
            SubjectCourseComboBox.Location = new Point(116, 188);
            SubjectCourseComboBox.Name = "SubjectCourseComboBox";
            SubjectCourseComboBox.Size = new Size(287, 23);
            SubjectCourseComboBox.TabIndex = 5;
            // 
            // CourseIDLabel
            // 
            CourseIDLabel.AutoSize = true;
            CourseIDLabel.Location = new Point(92, 42);
            CourseIDLabel.Name = "CourseIDLabel";
            CourseIDLabel.Size = new Size(18, 15);
            CourseIDLabel.TabIndex = 7;
            CourseIDLabel.Text = "ID";
            // 
            // CourseIDTextBox
            // 
            CourseIDTextBox.Enabled = false;
            CourseIDTextBox.Location = new Point(116, 39);
            CourseIDTextBox.Name = "CourseIDTextBox";
            CourseIDTextBox.Size = new Size(287, 23);
            CourseIDTextBox.TabIndex = 17;
            // 
            // CourseStateLabel
            // 
            CourseStateLabel.AutoSize = true;
            CourseStateLabel.Location = new Point(68, 71);
            CourseStateLabel.Name = "CourseStateLabel";
            CourseStateLabel.Size = new Size(42, 15);
            CourseStateLabel.TabIndex = 16;
            CourseStateLabel.Text = "Estado";
            // 
            // CourseStateTextBox
            // 
            CourseStateTextBox.Enabled = false;
            CourseStateTextBox.Location = new Point(116, 68);
            CourseStateTextBox.Name = "CourseStateTextBox";
            CourseStateTextBox.Size = new Size(287, 23);
            CourseStateTextBox.TabIndex = 11;
            // 
            // CourseCapacityLabel
            // 
            CourseCapacityLabel.AutoSize = true;
            CourseCapacityLabel.Location = new Point(47, 104);
            CourseCapacityLabel.Name = "CourseCapacityLabel";
            CourseCapacityLabel.Size = new Size(63, 15);
            CourseCapacityLabel.TabIndex = 7;
            CourseCapacityLabel.Text = "Capacidad";
            // 
            // CourseCapacityTextBox
            // 
            CourseCapacityTextBox.Location = new Point(116, 101);
            CourseCapacityTextBox.Name = "CourseCapacityTextBox";
            CourseCapacityTextBox.Size = new Size(287, 23);
            CourseCapacityTextBox.TabIndex = 12;
            // 
            // cancelCourseButton
            // 
            cancelCourseButton.Location = new Point(304, 284);
            cancelCourseButton.Name = "cancelCourseButton";
            cancelCourseButton.Size = new Size(99, 40);
            cancelCourseButton.TabIndex = 19;
            cancelCourseButton.Text = "Cancelar";
            cancelCourseButton.UseVisualStyleBackColor = true;
            cancelCourseButton.Click += cancelCourseButton_Click;
            // 
            // acceptCourseButton
            // 
            acceptCourseButton.Location = new Point(171, 284);
            acceptCourseButton.Name = "acceptCourseButton";
            acceptCourseButton.Size = new Size(99, 40);
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
            CourseAcademicYearTextBox.Location = new Point(116, 130);
            CourseAcademicYearTextBox.Name = "CourseAcademicYearTextBox";
            CourseAcademicYearTextBox.Size = new Size(287, 23);
            CourseAcademicYearTextBox.TabIndex = 14;
            CourseAcademicYearTextBox.Text = "2025";
            // 
            // CourseAcademicYearLabel
            // 
            CourseAcademicYearLabel.AutoSize = true;
            CourseAcademicYearLabel.Location = new Point(18, 133);
            CourseAcademicYearLabel.Name = "CourseAcademicYearLabel";
            CourseAcademicYearLabel.Size = new Size(92, 15);
            CourseAcademicYearLabel.TabIndex = 15;
            CourseAcademicYearLabel.Text = "Año Académico";
            // 
            // CourseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 343);
            Controls.Add(CourseAcademicYearLabel);
            Controls.Add(CourseAcademicYearTextBox);
            Controls.Add(SpecialtyLabel);
            Controls.Add(SpecialtyCourseComboBox);
            Controls.Add(PlanLabel);
            Controls.Add(PlanCourseComboBox);
            Controls.Add(SectionLabel);
            Controls.Add(SectionCourseComboBox);
            Controls.Add(SubjectLabel);
            Controls.Add(SubjectCourseComboBox);
            Controls.Add(CourseIDLabel);
            Controls.Add(CourseIDTextBox);
            Controls.Add(CourseStateLabel);
            Controls.Add(CourseStateTextBox);
            Controls.Add(CourseCapacityLabel);
            Controls.Add(CourseCapacityTextBox);
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
        private Label PlanLabel;
        private ComboBox PlanCourseComboBox;
        private Label SectionLabel;
        private ComboBox SectionCourseComboBox;
        private Label SubjectLabel;
        private ComboBox SubjectCourseComboBox;
        private Label CourseIDLabel;
        private TextBox CourseIDTextBox;
        private Label CourseStateLabel;
        private TextBox CourseStateTextBox;
        private Label CourseCapacityLabel;
        private TextBox CourseCapacityTextBox;
        private Button cancelCourseButton;
        private Button acceptCourseButton;
        private ErrorProvider CourseErrorProvider;
    }
}