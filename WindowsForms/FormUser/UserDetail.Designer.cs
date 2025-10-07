namespace WindowsForms
{

    partial class UserDetail

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
            components = new System.ComponentModel.Container();
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
            BirthDatePicker = new DateTimePicker();
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            UserIDLabel = new Label();
            UserStateLabel = new Label();
            UserIDTextBox = new TextBox();
            UserStateTextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(165, 81);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(303, 23);
            NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(30, 84);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(51, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Nombre";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(165, 106);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(303, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(30, 106);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(51, 15);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Apellido";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(165, 132);
            EmailTextBox.Margin = new Padding(3, 2, 3, 2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(303, 23);
            EmailTextBox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(30, 132);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(165, 157);
            AddressTextBox.Margin = new Padding(3, 2, 3, 2);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(303, 23);
            AddressTextBox.TabIndex = 9;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(30, 157);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(57, 15);
            AddressLabel.TabIndex = 8;
            AddressLabel.Text = "Direccion";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(165, 182);
            PhoneTextBox.Margin = new Padding(3, 2, 3, 2);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(303, 23);
            PhoneTextBox.TabIndex = 11;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(30, 182);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(52, 15);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Telefono";
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(30, 208);
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
            IDPlanComboBox.Location = new Point(165, 259);
            IDPlanComboBox.Margin = new Padding(3, 2, 3, 2);
            IDPlanComboBox.Name = "IDPlanComboBox";
            IDPlanComboBox.Size = new Size(302, 23);
            IDPlanComboBox.TabIndex = 15;
            IDPlanComboBox.VisibleChanged += IDPlanComboBoxData;
            // 
            // IDPlanLabel
            // 
            IDPlanLabel.AutoSize = true;
            IDPlanLabel.Location = new Point(30, 259);
            IDPlanLabel.Name = "IDPlanLabel";
            IDPlanLabel.Size = new Size(44, 15);
            IDPlanLabel.TabIndex = 16;
            IDPlanLabel.Text = "ID Plan";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(165, 325);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(303, 23);
            UsernameTextBox.TabIndex = 19;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(30, 325);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(109, 15);
            UsernameLabel.TabIndex = 18;
            UsernameLabel.Text = "Nombre de usuario";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(165, 350);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(303, 23);
            PasswordTextBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(30, 350);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 15);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Contraseña";
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(277, 410);
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
            CancelButton.Location = new Point(378, 410);
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
            PersonLabel.Location = new Point(20, 293);
            PersonLabel.Name = "PersonLabel";
            PersonLabel.Size = new Size(101, 15);
            PersonLabel.TabIndex = 27;
            PersonLabel.Text = "Datos del usuario:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(18, 22);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(113, 15);
            UserLabel.TabIndex = 28;
            UserLabel.Text = "Datos de la persona:";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(30, 375);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(122, 15);
            ConfirmPasswordLabel.TabIndex = 29;
            ConfirmPasswordLabel.Text = "Confirmar contraseña";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(165, 375);
            ConfirmPasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(303, 23);
            ConfirmPasswordTextBox.TabIndex = 30;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(165, 208);
            BirthDatePicker.Margin = new Padding(3, 2, 3, 2);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(302, 23);
            BirthDatePicker.TabIndex = 0;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(30, 234);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(30, 15);
            TypeLabel.TabIndex = 32;
            TypeLabel.Text = "Tipo";
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Location = new Point(165, 234);
            TypeComboBox.Margin = new Padding(3, 2, 3, 2);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(302, 23);
            TypeComboBox.TabIndex = 34;
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Location = new Point(30, 53);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(18, 15);
            UserIDLabel.TabIndex = 35;
            UserIDLabel.Text = "ID";
            // 
            // UserStateLabel
            // 
            UserStateLabel.AutoSize = true;
            UserStateLabel.Location = new Point(262, 53);
            UserStateLabel.Name = "UserStateLabel";
            UserStateLabel.Size = new Size(42, 15);
            UserStateLabel.TabIndex = 36;
            UserStateLabel.Text = "Estado";
            // 
            // UserIDTextBox
            // 
            UserIDTextBox.Enabled = false;
            UserIDTextBox.Location = new Point(164, 50);
            UserIDTextBox.Margin = new Padding(3, 2, 3, 2);
            UserIDTextBox.Name = "UserIDTextBox";
            UserIDTextBox.Size = new Size(58, 23);
            UserIDTextBox.TabIndex = 37;
            // 
            // UserStateTextBox
            // 
            UserStateTextBox.Enabled = false;
            UserStateTextBox.Location = new Point(310, 50);
            UserStateTextBox.Margin = new Padding(3, 2, 3, 2);
            UserStateTextBox.Name = "UserStateTextBox";
            UserStateTextBox.Size = new Size(158, 23);
            UserStateTextBox.TabIndex = 38;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 478);
            Controls.Add(TypeComboBox);
            Controls.Add(TypeLabel);
            Controls.Add(BirthDatePicker);
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
            Controls.Add(IDPlanLabel);
            Controls.Add(IDPlanComboBox);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserIDLabel);
            Controls.Add(UserStateLabel);
            Controls.Add(UserIDTextBox);
            Controls.Add(UserStateTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserDetail";
            Text = "Detalle de Usuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private DateTimePicker BirthDatePicker;
        private Label TypeLabel;
        private ComboBox TypeComboBox;
        private Label UserIDLabel;
        private Label UserStateLabel;
        private TextBox UserIDTextBox;
        private TextBox UserStateTextBox;
        private ErrorProvider errorProvider1;
    }
}
