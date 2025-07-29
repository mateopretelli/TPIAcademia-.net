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
            acceptButton = new Button();
            cancelButton = new Button();
            idTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            weeklyHoursTextBox = new TextBox();
            totalHoursTextBox = new TextBox();
            stateTextBox = new TextBox();
            idLabel = new Label();
            descriptionLabel = new Label();
            weeklyHoursLabel = new Label();
            totalHoursLabel = new Label();
            stateLabel = new Label();
            idPlanLabel = new Label();
            idPlanTextBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(227, 234);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(99, 24);
            acceptButton.TabIndex = 0;
            acceptButton.Text = "Aceptar";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(331, 234);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(99, 24);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(143, 40);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(287, 23);
            idTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(143, 68);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(287, 23);
            descriptionTextBox.TabIndex = 3;
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
            // stateTextBox
            // 
            stateTextBox.Enabled = false;
            stateTextBox.Location = new Point(143, 155);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(287, 23);
            stateTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(33, 43);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 7;
            idLabel.Text = "ID";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(31, 71);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(69, 15);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Descripcion";
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
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(33, 158);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(42, 15);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "Estado";
            // 
            // idPlanLabel
            // 
            idPlanLabel.AutoSize = true;
            idPlanLabel.Location = new Point(31, 187);
            idPlanLabel.Name = "idPlanLabel";
            idPlanLabel.Size = new Size(44, 15);
            idPlanLabel.TabIndex = 12;
            idPlanLabel.Text = "ID Plan";
            // 
            // idPlanTextBox
            // 
            idPlanTextBox.Location = new Point(143, 184);
            idPlanTextBox.Name = "idPlanTextBox";
            idPlanTextBox.Size = new Size(287, 23);
            idPlanTextBox.TabIndex = 13;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MateriaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 286);
            Controls.Add(idPlanTextBox);
            Controls.Add(idPlanLabel);
            Controls.Add(stateLabel);
            Controls.Add(totalHoursLabel);
            Controls.Add(weeklyHoursLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(idLabel);
            Controls.Add(stateTextBox);
            Controls.Add(totalHoursTextBox);
            Controls.Add(weeklyHoursTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(idTextBox);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Name = "MateriaDetalle";
            Text = "Materia Seleccionada";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button acceptButton;
        private Button cancelButton;
        private TextBox idTextBox;
        private TextBox descriptionTextBox;
        private TextBox weeklyHoursTextBox;
        private TextBox totalHoursTextBox;
        private TextBox stateTextBox;
        private TextBox idPlanTextBox;
        private Label idLabel;
        private Label descriptionLabel;
        private Label weeklyHoursLabel;
        private Label totalHoursLabel;
        private Label stateLabel;
        private Label idPlanLabel;
        private ErrorProvider errorProvider;
    }
}