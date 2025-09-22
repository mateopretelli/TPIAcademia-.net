using System.Windows.Forms;

namespace WindowsForms
{
    partial class PlanesList
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
            plansDataGridView = new DataGridView();
            addPlanButton = new Button();
            deletePlanButton = new Button();
            updatePlanButton = new Button();
            PlanHomeButton = new Button();
            PlanSearchBar = new TextBox();
            PlanSearchButton = new Button();
            PlanPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)plansDataGridView).BeginInit();
            PlanPanel.SuspendLayout();
            SuspendLayout();
            // 
            // plansDataGridView
            // 
            plansDataGridView.AllowUserToOrderColumns = true;
            plansDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            plansDataGridView.Dock = DockStyle.Fill;
            plansDataGridView.Location = new Point(34, 27);
            plansDataGridView.Name = "plansDataGridView";
            plansDataGridView.ReadOnly = true;
            plansDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            plansDataGridView.Size = new Size(690, 268);
            plansDataGridView.TabIndex = 0;
            plansDataGridView.CellContentClick += planesDataGridView_CellContentClick;
            // 
            // addPlanButton
            // 
            addPlanButton.Location = new Point(551, 388);
            addPlanButton.Name = "addPlanButton";
            addPlanButton.Size = new Size(75, 50);
            addPlanButton.TabIndex = 1;
            addPlanButton.Text = "Agregar";
            addPlanButton.UseVisualStyleBackColor = true;
            addPlanButton.Click += addButton_Click;
            // 
            // deletePlanButton
            // 
            deletePlanButton.Location = new Point(632, 388);
            deletePlanButton.Name = "deletePlanButton";
            deletePlanButton.Size = new Size(75, 50);
            deletePlanButton.TabIndex = 2;
            deletePlanButton.Text = "Eliminar";
            deletePlanButton.UseVisualStyleBackColor = true;
            deletePlanButton.Click += deleteButton_Click;
            // 
            // updatePlanButton
            // 
            updatePlanButton.Location = new Point(713, 388);
            updatePlanButton.Name = "updatePlanButton";
            updatePlanButton.Size = new Size(75, 50);
            updatePlanButton.TabIndex = 3;
            updatePlanButton.Text = "Modificar";
            updatePlanButton.UseVisualStyleBackColor = true;
            updatePlanButton.Click += updateButton_Click;
            // 
            // PlanHomeButton
            // 
            PlanHomeButton.Location = new Point(12, 388);
            PlanHomeButton.Name = "PlanHomeButton";
            PlanHomeButton.Size = new Size(111, 50);
            PlanHomeButton.TabIndex = 4;
            PlanHomeButton.Text = "Volver al Menu";
            PlanHomeButton.UseVisualStyleBackColor = true;
            PlanHomeButton.Click += PlanesHomeButton_Click;
            // 
            // PlanSearchBar
            // 
            PlanSearchBar.Location = new Point(12, 12);
            PlanSearchBar.Name = "PlanSearchBar";
            PlanSearchBar.PlaceholderText = "Buscar Plan por descripcion";
            PlanSearchBar.Size = new Size(304, 23);
            PlanSearchBar.TabIndex = 5;
            // 
            // PlanSearchButton
            // 
            PlanSearchButton.Location = new Point(322, 12);
            PlanSearchButton.Name = "PlanSearchButton";
            PlanSearchButton.Size = new Size(75, 23);
            PlanSearchButton.TabIndex = 6;
            PlanSearchButton.Text = "Buscar";
            PlanSearchButton.UseVisualStyleBackColor = true;
            PlanSearchButton.Click += PlanSearchButton_Click;
            // 
            // PlanPanel
            // 
            PlanPanel.Controls.Add(plansDataGridView);
            PlanPanel.Location = new Point(12, 41);
            PlanPanel.Name = "PlanPanel";
            PlanPanel.Size = new Size(776, 341);
            PlanPanel.TabIndex = 7;
            // 
            // PlanesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlanPanel);
            Controls.Add(PlanHomeButton);
            Controls.Add(updatePlanButton);
            Controls.Add(deletePlanButton);
            Controls.Add(addPlanButton);
            Controls.Add(PlanSearchBar);
            Controls.Add(PlanSearchButton);
            Name = "PlanesLista";
            Text = "Planes";
            Load += Plans_Load;
            ((System.ComponentModel.ISupportInitialize)plansDataGridView).EndInit();
            PlanPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView plansDataGridView;
        private Button addPlanButton;
        private Button deletePlanButton;
        private Button updatePlanButton;
        private Button PlanHomeButton;
        private TextBox PlanSearchBar;
        private Button PlanSearchButton;
        private Panel PlanPanel;
    }
}
