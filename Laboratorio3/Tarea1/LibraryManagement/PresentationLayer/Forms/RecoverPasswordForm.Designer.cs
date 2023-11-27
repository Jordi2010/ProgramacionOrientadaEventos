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
            this.backRecoverPasswordButton = new System.Windows.Forms.Button();
            this.recoverPasswordEmailButton = new System.Windows.Forms.Button();
            this.recoverPasswordEmailLineLabel = new System.Windows.Forms.Label();
            this.recoverPasswordEmailTextBox = new System.Windows.Forms.TextBox();
            this.recoverPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backRecoverPasswordButton
            // 
            this.backRecoverPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backRecoverPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.backRecoverPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backRecoverPasswordButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backRecoverPasswordButton.ForeColor = System.Drawing.Color.Silver;
            this.backRecoverPasswordButton.Location = new System.Drawing.Point(9, 8);
            this.backRecoverPasswordButton.Name = "backRecoverPasswordButton";
            this.backRecoverPasswordButton.Size = new System.Drawing.Size(81, 30);
            this.backRecoverPasswordButton.TabIndex = 36;
            this.backRecoverPasswordButton.Text = "⬅️ Volver";
            this.backRecoverPasswordButton.UseVisualStyleBackColor = true;
            this.backRecoverPasswordButton.Click += new System.EventHandler(this.backRecoverPasswordButton_Click);
            // 
            // recoverPasswordEmailButton
            // 
            this.recoverPasswordEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.recoverPasswordEmailButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.recoverPasswordEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoverPasswordEmailButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverPasswordEmailButton.ForeColor = System.Drawing.Color.Silver;
            this.recoverPasswordEmailButton.Location = new System.Drawing.Point(239, 417);
            this.recoverPasswordEmailButton.Name = "recoverPasswordEmailButton";
            this.recoverPasswordEmailButton.Size = new System.Drawing.Size(410, 39);
            this.recoverPasswordEmailButton.TabIndex = 27;
            this.recoverPasswordEmailButton.Text = "Enviar correo";
            this.recoverPasswordEmailButton.UseVisualStyleBackColor = false;
            this.recoverPasswordEmailButton.Click += new System.EventHandler(this.recoverPasswordEmailButton_Click);
            // 
            // recoverPasswordEmailLineLabel
            // 
            this.recoverPasswordEmailLineLabel.BackColor = System.Drawing.Color.Silver;
            this.recoverPasswordEmailLineLabel.Location = new System.Drawing.Point(240, 323);
            this.recoverPasswordEmailLineLabel.Name = "recoverPasswordEmailLineLabel";
            this.recoverPasswordEmailLineLabel.Size = new System.Drawing.Size(410, 2);
            this.recoverPasswordEmailLineLabel.TabIndex = 24;
            // 
            // recoverPasswordEmailTextBox
            // 
            this.recoverPasswordEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.recoverPasswordEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recoverPasswordEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverPasswordEmailTextBox.ForeColor = System.Drawing.Color.Silver;
            this.recoverPasswordEmailTextBox.Location = new System.Drawing.Point(240, 295);
            this.recoverPasswordEmailTextBox.Name = "recoverPasswordEmailTextBox";
            this.recoverPasswordEmailTextBox.PlaceholderText = "Correo electrónico";
            this.recoverPasswordEmailTextBox.Size = new System.Drawing.Size(410, 24);
            this.recoverPasswordEmailTextBox.TabIndex = 23;
            // 
            // recoverPasswordLabel
            // 
            this.recoverPasswordLabel.AutoSize = true;
            this.recoverPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.recoverPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recoverPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.recoverPasswordLabel.Location = new System.Drawing.Point(318, 186);
            this.recoverPasswordLabel.Name = "recoverPasswordLabel";
            this.recoverPasswordLabel.Size = new System.Drawing.Size(239, 25);
            this.recoverPasswordLabel.TabIndex = 22;
            this.recoverPasswordLabel.Text = "Recuperar contraseña";
            // 
            // RecoverPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(914, 676);
            this.Controls.Add(this.backRecoverPasswordButton);
            this.Controls.Add(this.recoverPasswordEmailButton);
            this.Controls.Add(this.recoverPasswordEmailLineLabel);
            this.Controls.Add(this.recoverPasswordEmailTextBox);
            this.Controls.Add(this.recoverPasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backRecoverPasswordButton;
        private Button recoverPasswordEmailButton;
        private Label recoverPasswordEmailLineLabel;
        private TextBox recoverPasswordEmailTextBox;
        private Label recoverPasswordLabel;
    }
}