namespace CClasses
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.signInErrorLabel = new System.Windows.Forms.Label();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.newUsernameTxt = new System.Windows.Forms.TextBox();
            this.newPasswordLbl = new System.Windows.Forms.Label();
            this.newUsernameLbl = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.newUserErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(11, 19);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(267, 16);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Please Enter Your Username and Password";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(9, 78);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 120);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(145, 78);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(100, 20);
            this.userNameTxt.TabIndex = 3;
            this.userNameTxt.TextChanged += new System.EventHandler(this.userNameTxt_TextChanged);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(145, 113);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(170, 156);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign Me In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // signInErrorLabel
            // 
            this.signInErrorLabel.AutoSize = true;
            this.signInErrorLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.signInErrorLabel.Location = new System.Drawing.Point(114, 38);
            this.signInErrorLabel.Name = "signInErrorLabel";
            this.signInErrorLabel.Size = new System.Drawing.Size(141, 30);
            this.signInErrorLabel.TabIndex = 6;
            this.signInErrorLabel.Text = "Incorrect Credentials\r\nPlease Try Again";
            this.signInErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.Location = new System.Drawing.Point(353, 21);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(239, 16);
            this.signUpLbl.TabIndex = 7;
            this.signUpLbl.Text = "Don\'t have an account? Sign up now!";
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(473, 105);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.newPasswordTxt.TabIndex = 11;
            this.newPasswordTxt.UseSystemPasswordChar = true;
            // 
            // newUsernameTxt
            // 
            this.newUsernameTxt.Location = new System.Drawing.Point(473, 70);
            this.newUsernameTxt.Name = "newUsernameTxt";
            this.newUsernameTxt.Size = new System.Drawing.Size(100, 20);
            this.newUsernameTxt.TabIndex = 10;
            this.newUsernameTxt.TextChanged += new System.EventHandler(this.newUsernameTxt_TextChanged);
            // 
            // newPasswordLbl
            // 
            this.newPasswordLbl.AutoSize = true;
            this.newPasswordLbl.Location = new System.Drawing.Point(337, 112);
            this.newPasswordLbl.Name = "newPasswordLbl";
            this.newPasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.newPasswordLbl.TabIndex = 9;
            this.newPasswordLbl.Text = "Password";
            // 
            // newUsernameLbl
            // 
            this.newUsernameLbl.AutoSize = true;
            this.newUsernameLbl.Location = new System.Drawing.Point(337, 70);
            this.newUsernameLbl.Name = "newUsernameLbl";
            this.newUsernameLbl.Size = new System.Drawing.Size(55, 13);
            this.newUsernameLbl.TabIndex = 8;
            this.newUsernameLbl.Text = "Username";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Location = new System.Drawing.Point(473, 142);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordTxt.TabIndex = 13;
            this.confirmPasswordTxt.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Location = new System.Drawing.Point(337, 149);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLbl.TabIndex = 12;
            this.confirmPasswordLbl.Text = "Confirm Password";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(498, 181);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn.TabIndex = 14;
            this.signUpBtn.Text = "Sign Me Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // newUserErrorLbl
            // 
            this.newUserErrorLbl.AutoSize = true;
            this.newUserErrorLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.newUserErrorLbl.Location = new System.Drawing.Point(18, 199);
            this.newUserErrorLbl.Name = "newUserErrorLbl";
            this.newUserErrorLbl.Size = new System.Drawing.Size(0, 15);
            this.newUserErrorLbl.TabIndex = 15;
            this.newUserErrorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(609, 264);
            this.Controls.Add(this.newUserErrorLbl);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.confirmPasswordLbl);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.newUsernameTxt);
            this.Controls.Add(this.newPasswordLbl);
            this.Controls.Add(this.newUsernameLbl);
            this.Controls.Add(this.signUpLbl);
            this.Controls.Add(this.signInErrorLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.loginLabel);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Supplies Store Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label signInErrorLabel;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.TextBox newUsernameTxt;
        private System.Windows.Forms.Label newPasswordLbl;
        private System.Windows.Forms.Label newUsernameLbl;
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Label newUserErrorLbl;
    }
}