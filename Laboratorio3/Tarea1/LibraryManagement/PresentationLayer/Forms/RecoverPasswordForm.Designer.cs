namespace PresentationLayer.Forms
{
    partial class RecoverPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPasswordForm));
            backRecoverPasswordButton = new Button();
            recoverPasswordEmailButton = new Button();
            recoverPasswordEmailLineLabel = new Label();
            recoverPasswordEmailTextBox = new TextBox();
            recoverPasswordLabel = new Label();
            ConsumeCodeButton = new Button();
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
            backRecoverPasswordButton.Size = new Size(47, 39);
            backRecoverPasswordButton.TabIndex = 36;
            backRecoverPasswordButton.UseVisualStyleBackColor = true;
            backRecoverPasswordButton.Click += backRecoverPasswordButton_Click;
            // 
            // recoverPasswordEmailButton
            // 
            recoverPasswordEmailButton.BackColor = Color.FromArgb(10, 61, 98);
            recoverPasswordEmailButton.FlatAppearance.BorderColor = Color.Teal;
            recoverPasswordEmailButton.FlatStyle = FlatStyle.Flat;
            recoverPasswordEmailButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            recoverPasswordEmailButton.ForeColor = Color.Silver;
            recoverPasswordEmailButton.Location = new Point(276, 377);
            recoverPasswordEmailButton.Name = "recoverPasswordEmailButton";
            recoverPasswordEmailButton.Size = new Size(410, 39);
            recoverPasswordEmailButton.TabIndex = 27;
            recoverPasswordEmailButton.Text = "Enviar correo";
            recoverPasswordEmailButton.UseVisualStyleBackColor = false;
            recoverPasswordEmailButton.Click += recoverPasswordEmailButton_Click;
            // 
            // recoverPasswordEmailLineLabel
            // 
            recoverPasswordEmailLineLabel.BackColor = Color.Silver;
            recoverPasswordEmailLineLabel.Location = new Point(277, 283);
            recoverPasswordEmailLineLabel.Name = "recoverPasswordEmailLineLabel";
            recoverPasswordEmailLineLabel.Size = new Size(410, 2);
            recoverPasswordEmailLineLabel.TabIndex = 24;
            // 
            // recoverPasswordEmailTextBox
            // 
            recoverPasswordEmailTextBox.BackColor = Color.FromArgb(25, 42, 86);
            recoverPasswordEmailTextBox.BorderStyle = BorderStyle.None;
            recoverPasswordEmailTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            recoverPasswordEmailTextBox.ForeColor = Color.Silver;
            recoverPasswordEmailTextBox.Location = new Point(277, 255);
            recoverPasswordEmailTextBox.Name = "recoverPasswordEmailTextBox";
            recoverPasswordEmailTextBox.PlaceholderText = "Correo electrónico";
            recoverPasswordEmailTextBox.Size = new Size(410, 24);
            recoverPasswordEmailTextBox.TabIndex = 23;
            // 
            // recoverPasswordLabel
            // 
            recoverPasswordLabel.AutoSize = true;
            recoverPasswordLabel.BackColor = Color.Transparent;
            recoverPasswordLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            recoverPasswordLabel.ForeColor = Color.White;
            recoverPasswordLabel.Location = new Point(351, 177);
            recoverPasswordLabel.Name = "recoverPasswordLabel";
            recoverPasswordLabel.Size = new Size(275, 25);
            recoverPasswordLabel.TabIndex = 22;
            recoverPasswordLabel.Text = "RECUPERAR CONTRASEÑA";
            // 
            // ConsumeCodeButton
            // 
            ConsumeCodeButton.BackColor = Color.FromArgb(10, 61, 98);
            ConsumeCodeButton.FlatAppearance.BorderColor = Color.Silver;
            ConsumeCodeButton.FlatStyle = FlatStyle.Flat;
            ConsumeCodeButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ConsumeCodeButton.ForeColor = Color.Silver;
            ConsumeCodeButton.Location = new Point(277, 461);
            ConsumeCodeButton.Name = "ConsumeCodeButton";
            ConsumeCodeButton.Size = new Size(410, 39);
            ConsumeCodeButton.TabIndex = 37;
            ConsumeCodeButton.Text = "Tengo mi código";
            ConsumeCodeButton.UseVisualStyleBackColor = false;
            ConsumeCodeButton.Click += ConsumeCodeButton_Click;
            // 
            // RecoverPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(914, 676);
            Controls.Add(ConsumeCodeButton);
            Controls.Add(backRecoverPasswordButton);
            Controls.Add(recoverPasswordEmailButton);
            Controls.Add(recoverPasswordEmailLineLabel);
            Controls.Add(recoverPasswordEmailTextBox);
            Controls.Add(recoverPasswordLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecoverPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoverPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backRecoverPasswordButton;
        private Button recoverPasswordEmailButton;
        private Label recoverPasswordEmailLineLabel;
        private TextBox recoverPasswordEmailTextBox;
        private Label recoverPasswordLabel;
        private Button ConsumeCodeButton;
    }
}