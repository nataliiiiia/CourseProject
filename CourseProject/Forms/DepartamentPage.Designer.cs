namespace CourseProject.Forms
{
    partial class DepartamentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartamentPage));
            panel1 = new Panel();
            roleLabel = new Label();
            linkLabel2 = new LinkLabel();
            depName = new Label();
            descriptionText = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            listOfProfessors = new ComboBox();
            goToProfessorPage = new Button();
            linkLabel1 = new LinkLabel();
            chiefName = new TextBox();
            contact = new TextBox();
            editButton = new Button();
            reviews = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(-39, -10);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 51);
            panel1.TabIndex = 7;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleLabel.ForeColor = Color.FromArgb(128, 64, 0);
            roleLabel.Location = new Point(662, 19);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(113, 17);
            roleLabel.TabIndex = 10;
            roleLabel.Text = "Ім'я користувача";
            roleLabel.Click += roleLabel_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(52, 19);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            linkLabel2.LinkClicked += GoToMainPage;
            // 
            // depName
            // 
            depName.AutoSize = true;
            depName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            depName.Location = new Point(16, 58);
            depName.Margin = new Padding(4, 0, 4, 0);
            depName.Name = "depName";
            depName.Size = new Size(141, 22);
            depName.TabIndex = 8;
            depName.Text = "Назва кафедри";
            // 
            // descriptionText
            // 
            descriptionText.BackColor = Color.AntiqueWhite;
            descriptionText.BorderStyle = BorderStyle.FixedSingle;
            descriptionText.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionText.Location = new Point(16, 103);
            descriptionText.Name = "descriptionText";
            descriptionText.ReadOnly = true;
            descriptionText.Size = new Size(387, 228);
            descriptionText.TabIndex = 9;
            descriptionText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(542, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 10;
            label1.Text = "Завідувач кафедри";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(542, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 22);
            label2.TabIndex = 12;
            label2.Text = "Контактний номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(19, 6);
            label3.Name = "label3";
            label3.Size = new Size(349, 45);
            label3.TabIndex = 0;
            label3.Text = "Національний університет України \"Університет\" © 2023-2024\r\nПідтримка: тел. +38(044)-111-11-11\r\nУсі права захищено";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-4, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 65);
            panel2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(571, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 15;
            label4.Text = "Викладачі";
            // 
            // listOfProfessors
            // 
            listOfProfessors.BackColor = Color.White;
            listOfProfessors.DropDownStyle = ComboBoxStyle.DropDownList;
            listOfProfessors.FlatStyle = FlatStyle.Popup;
            listOfProfessors.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listOfProfessors.ForeColor = Color.Black;
            listOfProfessors.FormattingEnabled = true;
            listOfProfessors.Location = new Point(499, 245);
            listOfProfessors.Name = "listOfProfessors";
            listOfProfessors.Size = new Size(251, 27);
            listOfProfessors.TabIndex = 16;
            // 
            // goToProfessorPage
            // 
            goToProfessorPage.BackColor = Color.SandyBrown;
            goToProfessorPage.FlatStyle = FlatStyle.Flat;
            goToProfessorPage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            goToProfessorPage.ForeColor = SystemColors.ControlText;
            goToProfessorPage.Location = new Point(582, 298);
            goToProfessorPage.Name = "goToProfessorPage";
            goToProfessorPage.Size = new Size(90, 33);
            goToProfessorPage.TabIndex = 17;
            goToProfessorPage.Text = "Перейти";
            goToProfessorPage.UseVisualStyleBackColor = false;
            goToProfessorPage.Click += GoToProfessorPage;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.Sienna;
            linkLabel1.Location = new Point(16, 343);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(326, 21);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "План роботи кафедри на 2023-2024 н.р.";
            linkLabel1.LinkClicked += GoToWorkingPlan;
            // 
            // chiefName
            // 
            chiefName.BackColor = Color.AntiqueWhite;
            chiefName.BorderStyle = BorderStyle.None;
            chiefName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chiefName.Location = new Point(499, 92);
            chiefName.Name = "chiefName";
            chiefName.ReadOnly = true;
            chiefName.Size = new Size(251, 22);
            chiefName.TabIndex = 19;
            chiefName.Text = "Завідувач";
            chiefName.TextAlign = HorizontalAlignment.Center;
            // 
            // contact
            // 
            contact.BackColor = Color.AntiqueWhite;
            contact.BorderStyle = BorderStyle.None;
            contact.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contact.Location = new Point(499, 168);
            contact.Name = "contact";
            contact.ReadOnly = true;
            contact.Size = new Size(251, 22);
            contact.TabIndex = 20;
            contact.Text = "Телефон";
            contact.TextAlign = HorizontalAlignment.Center;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Linen;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.Location = new Point(559, 356);
            editButton.Name = "editButton";
            editButton.Size = new Size(133, 37);
            editButton.TabIndex = 21;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // reviews
            // 
            reviews.AutoSize = true;
            reviews.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            reviews.LinkColor = Color.Sienna;
            reviews.Location = new Point(16, 374);
            reviews.Name = "reviews";
            reviews.Size = new Size(241, 21);
            reviews.TabIndex = 22;
            reviews.TabStop = true;
            reviews.Text = "Відгуки про роботу кафедри";
            reviews.LinkClicked += GetReviews;
            // 
            // DepartamentPage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(793, 467);
            Controls.Add(reviews);
            Controls.Add(editButton);
            Controls.Add(contact);
            Controls.Add(chiefName);
            Controls.Add(linkLabel1);
            Controls.Add(goToProfessorPage);
            Controls.Add(listOfProfessors);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(descriptionText);
            Controls.Add(depName);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DepartamentPage";
            Text = "Кафедра";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel2;
        private Label depName;
        private Label roleLabel;
        private RichTextBox descriptionText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private ComboBox listOfProfessors;
        private Button goToProfessorPage;
        private LinkLabel linkLabel1;
        private TextBox chiefName;
        private TextBox contact;
        private Button editButton;
        private LinkLabel reviews;
    }
}