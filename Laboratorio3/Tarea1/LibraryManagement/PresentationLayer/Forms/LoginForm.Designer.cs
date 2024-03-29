﻿namespace PresentationLayer.Forms
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
            loginTopBarPanel = new Panel();
            minimizeLoginButton = new Button();
            sizeLoginButton = new Button();
            closeLoginButton = new Button();
            loginSideBarPanel = new Panel();
            titleLabel = new Label();
            loginLogoPictureBox = new PictureBox();
            loginContentPanel = new Panel();
            HidePasswordpictureBox = new PictureBox();
            loginRegisterButton = new Button();
            loginPasswordLinkLabel = new LinkLabel();
            loginButton = new Button();
            loginPasswordLineLabel = new Label();
            loginPasswordTextBox = new TextBox();
            loginUserLineLabel = new Label();
            loginUserTextBox = new TextBox();
            loginLabel = new Label();
            SeePasswordpictureBox = new PictureBox();
            loginTopBarPanel.SuspendLayout();
            loginSideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginLogoPictureBox).BeginInit();
            loginContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HidePasswordpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeePasswordpictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginTopBarPanel
            // 
            loginTopBarPanel.BackColor = SystemColors.Highlight;
            loginTopBarPanel.Controls.Add(minimizeLoginButton);
            loginTopBarPanel.Controls.Add(sizeLoginButton);
            loginTopBarPanel.Controls.Add(closeLoginButton);
            loginTopBarPanel.Dock = DockStyle.Top;
            loginTopBarPanel.Location = new Point(0, 0);
            loginTopBarPanel.Name = "loginTopBarPanel";
            loginTopBarPanel.Size = new Size(1284, 35);
            loginTopBarPanel.TabIndex = 1;
            // 
            // minimizeLoginButton
            // 
            minimizeLoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeLoginButton.BackgroundImage = (Image)resources.GetObject("minimizeLoginButton.BackgroundImage");
            minimizeLoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeLoginButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            minimizeLoginButton.FlatStyle = FlatStyle.Flat;
            minimizeLoginButton.Location = new Point(1202, 10);
            minimizeLoginButton.Name = "minimizeLoginButton";
            minimizeLoginButton.Size = new Size(16, 15);
            minimizeLoginButton.TabIndex = 4;
            minimizeLoginButton.UseVisualStyleBackColor = true;
            minimizeLoginButton.Click += minimizeLoginButton_Click;
            // 
            // sizeLoginButton
            // 
            sizeLoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sizeLoginButton.BackgroundImage = (Image)resources.GetObject("sizeLoginButton.BackgroundImage");
            sizeLoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            sizeLoginButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            sizeLoginButton.FlatStyle = FlatStyle.Flat;
            sizeLoginButton.Location = new Point(1231, 10);
            sizeLoginButton.Name = "sizeLoginButton";
            sizeLoginButton.Size = new Size(16, 15);
            sizeLoginButton.TabIndex = 3;
            sizeLoginButton.UseVisualStyleBackColor = true;
            sizeLoginButton.Click += sizeLoginButton_Click;
            // 
            // closeLoginButton
            // 
            closeLoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeLoginButton.BackgroundImage = (Image)resources.GetObject("closeLoginButton.BackgroundImage");
            closeLoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeLoginButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            closeLoginButton.FlatStyle = FlatStyle.Flat;
            closeLoginButton.Location = new Point(1258, 10);
            closeLoginButton.Name = "closeLoginButton";
            closeLoginButton.Size = new Size(16, 15);
            closeLoginButton.TabIndex = 2;
            closeLoginButton.UseVisualStyleBackColor = true;
            closeLoginButton.Click += closeLoginButton_Click;
            // 
            // loginSideBarPanel
            // 
            loginSideBarPanel.BackColor = Color.FromArgb(0, 0, 64);
            loginSideBarPanel.Controls.Add(titleLabel);
            loginSideBarPanel.Controls.Add(loginLogoPictureBox);
            loginSideBarPanel.Dock = DockStyle.Left;
            loginSideBarPanel.Location = new Point(0, 35);
            loginSideBarPanel.Name = "loginSideBarPanel";
            loginSideBarPanel.Size = new Size(389, 676);
            loginSideBarPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(10, 409);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(346, 50);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "SISTEMA\r\nDE ADMINISTRACIÓN DE BIBLIOTECA\r\n";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginLogoPictureBox
            // 
            loginLogoPictureBox.Image = (Image)resources.GetObject("loginLogoPictureBox.Image");
            loginLogoPictureBox.Location = new Point(61, 161);
            loginLogoPictureBox.Name = "loginLogoPictureBox";
            loginLogoPictureBox.Size = new Size(252, 228);
            loginLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loginLogoPictureBox.TabIndex = 0;
            loginLogoPictureBox.TabStop = false;
            // 
            // loginContentPanel
            // 
            loginContentPanel.BackColor = Color.FromArgb(25, 42, 86);
            loginContentPanel.Controls.Add(HidePasswordpictureBox);
            loginContentPanel.Controls.Add(loginRegisterButton);
            loginContentPanel.Controls.Add(loginPasswordLinkLabel);
            loginContentPanel.Controls.Add(loginButton);
            loginContentPanel.Controls.Add(loginPasswordLineLabel);
            loginContentPanel.Controls.Add(loginPasswordTextBox);
            loginContentPanel.Controls.Add(loginUserLineLabel);
            loginContentPanel.Controls.Add(loginUserTextBox);
            loginContentPanel.Controls.Add(loginLabel);
            loginContentPanel.Controls.Add(SeePasswordpictureBox);
            loginContentPanel.Dock = DockStyle.Fill;
            loginContentPanel.Location = new Point(389, 35);
            loginContentPanel.Name = "loginContentPanel";
            loginContentPanel.Size = new Size(895, 676);
            loginContentPanel.TabIndex = 3;
            // 
            // HidePasswordpictureBox
            // 
            HidePasswordpictureBox.Image = (Image)resources.GetObject("HidePasswordpictureBox.Image");
            HidePasswordpictureBox.Location = new Point(641, 294);
            HidePasswordpictureBox.Name = "HidePasswordpictureBox";
            HidePasswordpictureBox.Size = new Size(37, 35);
            HidePasswordpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            HidePasswordpictureBox.TabIndex = 9;
            HidePasswordpictureBox.TabStop = false;
            HidePasswordpictureBox.Click += HidePasswordpictureBox_Click;
            // 
            // loginRegisterButton
            // 
            loginRegisterButton.BackColor = Color.Transparent;
            loginRegisterButton.FlatAppearance.BorderColor = Color.Silver;
            loginRegisterButton.FlatStyle = FlatStyle.Flat;
            loginRegisterButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginRegisterButton.ForeColor = Color.Silver;
            loginRegisterButton.Location = new Point(271, 518);
            loginRegisterButton.Name = "loginRegisterButton";
            loginRegisterButton.Size = new Size(410, 39);
            loginRegisterButton.TabIndex = 7;
            loginRegisterButton.Text = "Crear nueva cuenta";
            loginRegisterButton.UseVisualStyleBackColor = false;
            loginRegisterButton.Click += loginRegisterButton_Click;
            loginRegisterButton.MouseEnter += loginRegisterButton_MouseEnter;
            loginRegisterButton.MouseLeave += loginRegisterButton_MouseLeave;
            // 
            // loginPasswordLinkLabel
            // 
            loginPasswordLinkLabel.AutoSize = true;
            loginPasswordLinkLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginPasswordLinkLabel.LinkColor = Color.Silver;
            loginPasswordLinkLabel.Location = new Point(392, 386);
            loginPasswordLinkLabel.Name = "loginPasswordLinkLabel";
            loginPasswordLinkLabel.Size = new Size(166, 20);
            loginPasswordLinkLabel.TabIndex = 6;
            loginPasswordLinkLabel.TabStop = true;
            loginPasswordLinkLabel.Text = "Olvidé mi contraseña";
            loginPasswordLinkLabel.LinkClicked += loginPasswordLinkLabel_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(10, 61, 98);
            loginButton.FlatAppearance.BorderColor = Color.Teal;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.Silver;
            loginButton.Location = new Point(271, 427);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(410, 39);
            loginButton.TabIndex = 5;
            loginButton.Text = "Iniciar sesión";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginPasswordLineLabel
            // 
            loginPasswordLineLabel.BackColor = Color.Silver;
            loginPasswordLineLabel.Location = new Point(270, 332);
            loginPasswordLineLabel.Name = "loginPasswordLineLabel";
            loginPasswordLineLabel.Size = new Size(410, 2);
            loginPasswordLineLabel.TabIndex = 4;
            // 
            // loginPasswordTextBox
            // 
            loginPasswordTextBox.BackColor = Color.FromArgb(25, 42, 86);
            loginPasswordTextBox.BorderStyle = BorderStyle.None;
            loginPasswordTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginPasswordTextBox.ForeColor = Color.Silver;
            loginPasswordTextBox.Location = new Point(271, 304);
            loginPasswordTextBox.Name = "loginPasswordTextBox";
            loginPasswordTextBox.PasswordChar = '*';
            loginPasswordTextBox.PlaceholderText = "Contraseña";
            loginPasswordTextBox.Size = new Size(410, 24);
            loginPasswordTextBox.TabIndex = 3;
            // 
            // loginUserLineLabel
            // 
            loginUserLineLabel.BackColor = Color.Silver;
            loginUserLineLabel.Location = new Point(268, 216);
            loginUserLineLabel.Name = "loginUserLineLabel";
            loginUserLineLabel.Size = new Size(410, 2);
            loginUserLineLabel.TabIndex = 2;
            // 
            // loginUserTextBox
            // 
            loginUserTextBox.BackColor = Color.FromArgb(25, 42, 86);
            loginUserTextBox.BorderStyle = BorderStyle.None;
            loginUserTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginUserTextBox.ForeColor = Color.Silver;
            loginUserTextBox.Location = new Point(268, 188);
            loginUserTextBox.Name = "loginUserTextBox";
            loginUserTextBox.PlaceholderText = "Usuario";
            loginUserTextBox.Size = new Size(410, 24);
            loginUserTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.White;
            loginLabel.Location = new Point(392, 116);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(191, 25);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "INICIO DE SESIÓN";
            // 
            // SeePasswordpictureBox
            // 
            SeePasswordpictureBox.Image = (Image)resources.GetObject("SeePasswordpictureBox.Image");
            SeePasswordpictureBox.Location = new Point(641, 294);
            SeePasswordpictureBox.Name = "SeePasswordpictureBox";
            SeePasswordpictureBox.Size = new Size(37, 35);
            SeePasswordpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SeePasswordpictureBox.TabIndex = 10;
            SeePasswordpictureBox.TabStop = false;
            SeePasswordpictureBox.Click += SeePasswordpictureBox_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 711);
            Controls.Add(loginContentPanel);
            Controls.Add(loginSideBarPanel);
            Controls.Add(loginTopBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            loginTopBarPanel.ResumeLayout(false);
            loginSideBarPanel.ResumeLayout(false);
            loginSideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginLogoPictureBox).EndInit();
            loginContentPanel.ResumeLayout(false);
            loginContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HidePasswordpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeePasswordpictureBox).EndInit();
            ResumeLayout(false);
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
        private PictureBox HidePasswordpictureBox;
        private PictureBox SeePasswordpictureBox;
    }
}