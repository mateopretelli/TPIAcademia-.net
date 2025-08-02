namespace WindowsForms
{
    partial class MateriaDetalle
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
            components = new System.ComponentModel.Container();
            acceptMateriaButton = new Button();
            cancelMateriaButton = new Button();
            MateriaDescriptionTextBox = new TextBox();
            weeklyHoursTextBox = new TextBox();
            totalHoursTextBox = new TextBox();
            MateriaStateTextBox = new TextBox();
            MateriaIDLabel = new Label();
            MateriaDescriptionLabel = new Label();
            weeklyHoursLabel = new Label();
            totalHoursLabel = new Label();
            MateriaStateLabel = new Label();
            MateriaIDPlanLabel = new Label();
            errorProvider = new ErrorProvider(components);
            MateriaIDTextBox = new TextBox();
            IDPlanComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // acceptMateriaButton
            // 
            acceptMateriaButton.Location = new Point(226, 234);
            acceptMateriaButton.Name = "acceptMateriaButton";
            acceptMateriaButton.Size = new Size(99, 40);
            acceptMateriaButton.TabIndex = 0;
            acceptMateriaButton.Text = "Aceptar";
            acceptMateriaButton.UseVisualStyleBackColor = true;
            acceptMateriaButton.Click += acceptMateriaButton_Click;
            // 
            // cancelMateriaButton
            // 
            cancelMateriaButton.Location = new Point(331, 234);
            cancelMateriaButton.Name = "cancelMateriaButton";
            cancelMateriaButton.Size = new Size(99, 40);
            cancelMateriaButton.TabIndex = 1;
            cancelMateriaButton.Text = "Cancelar";
            cancelMateriaButton.UseVisualStyleBackColor = true;
            cancelMateriaButton.Click += cancelMateriaButton_Click;
            // 
            // MateriaDescriptionTextBox
            // 
            MateriaDescriptionTextBox.Location = new Point(143, 68);
            MateriaDescriptionTextBox.Name = "MateriaDescriptionTextBox";
            MateriaDescriptionTextBox.Size = new Size(287, 23);
            MateriaDescriptionTextBox.TabIndex = 3;
            // 
            // weeklyHoursTextBox
            // 
            weeklyHoursTextBox.Location = new Point(143, 97);
            weeklyHoursTextBox.Name = "weeklyHoursTextBox";
            weeklyHoursTextBox.Size = new Size(287, 23);
            weeklyHoursTextBox.TabIndex = 4;
            // 
            // totalHoursTextBox
            // 
            totalHoursTextBox.Location = new Point(143, 126);
            totalHoursTextBox.Name = "totalHoursTextBox";
            totalHoursTextBox.Size = new Size(287, 23);
            totalHoursTextBox.TabIndex = 5;
            // 
            // MateriaStateTextBox
            // 
            MateriaStateTextBox.Enabled = false;
            MateriaStateTextBox.Location = new Point(143, 155);
            MateriaStateTextBox.Name = "MateriaStateTextBox";
            MateriaStateTextBox.Size = new Size(287, 23);
            MateriaStateTextBox.TabIndex = 6;
            // 
            // MateriaIDLabel
            // 
            MateriaIDLabel.AutoSize = true;
            MateriaIDLabel.Location = new Point(33, 43);
            MateriaIDLabel.Name = "MateriaIDLabel";
            MateriaIDLabel.Size = new Size(18, 15);
            MateriaIDLabel.TabIndex = 7;
            MateriaIDLabel.Text = "ID";
            // 
            // MateriaDescriptionLabel
            // 
            MateriaDescriptionLabel.AutoSize = true;
            MateriaDescriptionLabel.Location = new Point(31, 71);
            MateriaDescriptionLabel.Name = "MateriaDescriptionLabel";
            MateriaDescriptionLabel.Size = new Size(69, 15);
            MateriaDescriptionLabel.TabIndex = 8;
            MateriaDescriptionLabel.Text = "Descripcion";
            // 
            // weeklyHoursLabel
            // 
            weeklyHoursLabel.AutoSize = true;
            weeklyHoursLabel.Location = new Point(31, 100);
            weeklyHoursLabel.Name = "weeklyHoursLabel";
            weeklyHoursLabel.Size = new Size(97, 15);
            weeklyHoursLabel.TabIndex = 9;
            weeklyHoursLabel.Text = "Horas Semanales";
            // 
            // totalHoursLabel
            // 
            totalHoursLabel.AutoSize = true;
            totalHoursLabel.Location = new Point(31, 129);
            totalHoursLabel.Name = "totalHoursLabel";
            totalHoursLabel.Size = new Size(77, 15);
            totalHoursLabel.TabIndex = 10;
            totalHoursLabel.Text = "Horas Totales";
            // 
            // MateriaStateLabel
            // 
            MateriaStateLabel.AutoSize = true;
            MateriaStateLabel.Location = new Point(33, 158);
            MateriaStateLabel.Name = "MateriaStateLabel";
            MateriaStateLabel.Size = new Size(42, 15);
            MateriaStateLabel.TabIndex = 11;
            MateriaStateLabel.Text = "Estado";
            // 
            // MateriaIDPlanLabel
            // 
            MateriaIDPlanLabel.AutoSize = true;
            MateriaIDPlanLabel.Location = new Point(31, 187);
            MateriaIDPlanLabel.Name = "MateriaIDPlanLabel";
            MateriaIDPlanLabel.Size = new Size(44, 15);
            MateriaIDPlanLabel.TabIndex = 12;
            MateriaIDPlanLabel.Text = "ID Plan";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MateriaIDTextBox
            // 
            MateriaIDTextBox.Enabled = false;
            MateriaIDTextBox.Location = new Point(143, 35);
            MateriaIDTextBox.Name = "MateriaIDTextBox";
            MateriaIDTextBox.Size = new Size(287, 23);
            MateriaIDTextBox.TabIndex = 14;
            // 
            // IDPlanComboBox
            // 
            IDPlanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDPlanComboBox.DropDownWidth = 280;
            IDPlanComboBox.FormattingEnabled = true;
            IDPlanComboBox.Location = new Point(143, 187);
            IDPlanComboBox.Name = "IDPlanComboBox";
            IDPlanComboBox.Size = new Size(287, 23);
            IDPlanComboBox.TabIndex = 15;
            IDPlanComboBox.VisibleChanged += IDPlanComboBoxData;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 286);
            Controls.Add(IDPlanComboBox);
            Controls.Add(MateriaIDTextBox);
            Controls.Add(MateriaIDPlanLabel);
            Controls.Add(MateriaStateLabel);
            Controls.Add(totalHoursLabel);
            Controls.Add(weeklyHoursLabel);
            Controls.Add(MateriaDescriptionLabel);
            Controls.Add(MateriaIDLabel);
            Controls.Add(MateriaStateTextBox);
            Controls.Add(totalHoursTextBox);
            Controls.Add(weeklyHoursTextBox);
            Controls.Add(MateriaDescriptionTextBox);
            Controls.Add(cancelMateriaButton);
            Controls.Add(acceptMateriaButton);
            Name = "MateriaDetalle";
            Text = "Plan Seleccionada";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button acceptMateriaButton;
        private Button cancelMateriaButton;
        private TextBox MateriaIDTextBox;
        private TextBox MateriaDescriptionTextBox;
        private TextBox weeklyHoursTextBox;
        private TextBox totalHoursTextBox;
        private TextBox MateriaStateTextBox;
        private ComboBox IDPlanComboBox;
        private Label MateriaIDLabel;
        private Label MateriaDescriptionLabel;
        private Label weeklyHoursLabel;
        private Label totalHoursLabel;
        private Label MateriaStateLabel;
        private Label MateriaIDPlanLabel;
        private ErrorProvider errorProvider;   
    }
}