namespace Shop__invertory_
{
    partial class Register
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginLinkLbl = new System.Windows.Forms.LinkLabel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordMatchLbl = new System.Windows.Forms.Label();
            this.confPassInput = new System.Windows.Forms.TextBox();
            this.repeatPasswordLbl = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(101, 334);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(268, 41);
            this.registerBtn.TabIndex = 19;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginLinkLbl
            // 
            this.loginLinkLbl.AutoSize = true;
            this.loginLinkLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLinkLbl.Location = new System.Drawing.Point(10, 409);
            this.loginLinkLbl.Name = "loginLinkLbl";
            this.loginLinkLbl.Size = new System.Drawing.Size(156, 17);
            this.loginLinkLbl.TabIndex = 20;
            this.loginLinkLbl.TabStop = true;
            this.loginLinkLbl.Text = "I already have an account";
            this.loginLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLbl_LinkClicked);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(99, 173);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(265, 33);
            this.passwordInput.TabIndex = 12;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(93, 145);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(91, 25);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(99, 106);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(266, 33);
            this.usernameInput.TabIndex = 10;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(94, 78);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(97, 25);
            this.usernameLbl.TabIndex = 9;
            this.usernameLbl.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Invertory Menagment";
            // 
            // passwordMatchLbl
            // 
            this.passwordMatchLbl.AutoSize = true;
            this.passwordMatchLbl.Location = new System.Drawing.Point(99, 284);
            this.passwordMatchLbl.Name = "passwordMatchLbl";
            this.passwordMatchLbl.Size = new System.Drawing.Size(0, 13);
            this.passwordMatchLbl.TabIndex = 18;
            // 
            // confPassInput
            // 
            this.confPassInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confPassInput.Location = new System.Drawing.Point(98, 241);
            this.confPassInput.Name = "confPassInput";
            this.confPassInput.Size = new System.Drawing.Size(266, 33);
            this.confPassInput.TabIndex = 17;
            this.confPassInput.UseSystemPasswordChar = true;
            this.confPassInput.TextChanged += new System.EventHandler(this.confPassInput_TextChanged);
            // 
            // repeatPasswordLbl
            // 
            this.repeatPasswordLbl.AutoSize = true;
            this.repeatPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordLbl.Location = new System.Drawing.Point(96, 213);
            this.repeatPasswordLbl.Name = "repeatPasswordLbl";
            this.repeatPasswordLbl.Size = new System.Drawing.Size(164, 25);
            this.repeatPasswordLbl.TabIndex = 16;
            this.repeatPasswordLbl.Text = "Confirm Password";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(249, 280);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(118, 21);
            this.showPasswordCheckBox.TabIndex = 18;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 435);
            this.Controls.Add(this.passwordMatchLbl);
            this.Controls.Add(this.confPassInput);
            this.Controls.Add(this.repeatPasswordLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.loginLinkLbl);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.LinkLabel loginLinkLbl;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordMatchLbl;
        private System.Windows.Forms.TextBox confPassInput;
        private System.Windows.Forms.Label repeatPasswordLbl;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}