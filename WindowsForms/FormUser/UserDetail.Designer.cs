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
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();

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
            LastNameTextBox.Location = new Point(187, 87);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(346, 26);
            LastNameTextBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(32, 87);
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
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(32, 217);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(128, 20);
            BirthDateLabel.TabIndex = 14;
            BirthDateLabel.Text = "Fecha Nacimiento";
            // 
            // IDPlanComboBox
            // 
            IDPlanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDPlanComboBox.DropDownWidth = 280;
            IDPlanComboBox.FormattingEnabled = true;
            IDPlanComboBox.Location = new Point(187, 281);
            IDPlanComboBox.Name = "IDPlanComboBox";
            IDPlanComboBox.Size = new Size(345, 27);
            IDPlanComboBox.TabIndex = 15;
            IDPlanComboBox.SelectedIndexChanged += IDPlanComboBox_SelectedIndexChanged;
            IDPlanComboBox.VisibleChanged += IDPlanComboBoxData;
            // 
            // IDPlanLabel
            // 
            IDPlanLabel.AutoSize = true;
            IDPlanLabel.Location = new Point(32, 281);
            IDPlanLabel.Name = "IDPlanLabel";
            IDPlanLabel.Size = new Size(56, 20);
            IDPlanLabel.TabIndex = 16;
            IDPlanLabel.Text = "ID Plan";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(187, 362);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(346, 26);
            UsernameTextBox.TabIndex = 19;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(32, 362);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(137, 20);
            UsernameLabel.TabIndex = 18;
            UsernameLabel.Text = "Nombre de usuario";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(187, 394);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(346, 26);
            PasswordTextBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(32, 394);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(83, 20);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Contraseña";
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(315, 470);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(102, 44);
            AcceptButton.TabIndex = 24;
            AcceptButton.Text = "Aceptar";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptUserButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(431, 470);
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
            PersonLabel.Location = new Point(32, 322);
            PersonLabel.Name = "PersonLabel";
            PersonLabel.Size = new Size(143, 20);
            PersonLabel.TabIndex = 27;
            PersonLabel.Text = "Datos del usuario:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(32, 20);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(130, 20);
            UserLabel.TabIndex = 28;
            UserLabel.Text = "Datos de la persona:";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(32, 425);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(151, 20);
            ConfirmPasswordLabel.TabIndex = 29;
            ConfirmPasswordLabel.Text = "Confirmar contraseña";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(187, 425);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(346, 26);
            ConfirmPasswordTextBox.TabIndex = 30;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(187, 217);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(345, 26);
            BirthDatePicker.TabIndex = 0;
            BirthDatePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(32, 249);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(39, 20);
            TypeLabel.TabIndex = 32;
            TypeLabel.Text = "Tipo";
            TypeLabel.Click += label1_Click;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Location = new Point(187, 249);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(345, 27);
            TypeComboBox.TabIndex = 34;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 545);
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
            Name = "UserDetalle";
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
        private ErrorProvider errorProvider1;
    }
}
