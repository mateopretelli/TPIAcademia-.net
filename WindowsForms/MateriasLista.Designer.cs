namespace WindowsForms
{
    partial class MateriasLista
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
            materiasDataGridView = new DataGridView();
            addButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // materiasDataGridView
            // 
            materiasDataGridView.AllowUserToOrderColumns = true;
            materiasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiasDataGridView.Location = new Point(12, 15);
            materiasDataGridView.Name = "materiasDataGridView";
            materiasDataGridView.ReadOnly = true;
            materiasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materiasDataGridView.Size = new Size(776, 339);
            materiasDataGridView.TabIndex = 0;
            materiasDataGridView.CellContentClick += materiasDataGridView_CellContentClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(551, 369);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(632, 369);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(713, 369);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 3;
            updateButton.Text = "Modificar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // MateriasLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(materiasDataGridView);
            Name = "MateriasLista";
            Text = "Materias";
            Load += Materias_Load;
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView materiasDataGridView;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
    }
}
