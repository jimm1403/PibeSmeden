namespace UserInterface
{
    partial class FormLogin
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.passWordTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(112, 99);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(100, 47);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTxtBox.TabIndex = 1;
            this.userNameTxtBox.TextChanged += new System.EventHandler(this.userNameTxtBox_TextChanged);
            // 
            // passWordTxtBox
            // 
            this.passWordTxtBox.Location = new System.Drawing.Point(100, 73);
            this.passWordTxtBox.Name = "passWordTxtBox";
            this.passWordTxtBox.PasswordChar = '*';
            this.passWordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passWordTxtBox.TabIndex = 2;
            this.passWordTxtBox.TextChanged += new System.EventHandler(this.passWordTxtBox_TextChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 193);
            this.Controls.Add(this.passWordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.LoginBtn);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passWordTxtBox;
    }
}