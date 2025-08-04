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
            contenedorHome = new FlowLayoutPanel();
            contenedorHome.SuspendLayout();
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Location = new Point(3, 108);
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
            PlanesButton.Location = new Point(3, 4);
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
            UsersButton.Location = new Point(3, 212);
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
            SpecialtiesButton.Location = new Point(3, 315);
            SpecialtiesButton.Name = "SpecialtiesButton";
            SpecialtiesButton.Size = new Size(421, 94);
            SpecialtiesButton.TabIndex = 2;
            SpecialtiesButton.Text = "Administrar Especialidades";
            SpecialtiesButton.UseVisualStyleBackColor = true;
            SpecialtiesButton.Click += SpecialtiesButton_Click;
            // 
            // flowLayoutPanel1
            // 
            contenedorHome.Anchor = AnchorStyles.None;
            contenedorHome.AutoSize = true;
            contenedorHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedorHome.Controls.Add(PlanesButton);
            contenedorHome.Controls.Add(MateriasButton);
            contenedorHome.Controls.Add(UsersButton);
            contenedorHome.Controls.Add(SpecialtiesButton);
            contenedorHome.FlowDirection = FlowDirection.TopDown;
            contenedorHome.Location = new Point(50, 32);
            contenedorHome.Name = "contenedorHome";
            contenedorHome.Size = new Size(427, 412);
            contenedorHome.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 484);
            Controls.Add(contenedorHome);
            Name = "Home";
            Text = "Sistema de Gestión Académica";
            contenedorHome.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MateriasButton;
        private Button PlanesButton;
        private Button UsersButton;
        private Button SpecialtiesButton;
        private FlowLayoutPanel contenedorHome;
    }
}