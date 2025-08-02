using System.Windows.Forms;

namespace WindowsForms
{
    partial class SpecialtyDetalle
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
            SpecialtyIDLabel = new Label();
            SpecialtyStateLabel = new Label();
            SpecialtyDescriptionLabel = new Label();
            SpecialtyIDTextBox = new TextBox();
            SpecialtyStateTextBox = new TextBox();
            SpecialtyDescriptionTextBox = new TextBox();
            cancelSpecialtyButton = new Button();
            acceptSpecialtyButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // SpecialtyIDLabel
            // 
            SpecialtyIDLabel.AutoSize = true;
            SpecialtyIDLabel.Location = new Point(20, 40);
            SpecialtyIDLabel.Name = "SpecialtyIDLabel";
            SpecialtyIDLabel.Size = new Size(18, 15);
            SpecialtyIDLabel.TabIndex = 0;
            SpecialtyIDLabel.Text = "ID";
            // 
            // SpecialtyStateLabel
            // 
            SpecialtyStateLabel.AutoSize = true;
            SpecialtyStateLabel.Location = new Point(20, 69);
            SpecialtyStateLabel.Name = "SpecialtyStateLabel";
            SpecialtyStateLabel.Size = new Size(42, 15);
            SpecialtyStateLabel.TabIndex = 1;
            SpecialtyStateLabel.Text = "Estado";
            // 
            // SpecialtyDescriptionLabel
            // 
            SpecialtyDescriptionLabel.AutoSize = true;
            SpecialtyDescriptionLabel.Location = new Point(20, 98);
            SpecialtyDescriptionLabel.Name = "SpecialtyDescriptionLabel";
            SpecialtyDescriptionLabel.Size = new Size(69, 15);
            SpecialtyDescriptionLabel.TabIndex = 2;
            SpecialtyDescriptionLabel.Text = "Descripcion";
            // 
            // SpecialtyIDTextBox
            // 
            SpecialtyIDTextBox.Enabled = false;
            SpecialtyIDTextBox.Location = new Point(136, 37);
            SpecialtyIDTextBox.Name = "SpecialtyIDTextBox";
            SpecialtyIDTextBox.Size = new Size(274, 23);
            SpecialtyIDTextBox.TabIndex = 4;
            // 
            // SpecialtyStateTextBox
            // 
            SpecialtyStateTextBox.Enabled = false;
            SpecialtyStateTextBox.Location = new Point(136, 66);
            SpecialtyStateTextBox.Name = "SpecialtyStateTextBox";
            SpecialtyStateTextBox.Size = new Size(274, 23);
            SpecialtyStateTextBox.TabIndex = 5;
            // 
            // SpecialtyDescriptionTextBox
            // 
            SpecialtyDescriptionTextBox.Location = new Point(136, 95);
            SpecialtyDescriptionTextBox.Name = "SpecialtyDescriptionTextBox";
            SpecialtyDescriptionTextBox.Size = new Size(274, 23);
            SpecialtyDescriptionTextBox.TabIndex = 6;
            // 
            // cancelSpecialtyButton
            // 
            cancelSpecialtyButton.Location = new Point(230, 163);
            cancelSpecialtyButton.Name = "cancelSpecialtyButton";
            cancelSpecialtyButton.Size = new Size(87, 40);
            cancelSpecialtyButton.TabIndex = 9;
            cancelSpecialtyButton.Text = "Cancelar";
            cancelSpecialtyButton.UseVisualStyleBackColor = true;
            cancelSpecialtyButton.Click += cancelSpecialtyButton_Click;
            // 
            // acceptSpecialtyButton
            // 
            acceptSpecialtyButton.Location = new Point(323, 163);
            acceptSpecialtyButton.Name = "acceptSpecialtyButton";
            acceptSpecialtyButton.Size = new Size(87, 40);
            acceptSpecialtyButton.TabIndex = 10;
            acceptSpecialtyButton.Text = "Aceptar";
            acceptSpecialtyButton.UseVisualStyleBackColor = true;
            acceptSpecialtyButton.Click += acceptSpecialtyButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SpecialtyDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 224);
            Controls.Add(acceptSpecialtyButton);
            Controls.Add(cancelSpecialtyButton);
            Controls.Add(SpecialtyDescriptionTextBox);
            Controls.Add(SpecialtyStateTextBox);
            Controls.Add(SpecialtyIDTextBox);
            Controls.Add(SpecialtyDescriptionLabel);
            Controls.Add(SpecialtyStateLabel);
            Controls.Add(SpecialtyIDLabel);
            Name = "PlanSpecialty";
            Text = "Detalle Specialty";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SpecialtyIDLabel;
        private Label SpecialtyStateLabel;
        private Label SpecialtyDescriptionLabel;
        private TextBox SpecialtyIDTextBox;
        private TextBox SpecialtyStateTextBox;
        private TextBox SpecialtyDescriptionTextBox;
        private Button cancelSpecialtyButton;
        private Button acceptSpecialtyButton;
        private ErrorProvider errorProvider1;
    }
}