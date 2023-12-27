namespace CourseProject.Forms
{
    partial class RevisorAuthorizationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisorAuthorizationPage));
            panel1 = new Panel();
            mainPageLink = new LinkLabel();
            revisorLogInButton = new Button();
            adminAuthLinkLabel = new LinkLabel();
            revisorPassword = new TextBox();
            revisorLog = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(mainPageLink);
            panel1.Location = new Point(-6, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 41);
            panel1.TabIndex = 1;
            // 
            // mainPageLink
            // 
            mainPageLink.AutoSize = true;
            mainPageLink.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainPageLink.LinkColor = Color.FromArgb(128, 64, 0);
            mainPageLink.Location = new Point(17, 7);
            mainPageLink.Margin = new Padding(4, 0, 4, 0);
            mainPageLink.Name = "mainPageLink";
            mainPageLink.Size = new Size(58, 17);
            mainPageLink.TabIndex = 6;
            mainPageLink.TabStop = true;
            mainPageLink.Text = "Головна";
            mainPageLink.LinkClicked += MainPageLink_LinkClicked;
            // 
            // revisorLogInButton
            // 
            revisorLogInButton.BackColor = Color.SandyBrown;
            revisorLogInButton.BackgroundImageLayout = ImageLayout.None;
            revisorLogInButton.FlatAppearance.BorderColor = Color.SandyBrown;
            revisorLogInButton.FlatStyle = FlatStyle.Popup;
            revisorLogInButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            revisorLogInButton.ForeColor = SystemColors.ActiveCaptionText;
            revisorLogInButton.Location = new Point(246, 229);
            revisorLogInButton.Margin = new Padding(4);
            revisorLogInButton.Name = "revisorLogInButton";
            revisorLogInButton.Size = new Size(83, 32);
            revisorLogInButton.TabIndex = 14;
            revisorLogInButton.Text = "Увійти";
            revisorLogInButton.UseVisualStyleBackColor = false;
            revisorLogInButton.Click += AdminLogInButton_Click;
            // 
            // adminAuthLinkLabel
            // 
            adminAuthLinkLabel.AutoSize = true;
            adminAuthLinkLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adminAuthLinkLabel.LinkColor = Color.FromArgb(128, 64, 0);
            adminAuthLinkLabel.Location = new Point(198, 276);
            adminAuthLinkLabel.Margin = new Padding(4, 0, 4, 0);
            adminAuthLinkLabel.Name = "adminAuthLinkLabel";
            adminAuthLinkLabel.Size = new Size(168, 19);
            adminAuthLinkLabel.TabIndex = 13;
            adminAuthLinkLabel.TabStop = true;
            adminAuthLinkLabel.Text = "Увійти як адміністратор";
            adminAuthLinkLabel.LinkClicked += AdminAuthLinkLabel_LinkClicked;
            // 
            // revisorPassword
            // 
            revisorPassword.BackColor = Color.OldLace;
            revisorPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            revisorPassword.Location = new Point(217, 181);
            revisorPassword.Margin = new Padding(4);
            revisorPassword.Name = "revisorPassword";
            revisorPassword.PasswordChar = '*';
            revisorPassword.Size = new Size(160, 29);
            revisorPassword.TabIndex = 12;
            // 
            // revisorLog
            // 
            revisorLog.BackColor = Color.OldLace;
            revisorLog.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            revisorLog.Location = new Point(217, 137);
            revisorLog.Margin = new Padding(4);
            revisorLog.Name = "revisorLog";
            revisorLog.Size = new Size(160, 29);
            revisorLog.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(140, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 10;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(153, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 9;
            label2.Text = "Логін:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(118, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 42);
            label1.TabIndex = 8;
            label1.Text = "Вхід у систему\r\nРоль: Відповідальний за виконання планів";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RevisorAuthorization
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(566, 344);
            Controls.Add(revisorLogInButton);
            Controls.Add(adminAuthLinkLabel);
            Controls.Add(revisorPassword);
            Controls.Add(revisorLog);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "RevisorAuthorization";
            Text = "Авторизація";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel mainPageLink;
        private Button revisorLogInButton;
        private LinkLabel adminAuthLinkLabel;
        private TextBox revisorPassword;
        private TextBox revisorLog;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}