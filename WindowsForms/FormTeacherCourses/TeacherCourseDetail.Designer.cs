namespace WindowsForms.FormTeacherCourse
{
    partial class TeacherCourseDetail
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
            SpecialtyTeacherCourseComboBox = new ComboBox();
            PlanLabel = new Label();
            PlanTeacherCourseComboBox = new ComboBox();
            SectionLabel = new Label();
            SectionTeacherCourseComboBox = new ComboBox();
            SubjectLabel = new Label();
            SubjectTeacherCourseComboBox = new ComboBox();
            TeacherLabel = new Label();
            TeacherTeacherCourseComboBox = new ComboBox();
            CourseLabel = new Label();
            CourseTeacherCourseComboBox = new ComboBox();
            TeacherCourseIDLabel = new Label();
            TeacherCourseIDTextBox = new TextBox();
            TeacherCourseStateLabel = new Label();
            TeacherCourseStateTextBox = new TextBox();
            TeacherCourseRoleLabel = new Label();
            TeacherCourseRoleComboBox = new ComboBox();
            cancelTeacherCourseButton = new Button();
            acceptTeacherCourseButton = new Button();
            TeacherCourseErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)TeacherCourseErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // SpecialtyLabel
            // 
            SpecialtyLabel.AutoSize = true;
            SpecialtyLabel.Location = new Point(38, 128);
            SpecialtyLabel.Name = "SpecialtyLabel";
            SpecialtyLabel.Size = new Size(72, 15);
            SpecialtyLabel.TabIndex = 1;
            SpecialtyLabel.Text = "Especialidad";
            // 
            // SpecialtyTeacherCourseComboBox
            // 
            SpecialtyTeacherCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialtyTeacherCourseComboBox.DropDownWidth = 280;
            SpecialtyTeacherCourseComboBox.FormattingEnabled = true;
            SpecialtyTeacherCourseComboBox.Location = new Point(116, 125);
            SpecialtyTeacherCourseComboBox.Name = "SpecialtyTeacherCourseComboBox";
            SpecialtyTeacherCourseComboBox.Size = new Size(166, 23);
            SpecialtyTeacherCourseComboBox.TabIndex = 2;
            SpecialtyTeacherCourseComboBox.SelectedIndexChanged += SpecialtyTeacherCourseComboBox_SelectedIndexChanged;
            // 
            // PlanLabel
            // 
            PlanLabel.AutoSize = true;
            PlanLabel.Location = new Point(300, 128);
            PlanLabel.Name = "PlanLabel";
            PlanLabel.Size = new Size(30, 15);
            PlanLabel.TabIndex = 8;
            PlanLabel.Text = "Plan";
            // 
            // PlanTeacherCourseComboBox
            // 
            PlanTeacherCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlanTeacherCourseComboBox.DropDownWidth = 280;
            PlanTeacherCourseComboBox.Enabled = false;
            PlanTeacherCourseComboBox.FormattingEnabled = true;
            PlanTeacherCourseComboBox.Location = new Point(336, 125);
            PlanTeacherCourseComboBox.Name = "PlanTeacherCourseComboBox";
            PlanTeacherCourseComboBox.Size = new Size(67, 23);
            PlanTeacherCourseComboBox.TabIndex = 3;
            PlanTeacherCourseComboBox.SelectedIndexChanged += PlanTeacherCourseComboBox_SelectedIndexChanged;
            // 
            // SectionLabel
            // 
            SectionLabel.AutoSize = true;
            SectionLabel.Location = new Point(52, 186);
            SectionLabel.Name = "SectionLabel";
            SectionLabel.Size = new Size(58, 15);
            SectionLabel.TabIndex = 9;
            SectionLabel.Text = "Comisión";
            // 
            // SectionTeacherCourseComboBox
            // 
            SectionTeacherCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionTeacherCourseComboBox.DropDownWidth = 280;
            SectionTeacherCourseComboBox.Enabled = false;
            SectionTeacherCourseComboBox.FormattingEnabled = true;
            SectionTeacherCourseComboBox.Location = new Point(116, 183);
            SectionTeacherCourseComboBox.Name = "SectionTeacherCourseComboBox";
            SectionTeacherCourseComboBox.Size = new Size(115, 23);
            SectionTeacherCourseComboBox.TabIndex = 4;
            SectionTeacherCourseComboBox.SelectedIndexChanged += Subject_Section_TeacherCourseComboBox_SelectedIndexChanged;
            // 
            // SubjectLabel
            // 
            SubjectLabel.AutoSize = true;
            SubjectLabel.Location = new Point(63, 157);
            SubjectLabel.Name = "SubjectLabel";
            SubjectLabel.Size = new Size(47, 15);
            SubjectLabel.TabIndex = 10;
            SubjectLabel.Text = "Materia";
            // 
            // SubjectTeacherCourseComboBox
            // 
            SubjectTeacherCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectTeacherCourseComboBox.DropDownWidth = 280;
            SubjectTeacherCourseComboBox.Enabled = false;
            SubjectTeacherCourseComboBox.FormattingEnabled = true;
            SubjectTeacherCourseComboBox.Location = new Point(116, 154);
            SubjectTeacherCourseComboBox.Name = "SubjectTeacherCourseComboBox";
            SubjectTeacherCourseComboBox.Size = new Size(287, 23);
            SubjectTeacherCourseComboBox.TabIndex = 5;
            SubjectTeacherCourseComboBox.SelectedIndexChanged += Subject_Section_TeacherCourseComboBox_SelectedIndexChanged;
            // 
            // TeacherLabel
            // 
            TeacherLabel.AutoSize = true;
            TeacherLabel.Location = new Point(59, 218);
            TeacherLabel.Name = "TeacherLabel";
            TeacherLabel.Size = new Size(51, 15);
            TeacherLabel.TabIndex = 20;
            TeacherLabel.Text = "Docente";
            // 
            // TeacherTeacherCourseComboBox
            // 
            TeacherTeacherCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeacherTeacherCourseComboBox.DropDownWidth = 280;
            TeacherTeacherCourseComboBox.Location = new Point(116, 215);
            TeacherTeacherCourseComboBox.Name = "TeacherTeacherCourseComboBox";
            TeacherTeacherCourseComboBox.Size = new Size(287, 23);
            TeacherTeacherCourseComboBox.TabIndex = 21;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Location = new Point(244, 186);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(38, 15);
            CourseLabel.TabIndex = 22;
            CourseLabel.Text = "Curso";
            // 
            // CourseTeacherCourseComboBox
            // 
            CourseTeacherCourseComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseTeacherCourseComboBox.DropDownWidth = 280;
            CourseTeacherCourseComboBox.Enabled = false;
            CourseTeacherCourseComboBox.FormattingEnabled = true;
            CourseTeacherCourseComboBox.Location = new Point(288, 183);
            CourseTeacherCourseComboBox.Name = "CourseTeacherCourseComboBox";
            CourseTeacherCourseComboBox.Size = new Size(115, 23);
            CourseTeacherCourseComboBox.TabIndex = 23;
            // 
            // TeacherCourseIDLabel
            // 
            TeacherCourseIDLabel.AutoSize = true;
            TeacherCourseIDLabel.Location = new Point(92, 42);
            TeacherCourseIDLabel.Name = "TeacherCourseIDLabel";
            TeacherCourseIDLabel.Size = new Size(18, 15);
            TeacherCourseIDLabel.TabIndex = 7;
            TeacherCourseIDLabel.Text = "ID";
            // 
            // TeacherCourseIDTextBox
            // 
            TeacherCourseIDTextBox.Enabled = false;
            TeacherCourseIDTextBox.Location = new Point(116, 39);
            TeacherCourseIDTextBox.Name = "TeacherCourseIDTextBox";
            TeacherCourseIDTextBox.Size = new Size(287, 23);
            TeacherCourseIDTextBox.TabIndex = 17;
            // 
            // TeacherCourseStateLabel
            // 
            TeacherCourseStateLabel.AutoSize = true;
            TeacherCourseStateLabel.Location = new Point(68, 71);
            TeacherCourseStateLabel.Name = "TeacherCourseStateLabel";
            TeacherCourseStateLabel.Size = new Size(42, 15);
            TeacherCourseStateLabel.TabIndex = 16;
            TeacherCourseStateLabel.Text = "Estado";
            // 
            // TeacherCourseStateTextBox
            // 
            TeacherCourseStateTextBox.Enabled = false;
            TeacherCourseStateTextBox.Location = new Point(116, 68);
            TeacherCourseStateTextBox.Name = "TeacherCourseStateTextBox";
            TeacherCourseStateTextBox.Size = new Size(287, 23);
            TeacherCourseStateTextBox.TabIndex = 11;
            // 
            // TeacherCourseRoleLabel
            // 
            TeacherCourseRoleLabel.AutoSize = true;
            TeacherCourseRoleLabel.Location = new Point(86, 99);
            TeacherCourseRoleLabel.Name = "TeacherCourseRoleLabel";
            TeacherCourseRoleLabel.Size = new Size(24, 15);
            TeacherCourseRoleLabel.TabIndex = 7;
            TeacherCourseRoleLabel.Text = "Rol";
            // 
            // TeacherCourseRoleComboBox
            // 
            TeacherCourseRoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeacherCourseRoleComboBox.DropDownWidth = 280;
            TeacherCourseRoleComboBox.FormattingEnabled = true;
            TeacherCourseRoleComboBox.Location = new Point(116, 96);
            TeacherCourseRoleComboBox.Name = "TeacherCourseRoleComboBox";
            TeacherCourseRoleComboBox.Size = new Size(287, 23);
            TeacherCourseRoleComboBox.TabIndex = 12;
            // 
            // cancelTeacherCourseButton
            // 
            cancelTeacherCourseButton.Location = new Point(304, 276);
            cancelTeacherCourseButton.Name = "cancelTeacherCourseButton";
            cancelTeacherCourseButton.Size = new Size(99, 40);
            cancelTeacherCourseButton.TabIndex = 19;
            cancelTeacherCourseButton.Text = "Cancelar";
            cancelTeacherCourseButton.UseVisualStyleBackColor = true;
            cancelTeacherCourseButton.Click += cancelTeacherCourseButton_Click;
            // 
            // acceptTeacherCourseButton
            // 
            acceptTeacherCourseButton.Location = new Point(183, 276);
            acceptTeacherCourseButton.Name = "acceptTeacherCourseButton";
            acceptTeacherCourseButton.Size = new Size(99, 40);
            acceptTeacherCourseButton.TabIndex = 18;
            acceptTeacherCourseButton.Text = "Aceptar";
            acceptTeacherCourseButton.UseVisualStyleBackColor = true;
            acceptTeacherCourseButton.Click += acceptTeacherCourseButton_Click;
            // 
            // TeacherCourseErrorProvider
            // 
            TeacherCourseErrorProvider.ContainerControl = this;
            // 
            // TeacherCourseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 330);
            Controls.Add(SpecialtyLabel);
            Controls.Add(SpecialtyTeacherCourseComboBox);
            Controls.Add(PlanLabel);
            Controls.Add(PlanTeacherCourseComboBox);
            Controls.Add(SectionLabel);
            Controls.Add(SectionTeacherCourseComboBox);
            Controls.Add(SubjectLabel);
            Controls.Add(SubjectTeacherCourseComboBox);
            Controls.Add(TeacherLabel);
            Controls.Add(TeacherTeacherCourseComboBox);
            Controls.Add(CourseLabel);
            Controls.Add(CourseTeacherCourseComboBox);
            Controls.Add(TeacherCourseIDLabel);
            Controls.Add(TeacherCourseIDTextBox);
            Controls.Add(TeacherCourseStateLabel);
            Controls.Add(TeacherCourseStateTextBox);
            Controls.Add(TeacherCourseRoleLabel);
            Controls.Add(TeacherCourseRoleComboBox);
            Controls.Add(cancelTeacherCourseButton);
            Controls.Add(acceptTeacherCourseButton);
            Name = "TeacherCourseDetail";
            Text = "Detalle de Docente-Curso";
            ((System.ComponentModel.ISupportInitialize)TeacherCourseErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SpecialtyLabel;

        private ComboBox SpecialtyTeacherCourseComboBox;
        private Label PlanLabel;
        private ComboBox PlanTeacherCourseComboBox;
        private Label SectionLabel;
        private ComboBox SectionTeacherCourseComboBox;
        private Label SubjectLabel;
        private ComboBox SubjectTeacherCourseComboBox;

        private Label TeacherLabel;
        private ComboBox TeacherTeacherCourseComboBox;
        private Label CourseLabel;
        private ComboBox CourseTeacherCourseComboBox;

        private Label TeacherCourseIDLabel;
        private TextBox TeacherCourseIDTextBox;
        private Label TeacherCourseStateLabel;
        private TextBox TeacherCourseStateTextBox;
        private Label TeacherCourseRoleLabel;
        private ComboBox TeacherCourseRoleComboBox;
        private Button cancelTeacherCourseButton;
        private Button acceptTeacherCourseButton;
        private ErrorProvider TeacherCourseErrorProvider;
    }
}