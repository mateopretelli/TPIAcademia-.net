namespace WindowsForms
{
    partial class PlanesLista
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
            planesDataGridView = new DataGridView();
            addPlanButton = new Button();
            deletePlanButton = new Button();
            updatePlanButton = new Button();
            PlanesHomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // planesDataGridView
            // 
            planesDataGridView.AllowUserToOrderColumns = true;
            planesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            planesDataGridView.Location = new Point(12, 15);
            planesDataGridView.Name = "planesDataGridView";
            planesDataGridView.ReadOnly = true;
            planesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesDataGridView.Size = new Size(776, 339);
            planesDataGridView.TabIndex = 0;
            planesDataGridView.CellContentClick += planesDataGridView_CellContentClick;
            // 
            // addPlanButton
            // 
            addPlanButton.Location = new Point(551, 369);
            addPlanButton.Name = "addPlanButton";
            addPlanButton.Size = new Size(75, 23);
            addPlanButton.TabIndex = 1;
            addPlanButton.Text = "Agregar";
            addPlanButton.UseVisualStyleBackColor = true;
            addPlanButton.Click += addButton_Click;
            // 
            // deletePlanButton
            // 
            deletePlanButton.Location = new Point(632, 369);
            deletePlanButton.Name = "deletePlanButton";
            deletePlanButton.Size = new Size(75, 23);
            deletePlanButton.TabIndex = 2;
            deletePlanButton.Text = "Eliminar";
            deletePlanButton.UseVisualStyleBackColor = true;
            deletePlanButton.Click += deleteButton_Click;
            // 
            // updatePlanButton
            // 
            updatePlanButton.Location = new Point(713, 369);
            updatePlanButton.Name = "updatePlanButton";
            updatePlanButton.Size = new Size(75, 23);
            updatePlanButton.TabIndex = 3;
            updatePlanButton.Text = "Modificar";
            updatePlanButton.UseVisualStyleBackColor = true;
            updatePlanButton.Click += updateButton_Click;
            // 
            // PlanesHomeButton
            // 
            PlanesHomeButton.Location = new Point(12, 369);
            PlanesHomeButton.Name = "PlanesHomeButton";
            PlanesHomeButton.Size = new Size(111, 50);
            PlanesHomeButton.TabIndex = 4;
            PlanesHomeButton.Text = "Volver al Menu";
            PlanesHomeButton.UseVisualStyleBackColor = true;
            PlanesHomeButton.Click += PlanesHomeButton_Click;
            // 
            // PlanesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlanesHomeButton);
            Controls.Add(updatePlanButton);
            Controls.Add(deletePlanButton);
            Controls.Add(addPlanButton);
            Controls.Add(planesDataGridView);
            Name = "PlanesLista";
            Text = "Planes";
            Load += Planes_Load;
            ((System.ComponentModel.ISupportInitialize)planesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView planesDataGridView;
        private Button addPlanButton;
        private Button deletePlanButton;
        private Button updatePlanButton;
        private Button PlanesHomeButton;
    }
}
