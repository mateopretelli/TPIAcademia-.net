namespace WindowsForms.Home
{
    partial class TeacherHome
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
            GradesReportButton = new Button();
            UploadGradesButton = new Button();
            TeacherLogoutButton = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(TeacherLogoutButton, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(GradesReportButton, 0, 2);
            tableLayoutPanel2.Controls.Add(UploadGradesButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 309);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // GradesReportButton
            // 
            GradesReportButton.Anchor = AnchorStyles.None;
            GradesReportButton.Font = new Font("Segoe UI", 15F);
            GradesReportButton.Location = new Point(203, 164);
            GradesReportButton.Name = "GradesReportButton";
            GradesReportButton.Size = new Size(387, 57);
            GradesReportButton.TabIndex = 1;
            GradesReportButton.Text = "Reporte Notas";
            GradesReportButton.UseVisualStyleBackColor = true;
            // 
            // UploadGradesButton
            // 
            UploadGradesButton.Anchor = AnchorStyles.None;
            UploadGradesButton.Font = new Font("Segoe UI", 15F);
            UploadGradesButton.Location = new Point(206, 85);
            UploadGradesButton.Name = "UploadGradesButton";
            UploadGradesButton.Size = new Size(382, 61);
            UploadGradesButton.TabIndex = 0;
            UploadGradesButton.Text = "Cargar notas por curso";
            UploadGradesButton.UseVisualStyleBackColor = true;
            // 
            // TeacherLogoutButton
            // 
            TeacherLogoutButton.Anchor = AnchorStyles.None;
            TeacherLogoutButton.Font = new Font("Segoe UI", 15F);
            TeacherLogoutButton.Location = new Point(285, 378);
            TeacherLogoutButton.Name = "TeacherLogoutButton";
            TeacherLogoutButton.Size = new Size(230, 53);
            TeacherLogoutButton.TabIndex = 2;
            TeacherLogoutButton.Text = "Cerrar Sesión";
            TeacherLogoutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(279, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 45);
            label1.TabIndex = 3;
            label1.Text = "Menu Profesor";
            // 
            // TeacherHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "TeacherHome";
            Text = "Sistema de Gestión Académica";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button TeacherLogoutButton;
        private Button UploadGradesButton;
        private Button GradesReportButton;
        private Label label1;
    }
}