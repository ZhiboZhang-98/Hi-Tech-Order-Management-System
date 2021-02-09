namespace Hi_Tech_Order_Management_System.GUI
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.userNameRequiredLabel = new System.Windows.Forms.Label();
            this.passwordRequiredLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(1089, 695);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(184, 55);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(538, 445);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(184, 55);
            this.buttonLogin.TabIndex = 16;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 112);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(417, 305);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(115, 21);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(556, 303);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 26);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(417, 201);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 21);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username :";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(556, 199);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(154, 26);
            this.textBoxUsername.TabIndex = 12;
            // 
            // userNameRequiredLabel
            // 
            this.userNameRequiredLabel.AutoSize = true;
            this.userNameRequiredLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userNameRequiredLabel.Location = new System.Drawing.Point(753, 201);
            this.userNameRequiredLabel.Name = "userNameRequiredLabel";
            this.userNameRequiredLabel.Size = new System.Drawing.Size(168, 20);
            this.userNameRequiredLabel.TabIndex = 18;
            this.userNameRequiredLabel.Text = "* User Name Required";
            // 
            // passwordRequiredLabel
            // 
            this.passwordRequiredLabel.AutoSize = true;
            this.passwordRequiredLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordRequiredLabel.Location = new System.Drawing.Point(753, 305);
            this.passwordRequiredLabel.Name = "passwordRequiredLabel";
            this.passwordRequiredLabel.Size = new System.Drawing.Size(157, 20);
            this.passwordRequiredLabel.TabIndex = 19;
            this.passwordRequiredLabel.Text = "* Password Required";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.ControlBox = false;
            this.Controls.Add(this.passwordRequiredLabel);
            this.Controls.Add(this.userNameRequiredLabel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label userNameRequiredLabel;
        private System.Windows.Forms.Label passwordRequiredLabel;
    }
}