namespace WindowsForms.StudentPages
{
    partial class PlanSubjects
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
            SubjectsGridView = new DataGridView();
            PlanSubjectsLabel = new Label();
            subjectListBackButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectsGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(SubjectsGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(PlanSubjectsLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(subjectListBackButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SubjectsGridView
            // 
            SubjectsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectsGridView.Dock = DockStyle.Fill;
            SubjectsGridView.Location = new Point(3, 48);
            SubjectsGridView.Name = "SubjectsGridView";
            SubjectsGridView.ReadOnly = true;
            SubjectsGridView.Size = new Size(794, 331);
            SubjectsGridView.TabIndex = 0;
            // 
            // PlanSubjectsLabel
            // 
            PlanSubjectsLabel.Anchor = AnchorStyles.None;
            PlanSubjectsLabel.AutoSize = true;
            PlanSubjectsLabel.Font = new Font("Segoe UI", 15F);
            PlanSubjectsLabel.Location = new Point(284, 8);
            PlanSubjectsLabel.Name = "PlanSubjectsLabel";
            PlanSubjectsLabel.Size = new Size(232, 28);
            PlanSubjectsLabel.TabIndex = 1;
            PlanSubjectsLabel.Text = "Lista de Materias del Plan";
            // 
            // subjectListBackButton
            // 
            subjectListBackButton.Font = new Font("Segoe UI", 11F);
            subjectListBackButton.Location = new Point(3, 385);
            subjectListBackButton.Name = "subjectListBackButton";
            subjectListBackButton.Size = new Size(169, 62);
            subjectListBackButton.TabIndex = 2;
            subjectListBackButton.Text = "Volver al Menú";
            subjectListBackButton.UseVisualStyleBackColor = true;
            subjectListBackButton.Click += SubjectListBackButton_Click;
            // 
            // PlanSubjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PlanSubjects";
            Text = "Materias del Plan";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView SubjectsGridView;
        private Label PlanSubjectsLabel;
        private Button subjectListBackButton;
    }
}