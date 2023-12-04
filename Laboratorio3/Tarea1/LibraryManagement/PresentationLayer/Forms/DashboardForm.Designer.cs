namespace PresentationLayer.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            dashboardTopBarPanel = new Panel();
            minimizeDashboardButton = new Button();
            sizeDashboardButton = new Button();
            closeDashboardButton = new Button();
            dashboardSideBarPanel = new Panel();
            profileButton = new Button();
            logoutButton = new Button();
            userButton = new Button();
            dashboardLogoPictureBox = new PictureBox();
            returnButton = new Button();
            loanButton = new Button();
            bookButton = new Button();
            authorButton = new Button();
            homeButton = new Button();
            dashboardContentPanel = new Panel();
            profileIconButton = new FontAwesome.Sharp.IconButton();
            userIconButton = new FontAwesome.Sharp.IconButton();
            returnIconButton = new FontAwesome.Sharp.IconButton();
            loanIconButton = new FontAwesome.Sharp.IconButton();
            bookIconButton = new FontAwesome.Sharp.IconButton();
            authorIconButton = new FontAwesome.Sharp.IconButton();
            dashboardWelcomeLabel = new Label();
            dashboardLabel = new Label();
            dashboardTopBarPanel.SuspendLayout();
            dashboardSideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardLogoPictureBox).BeginInit();
            dashboardContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardTopBarPanel
            // 
            dashboardTopBarPanel.BackColor = SystemColors.Highlight;
            dashboardTopBarPanel.Controls.Add(minimizeDashboardButton);
            dashboardTopBarPanel.Controls.Add(sizeDashboardButton);
            dashboardTopBarPanel.Controls.Add(closeDashboardButton);
            dashboardTopBarPanel.Dock = DockStyle.Top;
            dashboardTopBarPanel.Location = new Point(0, 0);
            dashboardTopBarPanel.Name = "dashboardTopBarPanel";
            dashboardTopBarPanel.Size = new Size(1284, 35);
            dashboardTopBarPanel.TabIndex = 0;
            // 
            // minimizeDashboardButton
            // 
            minimizeDashboardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeDashboardButton.BackgroundImage = (Image)resources.GetObject("minimizeDashboardButton.BackgroundImage");
            minimizeDashboardButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeDashboardButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            minimizeDashboardButton.FlatStyle = FlatStyle.Flat;
            minimizeDashboardButton.Location = new Point(1202, 10);
            minimizeDashboardButton.Name = "minimizeDashboardButton";
            minimizeDashboardButton.Size = new Size(16, 15);
            minimizeDashboardButton.TabIndex = 7;
            minimizeDashboardButton.UseVisualStyleBackColor = true;
            minimizeDashboardButton.Click += minimizeDashboardButton_Click;
            // 
            // sizeDashboardButton
            // 
            sizeDashboardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeDashboardButton.BackgroundImage = (Image)resources.GetObject("sizeDashboardButton.BackgroundImage");
            sizeDashboardButton.BackgroundImageLayout = ImageLayout.Stretch;
            sizeDashboardButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            sizeDashboardButton.FlatStyle = FlatStyle.Flat;
            sizeDashboardButton.Location = new Point(1231, 10);
            sizeDashboardButton.Name = "sizeDashboardButton";
            sizeDashboardButton.Size = new Size(16, 15);
            sizeDashboardButton.TabIndex = 6;
            sizeDashboardButton.UseVisualStyleBackColor = true;
            sizeDashboardButton.Click += sizeDashboardButton_Click;
            // 
            // closeDashboardButton
            // 
            closeDashboardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeDashboardButton.BackgroundImage = (Image)resources.GetObject("closeDashboardButton.BackgroundImage");
            closeDashboardButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeDashboardButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            closeDashboardButton.FlatStyle = FlatStyle.Flat;
            closeDashboardButton.Location = new Point(1258, 10);
            closeDashboardButton.Name = "closeDashboardButton";
            closeDashboardButton.Size = new Size(16, 15);
            closeDashboardButton.TabIndex = 5;
            closeDashboardButton.UseVisualStyleBackColor = true;
            closeDashboardButton.Click += closeDashboardButton_Click;
            // 
            // dashboardSideBarPanel
            // 
            dashboardSideBarPanel.BackColor = Color.FromArgb(25, 42, 86);
            dashboardSideBarPanel.Controls.Add(profileButton);
            dashboardSideBarPanel.Controls.Add(logoutButton);
            dashboardSideBarPanel.Controls.Add(userButton);
            dashboardSideBarPanel.Controls.Add(dashboardLogoPictureBox);
            dashboardSideBarPanel.Controls.Add(returnButton);
            dashboardSideBarPanel.Controls.Add(loanButton);
            dashboardSideBarPanel.Controls.Add(bookButton);
            dashboardSideBarPanel.Controls.Add(authorButton);
            dashboardSideBarPanel.Controls.Add(homeButton);
            dashboardSideBarPanel.Dock = DockStyle.Left;
            dashboardSideBarPanel.Location = new Point(0, 35);
            dashboardSideBarPanel.Name = "dashboardSideBarPanel";
            dashboardSideBarPanel.Size = new Size(200, 676);
            dashboardSideBarPanel.TabIndex = 1;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.Transparent;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            profileButton.ForeColor = Color.White;
            profileButton.Location = new Point(0, 363);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(200, 36);
            profileButton.TabIndex = 8;
            profileButton.Text = "👨‍💻 Perfil";
            profileButton.TextAlign = ContentAlignment.MiddleLeft;
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            profileButton.MouseEnter += profileButton_MouseEnter;
            profileButton.MouseLeave += profileButton_MouseLeave;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Transparent;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(0, 399);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 36);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "🔙 Cerrar sesión";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            logoutButton.MouseEnter += logoutButton_MouseEnter;
            logoutButton.MouseLeave += logoutButton_MouseLeave;
            // 
            // userButton
            // 
            userButton.BackColor = Color.Transparent;
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userButton.ForeColor = Color.White;
            userButton.Location = new Point(0, 327);
            userButton.Name = "userButton";
            userButton.Size = new Size(200, 36);
            userButton.TabIndex = 7;
            userButton.Text = "\U0001f9d1‍👨 ‍Usuarios";
            userButton.TextAlign = ContentAlignment.MiddleLeft;
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            userButton.MouseEnter += userButton_MouseEnter;
            userButton.MouseLeave += userButton_MouseLeave;
            // 
            // dashboardLogoPictureBox
            // 
            dashboardLogoPictureBox.Image = (Image)resources.GetObject("dashboardLogoPictureBox.Image");
            dashboardLogoPictureBox.Location = new Point(0, 25);
            dashboardLogoPictureBox.Name = "dashboardLogoPictureBox";
            dashboardLogoPictureBox.Size = new Size(200, 96);
            dashboardLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            dashboardLogoPictureBox.TabIndex = 5;
            dashboardLogoPictureBox.TabStop = false;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Transparent;
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(0, 291);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(200, 36);
            returnButton.TabIndex = 4;
            returnButton.Text = "↩️ Devoluciones";
            returnButton.TextAlign = ContentAlignment.MiddleLeft;
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            returnButton.MouseEnter += returnButton_MouseEnter;
            returnButton.MouseLeave += returnButton_MouseLeave;
            // 
            // loanButton
            // 
            loanButton.BackColor = Color.Transparent;
            loanButton.FlatAppearance.BorderSize = 0;
            loanButton.FlatStyle = FlatStyle.Flat;
            loanButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loanButton.ForeColor = Color.White;
            loanButton.Location = new Point(0, 255);
            loanButton.Name = "loanButton";
            loanButton.Size = new Size(200, 36);
            loanButton.TabIndex = 3;
            loanButton.Text = "📄 Préstamos";
            loanButton.TextAlign = ContentAlignment.MiddleLeft;
            loanButton.UseVisualStyleBackColor = false;
            loanButton.Click += loanButton_Click;
            loanButton.MouseEnter += loanButton_MouseEnter;
            loanButton.MouseLeave += loanButton_MouseLeave;
            // 
            // bookButton
            // 
            bookButton.BackColor = Color.Transparent;
            bookButton.FlatAppearance.BorderSize = 0;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookButton.ForeColor = Color.White;
            bookButton.Location = new Point(0, 219);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(200, 36);
            bookButton.TabIndex = 2;
            bookButton.Text = "📚 Libros";
            bookButton.TextAlign = ContentAlignment.MiddleLeft;
            bookButton.UseVisualStyleBackColor = false;
            bookButton.Click += bookButton_Click;
            bookButton.MouseEnter += bookButton_MouseEnter;
            bookButton.MouseLeave += bookButton_MouseLeave;
            // 
            // authorButton
            // 
            authorButton.BackColor = Color.Transparent;
            authorButton.FlatAppearance.BorderSize = 0;
            authorButton.FlatStyle = FlatStyle.Flat;
            authorButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorButton.ForeColor = Color.Transparent;
            authorButton.Location = new Point(0, 183);
            authorButton.Name = "authorButton";
            authorButton.Size = new Size(200, 36);
            authorButton.TabIndex = 1;
            authorButton.Text = "👨‍💼 Autores";
            authorButton.TextAlign = ContentAlignment.MiddleLeft;
            authorButton.UseVisualStyleBackColor = false;
            authorButton.Click += authorButton_Click;
            authorButton.MouseEnter += authorButton_MouseEnter;
            authorButton.MouseLeave += authorButton_MouseLeave;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.ForeColor = Color.White;
            homeButton.Location = new Point(0, 147);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(200, 36);
            homeButton.TabIndex = 0;
            homeButton.Text = "🏠 Inicio";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            homeButton.MouseEnter += homeButton_MouseEnter;
            homeButton.MouseLeave += homeButton_MouseLeave;
            // 
            // dashboardContentPanel
            // 
            dashboardContentPanel.BackColor = Color.FromArgb(10, 61, 98);
            dashboardContentPanel.Controls.Add(profileIconButton);
            dashboardContentPanel.Controls.Add(userIconButton);
            dashboardContentPanel.Controls.Add(returnIconButton);
            dashboardContentPanel.Controls.Add(loanIconButton);
            dashboardContentPanel.Controls.Add(bookIconButton);
            dashboardContentPanel.Controls.Add(authorIconButton);
            dashboardContentPanel.Controls.Add(dashboardWelcomeLabel);
            dashboardContentPanel.Controls.Add(dashboardLabel);
            dashboardContentPanel.Dock = DockStyle.Fill;
            dashboardContentPanel.Location = new Point(200, 35);
            dashboardContentPanel.Name = "dashboardContentPanel";
            dashboardContentPanel.Size = new Size(1084, 676);
            dashboardContentPanel.TabIndex = 2;
            // 
            // profileIconButton
            // 
            profileIconButton.BackColor = Color.FromArgb(128, 128, 255);
            profileIconButton.FlatStyle = FlatStyle.Flat;
            profileIconButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileIconButton.ForeColor = Color.White;
            profileIconButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            profileIconButton.IconColor = Color.White;
            profileIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            profileIconButton.Location = new Point(740, 273);
            profileIconButton.Name = "profileIconButton";
            profileIconButton.Size = new Size(296, 143);
            profileIconButton.TabIndex = 11;
            profileIconButton.Text = "Perfil";
            profileIconButton.TextAlign = ContentAlignment.BottomCenter;
            profileIconButton.TextImageRelation = TextImageRelation.ImageAboveText;
            profileIconButton.UseVisualStyleBackColor = false;
            profileIconButton.Click += profileIconButton_Click;
            // 
            // userIconButton
            // 
            userIconButton.BackColor = Color.FromArgb(128, 128, 255);
            userIconButton.FlatStyle = FlatStyle.Flat;
            userIconButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            userIconButton.ForeColor = Color.White;
            userIconButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            userIconButton.IconColor = Color.White;
            userIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userIconButton.Location = new Point(392, 273);
            userIconButton.Name = "userIconButton";
            userIconButton.Size = new Size(296, 143);
            userIconButton.TabIndex = 10;
            userIconButton.Text = "Usuarios";
            userIconButton.TextAlign = ContentAlignment.BottomCenter;
            userIconButton.TextImageRelation = TextImageRelation.ImageAboveText;
            userIconButton.UseVisualStyleBackColor = false;
            userIconButton.Click += userIconButton_Click;
            // 
            // returnIconButton
            // 
            returnIconButton.BackColor = Color.FromArgb(128, 128, 255);
            returnIconButton.FlatStyle = FlatStyle.Flat;
            returnIconButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            returnIconButton.ForeColor = Color.White;
            returnIconButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            returnIconButton.IconColor = Color.White;
            returnIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            returnIconButton.Location = new Point(43, 273);
            returnIconButton.Name = "returnIconButton";
            returnIconButton.Size = new Size(296, 143);
            returnIconButton.TabIndex = 9;
            returnIconButton.Text = "Devoluciones";
            returnIconButton.TextAlign = ContentAlignment.BottomCenter;
            returnIconButton.TextImageRelation = TextImageRelation.ImageAboveText;
            returnIconButton.UseVisualStyleBackColor = false;
            returnIconButton.Click += returnIconButton_Click;
            // 
            // loanIconButton
            // 
            loanIconButton.BackColor = Color.FromArgb(128, 128, 255);
            loanIconButton.FlatStyle = FlatStyle.Flat;
            loanIconButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanIconButton.ForeColor = Color.White;
            loanIconButton.IconChar = FontAwesome.Sharp.IconChar.FileText;
            loanIconButton.IconColor = Color.White;
            loanIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            loanIconButton.Location = new Point(740, 96);
            loanIconButton.Name = "loanIconButton";
            loanIconButton.Size = new Size(296, 143);
            loanIconButton.TabIndex = 8;
            loanIconButton.Text = "Préstamos";
            loanIconButton.TextAlign = ContentAlignment.BottomCenter;
            loanIconButton.TextImageRelation = TextImageRelation.ImageAboveText;
            loanIconButton.UseVisualStyleBackColor = false;
            loanIconButton.Click += loanIconButton_Click;
            // 
            // bookIconButton
            // 
            bookIconButton.BackColor = Color.FromArgb(128, 128, 255);
            bookIconButton.FlatStyle = FlatStyle.Flat;
            bookIconButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookIconButton.ForeColor = Color.White;
            bookIconButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            bookIconButton.IconColor = Color.White;
            bookIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bookIconButton.Location = new Point(392, 96);
            bookIconButton.Name = "bookIconButton";
            bookIconButton.Size = new Size(296, 143);
            bookIconButton.TabIndex = 7;
            bookIconButton.Text = "Libros";
            bookIconButton.TextAlign = ContentAlignment.BottomCenter;
            bookIconButton.TextImageRelation = TextImageRelation.ImageAboveText;
            bookIconButton.UseVisualStyleBackColor = false;
            bookIconButton.Click += bookIconButton_Click;
            // 
            // authorIconButton
            // 
            authorIconButton.BackColor = Color.FromArgb(128, 128, 255);
            authorIconButton.FlatStyle = FlatStyle.Flat;
            authorIconButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            authorIconButton.ForeColor = Color.White;
            authorIconButton.IconChar = FontAwesome.Sharp.IconChar.Person;
            authorIconButton.IconColor = Color.White;
            authorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            authorIconButton.Location = new Point(43, 96);
            authorIconButton.Name = "authorIconButton";
            authorIconButton.Size = new Size(296, 143);
            authorIconButton.TabIndex = 6;
            authorIconButton.Text = "Autores";
            authorIconButton.TextAlign = ContentAlignment.BottomCenter;
            authorIconButton.TextImageRelation = TextImageRelation.ImageAboveText;
            authorIconButton.UseVisualStyleBackColor = false;
            authorIconButton.Click += authorIconButton_Click;
            // 
            // dashboardWelcomeLabel
            // 
            dashboardWelcomeLabel.AutoSize = true;
            dashboardWelcomeLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardWelcomeLabel.ForeColor = Color.White;
            dashboardWelcomeLabel.Location = new Point(41, 49);
            dashboardWelcomeLabel.Name = "dashboardWelcomeLabel";
            dashboardWelcomeLabel.Size = new Size(188, 22);
            dashboardWelcomeLabel.TabIndex = 1;
            dashboardWelcomeLabel.Text = "Bienvenido usuario ";
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardLabel.ForeColor = Color.White;
            dashboardLabel.Location = new Point(477, 12);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(80, 25);
            dashboardLabel.TabIndex = 0;
            dashboardLabel.Text = "INICIO";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 711);
            Controls.Add(dashboardContentPanel);
            Controls.Add(dashboardSideBarPanel);
            Controls.Add(dashboardTopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            dashboardTopBarPanel.ResumeLayout(false);
            dashboardSideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dashboardLogoPictureBox).EndInit();
            dashboardContentPanel.ResumeLayout(false);
            dashboardContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardTopBarPanel;
        private Panel dashboardSideBarPanel;
        private Panel dashboardContentPanel;
        private Button homeButton;
        private Button authorButton;
        private Button returnButton;
        private Button loanButton;
        private Button bookButton;
        private PictureBox dashboardLogoPictureBox;
        private Label dashboardLabel;
        private Label dashboardWelcomeLabel;
        private Button logoutButton;
        private Button minimizeDashboardButton;
        private Button sizeDashboardButton;
        private Button closeDashboardButton;
        private FontAwesome.Sharp.IconButton authorIconButton;
        private FontAwesome.Sharp.IconButton returnIconButton;
        private FontAwesome.Sharp.IconButton loanIconButton;
        private FontAwesome.Sharp.IconButton bookIconButton;
        private Button profileButton;
        private Button userButton;
        private FontAwesome.Sharp.IconButton profileIconButton;
        private FontAwesome.Sharp.IconButton userIconButton;
    }
}