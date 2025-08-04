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
            IDPlanComboBox = new ComboBox();
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
            NameTextBox.Location = new Point(164, 44);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(303, 23);
            NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(28, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(51, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Nombre";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(164, 69);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(303, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(28, 69);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(51, 15);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Apellido";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(164, 95);
            EmailTextBox.Margin = new Padding(3, 2, 3, 2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(303, 23);
            EmailTextBox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(28, 95);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(164, 120);
            AddressTextBox.Margin = new Padding(3, 2, 3, 2);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(303, 23);
            AddressTextBox.TabIndex = 9;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(28, 120);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(57, 15);
            AddressLabel.TabIndex = 8;
            AddressLabel.Text = "Direccion";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(164, 145);
            PhoneTextBox.Margin = new Padding(3, 2, 3, 2);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(303, 23);
            PhoneTextBox.TabIndex = 11;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(28, 145);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(52, 15);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Telefono";
            // 
            // BirthDateTextBox
            // 
            BirthDateTextBox.Location = new Point(164, 171);
            BirthDateTextBox.Margin = new Padding(3, 2, 3, 2);
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.Size = new Size(303, 23);
            BirthDateTextBox.TabIndex = 15;
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(28, 171);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(103, 15);
            BirthDateLabel.TabIndex = 14;
            BirthDateLabel.Text = "Fecha Nacimiento";
            // 
            // IDPlanComboBox
            // 
            IDPlanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDPlanComboBox.DropDownWidth = 280;
            IDPlanComboBox.FormattingEnabled = true;
            IDPlanComboBox.Location = new Point(164, 198);
            IDPlanComboBox.Margin = new Padding(3, 2, 3, 2);
            IDPlanComboBox.Name = "IDPlanComboBox";
            IDPlanComboBox.Size = new Size(302, 23);
            IDPlanComboBox.TabIndex = 15;
            IDPlanComboBox.VisibleChanged += IDPlanComboBoxData;
            // 
            // IDPlanLabel
            // 
            IDPlanLabel.AutoSize = true;
            IDPlanLabel.Location = new Point(28, 196);
            IDPlanLabel.Name = "IDPlanLabel";
            IDPlanLabel.Size = new Size(44, 15);
            IDPlanLabel.TabIndex = 16;
            IDPlanLabel.Text = "ID Plan";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(164, 259);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(303, 23);
            UsernameTextBox.TabIndex = 19;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(28, 259);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(109, 15);
            UsernameLabel.TabIndex = 18;
            UsernameLabel.Text = "Nombre de usuario";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(164, 284);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(303, 23);
            PasswordTextBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(28, 284);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 15);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Contraseña";
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(276, 349);
            AcceptButton.Margin = new Padding(3, 2, 3, 2);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(89, 35);
            AcceptButton.TabIndex = 24;
            AcceptButton.Text = "Aceptar";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptUserButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(377, 349);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(89, 35);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Cancelar";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelUserButton_Click;
            // 
            // PersonLabel
            // 
            PersonLabel.AutoSize = true;
            PersonLabel.Location = new Point(28, 226);
            PersonLabel.Name = "PersonLabel";
            PersonLabel.Size = new Size(113, 15);
            PersonLabel.TabIndex = 27;
            PersonLabel.Text = "Datos de la Persona:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(28, 16);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(102, 15);
            UserLabel.TabIndex = 28;
            UserLabel.Text = "Datos del Usuario:";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(28, 309);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(122, 15);
            ConfirmPasswordLabel.TabIndex = 29;
            ConfirmPasswordLabel.Text = "Confirmar contraseña";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(164, 309);
            ConfirmPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(303, 23);
            ConfirmPasswordTextBox.TabIndex = 30;
            // 
            // UserDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 413);
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
            Controls.Add(IDPlanComboBox);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox IDPlanComboBox;
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
