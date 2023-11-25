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
            backRecoverPasswordButton = new Button();
            recoverPasswordEmailButton = new Button();
            recoverPasswordEmailLineLabel = new Label();
            recoverPasswordEmailTextBox = new TextBox();
            recoverPasswordLabel = new Label();
            SuspendLayout();
            // 
            // backRecoverPasswordButton
            // 
            backRecoverPasswordButton.BackgroundImageLayout = ImageLayout.None;
            backRecoverPasswordButton.FlatAppearance.BorderColor = Color.FromArgb(25, 42, 86);
            backRecoverPasswordButton.FlatStyle = FlatStyle.Flat;
            backRecoverPasswordButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            backRecoverPasswordButton.ForeColor = Color.Silver;
            backRecoverPasswordButton.Location = new Point(9, 8);
            backRecoverPasswordButton.Name = "backRecoverPasswordButton";
            backRecoverPasswordButton.Size = new Size(81, 30);
            backRecoverPasswordButton.TabIndex = 36;
            backRecoverPasswordButton.Text = "⬅️ Volver";
            backRecoverPasswordButton.UseVisualStyleBackColor = true;
            // 
            // recoverPasswordEmailButton
            // 
            recoverPasswordEmailButton.BackColor = Color.FromArgb(10, 61, 98);
            recoverPasswordEmailButton.FlatAppearance.BorderColor = Color.Teal;
            recoverPasswordEmailButton.FlatStyle = FlatStyle.Flat;
            recoverPasswordEmailButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            recoverPasswordEmailButton.ForeColor = Color.Silver;
            recoverPasswordEmailButton.Location = new Point(239, 417);
            recoverPasswordEmailButton.Name = "recoverPasswordEmailButton";
            recoverPasswordEmailButton.Size = new Size(410, 39);
            recoverPasswordEmailButton.TabIndex = 27;
            recoverPasswordEmailButton.Text = "Enviar correo";
            recoverPasswordEmailButton.UseVisualStyleBackColor = false;
            // 
            // recoverPasswordEmailLineLabel
            // 
            recoverPasswordEmailLineLabel.BackColor = Color.Silver;
            recoverPasswordEmailLineLabel.Location = new Point(240, 323);
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
            recoverPasswordEmailTextBox.Location = new Point(240, 295);
            recoverPasswordEmailTextBox.Name = "recoverPasswordEmailTextBox";
            recoverPasswordEmailTextBox.Size = new Size(410, 24);
            recoverPasswordEmailTextBox.TabIndex = 23;
            recoverPasswordEmailTextBox.Text = "Correo electrónico";
            // 
            // recoverPasswordLabel
            // 
            recoverPasswordLabel.AutoSize = true;
            recoverPasswordLabel.BackColor = Color.Transparent;
            recoverPasswordLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            recoverPasswordLabel.ForeColor = Color.White;
            recoverPasswordLabel.Location = new Point(318, 186);
            recoverPasswordLabel.Name = "recoverPasswordLabel";
            recoverPasswordLabel.Size = new Size(239, 25);
            recoverPasswordLabel.TabIndex = 22;
            recoverPasswordLabel.Text = "Recuperar contraseña";
            // 
            // RecoverPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(914, 676);
            Controls.Add(backRecoverPasswordButton);
            Controls.Add(recoverPasswordEmailButton);
            Controls.Add(recoverPasswordEmailLineLabel);
            Controls.Add(recoverPasswordEmailTextBox);
            Controls.Add(recoverPasswordLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecoverPasswordForm";
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
    }
}