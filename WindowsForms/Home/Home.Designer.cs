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
            UsersButton = new Button();
            SpecialtiesButton = new Button();
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Location = new Point(125, 42);
            MateriasButton.Margin = new Padding(3, 4, 3, 4);
            MateriasButton.Name = "MateriasButton";
            MateriasButton.Size = new Size(421, 96);
            MateriasButton.TabIndex = 0;
            MateriasButton.Text = "Administrar Materias";
            MateriasButton.UseVisualStyleBackColor = true;
            MateriasButton.Click += MateriasButton_Click;
            // 
            // PlanesButton
            // 
            PlanesButton.Location = new Point(125, 146);
            PlanesButton.Margin = new Padding(3, 4, 3, 4);
            PlanesButton.Name = "PlanesButton";
            PlanesButton.Size = new Size(421, 96);
            PlanesButton.TabIndex = 1;
            PlanesButton.Text = "Administrar Planes";
            PlanesButton.UseVisualStyleBackColor = true;
            PlanesButton.Click += PlanesButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.Location = new Point(552, 42);
            UsersButton.Margin = new Padding(3, 4, 3, 4);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(421, 96);
            UsersButton.TabIndex = 2;
            UsersButton.Text = "Administrar Usuarios";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // SpecialtiesButton
            // 
            SpecialtiesButton.Location = new Point(552, 146);
            SpecialtiesButton.Name = "SpecialtiesButton";
            SpecialtiesButton.Size = new Size(421, 94);
            SpecialtiesButton.TabIndex = 2;
            SpecialtiesButton.Text = "Administrar Especialidades";
            SpecialtiesButton.UseVisualStyleBackColor = true;
            SpecialtiesButton.Click += SpecialtiesButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 285);
            Controls.Add(SpecialtiesButton);
            Controls.Add(UsersButton);
            Controls.Add(PlanesButton);
            Controls.Add(MateriasButton);
            Name = "Home";
            Text = "Sistema de Gestión Académica";
            ResumeLayout(false);
        }

        #endregion

        private Button MateriasButton;
        private Button PlanesButton;
        private Button UsersButton;
        private Button SpecialtiesButton;
    }
}