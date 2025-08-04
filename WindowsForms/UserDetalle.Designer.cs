namespace WindowsForms
{
    partial class UserDetalle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            NameLabel = new Label();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            AddressTextBox = new TextBox();
            AddressLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            BirthDateTextBox = new TextBox();
            BirthDateLabel = new Label();
            IDPlanTextBox = new TextBox();
            IDPlanLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            AcceptButton = new Button();
            CancelButton = new Button();
            PersonLabel = new Label();
            UserLabel = new Label();
            ConfirmPasswordLabel = new Label();
            ConfirmPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(187, 56);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(346, 26);
            NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(32, 56);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Nombre";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(187, 88);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(346, 26);
            LastNameTextBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(32, 88);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(66, 20);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Apellido";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(187, 120);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(346, 26);
            EmailTextBox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(32, 120);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(187, 152);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(346, 26);
            AddressTextBox.TabIndex = 9;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(32, 152);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(72, 20);
            AddressLabel.TabIndex = 8;
            AddressLabel.Text = "Direccion";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(187, 184);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(346, 26);
            PhoneTextBox.TabIndex = 11;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(32, 184);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(67, 20);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Telefono";
            // 
            // BirthDateTextBox
            // 
            BirthDateTextBox.Location = new Point(187, 216);
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.Size = new Size(346, 26);
            BirthDateTextBox.TabIndex = 15;
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(32, 216);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(128, 20);
            BirthDateLabel.TabIndex = 14;
            BirthDateLabel.Text = "Fecha Nacimiento";
            // 
            // IDPlanTextBox
            // 
            IDPlanTextBox.Location = new Point(187, 248);
            IDPlanTextBox.Name = "IDPlanTextBox";
            IDPlanTextBox.Size = new Size(346, 26);
            IDPlanTextBox.TabIndex = 17;
            // 
            // IDPlanLabel
            // 
            IDPlanLabel.AutoSize = true;
            IDPlanLabel.Location = new Point(32, 248);
            IDPlanLabel.Name = "IDPlanLabel";
            IDPlanLabel.Size = new Size(56, 20);
            IDPlanLabel.TabIndex = 16;
            IDPlanLabel.Text = "ID Plan";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(187, 328);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(346, 26);
            UsernameTextBox.TabIndex = 19;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(32, 328);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(137, 20);
            UsernameLabel.TabIndex = 18;
            UsernameLabel.Text = "Nombre de usuario";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(187, 360);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(346, 26);
            PasswordTextBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(32, 360);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(83, 20);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Contraseña";
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(315, 442);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(102, 44);
            AcceptButton.TabIndex = 24;
            AcceptButton.Text = "Aceptar";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptUserButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(431, 442);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 44);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Cancelar";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelUserButton_Click;
            // 
            // PersonLabel
            // 
            PersonLabel.AutoSize = true;
            PersonLabel.Location = new Point(32, 286);
            PersonLabel.Name = "PersonLabel";
            PersonLabel.Size = new Size(50, 20);
            PersonLabel.TabIndex = 27;
            PersonLabel.Text = "Datos de la Persona:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(32, 20);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(50, 20);
            UserLabel.TabIndex = 28;
            UserLabel.Text = "Datos del Usuario:";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(32, 392);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(83, 20);
            ConfirmPasswordLabel.TabIndex = 29;
            ConfirmPasswordLabel.Text = "Confirmar contraseña";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(187, 392);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(346, 26);
            ConfirmPasswordTextBox.TabIndex = 30;
            // 
            // UserDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 523);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(UserLabel);
            Controls.Add(PersonLabel);
            Controls.Add(CancelButton);
            Controls.Add(AcceptButton);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(AddressTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(BirthDateLabel);
            Controls.Add(BirthDateTextBox);
            Controls.Add(IDPlanLabel);
            Controls.Add(IDPlanTextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Name = "UserDetalle";
            Text = "Detalle de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox AddressTextBox;
        private Label AddressLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox BirthDateTextBox;
        private Label BirthDateLabel;
        private TextBox IDPlanTextBox;
        private Label IDPlanLabel;
        private TextBox UsernameTextBox;
        private Label UsernameLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Button AcceptButton;
        private Button CancelButton;
        private Label PersonLabel;
        private Label UserLabel;
        private Label ConfirmPasswordLabel;
        private TextBox ConfirmPasswordTextBox;
    }
}
