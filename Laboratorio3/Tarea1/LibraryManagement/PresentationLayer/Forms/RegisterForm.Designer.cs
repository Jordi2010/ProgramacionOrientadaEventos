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
            this.registerButton = new System.Windows.Forms.Button();
            this.registerNameLineLabel = new System.Windows.Forms.Label();
            this.registerNameTextBox = new System.Windows.Forms.TextBox();
            this.registerUserLineLabel = new System.Windows.Forms.Label();
            this.registerUserTextBox = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.registerPhoneLineLabel = new System.Windows.Forms.Label();
            this.registerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.registerLastNameLineLabel = new System.Windows.Forms.Label();
            this.registerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordLineLabel = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerEmailLineLabel = new System.Windows.Forms.Label();
            this.registerEmailTextBox = new System.Windows.Forms.TextBox();
            this.backRegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.Silver;
            this.registerButton.Location = new System.Drawing.Point(238, 459);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(410, 39);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Registrarse";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerNameLineLabel
            // 
            this.registerNameLineLabel.BackColor = System.Drawing.Color.Silver;
            this.registerNameLineLabel.Location = new System.Drawing.Point(238, 213);
            this.registerNameLineLabel.Name = "registerNameLineLabel";
            this.registerNameLineLabel.Size = new System.Drawing.Size(410, 2);
            this.registerNameLineLabel.TabIndex = 10;
            // 
            // registerNameTextBox
            // 
            this.registerNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.registerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.registerNameTextBox.Location = new System.Drawing.Point(239, 185);
            this.registerNameTextBox.Name = "registerNameTextBox";
            this.registerNameTextBox.PlaceholderText = "Nombre";
            this.registerNameTextBox.Size = new System.Drawing.Size(410, 24);
            this.registerNameTextBox.TabIndex = 9;
            // 
            // registerUserLineLabel
            // 
            this.registerUserLineLabel.BackColor = System.Drawing.Color.Silver;
            this.registerUserLineLabel.Location = new System.Drawing.Point(239, 160);
            this.registerUserLineLabel.Name = "registerUserLineLabel";
            this.registerUserLineLabel.Size = new System.Drawing.Size(410, 2);
            this.registerUserLineLabel.TabIndex = 8;
            // 
            // registerUserTextBox
            // 
            this.registerUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.registerUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerUserTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerUserTextBox.ForeColor = System.Drawing.Color.Silver;
            this.registerUserTextBox.Location = new System.Drawing.Point(239, 132);
            this.registerUserTextBox.Name = "registerUserTextBox";
            this.registerUserTextBox.PlaceholderText = "Usuario";
            this.registerUserTextBox.Size = new System.Drawing.Size(410, 24);
            this.registerUserTextBox.TabIndex = 7;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(312, 69);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(248, 25);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.Text = "Registrar nueva cuenta";
            // 
            // registerPhoneLineLabel
            // 
            this.registerPhoneLineLabel.BackColor = System.Drawing.Color.Silver;
            this.registerPhoneLineLabel.Location = new System.Drawing.Point(237, 323);
            this.registerPhoneLineLabel.Name = "registerPhoneLineLabel";
            this.registerPhoneLineLabel.Size = new System.Drawing.Size(410, 2);
            this.registerPhoneLineLabel.TabIndex = 15;
            // 
            // registerPhoneTextBox
            // 
            this.registerPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.registerPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerPhoneTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerPhoneTextBox.ForeColor = System.Drawing.Color.Silver;
            this.registerPhoneTextBox.Location = new System.Drawing.Point(238, 295);
            this.registerPhoneTextBox.Name = "registerPhoneTextBox";
            this.registerPhoneTextBox.PlaceholderText = "Teléfono";
            this.registerPhoneTextBox.Size = new System.Drawing.Size(410, 24);
            this.registerPhoneTextBox.TabIndex = 14;
            // 
            // registerLastNameLineLabel
            // 
            this.registerLastNameLineLabel.BackColor = System.Drawing.Color.Silver;
            this.registerLastNameLineLabel.Location = new System.Drawing.Point(238, 268);
            this.registerLastNameLineLabel.Name = "registerLastNameLineLabel";
            this.registerLastNameLineLabel.Size = new System.Drawing.Size(410, 2);
            this.registerLastNameLineLabel.TabIndex = 13;
            // 
            // registerLastNameTextBox
            // 
            this.registerLastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.registerLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerLastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLastNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.registerLastNameTextBox.Location = new System.Drawing.Point(238, 240);
            this.registerLastNameTextBox.Name = "registerLastNameTextBox";
            this.registerLastNameTextBox.PlaceholderText = "Apellido";
            this.registerLastNameTextBox.Size = new System.Drawing.Size(410, 24);
            this.registerLastNameTextBox.TabIndex = 12;
            // 
            // registerPasswordLineLabel
            // 
            this.registerPasswordLineLabel.BackColor = System.Drawing.Color.Silver;
            this.registerPasswordLineLabel.Location = new System.Drawing.Point(236, 428);
            this.registerPasswordLineLabel.Name = "registerPasswordLineLabel";
            this.registerPasswordLineLabel.Size = new System.Drawing.Size(410, 2);
            this.registerPasswordLineLabel.TabIndex = 19;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.registerPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerPasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.registerPasswordTextBox.Location = new System.Drawing.Point(237, 400);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.PlaceholderText = "Contraseña";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(410, 24);
            this.registerPasswordTextBox.TabIndex = 18;
            // 
            // registerEmailLineLabel
            // 
            this.registerEmailLineLabel.BackColor = System.Drawing.Color.Silver;
            this.registerEmailLineLabel.Location = new System.Drawing.Point(237, 373);
            this.registerEmailLineLabel.Name = "registerEmailLineLabel";
            this.registerEmailLineLabel.Size = new System.Drawing.Size(410, 2);
            this.registerEmailLineLabel.TabIndex = 17;
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.registerEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerEmailTextBox.ForeColor = System.Drawing.Color.Silver;
            this.registerEmailTextBox.Location = new System.Drawing.Point(237, 345);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.PlaceholderText = "Correo electrónico";
            this.registerEmailTextBox.Size = new System.Drawing.Size(410, 24);
            this.registerEmailTextBox.TabIndex = 16;
            // 
            // backRegisterButton
            // 
            this.backRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backRegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.backRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backRegisterButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backRegisterButton.ForeColor = System.Drawing.Color.Silver;
            this.backRegisterButton.Location = new System.Drawing.Point(8, 7);
            this.backRegisterButton.Name = "backRegisterButton";
            this.backRegisterButton.Size = new System.Drawing.Size(81, 30);
            this.backRegisterButton.TabIndex = 21;
            this.backRegisterButton.Text = "⬅️ Volver";
            this.backRegisterButton.UseVisualStyleBackColor = true;
            this.backRegisterButton.Click += new System.EventHandler(this.backRegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(914, 676);
            this.Controls.Add(this.backRegisterButton);
            this.Controls.Add(this.registerPasswordLineLabel);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerEmailLineLabel);
            this.Controls.Add(this.registerEmailTextBox);
            this.Controls.Add(this.registerPhoneLineLabel);
            this.Controls.Add(this.registerPhoneTextBox);
            this.Controls.Add(this.registerLastNameLineLabel);
            this.Controls.Add(this.registerLastNameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerNameLineLabel);
            this.Controls.Add(this.registerNameTextBox);
            this.Controls.Add(this.registerUserLineLabel);
            this.Controls.Add(this.registerUserTextBox);
            this.Controls.Add(this.registerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}