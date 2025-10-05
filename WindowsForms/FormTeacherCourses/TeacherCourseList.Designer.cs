namespace WindowsForms.FormTeacherCourse
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
            panelTeacherCourse = new Panel();
            TeachersCoursesDataGridView = new DataGridView();
            TeacherCourseHomeButton = new Button();
            updateTeacherCourseButton = new Button();
            deleteTeacherCourseButton = new Button();
            addTeacherCourseButton = new Button();
            SearchTeacherCourseTextBox = new TextBox();
            SearchTeacherCourseButton = new Button();
            panelTeacherCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeachersCoursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelTeacherCourse
            // 
            panelTeacherCourse.Controls.Add(TeachersCoursesDataGridView);
            panelTeacherCourse.Location = new Point(12, 40);
            panelTeacherCourse.Name = "panelTeacherCourse";
            panelTeacherCourse.Size = new Size(776, 331);
            panelTeacherCourse.TabIndex = 0;
            // 
            // TeachersCoursesDataGridView
            // 
            TeachersCoursesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeachersCoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeachersCoursesDataGridView.Dock = DockStyle.Fill;
            TeachersCoursesDataGridView.Location = new Point(0, 0);
            TeachersCoursesDataGridView.MultiSelect = false;
            TeachersCoursesDataGridView.Name = "TeachersCoursesDataGridView";
            TeachersCoursesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TeachersCoursesDataGridView.Size = new Size(776, 331);
            TeachersCoursesDataGridView.TabIndex = 0;
            // 
            // TeacherCourseHomeButton
            // 
            TeacherCourseHomeButton.Location = new Point(12, 384);
            TeacherCourseHomeButton.Name = "TeacherCourseHomeButton";
            TeacherCourseHomeButton.Size = new Size(144, 54);
            TeacherCourseHomeButton.TabIndex = 1;
            TeacherCourseHomeButton.Text = "Volver al Menú";
            TeacherCourseHomeButton.UseVisualStyleBackColor = true;
            TeacherCourseHomeButton.Click += TeacherCourseHomeButton_Click;
            // 
            // updateTeacherCourseButton
            // 
            updateTeacherCourseButton.Location = new Point(704, 384);
            updateTeacherCourseButton.Name = "updateTeacherCourseButton";
            updateTeacherCourseButton.Size = new Size(84, 54);
            updateTeacherCourseButton.TabIndex = 2;
            updateTeacherCourseButton.Text = "Modificar";
            updateTeacherCourseButton.UseVisualStyleBackColor = true;
            updateTeacherCourseButton.Click += updateTeacherCourseButton_Click;
            // 
            // deleteTeacherCourseButton
            // 
            deleteTeacherCourseButton.Location = new Point(614, 384);
            deleteTeacherCourseButton.Name = "deleteTeacherCourseButton";
            deleteTeacherCourseButton.Size = new Size(84, 54);
            deleteTeacherCourseButton.TabIndex = 3;
            deleteTeacherCourseButton.Text = "Eliminar";
            deleteTeacherCourseButton.UseVisualStyleBackColor = true;
            deleteTeacherCourseButton.Click += deleteTeacherCourseButton_Click;
            // 
            // addTeacherCourseButton
            // 
            addTeacherCourseButton.Location = new Point(524, 384);
            addTeacherCourseButton.Name = "addTeacherCourseButton";
            addTeacherCourseButton.Size = new Size(84, 54);
            addTeacherCourseButton.TabIndex = 4;
            addTeacherCourseButton.Text = "Agregar";
            addTeacherCourseButton.UseVisualStyleBackColor = true;
            addTeacherCourseButton.Click += AddTeacherCourseButton_Click;
            // 
            // SearchTeacherCourseTextBox
            // 
            SearchTeacherCourseTextBox.Location = new Point(12, 11);
            SearchTeacherCourseTextBox.Name = "SearchTeacherCourseTextBox";
            SearchTeacherCourseTextBox.PlaceholderText = "Buscar curso por nombre o apellido del docente o por rol";
            SearchTeacherCourseTextBox.Size = new Size(338, 23);
            SearchTeacherCourseTextBox.TabIndex = 5;
            // 
            // SearchTeacherCourseButton
            // 
            SearchTeacherCourseButton.Location = new Point(356, 11);
            SearchTeacherCourseButton.Name = "SearchTeacherCourseButton";
            SearchTeacherCourseButton.Size = new Size(75, 24);
            SearchTeacherCourseButton.TabIndex = 6;
            SearchTeacherCourseButton.Text = "Buscar";
            SearchTeacherCourseButton.UseVisualStyleBackColor = true;
            // 
            // TeacherCourseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchTeacherCourseButton);
            Controls.Add(SearchTeacherCourseTextBox);
            Controls.Add(addTeacherCourseButton);
            Controls.Add(deleteTeacherCourseButton);
            Controls.Add(updateTeacherCourseButton);
            Controls.Add(TeacherCourseHomeButton);
            Controls.Add(panelTeacherCourse);
            Name = "TeacherCourseList";
            Text = "Lista de Docentes por cursos";
            Load += TeachersCourses_Load;
            panelTeacherCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TeachersCoursesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTeacherCourse;
        private DataGridView TeachersCoursesDataGridView;
        private Button TeacherCourseHomeButton;
        private Button updateTeacherCourseButton;
        private Button deleteTeacherCourseButton;
        private Button addTeacherCourseButton;
        private TextBox SearchTeacherCourseTextBox;
        private Button SearchTeacherCourseButton;
    }
}