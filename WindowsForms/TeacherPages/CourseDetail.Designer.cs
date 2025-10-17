namespace WindowsForms.TeacherPages
{
    partial class CourseDetail
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
            CourseDetailinfoGrid = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            CourseDetailBackButton = new Button();
            CourseReportButton = new Button();
            SelectStudentButton = new Button();
            CourseDetailInfoLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDetailinfoGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(CourseDetailinfoGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(CourseDetailInfoLabel, 0, 0);
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
            // CourseDetailinfoGrid
            // 
            CourseDetailinfoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CourseDetailinfoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDetailinfoGrid.Dock = DockStyle.Fill;
            CourseDetailinfoGrid.Location = new Point(3, 70);
            CourseDetailinfoGrid.Name = "CourseDetailinfoGrid";
            CourseDetailinfoGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CourseDetailinfoGrid.Size = new Size(794, 309);
            CourseDetailinfoGrid.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(CourseDetailBackButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CourseReportButton, 1, 0);
            tableLayoutPanel2.Controls.Add(SelectStudentButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 385);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 62);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // CourseDetailBackButton
            // 
            CourseDetailBackButton.Anchor = AnchorStyles.Left;
            CourseDetailBackButton.Location = new Point(3, 4);
            CourseDetailBackButton.Name = "CourseDetailBackButton";
            CourseDetailBackButton.Size = new Size(196, 53);
            CourseDetailBackButton.TabIndex = 0;
            CourseDetailBackButton.Text = "Volver atrás";
            CourseDetailBackButton.UseVisualStyleBackColor = true;
            CourseDetailBackButton.Click += CourseDetailBackButton_Click;
            // 
            // CourseReportButton
            // 
            CourseReportButton.Anchor = AnchorStyles.None;
            CourseReportButton.Enabled = false;
            CourseReportButton.Location = new Point(298, 4);
            CourseReportButton.Name = "CourseReportButton";
            CourseReportButton.Size = new Size(196, 53);
            CourseReportButton.TabIndex = 1;
            CourseReportButton.Text = "Reporte Curso";
            CourseReportButton.UseVisualStyleBackColor = true;
            CourseReportButton.Click += CourseReportButton_Click;
            // 
            // SelectStudentButton
            // 
            SelectStudentButton.Anchor = AnchorStyles.Right;
            SelectStudentButton.Enabled = false;
            SelectStudentButton.Location = new Point(595, 4);
            SelectStudentButton.Name = "SelectStudentButton";
            SelectStudentButton.Size = new Size(196, 53);
            SelectStudentButton.TabIndex = 2;
            SelectStudentButton.Text = "Elegir Estudiante";
            SelectStudentButton.UseVisualStyleBackColor = true;
            SelectStudentButton.Click += SelectStudentButton_Click;
            // 
            // CourseDetailInfoLabel
            // 
            CourseDetailInfoLabel.Anchor = AnchorStyles.None;
            CourseDetailInfoLabel.AutoSize = true;
            CourseDetailInfoLabel.Font = new Font("Segoe UI", 18F);
            CourseDetailInfoLabel.Location = new Point(400, 17);
            CourseDetailInfoLabel.Name = "CourseDetailInfoLabel";
            CourseDetailInfoLabel.Size = new Size(0, 32);
            CourseDetailInfoLabel.TabIndex = 2;
            // 
            // CourseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CourseDetail";
            Text = "Detalle del Curso";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDetailinfoGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView CourseDetailinfoGrid;
        private TableLayoutPanel tableLayoutPanel2;
        private Label CourseDetailInfoLabel;
        private Button CourseDetailBackButton;
        private Button CourseReportButton;
        private Button SelectStudentButton;
    }
}