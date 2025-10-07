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
            StudentCourseButton = new Button();
            contenedorHome.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Location = new Point(3, 396);
            MateriasButton.Margin = new Padding(3, 5, 3, 5);
            MateriasButton.Name = "MateriasButton";
            MateriasButton.Size = new Size(481, 122);
            MateriasButton.TabIndex = 0;
            MateriasButton.Text = "Administrar Materias";
            MateriasButton.UseVisualStyleBackColor = true;
            MateriasButton.Click += MateriasButton_Click;
            // 
            // PlanesButton
            // 
            PlanesButton.Location = new Point(3, 264);
            PlanesButton.Margin = new Padding(3, 5, 3, 5);
            PlanesButton.Name = "PlanesButton";
            PlanesButton.Size = new Size(481, 122);
            PlanesButton.TabIndex = 1;
            PlanesButton.Text = "Administrar Planes";
            PlanesButton.UseVisualStyleBackColor = true;
            PlanesButton.Click += PlanesButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.Location = new Point(3, 5);
            UsersButton.Margin = new Padding(3, 5, 3, 5);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(481, 122);
            UsersButton.TabIndex = 2;
            UsersButton.Text = "Administrar Usuarios";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // SpecialtiesButton
            // 
            SpecialtiesButton.Location = new Point(3, 136);
            SpecialtiesButton.Margin = new Padding(3, 4, 3, 4);
            SpecialtiesButton.Name = "SpecialtiesButton";
            SpecialtiesButton.Size = new Size(481, 119);
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
            contenedorHome.Controls.Add(StudentCourseButton);
            contenedorHome.FlowDirection = FlowDirection.TopDown;
            contenedorHome.Location = new Point(3, 4);
            contenedorHome.Margin = new Padding(3, 4, 3, 4);
            contenedorHome.Name = "contenedorHome";
            contenedorHome.Size = new Size(974, 523);
            contenedorHome.TabIndex = 3;
            // 
            // SectionsButton
            // 
            SectionsButton.Location = new Point(490, 5);
            SectionsButton.Margin = new Padding(3, 5, 3, 5);
            SectionsButton.Name = "SectionsButton";
            SectionsButton.Size = new Size(481, 122);
            SectionsButton.TabIndex = 5;
            SectionsButton.Text = "Administrar Comisiones";
            SectionsButton.UseVisualStyleBackColor = true;
            SectionsButton.Click += SectionsButton_Click;
            // 
            // CoursesButton
            // 
            CoursesButton.Location = new Point(490, 137);
            CoursesButton.Margin = new Padding(3, 5, 3, 5);
            CoursesButton.Name = "CoursesButton";
            CoursesButton.Size = new Size(481, 118);
            CoursesButton.TabIndex = 5;
            CoursesButton.Text = "Administrar Cursos";
            CoursesButton.UseVisualStyleBackColor = true;
            CoursesButton.Click += CoursesButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(contenedorHome);
            flowLayoutPanel1.Location = new Point(179, 43);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(991, 535);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // StudentCourseButton
            // 
            StudentCourseButton.Location = new Point(490, 263);
            StudentCourseButton.Name = "StudentCourseButton";
            StudentCourseButton.Size = new Size(481, 123);
            StudentCourseButton.TabIndex = 6;
            StudentCourseButton.Text = "Inscripcion Alumnos";
            StudentCourseButton.UseVisualStyleBackColor = true;
            StudentCourseButton.Click += StudentCourseButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 613);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button StudentCourseButton;
    }
}