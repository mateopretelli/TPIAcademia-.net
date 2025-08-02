using System.Windows.Forms;

namespace WindowsForms
{
    partial class SpecialtiesLista
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
            ((System.ComponentModel.ISupportInitialize)specialtiesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // specialtiesDataGridView
            // 
            specialtiesDataGridView.AllowUserToOrderColumns = true;
            specialtiesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            specialtiesDataGridView.Location = new Point(12, 15);
            specialtiesDataGridView.Name = "specialtiesDataGridView";
            specialtiesDataGridView.ReadOnly = true;
            specialtiesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            specialtiesDataGridView.Size = new Size(776, 339);
            specialtiesDataGridView.TabIndex = 0;
            specialtiesDataGridView.CellContentClick += specialtiesDataGridView_CellContentClick;
            // 
            // addSpecialtyButton
            // 
            addSpecialtyButton.Location = new Point(551, 369);
            addSpecialtyButton.Name = "addSpecialtyButton";
            addSpecialtyButton.Size = new Size(75, 23);
            addSpecialtyButton.TabIndex = 1;
            addSpecialtyButton.Text = "Agregar";
            addSpecialtyButton.UseVisualStyleBackColor = true;
            addSpecialtyButton.Click += addButton_Click;
            // 
            // deleteSpecialtyButton
            // 
            deleteSpecialtyButton.Location = new Point(632, 369);
            deleteSpecialtyButton.Name = "deleteSpecialtyButton";
            deleteSpecialtyButton.Size = new Size(75, 23);
            deleteSpecialtyButton.TabIndex = 2;
            deleteSpecialtyButton.Text = "Eliminar";
            deleteSpecialtyButton.UseVisualStyleBackColor = true;
            deleteSpecialtyButton.Click += deleteButton_Click;
            // 
            // updateSpecialtyButton
            // 
            updateSpecialtyButton.Location = new Point(713, 369);
            updateSpecialtyButton.Name = "updateSpecialtyButton";
            updateSpecialtyButton.Size = new Size(75, 23);
            updateSpecialtyButton.TabIndex = 3;
            updateSpecialtyButton.Text = "Modificar";
            updateSpecialtyButton.UseVisualStyleBackColor = true;
            updateSpecialtyButton.Click += updateButton_Click;
            // 
            // SpecialtiesHomeButton
            // 
            specialtiesHomeButton.Location = new Point(12, 369);
            specialtiesHomeButton.Name = "specialtiesHomeButton";
            specialtiesHomeButton.Size = new Size(111, 50);
            specialtiesHomeButton.TabIndex = 4;
            specialtiesHomeButton.Text = "Volver al Menu";
            specialtiesHomeButton.UseVisualStyleBackColor = true;
            specialtiesHomeButton.Click += specialtiesHomeButton_Click;
            // 
            // SpecialtiesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(specialtiesHomeButton);
            Controls.Add(updateSpecialtyButton);
            Controls.Add(deleteSpecialtyButton);
            Controls.Add(addSpecialtyButton);
            Controls.Add(specialtiesDataGridView);
            Name = "SpecialtiesLista";
            Text = "Specialties";
            Load += Specialties_Load;
            ((System.ComponentModel.ISupportInitialize)specialtiesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView specialtiesDataGridView;
        private Button addSpecialtyButton;
        private Button deleteSpecialtyButton;
        private Button updateSpecialtyButton;
        private Button specialtiesHomeButton;
    }
}