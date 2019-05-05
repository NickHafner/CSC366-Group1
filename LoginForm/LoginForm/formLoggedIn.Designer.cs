namespace LoginForm
{
    partial class formLoggedIn
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
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.loginFormLogoutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggedInLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.loggedInLabel.Location = new System.Drawing.Point(227, 110);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(260, 122);
            this.loggedInLabel.TabIndex = 0;
            this.loggedInLabel.Text = "You are logged in!";
            this.loggedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginFormLogoutButton
            // 
            this.loginFormLogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.loginFormLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginFormLogoutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormLogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.loginFormLogoutButton.Location = new System.Drawing.Point(368, 235);
            this.loginFormLogoutButton.Name = "loginFormLogoutButton";
            this.loginFormLogoutButton.Size = new System.Drawing.Size(141, 35);
            this.loginFormLogoutButton.TabIndex = 3;
            this.loginFormLogoutButton.Text = "Exit";
            this.loginFormLogoutButton.UseVisualStyleBackColor = false;
            this.loginFormLogoutButton.Click += new System.EventHandler(this.LoginFormLogoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.loginButton.Location = new System.Drawing.Point(205, 235);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(141, 35);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Logout";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // formLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(730, 414);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginFormLogoutButton);
            this.Controls.Add(this.loggedInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "formLoggedIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged In";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Button loginFormLogoutButton;
        private System.Windows.Forms.Button loginButton;
    }
}