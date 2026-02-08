namespace LearningManagement
{
    partial class LoginScreen
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
            lblUser = new Label();
            lblPass = new Label();
            txtUserId = new TextBox();
            txtUserPass = new TextBox();
            btnLogin = new Button();
            lblLOGIN = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(234, 73);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "User:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(234, 169);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(73, 20);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(404, 70);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(125, 27);
            txtUserId.TabIndex = 2;
            // 
            // txtUserPass
            // 
            txtUserPass.Location = new Point(404, 169);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.Size = new Size(125, 27);
            txtUserPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(335, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLOGIN
            // 
            lblLOGIN.AutoSize = true;
            lblLOGIN.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLOGIN.Location = new Point(271, 9);
            lblLOGIN.Name = "lblLOGIN";
            lblLOGIN.Size = new Size(239, 46);
            lblLOGIN.TabIndex = 5;
            lblLOGIN.Text = "Teacher Log in";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLOGIN);
            Controls.Add(btnLogin);
            Controls.Add(txtUserPass);
            Controls.Add(txtUserId);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Name = "LoginScreen";
            Text = "hello!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUserId;
        private TextBox txtUserPass;
        private Button btnLogin;
        private Label lblLOGIN;
    }
}