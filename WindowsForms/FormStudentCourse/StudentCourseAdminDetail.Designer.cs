namespace WindowsForms.FormStudentCourse
{
    partial class StudentCourseAdminDetail
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
            ((System.ComponentModel.ISupportInitialize)CourseGridView).BeginInit();
            SuspendLayout();
            // 
            // LegajoLabel
            // 
            LegajoLabel.AutoSize = true;
            LegajoLabel.Location = new Point(31, 43);
            LegajoLabel.Name = "LegajoLabel";
            LegajoLabel.Size = new Size(57, 20);
            LegajoLabel.TabIndex = 0;
            LegajoLabel.Text = "Legajo:";
            // 
            // LegajoTextBox
            // 
            LegajoTextBox.Location = new Point(123, 43);
            LegajoTextBox.Name = "LegajoTextBox";
            LegajoTextBox.Size = new Size(279, 26);
            LegajoTextBox.TabIndex = 1;
            LegajoTextBox.TextChanged += LegajoTextBox_TextChanged;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Location = new Point(31, 97);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(49, 20);
            CourseLabel.TabIndex = 2;
            CourseLabel.Text = "Curso:";
            // 
            // CourseTextBox
            // 
            CourseTextBox.Location = new Point(123, 99);
            CourseTextBox.Name = "CourseTextBox";
            CourseTextBox.Size = new Size(279, 26);
            CourseTextBox.PlaceholderText = "Buscar materia por descripcion";
            CourseTextBox.TabIndex = 3;
            // 
            // CourseGridView
            // 
            CourseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseGridView.Location = new Point(31, 152);
            CourseGridView.Name = "CourseGridView";
            CourseGridView.RowHeadersWidth = 49;
            CourseGridView.Size = new Size(737, 225);
            CourseGridView.TabIndex = 4;
            // 
            // SearchCourseButton
            // 
            SearchCourseButton.Location = new Point(427, 99);
            SearchCourseButton.Name = "SearchCourseButton";
            SearchCourseButton.Size = new Size(90, 28);
            SearchCourseButton.TabIndex = 5;
            SearchCourseButton.Text = "Buscar";
            SearchCourseButton.UseVisualStyleBackColor = true;
            SearchCourseButton.Click += SearchCourseButton_Click;
            // 
            // AddInscriptionButton
            // 
            AddInscriptionButton.Location = new Point(588, 398);
            AddInscriptionButton.Name = "AddInscriptionButton";
            AddInscriptionButton.Size = new Size(180, 40);
            AddInscriptionButton.TabIndex = 6;
            AddInscriptionButton.Text = "Añadir inscripcion";
            AddInscriptionButton.UseVisualStyleBackColor = true;
            SearchCourseButton.Click += AddInscriptionButton_Click;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(31, 398);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(180, 40);
            SelectButton.TabIndex = 7;
            SelectButton.Text = "Seleccionar";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // StudentCourseAdminDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectButton);
            Controls.Add(AddInscriptionButton);
            Controls.Add(SearchCourseButton);
            Controls.Add(CourseGridView);
            Controls.Add(CourseTextBox);
            Controls.Add(CourseLabel);
            Controls.Add(LegajoTextBox);
            Controls.Add(LegajoLabel);
            Name = "StudentCourseAdminDetail";
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
    }
}