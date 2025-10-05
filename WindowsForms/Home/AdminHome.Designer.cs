namespace WindowsForms
{
    partial class AdminHome
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
            contenedorHome = new FlowLayoutPanel();
            SectionsButton = new Button();
            CoursesButton = new Button();
            TeachersCoursesButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            PlanesButton = new Button();
            SpecialtiesButton = new Button();
            UsersButton = new Button();
            label1 = new Label();
            AdminLogoutButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Dock = DockStyle.Fill;
            MateriasButton.Font = new Font("Segoe UI", 15F);
            MateriasButton.Location = new Point(3, 247);
            MateriasButton.Margin = new Padding(3, 4, 3, 4);
            MateriasButton.Name = "MateriasButton";
            MateriasButton.Size = new Size(559, 75);
            MateriasButton.TabIndex = 0;
            MateriasButton.Text = "Administrar Materias";
            MateriasButton.UseVisualStyleBackColor = true;
            MateriasButton.Click += MateriasButton_Click;
            // 
            // contenedorHome
            // 
            contenedorHome.Anchor = AnchorStyles.None;
            contenedorHome.AutoSize = true;
            contenedorHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedorHome.FlowDirection = FlowDirection.TopDown;
            contenedorHome.Location = new Point(46, 115);
            contenedorHome.Name = "contenedorHome";
            contenedorHome.Size = new Size(0, 0);
            contenedorHome.TabIndex = 3;
            // 
            // SectionsButton
            // 
            SectionsButton.Dock = DockStyle.Fill;
            SectionsButton.Font = new Font("Segoe UI", 15F);
            SectionsButton.Location = new Point(3, 4);
            SectionsButton.Margin = new Padding(3, 4, 3, 4);
            SectionsButton.Name = "SectionsButton";
            SectionsButton.Size = new Size(559, 73);
            SectionsButton.TabIndex = 5;
            SectionsButton.Text = "Administrar Comisiones";
            SectionsButton.UseVisualStyleBackColor = true;
            SectionsButton.Click += SectionsButton_Click;
            // 
            // CoursesButton
            // 
            CoursesButton.Dock = DockStyle.Fill;
            CoursesButton.Font = new Font("Segoe UI", 15F);
            CoursesButton.Location = new Point(3, 85);
            CoursesButton.Margin = new Padding(3, 4, 3, 4);
            CoursesButton.Name = "CoursesButton";
            CoursesButton.Size = new Size(559, 73);
            CoursesButton.TabIndex = 5;
            CoursesButton.Text = "Administrar Cursos";
            CoursesButton.UseVisualStyleBackColor = true;
            CoursesButton.Click += CoursesButton_Click;
            // 
            // TeachersCoursesButton
            // 
            TeachersCoursesButton.Dock = DockStyle.Fill;
            TeachersCoursesButton.Font = new Font("Segoe UI", 15F);
            TeachersCoursesButton.Location = new Point(3, 166);
            TeachersCoursesButton.Margin = new Padding(3, 4, 3, 4);
            TeachersCoursesButton.Name = "TeachersCoursesButton";
            TeachersCoursesButton.Size = new Size(559, 73);
            TeachersCoursesButton.TabIndex = 6;
            TeachersCoursesButton.Text = "Administrar Docentes-Cursos";
            TeachersCoursesButton.UseVisualStyleBackColor = true;
            TeachersCoursesButton.Click += TeachersCoursesButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(AdminLogoutButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1143, 484);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1137, 332);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(MateriasButton, 0, 3);
            tableLayoutPanel4.Controls.Add(SectionsButton, 0, 0);
            tableLayoutPanel4.Controls.Add(PlanesButton, 1, 2);
            tableLayoutPanel4.Controls.Add(CoursesButton, 0, 1);
            tableLayoutPanel4.Controls.Add(SpecialtiesButton, 1, 1);
            tableLayoutPanel4.Controls.Add(TeachersCoursesButton, 0, 2);
            tableLayoutPanel4.Controls.Add(UsersButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(1131, 326);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // PlanesButton
            // 
            PlanesButton.Dock = DockStyle.Fill;
            PlanesButton.Font = new Font("Segoe UI", 15F);
            PlanesButton.Location = new Point(568, 166);
            PlanesButton.Margin = new Padding(3, 4, 3, 4);
            PlanesButton.Name = "PlanesButton";
            PlanesButton.Size = new Size(560, 73);
            PlanesButton.TabIndex = 1;
            PlanesButton.Text = "Administrar Planes";
            PlanesButton.UseVisualStyleBackColor = true;
            PlanesButton.Click += PlanesButton_Click;
            // 
            // SpecialtiesButton
            // 
            SpecialtiesButton.Dock = DockStyle.Fill;
            SpecialtiesButton.Font = new Font("Segoe UI", 15F);
            SpecialtiesButton.Location = new Point(568, 84);
            SpecialtiesButton.Name = "SpecialtiesButton";
            SpecialtiesButton.Size = new Size(560, 75);
            SpecialtiesButton.TabIndex = 2;
            SpecialtiesButton.Text = "Administrar Especialidades";
            SpecialtiesButton.UseVisualStyleBackColor = true;
            SpecialtiesButton.Click += SpecialtiesButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.Dock = DockStyle.Fill;
            UsersButton.Font = new Font("Segoe UI", 15F);
            UsersButton.Location = new Point(568, 4);
            UsersButton.Margin = new Padding(3, 4, 3, 4);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(560, 73);
            UsersButton.TabIndex = 2;
            UsersButton.Text = "Administrar Usuarios";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(407, 1);
            label1.Name = "label1";
            label1.Size = new Size(329, 46);
            label1.TabIndex = 6;
            label1.Text = "Menu Administrador";
            // 
            // AdminLogoutButton
            // 
            AdminLogoutButton.Anchor = AnchorStyles.None;
            AdminLogoutButton.Font = new Font("Segoe UI", 15F);
            AdminLogoutButton.Location = new Point(456, 406);
            AdminLogoutButton.Name = "AdminLogoutButton";
            AdminLogoutButton.Size = new Size(230, 58);
            AdminLogoutButton.TabIndex = 7;
            AdminLogoutButton.Text = "Cerrar Sesión";
            AdminLogoutButton.UseVisualStyleBackColor = true;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 484);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(contenedorHome);
            Name = "AdminHome";
            Text = "Sistema de Gestión Académica";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MateriasButton;
        private FlowLayoutPanel contenedorHome;
        private Button SectionsButton;
        private Button CoursesButton;
        private Button TeachersCoursesButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button PlanesButton;
        private Button SpecialtiesButton;
        private Button UsersButton;
        private Label label1;
        private Button AdminLogoutButton;
    }
}