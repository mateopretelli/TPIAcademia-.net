namespace WindowsForms
{
    partial class PlanDetalle
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
            PlanIDLabel = new Label();
            PlanStateLabel = new Label();
            PlanDescriptionLabel = new Label();
            PlanIDSpecialityLabel = new Label();
            PlanIDTextBox = new TextBox();
            PlanStateTextBox = new TextBox();
            PlanDescriptionTextBox = new TextBox();
            SpecialtyIDComboBox = new ComboBox();
            cancelPlanButton = new Button();
            acceptPlanButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // PlanIDLabel
            // 
            PlanIDLabel.AutoSize = true;
            PlanIDLabel.Location = new Point(20, 40);
            PlanIDLabel.Name = "PlanIDLabel";
            PlanIDLabel.Size = new Size(18, 15);
            PlanIDLabel.TabIndex = 0;
            PlanIDLabel.Text = "ID";
            // 
            // PlanStateLabel
            // 
            PlanStateLabel.AutoSize = true;
            PlanStateLabel.Location = new Point(20, 69);
            PlanStateLabel.Name = "PlanStateLabel";
            PlanStateLabel.Size = new Size(42, 15);
            PlanStateLabel.TabIndex = 1;
            PlanStateLabel.Text = "Estado";
            // 
            // PlanDescriptionLabel
            // 
            PlanDescriptionLabel.AutoSize = true;
            PlanDescriptionLabel.Location = new Point(20, 98);
            PlanDescriptionLabel.Name = "PlanDescriptionLabel";
            PlanDescriptionLabel.Size = new Size(69, 15);
            PlanDescriptionLabel.TabIndex = 2;
            PlanDescriptionLabel.Text = "Descripcion";
            // 
            // PlanIDSpecialityLabel
            // 
            PlanIDSpecialityLabel.AutoSize = true;
            PlanIDSpecialityLabel.Location = new Point(20, 127);
            PlanIDSpecialityLabel.Name = "PlanIDSpecialityLabel";
            PlanIDSpecialityLabel.Size = new Size(86, 15);
            PlanIDSpecialityLabel.TabIndex = 3;
            PlanIDSpecialityLabel.Text = "ID Especialidad";
            // 
            // PlanIDTextBox
            // 
            PlanIDTextBox.Enabled = false;
            PlanIDTextBox.Location = new Point(136, 37);
            PlanIDTextBox.Name = "PlanIDTextBox";
            PlanIDTextBox.Size = new Size(274, 23);
            PlanIDTextBox.TabIndex = 4;
            // 
            // PlanStateTextBox
            // 
            PlanStateTextBox.Enabled = false;
            PlanStateTextBox.Location = new Point(136, 66);
            PlanStateTextBox.Name = "PlanStateTextBox";
            PlanStateTextBox.Size = new Size(274, 23);
            PlanStateTextBox.TabIndex = 5;
            // 
            // PlanDescriptionTextBox
            // 
            PlanDescriptionTextBox.Location = new Point(136, 95);
            PlanDescriptionTextBox.Name = "PlanDescriptionTextBox";
            PlanDescriptionTextBox.Size = new Size(274, 23);
            PlanDescriptionTextBox.TabIndex = 6;
            // 
            // SpecialtyIDComboBox
            // 
            SpecialtyIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecialtyIDComboBox.DropDownWidth = 280;
            SpecialtyIDComboBox.FormattingEnabled = true;
            SpecialtyIDComboBox.Location = new Point(136, 127);
            SpecialtyIDComboBox.Name = "SpecialtyIDComboBox";
            SpecialtyIDComboBox.Size = new Size(274, 23);
            SpecialtyIDComboBox.TabIndex = 11;
            SpecialtyIDComboBox.VisibleChanged += SpecialtyIDComboBoxData;
            // 
            // cancelPlanButton
            // 
            cancelPlanButton.Location = new Point(230, 163);
            cancelPlanButton.Name = "cancelPlanButton";
            cancelPlanButton.Size = new Size(87, 40);
            cancelPlanButton.TabIndex = 9;
            cancelPlanButton.Text = "Cancelar";
            cancelPlanButton.UseVisualStyleBackColor = true;
            cancelPlanButton.Click += cancelPlanButton_Click;
            // 
            // acceptPlanButton
            // 
            acceptPlanButton.Location = new Point(323, 163);
            acceptPlanButton.Name = "acceptPlanButton";
            acceptPlanButton.Size = new Size(87, 40);
            acceptPlanButton.TabIndex = 10;
            acceptPlanButton.Text = "Aceptar";
            acceptPlanButton.UseVisualStyleBackColor = true;
            acceptPlanButton.Click += acceptPlanButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PlanDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 224);
            Controls.Add(acceptPlanButton);
            Controls.Add(cancelPlanButton);
            Controls.Add(SpecialtyIDComboBox);
            Controls.Add(PlanDescriptionTextBox);
            Controls.Add(PlanStateTextBox);
            Controls.Add(PlanIDTextBox);
            Controls.Add(PlanIDSpecialityLabel);
            Controls.Add(PlanDescriptionLabel);
            Controls.Add(PlanStateLabel);
            Controls.Add(PlanIDLabel);
            Name = "PlanDetalle";
            Text = "Detalle Plan";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlanIDLabel;
        private Label PlanStateLabel;
        private Label PlanDescriptionLabel;
        private Label PlanIDSpecialityLabel;
        private TextBox PlanIDTextBox;
        private TextBox PlanStateTextBox;
        private TextBox PlanDescriptionTextBox;
        private ComboBox SpecialtyIDComboBox;
        private Button cancelPlanButton;
        private Button acceptPlanButton;
        private ErrorProvider errorProvider1;
    }
}