namespace WinFormsGraphic
{
    partial class LoginResetPass
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
            this.labelErorrMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.loginLabelBox = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErorrMessage
            // 
            this.labelErorrMessage.AutoSize = true;
            this.labelErorrMessage.BackColor = System.Drawing.Color.Thistle;
            this.labelErorrMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErorrMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErorrMessage.Location = new System.Drawing.Point(783, 462);
            this.labelErorrMessage.Name = "labelErorrMessage";
            this.labelErorrMessage.Size = new System.Drawing.Size(353, 29);
            this.labelErorrMessage.TabIndex = 23;
            this.labelErorrMessage.Text = "The password doesn\'t match!";
            this.labelErorrMessage.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(872, 391);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 53);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(898, 266);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(314, 39);
            this.tbPassword.TabIndex = 21;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(898, 218);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(314, 39);
            this.tbEmail.TabIndex = 20;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Thistle;
            this.labelPassword.Location = new System.Drawing.Point(681, 269);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(173, 32);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "New password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Thistle;
            this.labelEmail.Location = new System.Drawing.Point(681, 221);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(76, 32);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Email:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Thistle;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(888, 160);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(116, 39);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Log in";
            // 
            // loginLabelBox
            // 
            this.loginLabelBox.AutoEllipsis = true;
            this.loginLabelBox.BackColor = System.Drawing.Color.Thistle;
            this.loginLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginLabelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLabelBox.Location = new System.Drawing.Point(649, 131);
            this.loginLabelBox.Name = "loginLabelBox";
            this.loginLabelBox.Size = new System.Drawing.Size(603, 377);
            this.loginLabelBox.TabIndex = 16;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(898, 311);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '●';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(314, 39);
            this.tbxConfirmPassword.TabIndex = 24;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.Thistle;
            this.labelConfirmPassword.Location = new System.Drawing.Point(681, 314);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(211, 32);
            this.labelConfirmPassword.TabIndex = 25;
            this.labelConfirmPassword.Text = "Confirm password:";
            // 
            // LoginResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WinFormsGraphic.Properties.Resources.loginbg;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.labelErorrMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.loginLabelBox);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "LoginResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginResetPass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelErorrMessage;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelTitle;
        private Label loginLabelBox;
        private TextBox tbxConfirmPassword;
        private Label labelConfirmPassword;
    }
}