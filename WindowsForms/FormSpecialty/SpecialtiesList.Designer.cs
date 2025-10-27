using System.Windows.Forms;

namespace WindowsForms
{
    partial class SpecialtiesList
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
            specialtiesDataGridView = new DataGridView();
            addSpecialtyButton = new Button();
            deleteSpecialtyButton = new Button();
            updateSpecialtyButton = new Button();
            specialtiesHomeButton = new Button();
            SpecialtySearchBar = new TextBox();
            SpecialtySearchButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)specialtiesDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // specialtiesDataGridView
            // 
            specialtiesDataGridView.AllowUserToOrderColumns = true;
            specialtiesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            specialtiesDataGridView.Dock = DockStyle.Fill;
            specialtiesDataGridView.Location = new Point(0, 0);
            specialtiesDataGridView.Name = "specialtiesDataGridView";
            specialtiesDataGridView.ReadOnly = true;
            specialtiesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            specialtiesDataGridView.Size = new Size(776, 339);
            specialtiesDataGridView.TabIndex = 0;
            specialtiesDataGridView.CellContentClick += specialtiesDataGridView_CellContentClick;
            // 
            // addSpecialtyButton
            // 
            addSpecialtyButton.Location = new Point(551, 388);
            addSpecialtyButton.Name = "addSpecialtyButton";
            addSpecialtyButton.Size = new Size(75, 50);
            addSpecialtyButton.TabIndex = 1;
            addSpecialtyButton.Text = "Agregar";
            addSpecialtyButton.UseVisualStyleBackColor = true;
            addSpecialtyButton.Click += addButton_Click;
            // 
            // deleteSpecialtyButton
            // 
            deleteSpecialtyButton.Location = new Point(632, 388);
            deleteSpecialtyButton.Name = "deleteSpecialtyButton";
            deleteSpecialtyButton.Size = new Size(75, 50);
            deleteSpecialtyButton.TabIndex = 2;
            deleteSpecialtyButton.Text = "Eliminar";
            deleteSpecialtyButton.UseVisualStyleBackColor = true;
            deleteSpecialtyButton.Click += deleteButton_Click;
            // 
            // updateSpecialtyButton
            // 
            updateSpecialtyButton.Location = new Point(713, 388);
            updateSpecialtyButton.Name = "updateSpecialtyButton";
            updateSpecialtyButton.Size = new Size(75, 50);
            updateSpecialtyButton.TabIndex = 3;
            updateSpecialtyButton.Text = "Modificar";
            updateSpecialtyButton.UseVisualStyleBackColor = true;
            updateSpecialtyButton.Click += updateButton_Click;
            // 
            // specialtiesHomeButton
            // 
            specialtiesHomeButton.Location = new Point(12, 388);
            specialtiesHomeButton.Name = "specialtiesHomeButton";
            specialtiesHomeButton.Size = new Size(111, 50);
            specialtiesHomeButton.TabIndex = 4;
            specialtiesHomeButton.Text = "Volver al Menu";
            specialtiesHomeButton.UseVisualStyleBackColor = true;
            specialtiesHomeButton.Click += specialtiesHomeButton_Click;
            // 
            // SpecialtySearchBar
            // 
            SpecialtySearchBar.Location = new Point(12, 12);
            SpecialtySearchBar.Name = "SpecialtySearchBar";
            SpecialtySearchBar.PlaceholderText = "Buscar Especialidad por descripcion";
            SpecialtySearchBar.Size = new Size(304, 23);
            SpecialtySearchBar.TabIndex = 5;
            // 
            // SpecialtySearchButton
            // 
            SpecialtySearchButton.Location = new Point(322, 12);
            SpecialtySearchButton.Name = "SpecialtySearchButton";
            SpecialtySearchButton.Size = new Size(75, 23);
            SpecialtySearchButton.TabIndex = 6;
            SpecialtySearchButton.Text = "Buscar";
            SpecialtySearchButton.UseVisualStyleBackColor = true;
            SpecialtySearchButton.Click += SpecialtySearchButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(specialtiesDataGridView);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 339);
            panel1.TabIndex = 7;
            // 
            // SpecialtiesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(SpecialtySearchButton);
            Controls.Add(SpecialtySearchBar);
            Controls.Add(specialtiesHomeButton);
            Controls.Add(updateSpecialtyButton);
            Controls.Add(deleteSpecialtyButton);
            Controls.Add(addSpecialtyButton);
            Name = "SpecialtiesLista";
            Text = "Specialties";
            Load += Specialties_Load;
            ((System.ComponentModel.ISupportInitialize)specialtiesDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView specialtiesDataGridView;
        private Button addSpecialtyButton;
        private Button deleteSpecialtyButton;
        private Button updateSpecialtyButton;
        private Button specialtiesHomeButton;
        private TextBox SpecialtySearchBar;
        private Button SpecialtySearchButton;
        private Panel panel1;
    }
}