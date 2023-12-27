namespace CourseProject
{
    partial class AdminAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAuthorization));
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            adminLog = new TextBox();
            adminPassword = new TextBox();
            revisorAuthLinkLabel = new LinkLabel();
            adminLogInButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(-8, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 44);
            panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(18, 11);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            linkLabel2.LinkClicked += LinkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 69);
            label1.Name = "label1";
            label1.Size = new Size(174, 42);
            label1.TabIndex = 1;
            label1.Text = "Вхід у систему\r\nРоль: Адміністратор";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 140);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 2;
            label2.Text = "Логін:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 181);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // adminLog
            // 
            adminLog.BackColor = Color.OldLace;
            adminLog.Location = new Point(217, 137);
            adminLog.Name = "adminLog";
            adminLog.Size = new Size(160, 29);
            adminLog.TabIndex = 4;
            adminLog.TextChanged += AdminLog_TextChanged;
            // 
            // adminPassword
            // 
            adminPassword.BackColor = Color.OldLace;
            adminPassword.Location = new Point(217, 181);
            adminPassword.Name = "adminPassword";
            adminPassword.PasswordChar = '*';
            adminPassword.Size = new Size(160, 29);
            adminPassword.TabIndex = 5;
            // 
            // revisorAuthLinkLabel
            // 
            revisorAuthLinkLabel.AutoSize = true;
            revisorAuthLinkLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            revisorAuthLinkLabel.LinkColor = Color.FromArgb(128, 64, 0);
            revisorAuthLinkLabel.Location = new Point(124, 274);
            revisorAuthLinkLabel.Name = "revisorAuthLinkLabel";
            revisorAuthLinkLabel.Size = new Size(317, 19);
            revisorAuthLinkLabel.TabIndex = 6;
            revisorAuthLinkLabel.TabStop = true;
            revisorAuthLinkLabel.Text = "Увійти як відповідальний за виконання плану";
            revisorAuthLinkLabel.LinkClicked += RevisorAuthLinkLabel_LinkClicked;
            // 
            // adminLogInButton
            // 
            adminLogInButton.BackColor = Color.SandyBrown;
            adminLogInButton.BackgroundImageLayout = ImageLayout.None;
            adminLogInButton.FlatAppearance.BorderColor = Color.SandyBrown;
            adminLogInButton.FlatStyle = FlatStyle.Popup;
            adminLogInButton.ForeColor = SystemColors.ActiveCaptionText;
            adminLogInButton.Location = new Point(246, 229);
            adminLogInButton.Name = "adminLogInButton";
            adminLogInButton.Size = new Size(83, 32);
            adminLogInButton.TabIndex = 7;
            adminLogInButton.Text = "Увійти";
            adminLogInButton.UseVisualStyleBackColor = false;
            adminLogInButton.Click += AdminLogInButton_Click;
            // 
            // AdminAuthorization
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(566, 344);
            Controls.Add(adminLogInButton);
            Controls.Add(revisorAuthLinkLabel);
            Controls.Add(adminPassword);
            Controls.Add(adminLog);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AdminAuthorization";
            Text = "Авторизація";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adminLog;
        private TextBox adminPassword;
        private LinkLabel revisorAuthLinkLabel;
        private Button adminLogInButton;
    }
}