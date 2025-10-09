namespace WindowsForms.Home
{
    partial class StudentHome
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
            tableLayoutPanel2 = new TableLayoutPanel();
            StudentSubjectsPlanButton = new Button();
            StudentInscriptionButton = new Button();
            StudentSubjectsGradeButton = new Button();
            label1 = new Label();
            AdminLogoutButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(AdminLogoutButton, 0, 2);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(StudentSubjectsPlanButton, 0, 0);
            tableLayoutPanel2.Controls.Add(StudentInscriptionButton, 0, 1);
            tableLayoutPanel2.Controls.Add(StudentSubjectsGradeButton, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 70);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(794, 309);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // StudentSubjectsPlanButton
            // 
            StudentSubjectsPlanButton.Anchor = AnchorStyles.None;
            StudentSubjectsPlanButton.Location = new Point(137, 11);
            StudentSubjectsPlanButton.Name = "StudentSubjectsPlanButton";
            StudentSubjectsPlanButton.Size = new Size(520, 80);
            StudentSubjectsPlanButton.TabIndex = 0;
            StudentSubjectsPlanButton.Text = "Materias del plan";
            StudentSubjectsPlanButton.UseVisualStyleBackColor = true;
            // 
            // StudentInscriptionButton
            // 
            StudentInscriptionButton.Anchor = AnchorStyles.None;
            StudentInscriptionButton.Location = new Point(137, 114);
            StudentInscriptionButton.Name = "StudentInscriptionButton";
            StudentInscriptionButton.Size = new Size(520, 80);
            StudentInscriptionButton.TabIndex = 1;
            StudentInscriptionButton.Text = "Inscripción a cursado";
            StudentInscriptionButton.UseVisualStyleBackColor = true;
            // 
            // StudentSubjectsGradeButton
            // 
            StudentSubjectsGradeButton.Anchor = AnchorStyles.None;
            StudentSubjectsGradeButton.Location = new Point(137, 217);
            StudentSubjectsGradeButton.Name = "StudentSubjectsGradeButton";
            StudentSubjectsGradeButton.Size = new Size(520, 80);
            StudentSubjectsGradeButton.TabIndex = 2;
            StudentSubjectsGradeButton.Text = "Materias / Notas";
            StudentSubjectsGradeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(283, 10);
            label1.Name = "label1";
            label1.Size = new Size(233, 46);
            label1.TabIndex = 1;
            label1.Text = "Menu Alumno";
            // 
            // AdminLogoutButton
            // 
            AdminLogoutButton.Anchor = AnchorStyles.None;
            AdminLogoutButton.Font = new Font("Segoe UI", 15F);
            AdminLogoutButton.Location = new Point(295, 389);
            AdminLogoutButton.Name = "AdminLogoutButton";
            AdminLogoutButton.Size = new Size(209, 53);
            AdminLogoutButton.TabIndex = 2;
            AdminLogoutButton.Text = "Cerrar Sesión";
            AdminLogoutButton.UseVisualStyleBackColor = true;
            AdminLogoutButton.Click += AdminLogoutButton_Click;
            // 
            // StudentHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentHome";
            Text = "Sistema de Gestión Académica";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AdminLogoutButton;
        private Button StudentSubjectsPlanButton;
        private Button StudentInscriptionButton;
        private Button StudentSubjectsGradeButton;
    }
}