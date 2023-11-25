namespace PresentationLayer.Forms
{
    partial class BookForm
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
            bookSearchTextBox = new TextBox();
            bookSearchLabel = new Label();
            pdfBookButton = new Button();
            deleteBookButton = new Button();
            editBookButton = new Button();
            saveBookButton = new Button();
            bookPublisherTextBox = new TextBox();
            bookPublisherLabel = new Label();
            bookTitleTextBox = new TextBox();
            bookTitleLabel = new Label();
            bookDataGridView = new DataGridView();
            bookManagementLabel = new Label();
            bookInformationGroupBox = new GroupBox();
            bookRegistryGroupBox = new GroupBox();
            bookStatusComboBox = new ComboBox();
            bookAuthorComboBox = new ComboBox();
            bookStatusLabel = new Label();
            bookAuthorLabel = new Label();
            bookGenreTextBox = new TextBox();
            bookGenreLabel = new Label();
            bookIsbnTextBox = new TextBox();
            bookIsbnLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            bookRegistryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // bookSearchTextBox
            // 
            bookSearchTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookSearchTextBox.Location = new Point(15, 113);
            bookSearchTextBox.Name = "bookSearchTextBox";
            bookSearchTextBox.Size = new Size(664, 27);
            bookSearchTextBox.TabIndex = 26;
            bookSearchTextBox.TextChanged += bookSearchTextBox_TextChanged;
            // 
            // bookSearchLabel
            // 
            bookSearchLabel.AutoSize = true;
            bookSearchLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookSearchLabel.ForeColor = Color.White;
            bookSearchLabel.Location = new Point(16, 84);
            bookSearchLabel.Name = "bookSearchLabel";
            bookSearchLabel.Size = new Size(104, 21);
            bookSearchLabel.TabIndex = 25;
            bookSearchLabel.Text = "Buscar libro";
            // 
            // pdfBookButton
            // 
            pdfBookButton.BackColor = Color.RoyalBlue;
            pdfBookButton.FlatAppearance.BorderColor = Color.Teal;
            pdfBookButton.FlatStyle = FlatStyle.Flat;
            pdfBookButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            pdfBookButton.ForeColor = Color.White;
            pdfBookButton.Location = new Point(481, 585);
            pdfBookButton.Name = "pdfBookButton";
            pdfBookButton.Size = new Size(110, 31);
            pdfBookButton.TabIndex = 24;
            pdfBookButton.Text = "PDF";
            pdfBookButton.UseVisualStyleBackColor = false;
            // 
            // deleteBookButton
            // 
            deleteBookButton.BackColor = Color.RoyalBlue;
            deleteBookButton.FlatAppearance.BorderColor = Color.Teal;
            deleteBookButton.FlatStyle = FlatStyle.Flat;
            deleteBookButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBookButton.ForeColor = Color.White;
            deleteBookButton.Location = new Point(285, 585);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(110, 31);
            deleteBookButton.TabIndex = 23;
            deleteBookButton.Text = "Eliminar";
            deleteBookButton.UseVisualStyleBackColor = false;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // editBookButton
            // 
            editBookButton.BackColor = Color.RoyalBlue;
            editBookButton.FlatAppearance.BorderColor = Color.Teal;
            editBookButton.FlatStyle = FlatStyle.Flat;
            editBookButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            editBookButton.ForeColor = Color.White;
            editBookButton.Location = new Point(87, 585);
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(110, 31);
            editBookButton.TabIndex = 22;
            editBookButton.Text = "Editar";
            editBookButton.UseVisualStyleBackColor = false;
            editBookButton.Click += editBookButton_Click;
            // 
            // saveBookButton
            // 
            saveBookButton.BackColor = Color.FromArgb(25, 42, 86);
            saveBookButton.FlatAppearance.BorderColor = Color.Teal;
            saveBookButton.FlatStyle = FlatStyle.Flat;
            saveBookButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveBookButton.ForeColor = Color.White;
            saveBookButton.Location = new Point(833, 583);
            saveBookButton.Name = "saveBookButton";
            saveBookButton.Size = new Size(110, 31);
            saveBookButton.TabIndex = 21;
            saveBookButton.Text = "Guardar";
            saveBookButton.UseVisualStyleBackColor = false;
            saveBookButton.Click += saveBookButton_Click;
            // 
            // bookPublisherTextBox
            // 
            bookPublisherTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookPublisherTextBox.Location = new Point(12, 228);
            bookPublisherTextBox.Name = "bookPublisherTextBox";
            bookPublisherTextBox.PlaceholderText = "ejemplo: Eksmo";
            bookPublisherTextBox.Size = new Size(359, 26);
            bookPublisherTextBox.TabIndex = 20;
            bookPublisherTextBox.KeyPress += bookPublisherTextBox_KeyPress;
            // 
            // bookPublisherLabel
            // 
            bookPublisherLabel.AutoSize = true;
            bookPublisherLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookPublisherLabel.ForeColor = Color.White;
            bookPublisherLabel.Location = new Point(702, 250);
            bookPublisherLabel.Name = "bookPublisherLabel";
            bookPublisherLabel.Size = new Size(80, 21);
            bookPublisherLabel.TabIndex = 19;
            bookPublisherLabel.Text = "Editorial:";
            // 
            // bookTitleTextBox
            // 
            bookTitleTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleTextBox.Location = new Point(12, 72);
            bookTitleTextBox.Name = "bookTitleTextBox";
            bookTitleTextBox.PlaceholderText = "ejemplo: Metro 2033";
            bookTitleTextBox.Size = new Size(359, 26);
            bookTitleTextBox.TabIndex = 18;
            bookTitleTextBox.KeyPress += bookTitleTextBox_KeyPress;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleLabel.ForeColor = Color.White;
            bookTitleLabel.Location = new Point(702, 94);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(57, 21);
            bookTitleLabel.TabIndex = 17;
            bookTitleLabel.Text = "Título:";
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bookDataGridView.BackgroundColor = Color.FromArgb(45, 66, 91);
            bookDataGridView.BorderStyle = BorderStyle.None;
            bookDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.EnableHeadersVisualStyles = false;
            bookDataGridView.Location = new Point(15, 151);
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            bookDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            bookDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            bookDataGridView.RowTemplate.Height = 25;
            bookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookDataGridView.Size = new Size(664, 387);
            bookDataGridView.TabIndex = 16;
            // 
            // bookManagementLabel
            // 
            bookManagementLabel.AutoSize = true;
            bookManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bookManagementLabel.ForeColor = Color.White;
            bookManagementLabel.Location = new Point(384, 11);
            bookManagementLabel.Name = "bookManagementLabel";
            bookManagementLabel.Size = new Size(257, 25);
            bookManagementLabel.TabIndex = 15;
            bookManagementLabel.Text = "Administración de libros";
            // 
            // bookInformationGroupBox
            // 
            bookInformationGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookInformationGroupBox.ForeColor = Color.White;
            bookInformationGroupBox.Location = new Point(7, 51);
            bookInformationGroupBox.Name = "bookInformationGroupBox";
            bookInformationGroupBox.Size = new Size(679, 615);
            bookInformationGroupBox.TabIndex = 27;
            bookInformationGroupBox.TabStop = false;
            bookInformationGroupBox.Text = "Información de libros";
            // 
            // bookRegistryGroupBox
            // 
            bookRegistryGroupBox.Controls.Add(bookStatusComboBox);
            bookRegistryGroupBox.Controls.Add(bookAuthorComboBox);
            bookRegistryGroupBox.Controls.Add(bookStatusLabel);
            bookRegistryGroupBox.Controls.Add(bookAuthorLabel);
            bookRegistryGroupBox.Controls.Add(bookGenreTextBox);
            bookRegistryGroupBox.Controls.Add(bookGenreLabel);
            bookRegistryGroupBox.Controls.Add(bookPublisherTextBox);
            bookRegistryGroupBox.Controls.Add(bookTitleTextBox);
            bookRegistryGroupBox.Controls.Add(bookIsbnTextBox);
            bookRegistryGroupBox.Controls.Add(bookIsbnLabel);
            bookRegistryGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookRegistryGroupBox.ForeColor = Color.White;
            bookRegistryGroupBox.Location = new Point(692, 51);
            bookRegistryGroupBox.Name = "bookRegistryGroupBox";
            bookRegistryGroupBox.Size = new Size(385, 615);
            bookRegistryGroupBox.TabIndex = 28;
            bookRegistryGroupBox.TabStop = false;
            bookRegistryGroupBox.Text = "Registro de libros";
            // 
            // bookStatusComboBox
            // 
            bookStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookStatusComboBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookStatusComboBox.FormattingEnabled = true;
            bookStatusComboBox.Location = new Point(12, 461);
            bookStatusComboBox.Name = "bookStatusComboBox";
            bookStatusComboBox.Size = new Size(359, 28);
            bookStatusComboBox.TabIndex = 28;
            // 
            // bookAuthorComboBox
            // 
            bookAuthorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bookAuthorComboBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorComboBox.FormattingEnabled = true;
            bookAuthorComboBox.Location = new Point(12, 148);
            bookAuthorComboBox.Name = "bookAuthorComboBox";
            bookAuthorComboBox.Size = new Size(359, 28);
            bookAuthorComboBox.TabIndex = 27;
            // 
            // bookStatusLabel
            // 
            bookStatusLabel.AutoSize = true;
            bookStatusLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookStatusLabel.ForeColor = Color.White;
            bookStatusLabel.Location = new Point(12, 432);
            bookStatusLabel.Name = "bookStatusLabel";
            bookStatusLabel.Size = new Size(73, 21);
            bookStatusLabel.TabIndex = 26;
            bookStatusLabel.Text = "Estado:";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorLabel.ForeColor = Color.White;
            bookAuthorLabel.Location = new Point(10, 119);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(61, 21);
            bookAuthorLabel.TabIndex = 25;
            bookAuthorLabel.Text = "Autor:";
            // 
            // bookGenreTextBox
            // 
            bookGenreTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookGenreTextBox.Location = new Point(12, 381);
            bookGenreTextBox.Name = "bookGenreTextBox";
            bookGenreTextBox.PlaceholderText = "ejemplo: ciencie ficción postapocalíptica";
            bookGenreTextBox.Size = new Size(359, 26);
            bookGenreTextBox.TabIndex = 24;
            // 
            // bookGenreLabel
            // 
            bookGenreLabel.AutoSize = true;
            bookGenreLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookGenreLabel.ForeColor = Color.White;
            bookGenreLabel.Location = new Point(10, 352);
            bookGenreLabel.Name = "bookGenreLabel";
            bookGenreLabel.Size = new Size(78, 21);
            bookGenreLabel.TabIndex = 23;
            bookGenreLabel.Text = "Género:";
            // 
            // bookIsbnTextBox
            // 
            bookIsbnTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookIsbnTextBox.Location = new Point(12, 304);
            bookIsbnTextBox.Name = "bookIsbnTextBox";
            bookIsbnTextBox.PlaceholderText = "ejemplo: 978-0-306-40615-7";
            bookIsbnTextBox.Size = new Size(359, 26);
            bookIsbnTextBox.TabIndex = 22;
            bookIsbnTextBox.KeyPress += bookIsbnTextBox_KeyPress;
            // 
            // bookIsbnLabel
            // 
            bookIsbnLabel.AutoSize = true;
            bookIsbnLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookIsbnLabel.ForeColor = Color.White;
            bookIsbnLabel.Location = new Point(10, 275);
            bookIsbnLabel.Name = "bookIsbnLabel";
            bookIsbnLabel.Size = new Size(51, 21);
            bookIsbnLabel.TabIndex = 21;
            bookIsbnLabel.Text = "ISBN:";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1084, 676);
            Controls.Add(bookSearchTextBox);
            Controls.Add(bookSearchLabel);
            Controls.Add(pdfBookButton);
            Controls.Add(deleteBookButton);
            Controls.Add(editBookButton);
            Controls.Add(saveBookButton);
            Controls.Add(bookPublisherLabel);
            Controls.Add(bookTitleLabel);
            Controls.Add(bookDataGridView);
            Controls.Add(bookManagementLabel);
            Controls.Add(bookInformationGroupBox);
            Controls.Add(bookRegistryGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookForm";
            Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            bookRegistryGroupBox.ResumeLayout(false);
            bookRegistryGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookSearchTextBox;
        private Label bookSearchLabel;
        private Button pdfBookButton;
        private Button deleteBookButton;
        private Button editBookButton;
        private Button saveBookButton;
        private TextBox bookPublisherTextBox;
        private Label bookPublisherLabel;
        private TextBox bookTitleTextBox;
        private Label bookTitleLabel;
        private DataGridView bookDataGridView;
        private Label bookManagementLabel;
        private GroupBox bookInformationGroupBox;
        private GroupBox bookRegistryGroupBox;
        private TextBox bookGenreTextBox;
        private Label bookGenreLabel;
        private TextBox bookIsbnTextBox;
        private Label bookIsbnLabel;
        private Label bookAuthorLabel;
        private ComboBox bookStatusComboBox;
        private ComboBox bookAuthorComboBox;
        private Label bookStatusLabel;
    }
}