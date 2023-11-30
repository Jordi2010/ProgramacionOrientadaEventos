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
            this.backRecoverPasswordButton = new System.Windows.Forms.Button();
            this.ValidateCodeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeToRecoverTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPasswordLineLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConsumeCodeButton = new System.Windows.Forms.Button();
            this.recoverPasswordButton = new System.Windows.Forms.Button();
            this.newPasswordLineLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.titlePasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backRecoverPasswordButton
            // 
            this.backRecoverPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backRecoverPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.backRecoverPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backRecoverPasswordButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backRecoverPasswordButton.ForeColor = System.Drawing.Color.Silver;
            this.backRecoverPasswordButton.Location = new System.Drawing.Point(12, 12);
            this.backRecoverPasswordButton.Name = "backRecoverPasswordButton";
            this.backRecoverPasswordButton.Size = new System.Drawing.Size(81, 30);
            this.backRecoverPasswordButton.TabIndex = 38;
            this.backRecoverPasswordButton.Text = "⬅️ Volver";
            this.backRecoverPasswordButton.UseVisualStyleBackColor = true;
            this.backRecoverPasswordButton.Click += new System.EventHandler(this.backRecoverPasswordButton_Click);
            // 
            // ValidateCodeButton
            // 
            this.ValidateCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ValidateCodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ValidateCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidateCodeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValidateCodeButton.ForeColor = System.Drawing.Color.Silver;
            this.ValidateCodeButton.Location = new System.Drawing.Point(252, 190);
            this.ValidateCodeButton.Name = "ValidateCodeButton";
            this.ValidateCodeButton.Size = new System.Drawing.Size(410, 39);
            this.ValidateCodeButton.TabIndex = 59;
            this.ValidateCodeButton.Text = "Validar Codigo";
            this.ValidateCodeButton.UseVisualStyleBackColor = false;
            this.ValidateCodeButton.Click += new System.EventHandler(this.ValidateCodeButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(253, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 2);
            this.label3.TabIndex = 58;
            // 
            // CodeToRecoverTextBox
            // 
            this.CodeToRecoverTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.CodeToRecoverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeToRecoverTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeToRecoverTextBox.ForeColor = System.Drawing.Color.Silver;
            this.CodeToRecoverTextBox.Location = new System.Drawing.Point(253, 135);
            this.CodeToRecoverTextBox.Name = "CodeToRecoverTextBox";
            this.CodeToRecoverTextBox.PlaceholderText = "Codigo";
            this.CodeToRecoverTextBox.Size = new System.Drawing.Size(410, 24);
            this.CodeToRecoverTextBox.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Introduce el codigo.";
            // 
            // confirmPasswordLineLabel
            // 
            this.confirmPasswordLineLabel.BackColor = System.Drawing.Color.Silver;
            this.confirmPasswordLineLabel.Location = new System.Drawing.Point(252, 438);
            this.confirmPasswordLineLabel.Name = "confirmPasswordLineLabel";
            this.confirmPasswordLineLabel.Size = new System.Drawing.Size(410, 2);
            this.confirmPasswordLineLabel.TabIndex = 55;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(252, 410);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PlaceholderText = "Repite la contraseña";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(410, 24);
            this.confirmPasswordTextBox.TabIndex = 54;
            // 
            // ConsumeCodeButton
            // 
            this.ConsumeCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.ConsumeCodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ConsumeCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsumeCodeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsumeCodeButton.ForeColor = System.Drawing.Color.Silver;
            this.ConsumeCodeButton.Location = new System.Drawing.Point(252, 556);
            this.ConsumeCodeButton.Name = "ConsumeCodeButton";
            this.ConsumeCodeButton.Size = new System.Drawing.Size(410, 39);
            this.ConsumeCodeButton.TabIndex = 53;
            this.ConsumeCodeButton.Text = "Cancelar";
            this.ConsumeCodeButton.UseVisualStyleBackColor = false;
            this.ConsumeCodeButton.Click += new System.EventHandler(this.ConsumeCodeButton_Click);
            // 
            // recoverPasswordButton
            // 
            this.recoverPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.recoverPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.recoverPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoverPasswordButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recoverPasswordButton.ForeColor = System.Drawing.Color.Silver;
            this.recoverPasswordButton.Location = new System.Drawing.Point(252, 487);
            this.recoverPasswordButton.Name = "recoverPasswordButton";
            this.recoverPasswordButton.Size = new System.Drawing.Size(410, 39);
            this.recoverPasswordButton.TabIndex = 52;
            this.recoverPasswordButton.Text = "Guardar nueva contraseña";
            this.recoverPasswordButton.UseVisualStyleBackColor = false;
            this.recoverPasswordButton.Click += new System.EventHandler(this.recoverPasswordButton_Click);
            // 
            // newPasswordLineLabel
            // 
            this.newPasswordLineLabel.BackColor = System.Drawing.Color.Silver;
            this.newPasswordLineLabel.Location = new System.Drawing.Point(253, 393);
            this.newPasswordLineLabel.Name = "newPasswordLineLabel";
            this.newPasswordLineLabel.Size = new System.Drawing.Size(410, 2);
            this.newPasswordLineLabel.TabIndex = 51;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.newPasswordTextBox.Location = new System.Drawing.Point(253, 365);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PlaceholderText = "Nueva contraseña";
            this.newPasswordTextBox.Size = new System.Drawing.Size(410, 24);
            this.newPasswordTextBox.TabIndex = 50;
            // 
            // titlePasswordLabel
            // 
            this.titlePasswordLabel.AutoSize = true;
            this.titlePasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.titlePasswordLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titlePasswordLabel.ForeColor = System.Drawing.Color.White;
            this.titlePasswordLabel.Location = new System.Drawing.Point(304, 288);
            this.titlePasswordLabel.Name = "titlePasswordLabel";
            this.titlePasswordLabel.Size = new System.Drawing.Size(300, 25);
            this.titlePasswordLabel.TabIndex = 49;
            this.titlePasswordLabel.Text = "Crea una nueva contraseña";
            // 
            // ChangePasswordWithCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(914, 676);
            this.Controls.Add(this.ValidateCodeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodeToRecoverTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmPasswordLineLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.ConsumeCodeButton);
            this.Controls.Add(this.recoverPasswordButton);
            this.Controls.Add(this.newPasswordLineLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.titlePasswordLabel);
            this.Controls.Add(this.backRecoverPasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordWithCodeForm";
            this.Text = "ChangePasswordWithCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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