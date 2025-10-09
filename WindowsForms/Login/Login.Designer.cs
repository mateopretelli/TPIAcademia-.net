namespace WindowsForms
{
    partial class Login
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
            UserLoginLabel = new Label();
            UserLoginTextBox = new TextBox();
            label1 = new Label();
            PwdLoginTextBox = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LoginButton = new Button();
            LoginErrorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // UserLoginLabel
            // 
            UserLoginLabel.Anchor = AnchorStyles.None;
            UserLoginLabel.AutoSize = true;
            UserLoginLabel.Font = new Font("Segoe UI", 12F);
            UserLoginLabel.Location = new Point(18, 25);
            UserLoginLabel.Name = "UserLoginLabel";
            UserLoginLabel.Size = new Size(64, 21);
            UserLoginLabel.TabIndex = 0;
            UserLoginLabel.Text = "Usuario";
            // 
            // UserLoginTextBox
            // 
            UserLoginTextBox.Anchor = AnchorStyles.None;
            UserLoginTextBox.Location = new Point(144, 24);
            UserLoginTextBox.Name = "UserLoginTextBox";
            UserLoginTextBox.Size = new Size(316, 23);
            UserLoginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(5, 97);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 2;
            label1.Text = "Contraseña";
            // 
            // PwdLoginTextBox
            // 
            PwdLoginTextBox.Anchor = AnchorStyles.None;
            PwdLoginTextBox.Location = new Point(145, 96);
            PwdLoginTextBox.Name = "PwdLoginTextBox";
            PwdLoginTextBox.PasswordChar = '*';
            PwdLoginTextBox.Size = new Size(314, 23);
            PwdLoginTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(172, 56);
            label2.Name = "label2";
            label2.Size = new Size(165, 37);
            label2.TabIndex = 4;
            label2.Text = "¡Bienvenido!";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(510, 450);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(UserLoginLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(UserLoginTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(PwdLoginTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 152);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(504, 144);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.Font = new Font("Segoe UI", 15F);
            LoginButton.Location = new Point(142, 344);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(225, 60);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Ingresar";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginErrorProvider
            // 
            LoginErrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Iniciar Sesión";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label UserLoginLabel;
        private TextBox UserLoginTextBox;
        private Label label1;
        private TextBox PwdLoginTextBox;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button LoginButton;
        private ErrorProvider LoginErrorProvider;
    }
}