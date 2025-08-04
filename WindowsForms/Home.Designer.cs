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
            SuspendLayout();
            // 
            // MateriasButton
            // 
            MateriasButton.Location = new Point(230, 57);
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
            PlanesButton.Location = new Point(230, 161);
            PlanesButton.Margin = new Padding(3, 4, 3, 4);
            PlanesButton.Name = "PlanesButton";
            PlanesButton.Size = new Size(421, 96);
            PlanesButton.TabIndex = 1;
            PlanesButton.Text = "Administrar Planes";
            PlanesButton.UseVisualStyleBackColor = true;
            PlanesButton.Click += PlanesButton_Click;
            // 
            // button1
            // 
            UsersButton.Location = new Point(230, 265);
            UsersButton.Margin = new Padding(3, 4, 3, 4);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(421, 96);
            UsersButton.TabIndex = 2;
            UsersButton.Text = "Administrar Usuarios";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(UsersButton);
            Controls.Add(PlanesButton);
            Controls.Add(MateriasButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Sistema de Gestión Académica";
            ResumeLayout(false);
        }

        #endregion

        private Button MateriasButton;
        private Button PlanesButton;
        private Button UsersButton;
    }
}