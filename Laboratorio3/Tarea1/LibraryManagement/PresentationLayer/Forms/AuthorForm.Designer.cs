namespace PresentationLayer.Forms
{
    partial class AuthorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            authorManagementLabel = new Label();
            authorDataGridView = new DataGridView();
            authorFirstNameLabel = new Label();
            authorFirstNameTextBox = new TextBox();
            authorLastNameTextBox = new TextBox();
            authorLastNameLabel = new Label();
            saveAuthorButton = new Button();
            editAuthorButton = new Button();
            deleteAuthorButton = new Button();
            pdfAuthorButton = new Button();
            authorSearchTextBox = new TextBox();
            authorSearchLabel = new Label();
            authorInformationGroupBox = new GroupBox();
            authorRegistryGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).BeginInit();
            authorRegistryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // authorManagementLabel
            // 
            authorManagementLabel.AutoSize = true;
            authorManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            authorManagementLabel.ForeColor = Color.White;
            authorManagementLabel.Location = new Point(384, 9);
            authorManagementLabel.Name = "authorManagementLabel";
            authorManagementLabel.Size = new Size(279, 25);
            authorManagementLabel.TabIndex = 1;
            authorManagementLabel.Text = "Administración de autores";
            // 
            // authorDataGridView
            // 
            authorDataGridView.AllowUserToAddRows = false;
            authorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            authorDataGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            authorDataGridView.BorderStyle = BorderStyle.None;
            authorDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            authorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            authorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorDataGridView.EnableHeadersVisualStyles = false;
            authorDataGridView.Location = new Point(15, 149);
            authorDataGridView.Name = "authorDataGridView";
            authorDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            authorDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            authorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            authorDataGridView.RowTemplate.Height = 25;
            authorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authorDataGridView.Size = new Size(664, 387);
            authorDataGridView.TabIndex = 2;
            // 
            // authorFirstNameLabel
            // 
            authorFirstNameLabel.AutoSize = true;
            authorFirstNameLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorFirstNameLabel.ForeColor = Color.White;
            authorFirstNameLabel.Location = new Point(702, 146);
            authorFirstNameLabel.Name = "authorFirstNameLabel";
            authorFirstNameLabel.Size = new Size(82, 21);
            authorFirstNameLabel.TabIndex = 3;
            authorFirstNameLabel.Text = "Nombre:";
            // 
            // authorFirstNameTextBox
            // 
            authorFirstNameTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            authorFirstNameTextBox.Location = new Point(10, 126);
            authorFirstNameTextBox.Name = "authorFirstNameTextBox";
            authorFirstNameTextBox.PlaceholderText = "ejemplo: Juan";
            authorFirstNameTextBox.Size = new Size(364, 26);
            authorFirstNameTextBox.TabIndex = 4;
            authorFirstNameTextBox.KeyPress += authorFirstNameTextBox_KeyPress;
            // 
            // authorLastNameTextBox
            // 
            authorLastNameTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            authorLastNameTextBox.Location = new Point(10, 203);
            authorLastNameTextBox.Name = "authorLastNameTextBox";
            authorLastNameTextBox.PlaceholderText = "ejemplo: Pérez";
            authorLastNameTextBox.Size = new Size(364, 26);
            authorLastNameTextBox.TabIndex = 6;
            authorLastNameTextBox.KeyPress += authorLastNameTextBox_KeyPress;
            // 
            // authorLastNameLabel
            // 
            authorLastNameLabel.AutoSize = true;
            authorLastNameLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorLastNameLabel.ForeColor = Color.White;
            authorLastNameLabel.Location = new Point(10, 174);
            authorLastNameLabel.Name = "authorLastNameLabel";
            authorLastNameLabel.Size = new Size(83, 21);
            authorLastNameLabel.TabIndex = 5;
            authorLastNameLabel.Text = "Apellido:";
            // 
            // saveAuthorButton
            // 
            saveAuthorButton.BackColor = Color.FromArgb(25, 42, 86);
            saveAuthorButton.FlatAppearance.BorderColor = Color.Teal;
            saveAuthorButton.FlatStyle = FlatStyle.Flat;
            saveAuthorButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveAuthorButton.ForeColor = Color.White;
            saveAuthorButton.Location = new Point(833, 581);
            saveAuthorButton.Name = "saveAuthorButton";
            saveAuthorButton.Size = new Size(110, 31);
            saveAuthorButton.TabIndex = 7;
            saveAuthorButton.Text = "Guardar";
            saveAuthorButton.UseVisualStyleBackColor = false;
            saveAuthorButton.Click += saveAuthorButton_Click;
            // 
            // editAuthorButton
            // 
            editAuthorButton.BackColor = Color.RoyalBlue;
            editAuthorButton.FlatAppearance.BorderColor = Color.Teal;
            editAuthorButton.FlatStyle = FlatStyle.Flat;
            editAuthorButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            editAuthorButton.ForeColor = Color.White;
            editAuthorButton.Location = new Point(87, 583);
            editAuthorButton.Name = "editAuthorButton";
            editAuthorButton.Size = new Size(110, 31);
            editAuthorButton.TabIndex = 8;
            editAuthorButton.Text = "Editar";
            editAuthorButton.UseVisualStyleBackColor = false;
            editAuthorButton.Click += editAuthorButton_Click;
            // 
            // deleteAuthorButton
            // 
            deleteAuthorButton.BackColor = Color.RoyalBlue;
            deleteAuthorButton.FlatAppearance.BorderColor = Color.Teal;
            deleteAuthorButton.FlatStyle = FlatStyle.Flat;
            deleteAuthorButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAuthorButton.ForeColor = Color.White;
            deleteAuthorButton.Location = new Point(285, 583);
            deleteAuthorButton.Name = "deleteAuthorButton";
            deleteAuthorButton.Size = new Size(110, 31);
            deleteAuthorButton.TabIndex = 9;
            deleteAuthorButton.Text = "Eliminar";
            deleteAuthorButton.UseVisualStyleBackColor = false;
            deleteAuthorButton.Click += deleteAuthorButton_Click;
            // 
            // pdfAuthorButton
            // 
            pdfAuthorButton.BackColor = Color.RoyalBlue;
            pdfAuthorButton.FlatAppearance.BorderColor = Color.Teal;
            pdfAuthorButton.FlatStyle = FlatStyle.Flat;
            pdfAuthorButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            pdfAuthorButton.ForeColor = Color.White;
            pdfAuthorButton.Location = new Point(481, 583);
            pdfAuthorButton.Name = "pdfAuthorButton";
            pdfAuthorButton.Size = new Size(110, 31);
            pdfAuthorButton.TabIndex = 10;
            pdfAuthorButton.Text = "PDF";
            pdfAuthorButton.UseVisualStyleBackColor = false;
            // 
            // authorSearchTextBox
            // 
            authorSearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorSearchTextBox.Location = new Point(15, 111);
            authorSearchTextBox.Name = "authorSearchTextBox";
            authorSearchTextBox.Size = new Size(664, 27);
            authorSearchTextBox.TabIndex = 12;
            // 
            // authorSearchLabel
            // 
            authorSearchLabel.AutoSize = true;
            authorSearchLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorSearchLabel.ForeColor = Color.White;
            authorSearchLabel.Location = new Point(16, 82);
            authorSearchLabel.Name = "authorSearchLabel";
            authorSearchLabel.Size = new Size(115, 21);
            authorSearchLabel.TabIndex = 11;
            authorSearchLabel.Text = "Buscar autor";
            // 
            // authorInformationGroupBox
            // 
            authorInformationGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorInformationGroupBox.ForeColor = Color.White;
            authorInformationGroupBox.Location = new Point(7, 49);
            authorInformationGroupBox.Name = "authorInformationGroupBox";
            authorInformationGroupBox.Size = new Size(679, 615);
            authorInformationGroupBox.TabIndex = 13;
            authorInformationGroupBox.TabStop = false;
            authorInformationGroupBox.Text = "Información de autores";
            // 
            // authorRegistryGroupBox
            // 
            authorRegistryGroupBox.Controls.Add(authorFirstNameTextBox);
            authorRegistryGroupBox.Controls.Add(authorLastNameLabel);
            authorRegistryGroupBox.Controls.Add(authorLastNameTextBox);
            authorRegistryGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorRegistryGroupBox.ForeColor = Color.White;
            authorRegistryGroupBox.Location = new Point(692, 49);
            authorRegistryGroupBox.Name = "authorRegistryGroupBox";
            authorRegistryGroupBox.Size = new Size(385, 615);
            authorRegistryGroupBox.TabIndex = 14;
            authorRegistryGroupBox.TabStop = false;
            authorRegistryGroupBox.Text = "Registro de autores";
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1084, 676);
            Controls.Add(authorSearchTextBox);
            Controls.Add(authorSearchLabel);
            Controls.Add(pdfAuthorButton);
            Controls.Add(deleteAuthorButton);
            Controls.Add(editAuthorButton);
            Controls.Add(saveAuthorButton);
            Controls.Add(authorFirstNameLabel);
            Controls.Add(authorDataGridView);
            Controls.Add(authorManagementLabel);
            Controls.Add(authorInformationGroupBox);
            Controls.Add(authorRegistryGroupBox);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorForm";
            Text = "AuthorForm";
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).EndInit();
            authorRegistryGroupBox.ResumeLayout(false);
            authorRegistryGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label authorManagementLabel;
        private DataGridView authorDataGridView;
        private Label authorFirstNameLabel;
        private TextBox authorFirstNameTextBox;
        private TextBox authorLastNameTextBox;
        private Label authorLastNameLabel;
        private Button saveAuthorButton;
        private Button editAuthorButton;
        private Button deleteAuthorButton;
        private Button pdfAuthorButton;
        private TextBox authorSearchTextBox;
        private Label authorSearchLabel;
        private GroupBox authorInformationGroupBox;
        private GroupBox authorRegistryGroupBox;
    }
}