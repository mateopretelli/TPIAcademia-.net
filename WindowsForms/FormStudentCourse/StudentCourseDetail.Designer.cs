namespace WindowsForms.FormStudentCourse
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
            LegajoLabel = new Label();
            LegajoTextBox = new TextBox();
            CourseLabel = new Label();
            CourseTextBox = new TextBox();
            CourseGridView = new DataGridView();
            SearchCourseButton = new Button();
            AddInscriptionButton = new Button();
            SelectButton = new Button();
            StudentCouseHomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CourseGridView).BeginInit();
            SuspendLayout();
            // 
            // LegajoLabel
            // 
            LegajoLabel.AutoSize = true;
            LegajoLabel.Location = new Point(27, 34);
            LegajoLabel.Name = "LegajoLabel";
            LegajoLabel.Size = new Size(45, 15);
            LegajoLabel.TabIndex = 0;
            LegajoLabel.Text = "Legajo:";
            // 
            // LegajoTextBox
            // 
            LegajoTextBox.Location = new Point(108, 34);
            LegajoTextBox.Margin = new Padding(3, 2, 3, 2);
            LegajoTextBox.Name = "LegajoTextBox";
            LegajoTextBox.Size = new Size(245, 23);
            LegajoTextBox.TabIndex = 1;
            LegajoTextBox.TextChanged += LegajoTextBox_TextChanged;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Location = new Point(27, 77);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(41, 15);
            CourseLabel.TabIndex = 2;
            CourseLabel.Text = "Curso:";
            // 
            // CourseTextBox
            // 
            CourseTextBox.Location = new Point(108, 78);
            CourseTextBox.Margin = new Padding(3, 2, 3, 2);
            CourseTextBox.Name = "CourseTextBox";
            CourseTextBox.PlaceholderText = "Buscar materia por descripcion";
            CourseTextBox.Size = new Size(245, 23);
            CourseTextBox.TabIndex = 3;
            // 
            // CourseGridView
            // 
            CourseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseGridView.Location = new Point(27, 120);
            CourseGridView.Margin = new Padding(3, 2, 3, 2);
            CourseGridView.Name = "CourseGridView";
            CourseGridView.RowHeadersWidth = 49;
            CourseGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CourseGridView.Size = new Size(645, 178);
            CourseGridView.TabIndex = 4;
            // 
            // SearchCourseButton
            // 
            SearchCourseButton.Location = new Point(374, 78);
            SearchCourseButton.Margin = new Padding(3, 2, 3, 2);
            SearchCourseButton.Name = "SearchCourseButton";
            SearchCourseButton.Size = new Size(79, 22);
            SearchCourseButton.TabIndex = 5;
            SearchCourseButton.Text = "Buscar";
            SearchCourseButton.UseVisualStyleBackColor = true;
            SearchCourseButton.Click += SearchCourseButton_Click;
            // 
            // AddInscriptionButton
            // 
            AddInscriptionButton.Location = new Point(514, 314);
            AddInscriptionButton.Margin = new Padding(3, 2, 3, 2);
            AddInscriptionButton.Name = "AddInscriptionButton";
            AddInscriptionButton.Size = new Size(158, 32);
            AddInscriptionButton.TabIndex = 6;
            AddInscriptionButton.Text = "Añadir inscripcion";
            AddInscriptionButton.UseVisualStyleBackColor = true;
            AddInscriptionButton.Click += AddInscriptionButton_Click;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(350, 314);
            SelectButton.Margin = new Padding(3, 2, 3, 2);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(158, 32);
            SelectButton.TabIndex = 7;
            SelectButton.Text = "Seleccionar Materia";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // StudentCouseHomeButton
            // 
            StudentCouseHomeButton.Location = new Point(27, 314);
            StudentCouseHomeButton.Name = "StudentCouseHomeButton";
            StudentCouseHomeButton.Size = new Size(156, 29);
            StudentCouseHomeButton.TabIndex = 8;
            StudentCouseHomeButton.Text = "Volver al Menu";
            StudentCouseHomeButton.UseVisualStyleBackColor = true;
            StudentCouseHomeButton.Click += StudentCouseHomeButton_Click;
            // 
            // StudentCourseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 355);
            Controls.Add(StudentCouseHomeButton);
            Controls.Add(SelectButton);
            Controls.Add(AddInscriptionButton);
            Controls.Add(SearchCourseButton);
            Controls.Add(CourseGridView);
            Controls.Add(CourseTextBox);
            Controls.Add(CourseLabel);
            Controls.Add(LegajoTextBox);
            Controls.Add(LegajoLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentCourseDetail";
            Text = "StudentCourseDetail";
            Load += StudentCourseAdminDetail_Load;
            ((System.ComponentModel.ISupportInitialize)CourseGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LegajoLabel;
        private TextBox LegajoTextBox;
        private Label CourseLabel;
        private TextBox CourseTextBox;
        private DataGridView CourseGridView;
        private Button SearchCourseButton;
        private Button AddInscriptionButton;
        private Button SelectButton;
        private Button StudentCouseHomeButton;
    }
}