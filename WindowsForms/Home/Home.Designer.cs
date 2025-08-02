namespace WindowsForms
{
    partial class Home
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
            MateriasButton = new Button();
            PlanesButton = new Button();
            SpecialtiesButton = new Button();
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Location = new Point(201, 45);
            MateriasButton.Name = "MateriasButton";
            MateriasButton.Size = new Size(368, 76);
            MateriasButton.TabIndex = 0;
            MateriasButton.Text = "Administrar Materias";
            MateriasButton.UseVisualStyleBackColor = true;
            MateriasButton.Click += MateriasButton_Click;
            // 
            // PlanesButton
            // 
            PlanesButton.Location = new Point(201, 127);
            PlanesButton.Name = "PlanesButton";
            PlanesButton.Size = new Size(368, 76);
            PlanesButton.TabIndex = 1;
            PlanesButton.Text = "Administrar Planes";
            PlanesButton.UseVisualStyleBackColor = true;
            PlanesButton.Click += PlanesButton_Click;
            // 
            // button1
            // 
            SpecialtiesButton.Location = new Point(201, 209);
            SpecialtiesButton.Name = "SpecialtiesButton";
            SpecialtiesButton.Size = new Size(368, 76);
            SpecialtiesButton.TabIndex = 2;
            SpecialtiesButton.Text = "Administrar Especialidades";
            SpecialtiesButton.UseVisualStyleBackColor = true;
            SpecialtiesButton.Click += SpecialtiesButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SpecialtiesButton);
            Controls.Add(PlanesButton);
            Controls.Add(MateriasButton);
            Name = "Home";
            Text = "Sistema de Gestión Académica";
            ResumeLayout(false);
        }

        #endregion

        private Button MateriasButton;
        private Button PlanesButton;
        private Button SpecialtiesButton;
    }
}