namespace PresentationLayer.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTopBarPanel = new System.Windows.Forms.Panel();
            this.minimizeLoginButton = new System.Windows.Forms.Button();
            this.sizeLoginButton = new System.Windows.Forms.Button();
            this.closeLoginButton = new System.Windows.Forms.Button();
            this.loginSideBarPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.loginContentPanel = new System.Windows.Forms.Panel();
            this.loginRegisterButton = new System.Windows.Forms.Button();
            this.loginPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordLineLabel = new System.Windows.Forms.Label();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginUserLineLabel = new System.Windows.Forms.Label();
            this.loginUserTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTopBarPanel.SuspendLayout();
            this.loginSideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogoPictureBox)).BeginInit();
            this.loginContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTopBarPanel
            // 
            this.loginTopBarPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginTopBarPanel.Controls.Add(this.minimizeLoginButton);
            this.loginTopBarPanel.Controls.Add(this.sizeLoginButton);
            this.loginTopBarPanel.Controls.Add(this.closeLoginButton);
            this.loginTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginTopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.loginTopBarPanel.Name = "loginTopBarPanel";
            this.loginTopBarPanel.Size = new System.Drawing.Size(1284, 35);
            this.loginTopBarPanel.TabIndex = 1;
            // 
            // minimizeLoginButton
            // 
            this.minimizeLoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeLoginButton.BackgroundImage")));
            this.minimizeLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeLoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.minimizeLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeLoginButton.Location = new System.Drawing.Point(1202, 10);
            this.minimizeLoginButton.Name = "minimizeLoginButton";
            this.minimizeLoginButton.Size = new System.Drawing.Size(16, 15);
            this.minimizeLoginButton.TabIndex = 4;
            this.minimizeLoginButton.UseVisualStyleBackColor = true;
            this.minimizeLoginButton.Click += new System.EventHandler(this.minimizeLoginButton_Click);
            // 
            // sizeLoginButton
            // 
            this.sizeLoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sizeLoginButton.BackgroundImage")));
            this.sizeLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sizeLoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.sizeLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeLoginButton.Location = new System.Drawing.Point(1231, 10);
            this.sizeLoginButton.Name = "sizeLoginButton";
            this.sizeLoginButton.Size = new System.Drawing.Size(16, 15);
            this.sizeLoginButton.TabIndex = 3;
            this.sizeLoginButton.UseVisualStyleBackColor = true;
            this.sizeLoginButton.Click += new System.EventHandler(this.sizeLoginButton_Click);
            // 
            // closeLoginButton
            // 
            this.closeLoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeLoginButton.BackgroundImage")));
            this.closeLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeLoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.closeLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLoginButton.Location = new System.Drawing.Point(1258, 10);
            this.closeLoginButton.Name = "closeLoginButton";
            this.closeLoginButton.Size = new System.Drawing.Size(16, 15);
            this.closeLoginButton.TabIndex = 2;
            this.closeLoginButton.UseVisualStyleBackColor = true;
            this.closeLoginButton.Click += new System.EventHandler(this.closeLoginButton_Click);
            // 
            // loginSideBarPanel
            // 
            this.loginSideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginSideBarPanel.Controls.Add(this.titleLabel);
            this.loginSideBarPanel.Controls.Add(this.loginLogoPictureBox);
            this.loginSideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginSideBarPanel.Location = new System.Drawing.Point(0, 35);
            this.loginSideBarPanel.Name = "loginSideBarPanel";
            this.loginSideBarPanel.Size = new System.Drawing.Size(370, 676);
            this.loginSideBarPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 360);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(340, 64);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Sistema de\r\nadministración de biblioteca";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginLogoPictureBox
            // 
            this.loginLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginLogoPictureBox.Image")));
            this.loginLogoPictureBox.Location = new System.Drawing.Point(59, 116);
            this.loginLogoPictureBox.Name = "loginLogoPictureBox";
            this.loginLogoPictureBox.Size = new System.Drawing.Size(252, 228);
            this.loginLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginLogoPictureBox.TabIndex = 0;
            this.loginLogoPictureBox.TabStop = false;
            // 
            // loginContentPanel
            // 
            this.loginContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.loginContentPanel.Controls.Add(this.loginRegisterButton);
            this.loginContentPanel.Controls.Add(this.loginPasswordLinkLabel);
            this.loginContentPanel.Controls.Add(this.loginButton);
            this.loginContentPanel.Controls.Add(this.loginPasswordLineLabel);
            this.loginContentPanel.Controls.Add(this.loginPasswordTextBox);
            this.loginContentPanel.Controls.Add(this.loginUserLineLabel);
            this.loginContentPanel.Controls.Add(this.loginUserTextBox);
            this.loginContentPanel.Controls.Add(this.loginLabel);
            this.loginContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginContentPanel.Location = new System.Drawing.Point(370, 35);
            this.loginContentPanel.Name = "loginContentPanel";
            this.loginContentPanel.Size = new System.Drawing.Size(914, 676);
            this.loginContentPanel.TabIndex = 3;
            // 
            // loginRegisterButton
            // 
            this.loginRegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.loginRegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loginRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginRegisterButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginRegisterButton.ForeColor = System.Drawing.Color.Silver;
            this.loginRegisterButton.Location = new System.Drawing.Point(261, 501);
            this.loginRegisterButton.Name = "loginRegisterButton";
            this.loginRegisterButton.Size = new System.Drawing.Size(410, 39);
            this.loginRegisterButton.TabIndex = 7;
            this.loginRegisterButton.Text = "Crear nueva cuenta";
            this.loginRegisterButton.UseVisualStyleBackColor = false;
            this.loginRegisterButton.Click += new System.EventHandler(this.loginRegisterButton_Click);
            this.loginRegisterButton.MouseEnter += new System.EventHandler(this.loginRegisterButton_MouseEnter);
            this.loginRegisterButton.MouseLeave += new System.EventHandler(this.loginRegisterButton_MouseLeave);
            // 
            // loginPasswordLinkLabel
            // 
            this.loginPasswordLinkLabel.AutoSize = true;
            this.loginPasswordLinkLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPasswordLinkLabel.LinkColor = System.Drawing.Color.Silver;
            this.loginPasswordLinkLabel.Location = new System.Drawing.Point(382, 369);
            this.loginPasswordLinkLabel.Name = "loginPasswordLinkLabel";
            this.loginPasswordLinkLabel.Size = new System.Drawing.Size(166, 20);
            this.loginPasswordLinkLabel.TabIndex = 6;
            this.loginPasswordLinkLabel.TabStop = true;
            this.loginPasswordLinkLabel.Text = "Olvidé mi contraseña";
            this.loginPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginPasswordLinkLabel_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.Silver;
            this.loginButton.Location = new System.Drawing.Point(261, 410);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(410, 39);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Iniciar sesión";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordLineLabel
            // 
            this.loginPasswordLineLabel.BackColor = System.Drawing.Color.Silver;
            this.loginPasswordLineLabel.Location = new System.Drawing.Point(260, 315);
            this.loginPasswordLineLabel.Name = "loginPasswordLineLabel";
            this.loginPasswordLineLabel.Size = new System.Drawing.Size(410, 2);
            this.loginPasswordLineLabel.TabIndex = 4;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.loginPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.loginPasswordTextBox.Location = new System.Drawing.Point(261, 287);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PlaceholderText = "Contraseña";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(410, 24);
            this.loginPasswordTextBox.TabIndex = 3;
            // 
            // loginUserLineLabel
            // 
            this.loginUserLineLabel.BackColor = System.Drawing.Color.Silver;
            this.loginUserLineLabel.Location = new System.Drawing.Point(258, 199);
            this.loginUserLineLabel.Name = "loginUserLineLabel";
            this.loginUserLineLabel.Size = new System.Drawing.Size(410, 2);
            this.loginUserLineLabel.TabIndex = 2;
            // 
            // loginUserTextBox
            // 
            this.loginUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.loginUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUserTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginUserTextBox.ForeColor = System.Drawing.Color.Silver;
            this.loginUserTextBox.Location = new System.Drawing.Point(258, 171);
            this.loginUserTextBox.Name = "loginUserTextBox";
            this.loginUserTextBox.PlaceholderText = "Usuario";
            this.loginUserTextBox.Size = new System.Drawing.Size(410, 24);
            this.loginUserTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(395, 100);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(168, 25);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Inicio de sesión";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.loginContentPanel);
            this.Controls.Add(this.loginSideBarPanel);
            this.Controls.Add(this.loginTopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.loginTopBarPanel.ResumeLayout(false);
            this.loginSideBarPanel.ResumeLayout(false);
            this.loginSideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogoPictureBox)).EndInit();
            this.loginContentPanel.ResumeLayout(false);
            this.loginContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginTopBarPanel;
        private Panel loginSideBarPanel;
        private Panel loginContentPanel;
        private PictureBox loginLogoPictureBox;
        private Label titleLabel;
        private TextBox loginUserTextBox;
        private Label loginLabel;
        private Label loginUserLineLabel;
        private Label loginPasswordLineLabel;
        private TextBox loginPasswordTextBox;
        private Button loginButton;
        private LinkLabel loginPasswordLinkLabel;
        private Button closeLoginButton;
        private Button minimizeLoginButton;
        private Button sizeLoginButton;
        private Button loginRegisterButton;
    }
}