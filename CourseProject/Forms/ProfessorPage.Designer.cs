namespace CourseProject.Forms
{
    partial class ProfessorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorPage));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            roleLabel = new Label();
            linkLabel2 = new LinkLabel();
            panel2 = new Panel();
            label1 = new Label();
            professorName = new TextBox();
            position = new TextBox();
            contact = new TextBox();
            label2 = new Label();
            label3 = new Label();
            handlership = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(-11, -12);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 53);
            panel1.TabIndex = 8;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel1.Location = new Point(102, 22);
            linkLabel1.Margin = new Padding(6, 0, 6, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 17);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Кафедра";
            linkLabel1.LinkClicked += OpenDepartmentPage;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleLabel.ForeColor = Color.FromArgb(128, 64, 0);
            roleLabel.Location = new Point(561, 22);
            roleLabel.Margin = new Padding(4, 0, 4, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(113, 17);
            roleLabel.TabIndex = 10;
            roleLabel.Text = "Ім'я користувача";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(27, 22);
            linkLabel2.Margin = new Padding(6, 0, 6, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            linkLabel2.LinkClicked += OpenMainPage;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-11, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 76);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 0;
            label1.Text = "Національний університет України \"Університет\" © 2023-2024\r\nПідтримка: тел. +38(044)-111-11-11\r\nУсі права захищено";
            // 
            // professorName
            // 
            professorName.BackColor = Color.AntiqueWhite;
            professorName.BorderStyle = BorderStyle.None;
            professorName.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            professorName.Location = new Point(27, 66);
            professorName.Name = "professorName";
            professorName.ReadOnly = true;
            professorName.Size = new Size(329, 22);
            professorName.TabIndex = 10;
            professorName.Text = "ПІБ";
            // 
            // position
            // 
            position.BackColor = Color.AntiqueWhite;
            position.BorderStyle = BorderStyle.None;
            position.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            position.Location = new Point(27, 102);
            position.Name = "position";
            position.ReadOnly = true;
            position.Size = new Size(200, 19);
            position.TabIndex = 11;
            position.Text = "Посада";
            // 
            // contact
            // 
            contact.BackColor = Color.AntiqueWhite;
            contact.BorderStyle = BorderStyle.None;
            contact.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contact.Location = new Point(27, 176);
            contact.Name = "contact";
            contact.ReadOnly = true;
            contact.Size = new Size(200, 22);
            contact.TabIndex = 12;
            contact.Text = "Робочий номер телефону";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 141);
            label2.Name = "label2";
            label2.Size = new Size(234, 22);
            label2.TabIndex = 13;
            label2.Text = "Робочий номер телефону:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(23, 227);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 14;
            label3.Text = "Кураторство:";
            // 
            // handlership
            // 
            handlership.BackColor = Color.AntiqueWhite;
            handlership.BorderStyle = BorderStyle.None;
            handlership.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            handlership.Location = new Point(27, 262);
            handlership.Name = "handlership";
            handlership.ReadOnly = true;
            handlership.Size = new Size(111, 19);
            handlership.TabIndex = 15;
            handlership.Text = "Кураторство";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(340, 65);
            label4.Name = "label4";
            label4.Size = new Size(248, 22);
            label4.TabIndex = 16;
            label4.Text = "Відповідальність за заходи:";
            // 
            // ProfessorPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(727, 399);
            Controls.Add(label4);
            Controls.Add(handlership);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(contact);
            Controls.Add(position);
            Controls.Add(professorName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ProfessorPage";
            Text = "Викладач";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label roleLabel;
        private LinkLabel linkLabel2;
        private Panel panel2;
        private Label label1;
        private TextBox professorName;
        private LinkLabel linkLabel1;
        private TextBox position;
        private TextBox contact;
        private Label label2;
        private Label label3;
        private TextBox handlership;
        private Label label4;
    }
}