namespace WindowsForms
{
    partial class UserLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userDataGridView = new DataGridView();
            addUserButton = new Button();
            deleteUserButton = new Button();
            updateUserButton = new Button();
            UserHomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usersDataGridView
            // 
            userDataGridView.AllowUserToOrderColumns = true;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            userDataGridView.Location = new Point(12, 15);
            userDataGridView.Name = "usersDataGridView";
            userDataGridView.ReadOnly = true;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Size = new Size(776, 339);
            userDataGridView.TabIndex = 0;
            userDataGridView.CellContentClick += userDataGridView_CellContentClick;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(551, 369);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(75, 23);
            addUserButton.TabIndex = 1;
            addUserButton.Text = "Agregar";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(632, 369);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(75, 23);
            deleteUserButton.TabIndex = 2;
            deleteUserButton.Text = "Eliminar";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteButton_Click;
            // 
            // updateUserButton
            // 
            updateUserButton.Location = new Point(713, 369);
            updateUserButton.Name = "updateUserButton";
            updateUserButton.Size = new Size(75, 23);
            updateUserButton.TabIndex = 3;
            updateUserButton.Text = "Modificar";
            updateUserButton.UseVisualStyleBackColor = true;
            updateUserButton.Click += updateButton_Click;
            // 
            // UsersHomeButton
            // 
            UserHomeButton.Location = new Point(12, 369);
            UserHomeButton.Name = "UsersHomeButton";
            UserHomeButton.Size = new Size(111, 50);
            UserHomeButton.TabIndex = 4;
            UserHomeButton.Text = "Volver al Menu";
            UserHomeButton.UseVisualStyleBackColor = true;
            UserHomeButton.Click += UserHomeButton_Click;
            // 
            // UsersLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserHomeButton);
            Controls.Add(updateUserButton);
            Controls.Add(deleteUserButton);
            Controls.Add(addUserButton);
            Controls.Add(userDataGridView);
            Name = "UsersLista";
            Text = "Usuarios";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView userDataGridView;
        private Button addUserButton;
        private Button deleteUserButton;
        private Button updateUserButton;
        private Button UserHomeButton;
    }
}
