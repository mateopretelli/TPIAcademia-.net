namespace WindowsForms.TeacherPages
{
    partial class StudentCourseDetail
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            UpdateStudentCourse = new Button();
            StudentCourseDetailBackButton = new Button();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label5 = new Label();
            studentGradeTextBox = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            studentEmailTextBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            studentLastNameTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            studentNameTextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            StudentConditionComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(470, 482);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(UpdateStudentCourse, 1, 0);
            tableLayoutPanel2.Controls.Add(StudentCourseDetailBackButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 412);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(464, 67);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // UpdateStudentCourse
            // 
            UpdateStudentCourse.Anchor = AnchorStyles.Right;
            UpdateStudentCourse.Location = new Point(284, 8);
            UpdateStudentCourse.Name = "UpdateStudentCourse";
            UpdateStudentCourse.Size = new Size(177, 51);
            UpdateStudentCourse.TabIndex = 0;
            UpdateStudentCourse.Text = "Modificar";
            UpdateStudentCourse.UseVisualStyleBackColor = true;
            UpdateStudentCourse.Click += UpdateStudentCourse_Click;
            // 
            // StudentCourseDetailBackButton
            // 
            StudentCourseDetailBackButton.Anchor = AnchorStyles.Left;
            StudentCourseDetailBackButton.Location = new Point(3, 8);
            StudentCourseDetailBackButton.Name = "StudentCourseDetailBackButton";
            StudentCourseDetailBackButton.Size = new Size(177, 51);
            StudentCourseDetailBackButton.TabIndex = 1;
            StudentCourseDetailBackButton.Text = "Volver atrás";
            StudentCourseDetailBackButton.UseVisualStyleBackColor = true;
            StudentCourseDetailBackButton.Click += StudentCourseDetailBackButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(92, 10);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 1;
            label1.Text = "Actualizar estado de estudiante";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel3.Location = new Point(3, 51);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(464, 355);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Controls.Add(StudentConditionComboBox, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 287);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(458, 65);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(47, 22);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 0;
            label6.Text = "Condición";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel7.Controls.Add(label5, 0, 0);
            tableLayoutPanel7.Controls.Add(studentGradeTextBox, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 216);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(458, 65);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(83, 22);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 0;
            label5.Text = "Nota";
            // 
            // studentGradeTextBox
            // 
            studentGradeTextBox.Anchor = AnchorStyles.Left;
            studentGradeTextBox.Location = new Point(133, 18);
            studentGradeTextBox.Name = "studentGradeTextBox";
            studentGradeTextBox.Size = new Size(292, 29);
            studentGradeTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(studentEmailTextBox, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 145);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(458, 65);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(79, 22);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // studentEmailTextBox
            // 
            studentEmailTextBox.Anchor = AnchorStyles.Left;
            studentEmailTextBox.Enabled = false;
            studentEmailTextBox.Location = new Point(133, 18);
            studentEmailTextBox.Name = "studentEmailTextBox";
            studentEmailTextBox.Size = new Size(292, 29);
            studentEmailTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(studentLastNameTextBox, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 74);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(458, 65);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 22);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 0;
            label3.Text = "Apellido";
            // 
            // studentLastNameTextBox
            // 
            studentLastNameTextBox.Anchor = AnchorStyles.Left;
            studentLastNameTextBox.Enabled = false;
            studentLastNameTextBox.Location = new Point(133, 18);
            studentLastNameTextBox.Name = "studentLastNameTextBox";
            studentLastNameTextBox.Size = new Size(292, 29);
            studentLastNameTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(studentNameTextBox, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(458, 65);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 22);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Anchor = AnchorStyles.Left;
            studentNameTextBox.Enabled = false;
            studentNameTextBox.Location = new Point(133, 18);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(292, 29);
            studentNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // StudentConditionComboBox
            // 
            StudentConditionComboBox.Anchor = AnchorStyles.Left;
            StudentConditionComboBox.FormattingEnabled = true;
            StudentConditionComboBox.Location = new Point(133, 21);
            StudentConditionComboBox.Name = "StudentConditionComboBox";
            StudentConditionComboBox.Size = new Size(292, 29);
            StudentConditionComboBox.TabIndex = 1;
            // 
            // StudentCourseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 482);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentCourseDetail";
            Text = "Detalle Estudiante";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button UpdateStudentCourse;
        private Button StudentCourseDetailBackButton;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox studentGradeTextBox;
        private TextBox studentEmailTextBox;
        private TextBox studentLastNameTextBox;
        private TextBox studentNameTextBox;
        private ErrorProvider errorProvider1;
        private ComboBox StudentConditionComboBox;
    }
}