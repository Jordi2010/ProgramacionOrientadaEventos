namespace PresentationLayer.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            saveProfileButton = new Button();
            editProfileButton = new Button();
            profileEmailTextBox = new TextBox();
            profileEmailLabel = new Label();
            profileLastNameTextBox = new TextBox();
            profilePhoneTextBox = new TextBox();
            profilePhoneLabel = new Label();
            profileLastNameLabel = new Label();
            profileNameLabel = new Label();
            profileUserTextBox = new TextBox();
            profileUserLabel = new Label();
            profileInformationGroupBox = new GroupBox();
            profileEmailViewLabel = new Label();
            profileEmailTitleLabel = new Label();
            profilePhoneViewLabel = new Label();
            profilePhoneTitleLabel = new Label();
            profileLastNameViewLabel = new Label();
            profileLastNameTitleLabel = new Label();
            profileNameViewLabel = new Label();
            profileNameTitleLabel = new Label();
            profileUserViewLabel = new Label();
            profileUserTitleLabel = new Label();
            profilePictureBox = new PictureBox();
            profileEditGroupBox = new GroupBox();
            profileNameTextBox = new TextBox();
            profileManagementLabel = new Label();
            profileInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            profileEditGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // saveProfileButton
            // 
            saveProfileButton.BackColor = Color.FromArgb(25, 42, 86);
            saveProfileButton.FlatAppearance.BorderColor = Color.Teal;
            saveProfileButton.FlatStyle = FlatStyle.Flat;
            saveProfileButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveProfileButton.ForeColor = Color.White;
            saveProfileButton.Location = new Point(141, 497);
            saveProfileButton.Name = "saveProfileButton";
            saveProfileButton.Size = new Size(110, 31);
            saveProfileButton.TabIndex = 32;
            saveProfileButton.Text = "Guardar";
            saveProfileButton.UseVisualStyleBackColor = false;
            saveProfileButton.Click += saveProfileButton_Click;
            // 
            // editProfileButton
            // 
            editProfileButton.BackColor = Color.RoyalBlue;
            editProfileButton.FlatAppearance.BorderColor = Color.Teal;
            editProfileButton.FlatStyle = FlatStyle.Flat;
            editProfileButton.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            editProfileButton.ForeColor = Color.White;
            editProfileButton.Location = new Point(271, 497);
            editProfileButton.Name = "editProfileButton";
            editProfileButton.Size = new Size(110, 31);
            editProfileButton.TabIndex = 33;
            editProfileButton.Text = "Editar";
            editProfileButton.UseVisualStyleBackColor = false;
            editProfileButton.Click += editProfileButton_Click;
            // 
            // profileEmailTextBox
            // 
            profileEmailTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            profileEmailTextBox.Location = new Point(12, 381);
            profileEmailTextBox.Name = "profileEmailTextBox";
            profileEmailTextBox.Size = new Size(359, 26);
            profileEmailTextBox.TabIndex = 24;
            // 
            // profileEmailLabel
            // 
            profileEmailLabel.AutoSize = true;
            profileEmailLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileEmailLabel.ForeColor = Color.White;
            profileEmailLabel.Location = new Point(10, 352);
            profileEmailLabel.Name = "profileEmailLabel";
            profileEmailLabel.Size = new Size(171, 21);
            profileEmailLabel.TabIndex = 23;
            profileEmailLabel.Text = "Correo electrónico:";
            // 
            // profileLastNameTextBox
            // 
            profileLastNameTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            profileLastNameTextBox.Location = new Point(12, 228);
            profileLastNameTextBox.Name = "profileLastNameTextBox";
            profileLastNameTextBox.Size = new Size(359, 26);
            profileLastNameTextBox.TabIndex = 20;
            // 
            // profilePhoneTextBox
            // 
            profilePhoneTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            profilePhoneTextBox.Location = new Point(12, 304);
            profilePhoneTextBox.Name = "profilePhoneTextBox";
            profilePhoneTextBox.Size = new Size(359, 26);
            profilePhoneTextBox.TabIndex = 22;
            // 
            // profilePhoneLabel
            // 
            profilePhoneLabel.AutoSize = true;
            profilePhoneLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profilePhoneLabel.ForeColor = Color.White;
            profilePhoneLabel.Location = new Point(10, 275);
            profilePhoneLabel.Name = "profilePhoneLabel";
            profilePhoneLabel.Size = new Size(85, 21);
            profilePhoneLabel.TabIndex = 21;
            profilePhoneLabel.Text = "Teléfono:";
            // 
            // profileLastNameLabel
            // 
            profileLastNameLabel.AutoSize = true;
            profileLastNameLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileLastNameLabel.ForeColor = Color.White;
            profileLastNameLabel.Location = new Point(702, 250);
            profileLastNameLabel.Name = "profileLastNameLabel";
            profileLastNameLabel.Size = new Size(83, 21);
            profileLastNameLabel.TabIndex = 31;
            profileLastNameLabel.Text = "Apellido:";
            // 
            // profileNameLabel
            // 
            profileNameLabel.AutoSize = true;
            profileNameLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileNameLabel.ForeColor = Color.White;
            profileNameLabel.Location = new Point(10, 119);
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Size = new Size(82, 21);
            profileNameLabel.TabIndex = 25;
            profileNameLabel.Text = "Nombre:";
            // 
            // profileUserTextBox
            // 
            profileUserTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            profileUserTextBox.Location = new Point(12, 72);
            profileUserTextBox.Name = "profileUserTextBox";
            profileUserTextBox.Size = new Size(359, 26);
            profileUserTextBox.TabIndex = 18;
            // 
            // profileUserLabel
            // 
            profileUserLabel.AutoSize = true;
            profileUserLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileUserLabel.ForeColor = Color.White;
            profileUserLabel.Location = new Point(702, 94);
            profileUserLabel.Name = "profileUserLabel";
            profileUserLabel.Size = new Size(75, 21);
            profileUserLabel.TabIndex = 30;
            profileUserLabel.Text = "Usuario:";
            // 
            // profileInformationGroupBox
            // 
            profileInformationGroupBox.Controls.Add(profileEmailViewLabel);
            profileInformationGroupBox.Controls.Add(profileEmailTitleLabel);
            profileInformationGroupBox.Controls.Add(profilePhoneViewLabel);
            profileInformationGroupBox.Controls.Add(profilePhoneTitleLabel);
            profileInformationGroupBox.Controls.Add(profileLastNameViewLabel);
            profileInformationGroupBox.Controls.Add(profileLastNameTitleLabel);
            profileInformationGroupBox.Controls.Add(profileNameViewLabel);
            profileInformationGroupBox.Controls.Add(profileNameTitleLabel);
            profileInformationGroupBox.Controls.Add(profileUserViewLabel);
            profileInformationGroupBox.Controls.Add(profileUserTitleLabel);
            profileInformationGroupBox.Controls.Add(profilePictureBox);
            profileInformationGroupBox.Controls.Add(editProfileButton);
            profileInformationGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileInformationGroupBox.ForeColor = Color.White;
            profileInformationGroupBox.Location = new Point(7, 51);
            profileInformationGroupBox.Name = "profileInformationGroupBox";
            profileInformationGroupBox.Size = new Size(679, 615);
            profileInformationGroupBox.TabIndex = 34;
            profileInformationGroupBox.TabStop = false;
            profileInformationGroupBox.Text = "Información de perfil actual";
            // 
            // profileEmailViewLabel
            // 
            profileEmailViewLabel.Location = new Point(242, 382);
            profileEmailViewLabel.Name = "profileEmailViewLabel";
            profileEmailViewLabel.Size = new Size(417, 21);
            profileEmailViewLabel.TabIndex = 44;
            profileEmailViewLabel.Text = "Correo electrónico";
            // 
            // profileEmailTitleLabel
            // 
            profileEmailTitleLabel.AutoSize = true;
            profileEmailTitleLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileEmailTitleLabel.Location = new Point(242, 352);
            profileEmailTitleLabel.Name = "profileEmailTitleLabel";
            profileEmailTitleLabel.Size = new Size(168, 19);
            profileEmailTitleLabel.TabIndex = 43;
            profileEmailTitleLabel.Text = "Correo electrónico:";
            // 
            // profilePhoneViewLabel
            // 
            profilePhoneViewLabel.Location = new Point(242, 305);
            profilePhoneViewLabel.Name = "profilePhoneViewLabel";
            profilePhoneViewLabel.Size = new Size(417, 21);
            profilePhoneViewLabel.TabIndex = 42;
            profilePhoneViewLabel.Text = "Teléfono";
            // 
            // profilePhoneTitleLabel
            // 
            profilePhoneTitleLabel.AutoSize = true;
            profilePhoneTitleLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            profilePhoneTitleLabel.Location = new Point(242, 275);
            profilePhoneTitleLabel.Name = "profilePhoneTitleLabel";
            profilePhoneTitleLabel.Size = new Size(84, 19);
            profilePhoneTitleLabel.TabIndex = 41;
            profilePhoneTitleLabel.Text = "Teléfono:";
            // 
            // profileLastNameViewLabel
            // 
            profileLastNameViewLabel.Location = new Point(242, 243);
            profileLastNameViewLabel.Name = "profileLastNameViewLabel";
            profileLastNameViewLabel.Size = new Size(417, 21);
            profileLastNameViewLabel.TabIndex = 40;
            profileLastNameViewLabel.Text = "Apellido";
            // 
            // profileLastNameTitleLabel
            // 
            profileLastNameTitleLabel.AutoSize = true;
            profileLastNameTitleLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileLastNameTitleLabel.Location = new Point(242, 213);
            profileLastNameTitleLabel.Name = "profileLastNameTitleLabel";
            profileLastNameTitleLabel.Size = new Size(83, 19);
            profileLastNameTitleLabel.TabIndex = 39;
            profileLastNameTitleLabel.Text = "Apellido:";
            // 
            // profileNameViewLabel
            // 
            profileNameViewLabel.Location = new Point(242, 183);
            profileNameViewLabel.Name = "profileNameViewLabel";
            profileNameViewLabel.Size = new Size(417, 21);
            profileNameViewLabel.TabIndex = 38;
            profileNameViewLabel.Text = "Nombre";
            // 
            // profileNameTitleLabel
            // 
            profileNameTitleLabel.AutoSize = true;
            profileNameTitleLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileNameTitleLabel.Location = new Point(242, 155);
            profileNameTitleLabel.Name = "profileNameTitleLabel";
            profileNameTitleLabel.Size = new Size(81, 19);
            profileNameTitleLabel.TabIndex = 37;
            profileNameTitleLabel.Text = "Nombre:";
            // 
            // profileUserViewLabel
            // 
            profileUserViewLabel.Location = new Point(242, 73);
            profileUserViewLabel.Name = "profileUserViewLabel";
            profileUserViewLabel.Size = new Size(417, 82);
            profileUserViewLabel.TabIndex = 36;
            profileUserViewLabel.Text = "Usuario";
            // 
            // profileUserTitleLabel
            // 
            profileUserTitleLabel.AutoSize = true;
            profileUserTitleLabel.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileUserTitleLabel.Location = new Point(242, 43);
            profileUserTitleLabel.Name = "profileUserTitleLabel";
            profileUserTitleLabel.Size = new Size(73, 19);
            profileUserTitleLabel.TabIndex = 35;
            profileUserTitleLabel.Text = "Usuario:";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Image = (Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new Point(29, 41);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(193, 445);
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox.TabIndex = 34;
            profilePictureBox.TabStop = false;
            // 
            // profileEditGroupBox
            // 
            profileEditGroupBox.Controls.Add(saveProfileButton);
            profileEditGroupBox.Controls.Add(profileNameTextBox);
            profileEditGroupBox.Controls.Add(profileNameLabel);
            profileEditGroupBox.Controls.Add(profileEmailTextBox);
            profileEditGroupBox.Controls.Add(profileEmailLabel);
            profileEditGroupBox.Controls.Add(profileLastNameTextBox);
            profileEditGroupBox.Controls.Add(profileUserTextBox);
            profileEditGroupBox.Controls.Add(profilePhoneTextBox);
            profileEditGroupBox.Controls.Add(profilePhoneLabel);
            profileEditGroupBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileEditGroupBox.ForeColor = Color.White;
            profileEditGroupBox.Location = new Point(692, 51);
            profileEditGroupBox.Name = "profileEditGroupBox";
            profileEditGroupBox.Size = new Size(385, 615);
            profileEditGroupBox.TabIndex = 35;
            profileEditGroupBox.TabStop = false;
            profileEditGroupBox.Text = "Editar mis datos";
            // 
            // profileNameTextBox
            // 
            profileNameTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            profileNameTextBox.Location = new Point(10, 148);
            profileNameTextBox.Name = "profileNameTextBox";
            profileNameTextBox.Size = new Size(359, 26);
            profileNameTextBox.TabIndex = 29;
            // 
            // profileManagementLabel
            // 
            profileManagementLabel.AutoSize = true;
            profileManagementLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            profileManagementLabel.ForeColor = Color.White;
            profileManagementLabel.Location = new Point(384, 11);
            profileManagementLabel.Name = "profileManagementLabel";
            profileManagementLabel.Size = new Size(301, 25);
            profileManagementLabel.TabIndex = 29;
            profileManagementLabel.Text = "ADMINISTRACIÓN DEL PERFIL";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 61, 98);
            ClientSize = new Size(1084, 591);
            Controls.Add(profileLastNameLabel);
            Controls.Add(profileUserLabel);
            Controls.Add(profileInformationGroupBox);
            Controls.Add(profileEditGroupBox);
            Controls.Add(profileManagementLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            profileInformationGroupBox.ResumeLayout(false);
            profileInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            profileEditGroupBox.ResumeLayout(false);
            profileEditGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveProfileButton;
        private Button editProfileButton;
        private TextBox profileEmailTextBox;
        private Label profileEmailLabel;
        private TextBox profileLastNameTextBox;
        private TextBox profilePhoneTextBox;
        private Label profilePhoneLabel;
        private Label profileLastNameLabel;
        private Label profileNameLabel;
        private TextBox profileUserTextBox;
        private Label profileUserLabel;
        private GroupBox profileInformationGroupBox;
        private GroupBox profileEditGroupBox;
        private Label profileManagementLabel;
        private TextBox profileNameTextBox;
        private PictureBox profilePictureBox;
        private Label profileUserViewLabel;
        private Label profileUserTitleLabel;
        private Label profileEmailViewLabel;
        private Label profileEmailTitleLabel;
        private Label profilePhoneViewLabel;
        private Label profilePhoneTitleLabel;
        private Label profileLastNameViewLabel;
        private Label profileLastNameTitleLabel;
        private Label profileNameViewLabel;
        private Label profileNameTitleLabel;
    }
}