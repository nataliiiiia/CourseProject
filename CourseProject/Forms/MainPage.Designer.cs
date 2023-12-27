namespace CourseProject
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            label3 = new Label();
            label4 = new Label();
            authLink = new LinkLabel();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            logOutLinkLabel = new LinkLabel();
            roleLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            reviewButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(214, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(530, 22);
            label3.TabIndex = 2;
            label3.Text = "Вітаємо на головній сторінці системи \"ПедНавантаження\"!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(92, 114);
            label4.Name = "label4";
            label4.Size = new Size(728, 42);
            label4.TabIndex = 3;
            label4.Text = "Із допомогою даної системи можна ознайомитися із розкладом роботи кафедр, \r\nїї викладачами, усіма запланованими заходами, а також відстежувати їхнє виконання.\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // authLink
            // 
            authLink.ActiveLinkColor = Color.RosyBrown;
            authLink.AutoSize = true;
            authLink.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authLink.LinkColor = Color.FromArgb(128, 64, 0);
            authLink.Location = new Point(790, 17);
            authLink.Name = "authLink";
            authLink.Size = new Size(84, 17);
            authLink.TabIndex = 4;
            authLink.TabStop = true;
            authLink.Text = "Авторизація";
            authLink.VisitedLinkColor = Color.OrangeRed;
            authLink.LinkClicked += AuthLink_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(14, 17);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(logOutLinkLabel);
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(authLink);
            panel1.Location = new Point(-2, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 48);
            panel1.TabIndex = 6;
            // 
            // logOutLinkLabel
            // 
            logOutLinkLabel.AutoSize = true;
            logOutLinkLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logOutLinkLabel.LinkColor = Color.FromArgb(128, 64, 0);
            logOutLinkLabel.Location = new Point(833, 17);
            logOutLinkLabel.Name = "logOutLinkLabel";
            logOutLinkLabel.Size = new Size(46, 17);
            logOutLinkLabel.TabIndex = 7;
            logOutLinkLabel.TabStop = true;
            logOutLinkLabel.Text = "Вийти";
            logOutLinkLabel.LinkClicked += LogOutLinkLabel_LinkClicked;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleLabel.ForeColor = Color.FromArgb(128, 64, 0);
            roleLabel.Location = new Point(683, 17);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(0, 17);
            roleLabel.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 76);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 0;
            label1.Text = "Національний університет України \"Університет\" © 2023-2024\r\nПідтримка: тел. +38(044)-111-11-11\r\nУсі права захищено";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(92, 185);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 8;
            label2.Text = "Оберіть кафедру:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(712, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(486, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // reviewButton
            // 
            reviewButton.BackColor = Color.SandyBrown;
            reviewButton.FlatStyle = FlatStyle.Flat;
            reviewButton.Location = new Point(41, 362);
            reviewButton.Name = "reviewButton";
            reviewButton.Size = new Size(396, 33);
            reviewButton.TabIndex = 12;
            reviewButton.Text = "Написати відгук про роботу кафедри\r\n";
            reviewButton.UseVisualStyleBackColor = false;
            reviewButton.Click += ReviewButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(884, 461);
            Controls.Add(reviewButton);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainPage";
            Text = "Головна";
            TransparencyKey = Color.White;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private LinkLabel authLink;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label roleLabel;
        private LinkLabel logOutLinkLabel;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button reviewButton;
    }
}
