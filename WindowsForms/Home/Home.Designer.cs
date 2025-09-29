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
            SectionsButton = new Button();
            CoursesButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contenedorHome.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Location = new Point(3, 312);
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
            PlanesButton.Location = new Point(3, 208);
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
            UsersButton.Location = new Point(3, 4);
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
            SpecialtiesButton.Location = new Point(3, 107);
            SpecialtiesButton.Name = "SpecialtiesButton";
            SpecialtiesButton.Size = new Size(421, 94);
            SpecialtiesButton.TabIndex = 2;
            SpecialtiesButton.Text = "Administrar Especialidades";
            SpecialtiesButton.UseVisualStyleBackColor = true;
            SpecialtiesButton.Click += SpecialtiesButton_Click;
            // 
            // contenedorHome
            // 
            contenedorHome.Anchor = AnchorStyles.None;
            contenedorHome.AutoSize = true;
            contenedorHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedorHome.Controls.Add(UsersButton);
            contenedorHome.Controls.Add(SpecialtiesButton);
            contenedorHome.Controls.Add(PlanesButton);
            contenedorHome.Controls.Add(MateriasButton);
            contenedorHome.Controls.Add(SectionsButton);
            contenedorHome.Controls.Add(CoursesButton);
            contenedorHome.FlowDirection = FlowDirection.TopDown;
            contenedorHome.Location = new Point(3, 3);
            contenedorHome.Name = "contenedorHome";
            contenedorHome.Size = new Size(854, 412);
            contenedorHome.TabIndex = 3;
            // 
            // SectionsButton
            // 
            SectionsButton.Location = new Point(430, 4);
            SectionsButton.Margin = new Padding(3, 4, 3, 4);
            SectionsButton.Name = "SectionsButton";
            SectionsButton.Size = new Size(421, 96);
            SectionsButton.TabIndex = 5;
            SectionsButton.Text = "Administrar Comisiones";
            SectionsButton.UseVisualStyleBackColor = true;
            SectionsButton.Click += SectionsButton_Click;
            // 
            // CoursesButton
            // 
            CoursesButton.Location = new Point(430, 108);
            CoursesButton.Margin = new Padding(3, 4, 3, 4);
            CoursesButton.Name = "CoursesButton";
            CoursesButton.Size = new Size(421, 93);
            CoursesButton.TabIndex = 5;
            CoursesButton.Text = "Administrar Cursos";
            CoursesButton.UseVisualStyleBackColor = true;
            CoursesButton.Click += CoursesButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(contenedorHome);
            flowLayoutPanel1.Location = new Point(157, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(867, 422);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 484);
            Controls.Add(flowLayoutPanel1);
            Name = "Home";
            Text = "Sistema de Gestión Académica";
            contenedorHome.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button MateriasButton;
        private Button PlanesButton;
        private Button UsersButton;
        private Button SpecialtiesButton;
        private FlowLayoutPanel contenedorHome;
        private Button SectionsButton;
        private Button CoursesButton;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}