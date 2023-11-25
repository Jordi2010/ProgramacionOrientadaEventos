namespace PresentationLayer.Forms
{
    partial class UserForm
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
            userSearchTextBox = new TextBox();
            userSearchLabel = new Label();
            pdfUserButton = new Button();
            deleteUserButton = new Button();
            userDataGridView = new DataGridView();
            userManagementLabel = new Label();
            userInformationGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userSearchTextBox
            // 
            userSearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSearchTextBox.Location = new Point(51, 113);
            userSearchTextBox.Name = "userSearchTextBox";
            userSearchTextBox.Size = new Size(986, 27);
            userSearchTextBox.TabIndex = 33;
            // 
            // userSearchLabel
            // 
            userSearchLabel.AutoSize = true;
            userSearchLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            userSearchLabel.ForeColor = Color.White;
            userSearchLabel.Location = new Point(54, 84);
            userSearchLabel.Name = "userSearchLabel";
            userSearchLabel.Size = new Size(128, 21);
            userSearchLabel.TabIndex = 32;
            userSearchLabel.Text = "Buscar usuario";
            // 
            // pdfUserButton
            // 
            pdfUserButton.BackColor = Color.RoyalBlue;
            pdfUserButton.FlatAppearance.BorderColor = Color.Teal;
            pdfUserButton.FlatStyle = FlatStyle.Flat;
            pdfUserButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            pdfUserButton.ForeColor = Color.White;
            pdfUserButton.Location = new Point(576, 585);
            pdfUserButton.Name = "pdfUserButton";
            pdfUserButton.Size = new Size(110, 31);
            pdfUserButton.TabIndex = 31;
            pdfUserButton.Text = "PDF";
            pdfUserButton.UseVisualStyleBackColor = false;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.RoyalBlue;
            deleteUserButton.FlatAppearance.BorderColor = Color.Teal;
            deleteUserButton.FlatStyle = FlatStyle.Flat;
            deleteUserButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteUserButton.ForeColor = Color.White;
            deleteUserButton.Location = new Point(380, 585);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(110, 31);
            deleteUserButton.TabIndex = 30;
            deleteUserButton.Text = "Eliminar";
            deleteUserButton.UseVisualStyleBackColor = false;
            // 
            // userDataGridView
            // 
            userDataGridView.AllowUserToAddRows = false;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            userDataGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            userDataGridView.BorderStyle = BorderStyle.None;
            userDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.Location = new Point(51, 151);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            userDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGridView.Size = new Size(986, 387);
            userDataGridView.TabIndex = 29;
            // 
            // userManagementLabel
            // 
            userManagementLabel.AutoSize = true;
            userManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            userManagementLabel.ForeColor = Color.White;
            userManagementLabel.Location = new Point(407, 15);
            userManagementLabel.Name = "userManagementLabel";
            userManagementLabel.Size = new Size(287, 25);
            userManagementLabel.TabIndex = 28;
            userManagementLabel.Text = "Administración de usuarios";
            // 
            // userInformationGroupBox
            // 
            userInformationGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            userInformationGroupBox.ForeColor = Color.White;
            userInformationGroupBox.Location = new Point(12, 51);
            userInformationGroupBox.Name = "userInformationGroupBox";
            userInformationGroupBox.Size = new Size(1060, 615);
            userInformationGroupBox.TabIndex = 34;
            userInformationGroupBox.TabStop = false;
            userInformationGroupBox.Text = "Información de usuarios";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1084, 676);
            Controls.Add(userSearchTextBox);
            Controls.Add(userSearchLabel);
            Controls.Add(pdfUserButton);
            Controls.Add(deleteUserButton);
            Controls.Add(userDataGridView);
            Controls.Add(userManagementLabel);
            Controls.Add(userInformationGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userSearchTextBox;
        private Label userSearchLabel;
        private Button pdfUserButton;
        private Button deleteUserButton;
        private DataGridView userDataGridView;
        private Label userManagementLabel;
        private GroupBox userInformationGroupBox;
    }
}