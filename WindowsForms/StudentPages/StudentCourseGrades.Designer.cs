namespace WindowsForms.StudentPages
{
    partial class StudentCourseGrades
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
            tableLayoutPanel1 = new TableLayoutPanel();
            studentCourseGradesGrid = new DataGridView();
            StudentCourseGradesLabel = new Label();
            StudentCourseGradesBackButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentCourseGradesGrid).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(studentCourseGradesGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(StudentCourseGradesLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(StudentCourseGradesBackButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // studentCourseGradesGrid
            // 
            studentCourseGradesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentCourseGradesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentCourseGradesGrid.Dock = DockStyle.Fill;
            studentCourseGradesGrid.Location = new Point(3, 70);
            studentCourseGradesGrid.Name = "studentCourseGradesGrid";
            studentCourseGradesGrid.ReadOnly = true;
            studentCourseGradesGrid.Size = new Size(794, 309);
            studentCourseGradesGrid.TabIndex = 0;
            // 
            // StudentCourseGradesLabel
            // 
            StudentCourseGradesLabel.Anchor = AnchorStyles.None;
            StudentCourseGradesLabel.AutoSize = true;
            StudentCourseGradesLabel.Font = new Font("Segoe UI", 20F);
            StudentCourseGradesLabel.Location = new Point(286, 15);
            StudentCourseGradesLabel.Name = "StudentCourseGradesLabel";
            StudentCourseGradesLabel.Size = new Size(228, 37);
            StudentCourseGradesLabel.TabIndex = 1;
            StudentCourseGradesLabel.Text = "Notas del alumno";
            // 
            // StudentCourseGradesBackButton
            // 
            StudentCourseGradesBackButton.Font = new Font("Segoe UI", 15F);
            StudentCourseGradesBackButton.Location = new Point(3, 385);
            StudentCourseGradesBackButton.Name = "StudentCourseGradesBackButton";
            StudentCourseGradesBackButton.Size = new Size(166, 62);
            StudentCourseGradesBackButton.TabIndex = 2;
            StudentCourseGradesBackButton.Text = "Volver atrás";
            StudentCourseGradesBackButton.UseVisualStyleBackColor = true;
            StudentCourseGradesBackButton.Click += StudentCourseGradesBackButton_Click;
            // 
            // StudentCourseGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentCourseGrades";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentCourseGradesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView studentCourseGradesGrid;
        private Label StudentCourseGradesLabel;
        private Button StudentCourseGradesBackButton;
    }
}