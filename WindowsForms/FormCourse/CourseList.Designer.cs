namespace WindowsForms.FormCourse
{
    partial class CourseList
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
            panelCourse = new Panel();
            CoursesDataGridView = new DataGridView();
            CourseHomeButton = new Button();
            updateCourseButton = new Button();
            deleteCourseButton = new Button();
            addCourseButton = new Button();
            SearchCourseTextBox = new TextBox();
            SearchCourseButton = new Button();
            panelCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelCourse
            // 
            panelCourse.Controls.Add(CoursesDataGridView);
            panelCourse.Location = new Point(12, 40);
            panelCourse.Name = "panelCourse";
            panelCourse.Size = new Size(776, 331);
            panelCourse.TabIndex = 0;
            // 
            // CoursesDataGridView
            // 
            CoursesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesDataGridView.Dock = DockStyle.Fill;
            CoursesDataGridView.Location = new Point(0, 0);
            CoursesDataGridView.MultiSelect = false;
            CoursesDataGridView.Name = "CoursesDataGridView";
            CoursesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CoursesDataGridView.Size = new Size(776, 331);
            CoursesDataGridView.TabIndex = 0;
            // 
            // CourseHomeButton
            // 
            CourseHomeButton.Location = new Point(12, 384);
            CourseHomeButton.Name = "CourseHomeButton";
            CourseHomeButton.Size = new Size(144, 54);
            CourseHomeButton.TabIndex = 1;
            CourseHomeButton.Text = "Volver al Menú";
            CourseHomeButton.UseVisualStyleBackColor = true;
            CourseHomeButton.Click += CourseHomeButton_Click;
            // 
            // updateCourseButton
            // 
            updateCourseButton.Location = new Point(704, 384);
            updateCourseButton.Name = "updateCourseButton";
            updateCourseButton.Size = new Size(84, 54);
            updateCourseButton.TabIndex = 2;
            updateCourseButton.Text = "Modificar";
            updateCourseButton.UseVisualStyleBackColor = true;
            updateCourseButton.Click += updateCourseButton_Click;
            // 
            // deleteCourseButton
            // 
            deleteCourseButton.Location = new Point(614, 384);
            deleteCourseButton.Name = "deleteCourseButton";
            deleteCourseButton.Size = new Size(84, 54);
            deleteCourseButton.TabIndex = 3;
            deleteCourseButton.Text = "Eliminar";
            deleteCourseButton.UseVisualStyleBackColor = true;
            deleteCourseButton.Click += deleteCourseButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(524, 384);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(84, 54);
            addCourseButton.TabIndex = 4;
            addCourseButton.Text = "Agregar";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += AddCourseButton_Click;
            // 
            // SearchCourseTextBox
            // 
            SearchCourseTextBox.Location = new Point(12, 11);
            SearchCourseTextBox.Name = "SearchCourseTextBox";
            SearchCourseTextBox.PlaceholderText = "Buscar curso por año, materia o comisión";
            SearchCourseTextBox.Size = new Size(338, 23);
            SearchCourseTextBox.TabIndex = 5;
            // 
            // SearchCourseButton
            // 
            SearchCourseButton.Location = new Point(356, 11);
            SearchCourseButton.Name = "SearchCourseButton";
            SearchCourseButton.Size = new Size(75, 24);
            SearchCourseButton.TabIndex = 6;
            SearchCourseButton.Text = "Buscar";
            SearchCourseButton.UseVisualStyleBackColor = true;
            // 
            // CourseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchCourseButton);
            Controls.Add(SearchCourseTextBox);
            Controls.Add(addCourseButton);
            Controls.Add(deleteCourseButton);
            Controls.Add(updateCourseButton);
            Controls.Add(CourseHomeButton);
            Controls.Add(panelCourse);
            Name = "CourseList";
            Text = "Lista de Cursos";
            Load += Courses_Load;
            panelCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CoursesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCourse;
        private DataGridView CoursesDataGridView;
        private Button CourseHomeButton;
        private Button updateCourseButton;
        private Button deleteCourseButton;
        private Button addCourseButton;
        private TextBox SearchCourseTextBox;
        private Button SearchCourseButton;
    }
}