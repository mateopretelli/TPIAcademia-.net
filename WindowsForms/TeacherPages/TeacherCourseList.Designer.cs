namespace WindowsForms.TeacherPages
{
    partial class TeacherCourseList
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
            TeacherCoursesLabel = new Label();
            TeacherCoursesGrid = new DataGridView();
            SelectCourseGradeButton = new Button();
            CoursesByTeacherBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TeacherCoursesGrid).BeginInit();
            SuspendLayout();
            // 
            // TeacherCoursesLabel
            // 
            TeacherCoursesLabel.AutoSize = true;
            TeacherCoursesLabel.Font = new Font("Segoe UI", 20F);
            TeacherCoursesLabel.Location = new Point(12, 9);
            TeacherCoursesLabel.Name = "TeacherCoursesLabel";
            TeacherCoursesLabel.Size = new Size(189, 37);
            TeacherCoursesLabel.TabIndex = 0;
            TeacherCoursesLabel.Text = "Lista de cursos";
            // 
            // TeacherCoursesGrid
            // 
            TeacherCoursesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeacherCoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherCoursesGrid.Location = new Point(12, 53);
            TeacherCoursesGrid.Name = "TeacherCoursesGrid";
            TeacherCoursesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TeacherCoursesGrid.Size = new Size(776, 329);
            TeacherCoursesGrid.TabIndex = 1;
            // 
            // SelectCourseGradeButton
            // 
            SelectCourseGradeButton.Enabled = false;
            SelectCourseGradeButton.Font = new Font("Segoe UI", 12F);
            SelectCourseGradeButton.Location = new Point(618, 388);
            SelectCourseGradeButton.Name = "SelectCourseGradeButton";
            SelectCourseGradeButton.Size = new Size(170, 59);
            SelectCourseGradeButton.TabIndex = 2;
            SelectCourseGradeButton.Text = "Seleccionar Curso";
            SelectCourseGradeButton.UseVisualStyleBackColor = true;
            SelectCourseGradeButton.Click += SelectCourseGradeButton_Click;
            // 
            // CoursesByTeacherBackButton
            // 
            CoursesByTeacherBackButton.Font = new Font("Segoe UI", 12F);
            CoursesByTeacherBackButton.Location = new Point(12, 388);
            CoursesByTeacherBackButton.Name = "CoursesByTeacherBackButton";
            CoursesByTeacherBackButton.Size = new Size(170, 59);
            CoursesByTeacherBackButton.TabIndex = 3;
            CoursesByTeacherBackButton.Text = "Volver al Menú";
            CoursesByTeacherBackButton.UseVisualStyleBackColor = true;
            CoursesByTeacherBackButton.Click += CoursesByTeacherBackButton_Click;
            // 
            // TeacherCourseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CoursesByTeacherBackButton);
            Controls.Add(SelectCourseGradeButton);
            Controls.Add(TeacherCoursesGrid);
            Controls.Add(TeacherCoursesLabel);
            Name = "TeacherCourseList";
            Text = "Lista de cursos";
            ((System.ComponentModel.ISupportInitialize)TeacherCoursesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TeacherCoursesLabel;
        private DataGridView TeacherCoursesGrid;
        private Button SelectCourseGradeButton;
        private Button CoursesByTeacherBackButton;
    }
}