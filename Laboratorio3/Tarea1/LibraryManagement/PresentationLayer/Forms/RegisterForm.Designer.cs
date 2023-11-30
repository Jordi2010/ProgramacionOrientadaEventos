namespace PresentationLayer.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            registerButton = new Button();
            registerNameLineLabel = new Label();
            registerNameTextBox = new TextBox();
            registerUserLineLabel = new Label();
            registerUserTextBox = new TextBox();
            registerLabel = new Label();
            registerPhoneLineLabel = new Label();
            registerPhoneTextBox = new TextBox();
            registerLastNameLineLabel = new Label();
            registerLastNameTextBox = new TextBox();
            registerPasswordLineLabel = new Label();
            registerPasswordTextBox = new TextBox();
            registerEmailLineLabel = new Label();
            registerEmailTextBox = new TextBox();
            backRegisterButton = new Button();
            HidePasswordRegisterPictureBox = new PictureBox();
            SeePasswordRegisterPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HidePasswordRegisterPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeePasswordRegisterPictureBox).BeginInit();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(10, 61, 98);
            registerButton.FlatAppearance.BorderColor = Color.Teal;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = Color.Silver;
            registerButton.Location = new Point(275, 529);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(410, 39);
            registerButton.TabIndex = 11;
            registerButton.Text = "Registrarse";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // registerNameLineLabel
            // 
            registerNameLineLabel.BackColor = Color.Silver;
            registerNameLineLabel.Location = new Point(275, 283);
            registerNameLineLabel.Name = "registerNameLineLabel";
            registerNameLineLabel.Size = new Size(410, 2);
            registerNameLineLabel.TabIndex = 10;
            // 
            // registerNameTextBox
            // 
            registerNameTextBox.BackColor = Color.FromArgb(25, 42, 86);
            registerNameTextBox.BorderStyle = BorderStyle.None;
            registerNameTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerNameTextBox.ForeColor = Color.Silver;
            registerNameTextBox.Location = new Point(276, 255);
            registerNameTextBox.Name = "registerNameTextBox";
            registerNameTextBox.PlaceholderText = "Nombre";
            registerNameTextBox.Size = new Size(410, 24);
            registerNameTextBox.TabIndex = 9;
            // 
            // registerUserLineLabel
            // 
            registerUserLineLabel.BackColor = Color.Silver;
            registerUserLineLabel.Location = new Point(276, 230);
            registerUserLineLabel.Name = "registerUserLineLabel";
            registerUserLineLabel.Size = new Size(410, 2);
            registerUserLineLabel.TabIndex = 8;
            // 
            // registerUserTextBox
            // 
            registerUserTextBox.BackColor = Color.FromArgb(25, 42, 86);
            registerUserTextBox.BorderStyle = BorderStyle.None;
            registerUserTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerUserTextBox.ForeColor = Color.Silver;
            registerUserTextBox.Location = new Point(276, 202);
            registerUserTextBox.Name = "registerUserTextBox";
            registerUserTextBox.PlaceholderText = "Usuario";
            registerUserTextBox.Size = new Size(410, 24);
            registerUserTextBox.TabIndex = 7;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.BackColor = Color.Transparent;
            registerLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.White;
            registerLabel.Location = new Point(328, 135);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(285, 25);
            registerLabel.TabIndex = 6;
            registerLabel.Text = "REGISTRAR NUEVA CUENTA";
            // 
            // registerPhoneLineLabel
            // 
            registerPhoneLineLabel.BackColor = Color.Silver;
            registerPhoneLineLabel.Location = new Point(274, 393);
            registerPhoneLineLabel.Name = "registerPhoneLineLabel";
            registerPhoneLineLabel.Size = new Size(410, 2);
            registerPhoneLineLabel.TabIndex = 15;
            // 
            // registerPhoneTextBox
            // 
            registerPhoneTextBox.BackColor = Color.FromArgb(25, 42, 86);
            registerPhoneTextBox.BorderStyle = BorderStyle.None;
            registerPhoneTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerPhoneTextBox.ForeColor = Color.Silver;
            registerPhoneTextBox.Location = new Point(275, 365);
            registerPhoneTextBox.Name = "registerPhoneTextBox";
            registerPhoneTextBox.PlaceholderText = "Teléfono";
            registerPhoneTextBox.Size = new Size(410, 24);
            registerPhoneTextBox.TabIndex = 14;
            // 
            // registerLastNameLineLabel
            // 
            registerLastNameLineLabel.BackColor = Color.Silver;
            registerLastNameLineLabel.Location = new Point(275, 338);
            registerLastNameLineLabel.Name = "registerLastNameLineLabel";
            registerLastNameLineLabel.Size = new Size(410, 2);
            registerLastNameLineLabel.TabIndex = 13;
            // 
            // registerLastNameTextBox
            // 
            registerLastNameTextBox.BackColor = Color.FromArgb(25, 42, 86);
            registerLastNameTextBox.BorderStyle = BorderStyle.None;
            registerLastNameTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerLastNameTextBox.ForeColor = Color.Silver;
            registerLastNameTextBox.Location = new Point(275, 310);
            registerLastNameTextBox.Name = "registerLastNameTextBox";
            registerLastNameTextBox.PlaceholderText = "Apellido";
            registerLastNameTextBox.Size = new Size(410, 24);
            registerLastNameTextBox.TabIndex = 12;
            // 
            // registerPasswordLineLabel
            // 
            registerPasswordLineLabel.BackColor = Color.Silver;
            registerPasswordLineLabel.Location = new Point(273, 498);
            registerPasswordLineLabel.Name = "registerPasswordLineLabel";
            registerPasswordLineLabel.Size = new Size(410, 2);
            registerPasswordLineLabel.TabIndex = 19;
            // 
            // registerPasswordTextBox
            // 
            registerPasswordTextBox.BackColor = Color.FromArgb(25, 42, 86);
            registerPasswordTextBox.BorderStyle = BorderStyle.None;
            registerPasswordTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerPasswordTextBox.ForeColor = Color.Silver;
            registerPasswordTextBox.Location = new Point(274, 470);
            registerPasswordTextBox.Name = "registerPasswordTextBox";
            registerPasswordTextBox.PasswordChar = '*';
            registerPasswordTextBox.PlaceholderText = "Contraseña";
            registerPasswordTextBox.Size = new Size(410, 24);
            registerPasswordTextBox.TabIndex = 18;
            // 
            // registerEmailLineLabel
            // 
            registerEmailLineLabel.BackColor = Color.Silver;
            registerEmailLineLabel.Location = new Point(274, 443);
            registerEmailLineLabel.Name = "registerEmailLineLabel";
            registerEmailLineLabel.Size = new Size(410, 2);
            registerEmailLineLabel.TabIndex = 17;
            // 
            // registerEmailTextBox
            // 
            registerEmailTextBox.BackColor = Color.FromArgb(25, 42, 86);
            registerEmailTextBox.BorderStyle = BorderStyle.None;
            registerEmailTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerEmailTextBox.ForeColor = Color.Silver;
            registerEmailTextBox.Location = new Point(274, 415);
            registerEmailTextBox.Name = "registerEmailTextBox";
            registerEmailTextBox.PlaceholderText = "Correo electrónico";
            registerEmailTextBox.Size = new Size(410, 24);
            registerEmailTextBox.TabIndex = 16;
            // 
            // backRegisterButton
            // 
            backRegisterButton.BackgroundImage = (Image)resources.GetObject("backRegisterButton.BackgroundImage");
            backRegisterButton.BackgroundImageLayout = ImageLayout.Stretch;
            backRegisterButton.FlatAppearance.BorderColor = Color.FromArgb(25, 42, 86);
            backRegisterButton.FlatStyle = FlatStyle.Flat;
            backRegisterButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            backRegisterButton.ForeColor = Color.Silver;
            backRegisterButton.Location = new Point(12, 12);
            backRegisterButton.Name = "backRegisterButton";
            backRegisterButton.Size = new Size(47, 47);
            backRegisterButton.TabIndex = 21;
            backRegisterButton.UseVisualStyleBackColor = true;
            backRegisterButton.Click += backRegisterButton_Click;
            // 
            // HidePasswordRegisterPictureBox
            // 
            HidePasswordRegisterPictureBox.Image = (Image)resources.GetObject("HidePasswordRegisterPictureBox.Image");
            HidePasswordRegisterPictureBox.Location = new Point(648, 460);
            HidePasswordRegisterPictureBox.Name = "HidePasswordRegisterPictureBox";
            HidePasswordRegisterPictureBox.Size = new Size(37, 35);
            HidePasswordRegisterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            HidePasswordRegisterPictureBox.TabIndex = 23;
            HidePasswordRegisterPictureBox.TabStop = false;
            HidePasswordRegisterPictureBox.Click += HidePasswordRegisterPictureBox_Click;
            // 
            // SeePasswordRegisterPictureBox
            // 
            SeePasswordRegisterPictureBox.Image = (Image)resources.GetObject("SeePasswordRegisterPictureBox.Image");
            SeePasswordRegisterPictureBox.Location = new Point(648, 460);
            SeePasswordRegisterPictureBox.Name = "SeePasswordRegisterPictureBox";
            SeePasswordRegisterPictureBox.Size = new Size(37, 35);
            SeePasswordRegisterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SeePasswordRegisterPictureBox.TabIndex = 24;
            SeePasswordRegisterPictureBox.TabStop = false;
            SeePasswordRegisterPictureBox.Click += SeePasswordRegisterPictureBox_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(914, 676);
            Controls.Add(HidePasswordRegisterPictureBox);
            Controls.Add(backRegisterButton);
            Controls.Add(registerPasswordLineLabel);
            Controls.Add(registerPasswordTextBox);
            Controls.Add(registerEmailLineLabel);
            Controls.Add(registerEmailTextBox);
            Controls.Add(registerPhoneLineLabel);
            Controls.Add(registerPhoneTextBox);
            Controls.Add(registerLastNameLineLabel);
            Controls.Add(registerLastNameTextBox);
            Controls.Add(registerButton);
            Controls.Add(registerNameLineLabel);
            Controls.Add(registerNameTextBox);
            Controls.Add(registerUserLineLabel);
            Controls.Add(registerUserTextBox);
            Controls.Add(registerLabel);
            Controls.Add(SeePasswordRegisterPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)HidePasswordRegisterPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeePasswordRegisterPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label registerNameLineLabel;
        private TextBox registerNameTextBox;
        private Label registerUserLineLabel;
        private TextBox registerUserTextBox;
        private Label registerLabel;
        private Label registerPhoneLineLabel;
        private TextBox registerPhoneTextBox;
        private Label registerLastNameLineLabel;
        private TextBox registerLastNameTextBox;
        private Label registerPasswordLineLabel;
        private TextBox registerPasswordTextBox;
        private Label registerEmailLineLabel;
        private TextBox registerEmailTextBox;
        private Button backRegisterButton;
        private PictureBox HidePasswordRegisterPictureBox;
        private PictureBox SeePasswordRegisterPictureBox;
    }
}