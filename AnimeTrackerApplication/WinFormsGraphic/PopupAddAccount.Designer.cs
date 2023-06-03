namespace WinFormsGraphic
{
    partial class PopupAddAccount
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
            this.groupBoxAccountDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelAccountAddition = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxAccountDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAccountDetails
            // 
            this.groupBoxAccountDetails.Controls.Add(this.btnCancelAccountAddition);
            this.groupBoxAccountDetails.Controls.Add(this.tbxEmail);
            this.groupBoxAccountDetails.Controls.Add(this.btnAddAccount);
            this.groupBoxAccountDetails.Controls.Add(this.cbxRole);
            this.groupBoxAccountDetails.Controls.Add(this.labelRole);
            this.groupBoxAccountDetails.Controls.Add(this.tbxName);
            this.groupBoxAccountDetails.Controls.Add(this.labelEmail);
            this.groupBoxAccountDetails.Controls.Add(this.labelName);
            this.groupBoxAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxAccountDetails.Location = new System.Drawing.Point(14, 14);
            this.groupBoxAccountDetails.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxAccountDetails.Name = "groupBoxAccountDetails";
            this.groupBoxAccountDetails.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxAccountDetails.Size = new System.Drawing.Size(537, 308);
            this.groupBoxAccountDetails.TabIndex = 5;
            this.groupBoxAccountDetails.TabStop = false;
            this.groupBoxAccountDetails.Text = "Account details";
            // 
            // btnCancelAccountAddition
            // 
            this.btnCancelAccountAddition.BackColor = System.Drawing.Color.Plum;
            this.btnCancelAccountAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAccountAddition.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAccountAddition.Location = new System.Drawing.Point(283, 212);
            this.btnCancelAccountAddition.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelAccountAddition.Name = "btnCancelAccountAddition";
            this.btnCancelAccountAddition.Size = new System.Drawing.Size(221, 72);
            this.btnCancelAccountAddition.TabIndex = 44;
            this.btnCancelAccountAddition.Text = "Cancel";
            this.btnCancelAccountAddition.UseVisualStyleBackColor = false;
            this.btnCancelAccountAddition.Click += new System.EventHandler(this.btnCancelAccountAddition_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(111, 85);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(393, 36);
            this.tbxEmail.TabIndex = 41;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Plum;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Location = new System.Drawing.Point(17, 212);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(221, 72);
            this.btnAddAccount.TabIndex = 36;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.ItemHeight = 30;
            this.cbxRole.Location = new System.Drawing.Point(111, 131);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(5);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(206, 38);
            this.cbxRole.TabIndex = 13;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(17, 142);
            this.labelRole.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(60, 30);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "Role:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(111, 39);
            this.tbxName.Margin = new System.Windows.Forms.Padding(5);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(393, 36);
            this.tbxName.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(17, 91);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(69, 30);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 47);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 30);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // PopupAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(567, 335);
            this.Controls.Add(this.groupBoxAccountDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PopupAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupAddAccount";
            this.groupBoxAccountDetails.ResumeLayout(false);
            this.groupBoxAccountDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxAccountDetails;
        private Button btnCancelAccountAddition;
        private TextBox tbxEmail;
        private Button btnAddAccount;
        private ComboBox cbxRole;
        private Label labelRole;
        private TextBox tbxName;
        private Label labelEmail;
        private Label labelName;
    }
}