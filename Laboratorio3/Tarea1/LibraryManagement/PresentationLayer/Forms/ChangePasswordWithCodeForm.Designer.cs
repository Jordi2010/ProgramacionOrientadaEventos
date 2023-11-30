namespace PresentationLayer.Forms
{
    partial class ChangePasswordWithCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordWithCodeForm));
            backRecoverPasswordButton = new Button();
            ValidateCodeButton = new Button();
            label3 = new Label();
            CodeToRecoverTextBox = new TextBox();
            label2 = new Label();
            confirmPasswordLineLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            ConsumeCodeButton = new Button();
            recoverPasswordButton = new Button();
            newPasswordLineLabel = new Label();
            newPasswordTextBox = new TextBox();
            titlePasswordLabel = new Label();
            SuspendLayout();
            // 
            // backRecoverPasswordButton
            // 
            backRecoverPasswordButton.BackgroundImage = (Image)resources.GetObject("backRecoverPasswordButton.BackgroundImage");
            backRecoverPasswordButton.BackgroundImageLayout = ImageLayout.Stretch;
            backRecoverPasswordButton.FlatAppearance.BorderColor = Color.FromArgb(25, 42, 86);
            backRecoverPasswordButton.FlatStyle = FlatStyle.Flat;
            backRecoverPasswordButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            backRecoverPasswordButton.ForeColor = Color.Silver;
            backRecoverPasswordButton.Location = new Point(12, 12);
            backRecoverPasswordButton.Name = "backRecoverPasswordButton";
            backRecoverPasswordButton.Size = new Size(50, 48);
            backRecoverPasswordButton.TabIndex = 38;
            backRecoverPasswordButton.UseVisualStyleBackColor = true;
            backRecoverPasswordButton.Click += backRecoverPasswordButton_Click;
            // 
            // ValidateCodeButton
            // 
            ValidateCodeButton.BackColor = Color.FromArgb(10, 61, 98);
            ValidateCodeButton.FlatAppearance.BorderColor = Color.Teal;
            ValidateCodeButton.FlatStyle = FlatStyle.Flat;
            ValidateCodeButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ValidateCodeButton.ForeColor = Color.Silver;
            ValidateCodeButton.Location = new Point(255, 223);
            ValidateCodeButton.Name = "ValidateCodeButton";
            ValidateCodeButton.Size = new Size(410, 39);
            ValidateCodeButton.TabIndex = 59;
            ValidateCodeButton.Text = "Validar Código";
            ValidateCodeButton.UseVisualStyleBackColor = false;
            ValidateCodeButton.Click += ValidateCodeButton_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.Location = new Point(255, 194);
            label3.Name = "label3";
            label3.Size = new Size(410, 2);
            label3.TabIndex = 58;
            // 
            // CodeToRecoverTextBox
            // 
            CodeToRecoverTextBox.BackColor = Color.FromArgb(25, 42, 86);
            CodeToRecoverTextBox.BorderStyle = BorderStyle.None;
            CodeToRecoverTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodeToRecoverTextBox.ForeColor = Color.Silver;
            CodeToRecoverTextBox.Location = new Point(255, 166);
            CodeToRecoverTextBox.Name = "CodeToRecoverTextBox";
            CodeToRecoverTextBox.PlaceholderText = "Código";
            CodeToRecoverTextBox.Size = new Size(410, 24);
            CodeToRecoverTextBox.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 118);
            label2.Name = "label2";
            label2.Size = new Size(252, 25);
            label2.TabIndex = 56;
            label2.Text = "INTRODUCE EL CÓDIGO";
            // 
            // confirmPasswordLineLabel
            // 
            confirmPasswordLineLabel.BackColor = Color.Silver;
            confirmPasswordLineLabel.Location = new Point(253, 437);
            confirmPasswordLineLabel.Name = "confirmPasswordLineLabel";
            confirmPasswordLineLabel.Size = new Size(410, 2);
            confirmPasswordLineLabel.TabIndex = 55;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.FromArgb(25, 42, 86);
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.ForeColor = Color.Silver;
            confirmPasswordTextBox.Location = new Point(255, 410);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PlaceholderText = "Repite la contraseña";
            confirmPasswordTextBox.Size = new Size(410, 24);
            confirmPasswordTextBox.TabIndex = 54;
            // 
            // ConsumeCodeButton
            // 
            ConsumeCodeButton.BackColor = Color.FromArgb(10, 61, 98);
            ConsumeCodeButton.FlatAppearance.BorderColor = Color.Silver;
            ConsumeCodeButton.FlatStyle = FlatStyle.Flat;
            ConsumeCodeButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ConsumeCodeButton.ForeColor = Color.Silver;
            ConsumeCodeButton.Location = new Point(253, 550);
            ConsumeCodeButton.Name = "ConsumeCodeButton";
            ConsumeCodeButton.Size = new Size(410, 39);
            ConsumeCodeButton.TabIndex = 53;
            ConsumeCodeButton.Text = "Cancelar";
            ConsumeCodeButton.UseVisualStyleBackColor = false;
            ConsumeCodeButton.Click += ConsumeCodeButton_Click;
            // 
            // recoverPasswordButton
            // 
            recoverPasswordButton.BackColor = Color.FromArgb(10, 61, 98);
            recoverPasswordButton.FlatAppearance.BorderColor = Color.Teal;
            recoverPasswordButton.FlatStyle = FlatStyle.Flat;
            recoverPasswordButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            recoverPasswordButton.ForeColor = Color.Silver;
            recoverPasswordButton.Location = new Point(255, 469);
            recoverPasswordButton.Name = "recoverPasswordButton";
            recoverPasswordButton.Size = new Size(410, 39);
            recoverPasswordButton.TabIndex = 52;
            recoverPasswordButton.Text = "Guardar nueva contraseña";
            recoverPasswordButton.UseVisualStyleBackColor = false;
            recoverPasswordButton.Click += recoverPasswordButton_Click;
            // 
            // newPasswordLineLabel
            // 
            newPasswordLineLabel.BackColor = Color.Silver;
            newPasswordLineLabel.Location = new Point(254, 392);
            newPasswordLineLabel.Name = "newPasswordLineLabel";
            newPasswordLineLabel.Size = new Size(410, 2);
            newPasswordLineLabel.TabIndex = 51;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.BackColor = Color.FromArgb(25, 42, 86);
            newPasswordTextBox.BorderStyle = BorderStyle.None;
            newPasswordTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordTextBox.ForeColor = Color.Silver;
            newPasswordTextBox.Location = new Point(255, 365);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "Nueva contraseña";
            newPasswordTextBox.Size = new Size(410, 24);
            newPasswordTextBox.TabIndex = 50;
            // 
            // titlePasswordLabel
            // 
            titlePasswordLabel.AutoSize = true;
            titlePasswordLabel.BackColor = Color.Transparent;
            titlePasswordLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            titlePasswordLabel.ForeColor = Color.White;
            titlePasswordLabel.Location = new Point(294, 298);
            titlePasswordLabel.Name = "titlePasswordLabel";
            titlePasswordLabel.Size = new Size(344, 25);
            titlePasswordLabel.TabIndex = 49;
            titlePasswordLabel.Text = "CREA UNA NUEVA CONTRASEÑA";
            // 
            // ChangePasswordWithCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(914, 676);
            Controls.Add(ValidateCodeButton);
            Controls.Add(label3);
            Controls.Add(CodeToRecoverTextBox);
            Controls.Add(label2);
            Controls.Add(confirmPasswordLineLabel);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(ConsumeCodeButton);
            Controls.Add(recoverPasswordButton);
            Controls.Add(newPasswordLineLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(titlePasswordLabel);
            Controls.Add(backRecoverPasswordButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordWithCodeForm";
            Text = "ChangePasswordWithCodeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backRecoverPasswordButton;
        private Button ValidateCodeButton;
        private Label label3;
        private TextBox CodeToRecoverTextBox;
        private Label label2;
        private Label confirmPasswordLineLabel;
        private TextBox confirmPasswordTextBox;
        private Button ConsumeCodeButton;
        private Button recoverPasswordButton;
        private Label newPasswordLineLabel;
        private TextBox newPasswordTextBox;
        private Label titlePasswordLabel;
    }
}