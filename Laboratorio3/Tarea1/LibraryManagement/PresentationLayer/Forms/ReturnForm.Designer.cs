namespace PresentationLayer.Forms
{
    partial class ReturnForm
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
            saveReturnButton = new Button();
            returnSearchTextBox = new TextBox();
            returnSearchLabel = new Label();
            pdfReturnButton = new Button();
            deleteReturnButton = new Button();
            returnLoanStatusLabel = new Label();
            returnDateLabel = new Label();
            returnLoanStatusComboBox = new ComboBox();
            returnCustomerLabel = new Label();
            returnBookLabel = new Label();
            returnDataGridView = new DataGridView();
            returnInformationGroupBox = new GroupBox();
            returnRegistryGroupBox = new GroupBox();
            returnCustomerNameLabel = new Label();
            returnDateDateTimePicker = new DateTimePicker();
            returnBookComboBox = new ComboBox();
            returnManagementLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)returnDataGridView).BeginInit();
            returnRegistryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // saveReturnButton
            // 
            saveReturnButton.BackColor = Color.FromArgb(25, 42, 86);
            saveReturnButton.FlatAppearance.BorderColor = Color.Teal;
            saveReturnButton.FlatStyle = FlatStyle.Flat;
            saveReturnButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveReturnButton.ForeColor = Color.White;
            saveReturnButton.Location = new Point(833, 583);
            saveReturnButton.Name = "saveReturnButton";
            saveReturnButton.Size = new Size(110, 31);
            saveReturnButton.TabIndex = 35;
            saveReturnButton.Text = "Guardar";
            saveReturnButton.UseVisualStyleBackColor = false;
            saveReturnButton.Click += saveReturnButton_Click;
            // 
            // returnSearchTextBox
            // 
            returnSearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            returnSearchTextBox.Location = new Point(15, 113);
            returnSearchTextBox.Name = "returnSearchTextBox";
            returnSearchTextBox.Size = new Size(664, 27);
            returnSearchTextBox.TabIndex = 40;
            returnSearchTextBox.TextChanged += returnSearchTextBox_TextChanged;
            // 
            // returnSearchLabel
            // 
            returnSearchLabel.AutoSize = true;
            returnSearchLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnSearchLabel.ForeColor = Color.White;
            returnSearchLabel.Location = new Point(16, 84);
            returnSearchLabel.Name = "returnSearchLabel";
            returnSearchLabel.Size = new Size(163, 21);
            returnSearchLabel.TabIndex = 39;
            returnSearchLabel.Text = "Buscar devolución";
            // 
            // pdfReturnButton
            // 
            pdfReturnButton.BackColor = Color.RoyalBlue;
            pdfReturnButton.FlatAppearance.BorderColor = Color.Teal;
            pdfReturnButton.FlatStyle = FlatStyle.Flat;
            pdfReturnButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            pdfReturnButton.ForeColor = Color.White;
            pdfReturnButton.Location = new Point(389, 585);
            pdfReturnButton.Name = "pdfReturnButton";
            pdfReturnButton.Size = new Size(110, 31);
            pdfReturnButton.TabIndex = 38;
            pdfReturnButton.Text = "PDF";
            pdfReturnButton.UseVisualStyleBackColor = false;
            // 
            // deleteReturnButton
            // 
            deleteReturnButton.BackColor = Color.RoyalBlue;
            deleteReturnButton.FlatAppearance.BorderColor = Color.Teal;
            deleteReturnButton.FlatStyle = FlatStyle.Flat;
            deleteReturnButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteReturnButton.ForeColor = Color.White;
            deleteReturnButton.Location = new Point(193, 585);
            deleteReturnButton.Name = "deleteReturnButton";
            deleteReturnButton.Size = new Size(110, 31);
            deleteReturnButton.TabIndex = 37;
            deleteReturnButton.Text = "Eliminar";
            deleteReturnButton.UseVisualStyleBackColor = false;
            deleteReturnButton.Click += deleteReturnButton_Click;
            // 
            // returnLoanStatusLabel
            // 
            returnLoanStatusLabel.AutoSize = true;
            returnLoanStatusLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnLoanStatusLabel.ForeColor = Color.White;
            returnLoanStatusLabel.Location = new Point(10, 353);
            returnLoanStatusLabel.Name = "returnLoanStatusLabel";
            returnLoanStatusLabel.Size = new Size(186, 21);
            returnLoanStatusLabel.TabIndex = 21;
            returnLoanStatusLabel.Text = "Estado de préstamo:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnDateLabel.ForeColor = Color.White;
            returnDateLabel.Location = new Point(10, 268);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new Size(229, 21);
            returnDateLabel.TabIndex = 33;
            returnDateLabel.Text = "Fecha de devolución real:";
            // 
            // returnLoanStatusComboBox
            // 
            returnLoanStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            returnLoanStatusComboBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            returnLoanStatusComboBox.FormattingEnabled = true;
            returnLoanStatusComboBox.Location = new Point(10, 383);
            returnLoanStatusComboBox.Name = "returnLoanStatusComboBox";
            returnLoanStatusComboBox.Size = new Size(363, 28);
            returnLoanStatusComboBox.TabIndex = 28;
            // 
            // returnCustomerLabel
            // 
            returnCustomerLabel.AutoSize = true;
            returnCustomerLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnCustomerLabel.ForeColor = Color.White;
            returnCustomerLabel.Location = new Point(10, 181);
            returnCustomerLabel.Name = "returnCustomerLabel";
            returnCustomerLabel.Size = new Size(174, 21);
            returnCustomerLabel.TabIndex = 25;
            returnCustomerLabel.Text = "Nombre del cliente:";
            // 
            // returnBookLabel
            // 
            returnBookLabel.AutoSize = true;
            returnBookLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnBookLabel.ForeColor = Color.White;
            returnBookLabel.Location = new Point(702, 148);
            returnBookLabel.Name = "returnBookLabel";
            returnBookLabel.Size = new Size(151, 21);
            returnBookLabel.TabIndex = 31;
            returnBookLabel.Text = "Libro a devolver:";
            // 
            // returnDataGridView
            // 
            returnDataGridView.AllowUserToAddRows = false;
            returnDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            returnDataGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            returnDataGridView.BorderStyle = BorderStyle.None;
            returnDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            returnDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            returnDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnDataGridView.EnableHeadersVisualStyles = false;
            returnDataGridView.Location = new Point(15, 151);
            returnDataGridView.Name = "returnDataGridView";
            returnDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            returnDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            returnDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            returnDataGridView.RowTemplate.Height = 25;
            returnDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            returnDataGridView.Size = new Size(664, 387);
            returnDataGridView.TabIndex = 30;
            // 
            // returnInformationGroupBox
            // 
            returnInformationGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnInformationGroupBox.ForeColor = Color.White;
            returnInformationGroupBox.Location = new Point(7, 51);
            returnInformationGroupBox.Name = "returnInformationGroupBox";
            returnInformationGroupBox.Size = new Size(679, 615);
            returnInformationGroupBox.TabIndex = 41;
            returnInformationGroupBox.TabStop = false;
            returnInformationGroupBox.Text = "Información de devoluciones";
            // 
            // returnRegistryGroupBox
            // 
            returnRegistryGroupBox.Controls.Add(returnCustomerNameLabel);
            returnRegistryGroupBox.Controls.Add(returnDateDateTimePicker);
            returnRegistryGroupBox.Controls.Add(returnLoanStatusComboBox);
            returnRegistryGroupBox.Controls.Add(returnBookComboBox);
            returnRegistryGroupBox.Controls.Add(returnCustomerLabel);
            returnRegistryGroupBox.Controls.Add(returnLoanStatusLabel);
            returnRegistryGroupBox.Controls.Add(returnDateLabel);
            returnRegistryGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnRegistryGroupBox.ForeColor = Color.White;
            returnRegistryGroupBox.Location = new Point(692, 51);
            returnRegistryGroupBox.Name = "returnRegistryGroupBox";
            returnRegistryGroupBox.Size = new Size(385, 615);
            returnRegistryGroupBox.TabIndex = 42;
            returnRegistryGroupBox.TabStop = false;
            returnRegistryGroupBox.Text = "Registro de devoluciones";
            // 
            // returnCustomerNameLabel
            // 
            returnCustomerNameLabel.AutoSize = true;
            returnCustomerNameLabel.Location = new Point(10, 209);
            returnCustomerNameLabel.Name = "returnCustomerNameLabel";
            returnCustomerNameLabel.Size = new Size(0, 21);
            returnCustomerNameLabel.TabIndex = 35;
            // 
            // returnDateDateTimePicker
            // 
            returnDateDateTimePicker.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            returnDateDateTimePicker.Location = new Point(10, 298);
            returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            returnDateDateTimePicker.Size = new Size(363, 26);
            returnDateDateTimePicker.TabIndex = 34;
            // 
            // returnBookComboBox
            // 
            returnBookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            returnBookComboBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            returnBookComboBox.FormattingEnabled = true;
            returnBookComboBox.Location = new Point(10, 125);
            returnBookComboBox.Name = "returnBookComboBox";
            returnBookComboBox.Size = new Size(363, 28);
            returnBookComboBox.TabIndex = 27;
            returnBookComboBox.SelectedIndexChanged += returnBookComboBox_SelectedIndexChanged;
            // 
            // returnManagementLabel
            // 
            returnManagementLabel.AutoSize = true;
            returnManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            returnManagementLabel.ForeColor = Color.White;
            returnManagementLabel.Location = new Point(384, 11);
            returnManagementLabel.Name = "returnManagementLabel";
            returnManagementLabel.Size = new Size(392, 25);
            returnManagementLabel.TabIndex = 29;
            returnManagementLabel.Text = "ADMINISTRACIÓN DE DEVOLUCIONES";
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1084, 676);
            Controls.Add(saveReturnButton);
            Controls.Add(returnSearchTextBox);
            Controls.Add(returnSearchLabel);
            Controls.Add(pdfReturnButton);
            Controls.Add(deleteReturnButton);
            Controls.Add(returnBookLabel);
            Controls.Add(returnDataGridView);
            Controls.Add(returnInformationGroupBox);
            Controls.Add(returnRegistryGroupBox);
            Controls.Add(returnManagementLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReturnForm";
            Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)returnDataGridView).EndInit();
            returnRegistryGroupBox.ResumeLayout(false);
            returnRegistryGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveReturnButton;
        private TextBox returnSearchTextBox;
        private Label returnSearchLabel;
        private Button pdfReturnButton;
        private Button deleteReturnButton;
        private Label returnLoanStatusLabel;
        private Label returnDateLabel;
        private ComboBox returnLoanStatusComboBox;
        private Label returnCustomerLabel;
        private Label returnBookLabel;
        private DataGridView returnDataGridView;
        private GroupBox returnInformationGroupBox;
        private GroupBox returnRegistryGroupBox;
        private ComboBox returnBookComboBox;
        private Label returnManagementLabel;
        private DateTimePicker returnDateDateTimePicker;
        private Label returnCustomerNameLabel;
    }
}