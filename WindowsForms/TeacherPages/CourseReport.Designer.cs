namespace WindowsForms.TeacherPages
{
    partial class CourseReport
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
            courseTitleLabel = new Label();
            totalStudentsLabel = new Label();
            regularesLabel = new Label();
            aprobadosLabel = new Label();
            avgRegularesLabel = new Label();
            avgAprobadosLabel = new Label();
            conditionChart = new FastReport.DataVisualization.Charting.Chart();
            gradesChart = new FastReport.DataVisualization.Charting.Chart();
            gradeDistributionChart = new FastReport.DataVisualization.Charting.Chart();
            courseReportBackButton = new Button();
            inscriptosLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)conditionChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradesChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradeDistributionChart).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.Anchor = AnchorStyles.None;
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.Font = new Font("Segoe UI", 20F);
            courseTitleLabel.Location = new Point(504, 4);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new Size(224, 37);
            courseTitleLabel.TabIndex = 0;
            courseTitleLabel.Text = "Reporte del curso";
            // 
            // totalStudentsLabel
            // 
            totalStudentsLabel.Anchor = AnchorStyles.None;
            totalStudentsLabel.AutoSize = true;
            totalStudentsLabel.Font = new Font("Segoe UI", 12F);
            totalStudentsLabel.Location = new Point(544, 1);
            totalStudentsLabel.Name = "totalStudentsLabel";
            totalStudentsLabel.Size = new Size(138, 21);
            totalStudentsLabel.TabIndex = 1;
            totalStudentsLabel.Text = "totalStudentsLabel";
            // 
            // regularesLabel
            // 
            regularesLabel.Anchor = AnchorStyles.None;
            regularesLabel.AutoSize = true;
            regularesLabel.Font = new Font("Segoe UI", 12F);
            regularesLabel.Location = new Point(557, 25);
            regularesLabel.Name = "regularesLabel";
            regularesLabel.Size = new Size(112, 21);
            regularesLabel.TabIndex = 2;
            regularesLabel.Text = "regularesLabel";
            // 
            // aprobadosLabel
            // 
            aprobadosLabel.Anchor = AnchorStyles.None;
            aprobadosLabel.AutoSize = true;
            aprobadosLabel.Font = new Font("Segoe UI", 12F);
            aprobadosLabel.Location = new Point(553, 73);
            aprobadosLabel.Name = "aprobadosLabel";
            aprobadosLabel.Size = new Size(121, 21);
            aprobadosLabel.TabIndex = 3;
            aprobadosLabel.Text = "aprobadosLabel";
            // 
            // avgRegularesLabel
            // 
            avgRegularesLabel.Anchor = AnchorStyles.None;
            avgRegularesLabel.AutoSize = true;
            avgRegularesLabel.Font = new Font("Segoe UI", 12F);
            avgRegularesLabel.Location = new Point(543, 121);
            avgRegularesLabel.Name = "avgRegularesLabel";
            avgRegularesLabel.Size = new Size(141, 21);
            avgRegularesLabel.TabIndex = 5;
            avgRegularesLabel.Text = "avgRegularesLabel";
            // 
            // avgAprobadosLabel
            // 
            avgAprobadosLabel.Anchor = AnchorStyles.None;
            avgAprobadosLabel.AutoSize = true;
            avgAprobadosLabel.Font = new Font("Segoe UI", 12F);
            avgAprobadosLabel.Location = new Point(539, 148);
            avgAprobadosLabel.Name = "avgAprobadosLabel";
            avgAprobadosLabel.Size = new Size(148, 21);
            avgAprobadosLabel.TabIndex = 6;
            avgAprobadosLabel.Text = "avgAprobadosLabel";
            // 
            // conditionChart
            // 
            conditionChart.Dock = DockStyle.Fill;
            conditionChart.Location = new Point(3, 3);
            conditionChart.Name = "conditionChart";
            conditionChart.Size = new Size(403, 168);
            conditionChart.TabIndex = 7;
            conditionChart.Text = "chart1";
            // 
            // gradesChart
            // 
            gradesChart.Dock = DockStyle.Fill;
            gradesChart.Location = new Point(412, 3);
            gradesChart.Name = "gradesChart";
            gradesChart.Size = new Size(403, 168);
            gradesChart.TabIndex = 8;
            gradesChart.Text = "chart1";
            // 
            // gradeDistributionChart
            // 
            gradeDistributionChart.Dock = DockStyle.Fill;
            gradeDistributionChart.Location = new Point(821, 3);
            gradeDistributionChart.Name = "gradeDistributionChart";
            gradeDistributionChart.Size = new Size(403, 168);
            gradeDistributionChart.TabIndex = 9;
            gradeDistributionChart.Text = "chart1";
            // 
            // courseReportBackButton
            // 
            courseReportBackButton.Font = new Font("Segoe UI", 12F);
            courseReportBackButton.Location = new Point(3, 408);
            courseReportBackButton.Name = "courseReportBackButton";
            courseReportBackButton.Size = new Size(182, 39);
            courseReportBackButton.TabIndex = 10;
            courseReportBackButton.Text = "Volver atrás";
            courseReportBackButton.UseVisualStyleBackColor = true;
            courseReportBackButton.Click += courseReportBackButton_Click;
            // 
            // inscriptosLabel
            // 
            inscriptosLabel.Anchor = AnchorStyles.None;
            inscriptosLabel.AutoSize = true;
            inscriptosLabel.Font = new Font("Segoe UI", 12F);
            inscriptosLabel.Location = new Point(556, 49);
            inscriptosLabel.Name = "inscriptosLabel";
            inscriptosLabel.Size = new Size(114, 21);
            inscriptosLabel.TabIndex = 11;
            inscriptosLabel.Text = "inscriptosLabel";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(courseReportBackButton, 0, 3);
            tableLayoutPanel1.Controls.Add(courseTitleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1233, 450);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(totalStudentsLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(regularesLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(inscriptosLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(avgAprobadosLabel, 0, 6);
            tableLayoutPanel3.Controls.Add(aprobadosLabel, 0, 3);
            tableLayoutPanel3.Controls.Add(avgRegularesLabel, 0, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 48);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Size = new Size(1227, 174);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(conditionChart, 0, 0);
            tableLayoutPanel2.Controls.Add(gradeDistributionChart, 2, 0);
            tableLayoutPanel2.Controls.Add(gradesChart, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 228);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1227, 174);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // CourseReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CourseReport";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)conditionChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradesChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradeDistributionChart).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label courseTitleLabel;
        private Label totalStudentsLabel;
        private Label regularesLabel;
        private Label aprobadosLabel;
        private Label avgRegularesLabel;
        private Label avgAprobadosLabel;
        private FastReport.DataVisualization.Charting.Chart conditionChart;
        private FastReport.DataVisualization.Charting.Chart gradesChart;
        private FastReport.DataVisualization.Charting.Chart gradeDistributionChart;
        private Button courseReportBackButton;
        private Label inscriptosLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}