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
            addMateriaButton = new Button();
            deleteMateriaButton = new Button();
            updateMateriaButton = new Button();
            MateriasHomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // materiasDataGridView
            // 
            materiasDataGridView.AllowUserToOrderColumns = true;
            materiasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            materiasDataGridView.Location = new Point(12, 15);
            materiasDataGridView.Name = "materiasDataGridView";
            materiasDataGridView.ReadOnly = true;
            materiasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materiasDataGridView.Size = new Size(776, 339);
            materiasDataGridView.TabIndex = 0;
            materiasDataGridView.CellContentClick += materiasDataGridView_CellContentClick;
            // 
            // addMateriaButton
            // 
            addMateriaButton.Location = new Point(551, 369);
            addMateriaButton.Size = new Size(75, 23);
            addMateriaButton.TabIndex = 1;
            addMateriaButton.Name = "addMateriaButton";
            addMateriaButton.Text = "Agregar";
            addMateriaButton.UseVisualStyleBackColor = true;
            addMateriaButton.Click += addMateriaButton_Click;
            // 
            // deleteMateriaButton
            // 
            deleteMateriaButton.Location = new Point(632, 369);
            deleteMateriaButton.Name = "deleteMateriaButton";
            deleteMateriaButton.Size = new Size(75, 23);
            deleteMateriaButton.TabIndex = 2;
            deleteMateriaButton.Text = "Eliminar";
            deleteMateriaButton.UseVisualStyleBackColor = true;
            deleteMateriaButton.Click += deleteMateriaButton_Click;
            // 
            // updateMateriaButton
            // 
            updateMateriaButton.Location = new Point(713, 369);
            updateMateriaButton.Name = "updateMateriaButton";
            updateMateriaButton.Size = new Size(75, 23);
            updateMateriaButton.TabIndex = 3;
            updateMateriaButton.Text = "Modificar";
            updateMateriaButton.UseVisualStyleBackColor = true;
            updateMateriaButton.Click += updateMateriaButton_Click;
            // 
            // MateriasHomeButton
            // 
            MateriasHomeButton.Location = new Point(12, 369);
            MateriasHomeButton.Name = "MateriasHomeButton";
            MateriasHomeButton.Size = new Size(111, 50);
            MateriasHomeButton.TabIndex = 4;
            MateriasHomeButton.Text = "Volver al Menu";
            MateriasHomeButton.UseVisualStyleBackColor = true;
            MateriasHomeButton.Click += MateriasHomeButton_Click;
            // 
            // MateriasLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MateriasHomeButton);
            Controls.Add(updateMateriaButton);
            Controls.Add(deleteMateriaButton);
            Controls.Add(addMateriaButton);
            Controls.Add(materiasDataGridView);
            Name = "MateriasLista";
            Text = "Materias";
            Load += Materias_Load;
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView materiasDataGridView;
        private Button addMateriaButton;
        private Button deleteMateriaButton;
        private Button updateMateriaButton;
        private Button MateriasHomeButton;
    }
}
