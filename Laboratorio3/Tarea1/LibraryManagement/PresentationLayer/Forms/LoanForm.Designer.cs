namespace PresentationLayer.Forms
{
    partial class LoanForm
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
            saveLoanButton = new Button();
            loanSearchTextBox = new TextBox();
            loanSearchLabel = new Label();
            pdfLoanButton = new Button();
            deleteLoanButton = new Button();
            loanReturnDateLabel = new Label();
            loanDateLabel = new Label();
            loanCustomerTextBox = new TextBox();
            loanCustomerLabel = new Label();
            loanBookLabel = new Label();
            loanDataGridView = new DataGridView();
            loanInformationGroupBox = new GroupBox();
            loanRegistryGroupBox = new GroupBox();
            loanReturnDateDateTimePicker = new DateTimePicker();
            loanDateDateTimePicker = new DateTimePicker();
            loanBookComboBox = new ComboBox();
            loanManagementLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)loanDataGridView).BeginInit();
            loanRegistryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // saveLoanButton
            // 
            saveLoanButton.BackColor = Color.FromArgb(25, 42, 86);
            saveLoanButton.FlatAppearance.BorderColor = Color.Teal;
            saveLoanButton.FlatStyle = FlatStyle.Flat;
            saveLoanButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveLoanButton.ForeColor = Color.White;
            saveLoanButton.Location = new Point(833, 583);
            saveLoanButton.Name = "saveLoanButton";
            saveLoanButton.Size = new Size(110, 31);
            saveLoanButton.TabIndex = 35;
            saveLoanButton.Text = "Guardar";
            saveLoanButton.UseVisualStyleBackColor = false;
            saveLoanButton.Click += saveLoanButton_Click;
            // 
            // loanSearchTextBox
            // 
            loanSearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loanSearchTextBox.Location = new Point(15, 113);
            loanSearchTextBox.Name = "loanSearchTextBox";
            loanSearchTextBox.Size = new Size(664, 27);
            loanSearchTextBox.TabIndex = 40;
            // 
            // loanSearchLabel
            // 
            loanSearchLabel.AutoSize = true;
            loanSearchLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanSearchLabel.ForeColor = Color.White;
            loanSearchLabel.Location = new Point(16, 84);
            loanSearchLabel.Name = "loanSearchLabel";
            loanSearchLabel.Size = new Size(150, 21);
            loanSearchLabel.TabIndex = 39;
            loanSearchLabel.Text = "Buscar préstamo";
            // 
            // pdfLoanButton
            // 
            pdfLoanButton.BackColor = Color.RoyalBlue;
            pdfLoanButton.FlatAppearance.BorderColor = Color.Teal;
            pdfLoanButton.FlatStyle = FlatStyle.Flat;
            pdfLoanButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            pdfLoanButton.ForeColor = Color.White;
            pdfLoanButton.Location = new Point(382, 585);
            pdfLoanButton.Name = "pdfLoanButton";
            pdfLoanButton.Size = new Size(110, 31);
            pdfLoanButton.TabIndex = 38;
            pdfLoanButton.Text = "PDF";
            pdfLoanButton.UseVisualStyleBackColor = false;
            // 
            // deleteLoanButton
            // 
            deleteLoanButton.BackColor = Color.RoyalBlue;
            deleteLoanButton.FlatAppearance.BorderColor = Color.Teal;
            deleteLoanButton.FlatStyle = FlatStyle.Flat;
            deleteLoanButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteLoanButton.ForeColor = Color.White;
            deleteLoanButton.Location = new Point(186, 585);
            deleteLoanButton.Name = "deleteLoanButton";
            deleteLoanButton.Size = new Size(110, 31);
            deleteLoanButton.TabIndex = 37;
            deleteLoanButton.Text = "Eliminar";
            deleteLoanButton.UseVisualStyleBackColor = false;
            deleteLoanButton.Click += deleteLoanButton_Click;
            // 
            // loanReturnDateLabel
            // 
            loanReturnDateLabel.AutoSize = true;
            loanReturnDateLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanReturnDateLabel.ForeColor = Color.White;
            loanReturnDateLabel.Location = new Point(10, 362);
            loanReturnDateLabel.Name = "loanReturnDateLabel";
            loanReturnDateLabel.Size = new Size(280, 21);
            loanReturnDateLabel.TabIndex = 21;
            loanReturnDateLabel.Text = "Fecha de devolución esperada:";
            // 
            // loanDateLabel
            // 
            loanDateLabel.AutoSize = true;
            loanDateLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanDateLabel.ForeColor = Color.White;
            loanDateLabel.Location = new Point(702, 324);
            loanDateLabel.Name = "loanDateLabel";
            loanDateLabel.Size = new Size(180, 21);
            loanDateLabel.TabIndex = 33;
            loanDateLabel.Text = "Fecha de préstamo:";
            // 
            // loanCustomerTextBox
            // 
            loanCustomerTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanCustomerTextBox.Location = new Point(10, 215);
            loanCustomerTextBox.Name = "loanCustomerTextBox";
            loanCustomerTextBox.PlaceholderText = "ejemplo: Andrew Lauttner";
            loanCustomerTextBox.Size = new Size(364, 26);
            loanCustomerTextBox.TabIndex = 32;
            // 
            // loanCustomerLabel
            // 
            loanCustomerLabel.AutoSize = true;
            loanCustomerLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanCustomerLabel.ForeColor = Color.White;
            loanCustomerLabel.Location = new Point(10, 186);
            loanCustomerLabel.Name = "loanCustomerLabel";
            loanCustomerLabel.Size = new Size(74, 21);
            loanCustomerLabel.TabIndex = 25;
            loanCustomerLabel.Text = "Cliente:";
            // 
            // loanBookLabel
            // 
            loanBookLabel.AutoSize = true;
            loanBookLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanBookLabel.ForeColor = Color.White;
            loanBookLabel.Location = new Point(702, 148);
            loanBookLabel.Name = "loanBookLabel";
            loanBookLabel.Size = new Size(54, 21);
            loanBookLabel.TabIndex = 31;
            loanBookLabel.Text = "Libro:";
            // 
            // loanDataGridView
            // 
            loanDataGridView.AllowUserToAddRows = false;
            loanDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            loanDataGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            loanDataGridView.BorderStyle = BorderStyle.None;
            loanDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            loanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            loanDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loanDataGridView.EnableHeadersVisualStyles = false;
            loanDataGridView.Location = new Point(15, 151);
            loanDataGridView.Name = "loanDataGridView";
            loanDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            loanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            loanDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            loanDataGridView.RowTemplate.Height = 25;
            loanDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loanDataGridView.Size = new Size(664, 387);
            loanDataGridView.TabIndex = 30;
            // 
            // loanInformationGroupBox
            // 
            loanInformationGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanInformationGroupBox.ForeColor = Color.White;
            loanInformationGroupBox.Location = new Point(7, 51);
            loanInformationGroupBox.Name = "loanInformationGroupBox";
            loanInformationGroupBox.Size = new Size(679, 615);
            loanInformationGroupBox.TabIndex = 41;
            loanInformationGroupBox.TabStop = false;
            loanInformationGroupBox.Text = "Información de préstamos";
            // 
            // loanRegistryGroupBox
            // 
            loanRegistryGroupBox.Controls.Add(loanReturnDateDateTimePicker);
            loanRegistryGroupBox.Controls.Add(loanDateDateTimePicker);
            loanRegistryGroupBox.Controls.Add(loanBookComboBox);
            loanRegistryGroupBox.Controls.Add(loanCustomerLabel);
            loanRegistryGroupBox.Controls.Add(loanReturnDateLabel);
            loanRegistryGroupBox.Controls.Add(loanCustomerTextBox);
            loanRegistryGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanRegistryGroupBox.ForeColor = Color.White;
            loanRegistryGroupBox.Location = new Point(692, 51);
            loanRegistryGroupBox.Name = "loanRegistryGroupBox";
            loanRegistryGroupBox.Size = new Size(385, 615);
            loanRegistryGroupBox.TabIndex = 42;
            loanRegistryGroupBox.TabStop = false;
            loanRegistryGroupBox.Text = "Registro de préstamos";
            // 
            // loanReturnDateDateTimePicker
            // 
            loanReturnDateDateTimePicker.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanReturnDateDateTimePicker.Location = new Point(10, 391);
            loanReturnDateDateTimePicker.Name = "loanReturnDateDateTimePicker";
            loanReturnDateDateTimePicker.Size = new Size(364, 26);
            loanReturnDateDateTimePicker.TabIndex = 29;
            // 
            // loanDateDateTimePicker
            // 
            loanDateDateTimePicker.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanDateDateTimePicker.Location = new Point(10, 304);
            loanDateDateTimePicker.Name = "loanDateDateTimePicker";
            loanDateDateTimePicker.Size = new Size(364, 26);
            loanDateDateTimePicker.TabIndex = 28;
            // 
            // loanBookComboBox
            // 
            loanBookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            loanBookComboBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loanBookComboBox.FormattingEnabled = true;
            loanBookComboBox.Location = new Point(10, 126);
            loanBookComboBox.Name = "loanBookComboBox";
            loanBookComboBox.Size = new Size(364, 28);
            loanBookComboBox.TabIndex = 27;
            // 
            // loanManagementLabel
            // 
            loanManagementLabel.AutoSize = true;
            loanManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loanManagementLabel.ForeColor = Color.White;
            loanManagementLabel.Location = new Point(384, 11);
            loanManagementLabel.Name = "loanManagementLabel";
            loanManagementLabel.Size = new Size(309, 25);
            loanManagementLabel.TabIndex = 29;
            loanManagementLabel.Text = "Administración de préstamos";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1084, 676);
            Controls.Add(saveLoanButton);
            Controls.Add(loanSearchTextBox);
            Controls.Add(loanSearchLabel);
            Controls.Add(pdfLoanButton);
            Controls.Add(deleteLoanButton);
            Controls.Add(loanDateLabel);
            Controls.Add(loanBookLabel);
            Controls.Add(loanDataGridView);
            Controls.Add(loanInformationGroupBox);
            Controls.Add(loanRegistryGroupBox);
            Controls.Add(loanManagementLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoanForm";
            Text = "LoanForm";
            ((System.ComponentModel.ISupportInitialize)loanDataGridView).EndInit();
            loanRegistryGroupBox.ResumeLayout(false);
            loanRegistryGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveLoanButton;
        private TextBox loanSearchTextBox;
        private Label loanSearchLabel;
        private Button pdfLoanButton;
        private Button deleteLoanButton;
        private Label loanReturnDateLabel;
        private Label loanDateLabel;
        private TextBox loanCustomerTextBox;
        private Label loanCustomerLabel;
        private Label loanBookLabel;
        private DataGridView loanDataGridView;
        private GroupBox loanInformationGroupBox;
        private GroupBox loanRegistryGroupBox;
        private ComboBox loanBookComboBox;
        private Label loanManagementLabel;
        private DateTimePicker loanReturnDateDateTimePicker;
        private DateTimePicker loanDateDateTimePicker;
    }
}