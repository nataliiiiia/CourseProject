
namespace CourseProject.Forms
{
    partial class EventPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPage));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            roleLabel = new Label();
            linkLabel2 = new LinkLabel();
            eventName = new TextBox();
            descriptionBox = new RichTextBox();
            statusBox = new TextBox();
            resultBox = new TextBox();
            dueBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            sectionBox = new TextBox();
            editButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            statusCombo = new ComboBox();
            sectionCombo = new ComboBox();
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
            panel1.Location = new Point(-11, -11);
            panel1.Margin = new Padding(7);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 52);
            panel1.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel1.Location = new Point(91, 20);
            linkLabel1.Margin = new Padding(7, 0, 7, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 17);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Кафедра";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleLabel.ForeColor = Color.FromArgb(128, 64, 0);
            roleLabel.Location = new Point(541, 20);
            roleLabel.Margin = new Padding(6, 0, 6, 0);
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
            linkLabel2.Location = new Point(24, 20);
            linkLabel2.Margin = new Padding(7, 0, 7, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // eventName
            // 
            eventName.BackColor = Color.AntiqueWhite;
            eventName.BorderStyle = BorderStyle.None;
            eventName.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            eventName.Location = new Point(17, 64);
            eventName.Margin = new Padding(4);
            eventName.Name = "eventName";
            eventName.ReadOnly = true;
            eventName.Size = new Size(668, 22);
            eventName.TabIndex = 10;
            eventName.Text = "Назва заходу";
            // 
            // descriptionBox
            // 
            descriptionBox.BackColor = Color.AntiqueWhite;
            descriptionBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionBox.Location = new Point(17, 115);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.ReadOnly = true;
            descriptionBox.Size = new Size(306, 95);
            descriptionBox.TabIndex = 11;
            descriptionBox.Text = "Опис";
            // 
            // statusBox
            // 
            statusBox.BackColor = Color.AntiqueWhite;
            statusBox.BorderStyle = BorderStyle.None;
            statusBox.Location = new Point(497, 116);
            statusBox.Name = "statusBox";
            statusBox.ReadOnly = true;
            statusBox.Size = new Size(174, 22);
            statusBox.TabIndex = 12;
            statusBox.Text = "Статус";
            statusBox.TextAlign = HorizontalAlignment.Center;
            // 
            // resultBox
            // 
            resultBox.BackColor = Color.AntiqueWhite;
            resultBox.BorderStyle = BorderStyle.None;
            resultBox.Location = new Point(17, 315);
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(654, 22);
            resultBox.TabIndex = 13;
            resultBox.Text = "Очікуваний результат";
            // 
            // dueBox
            // 
            dueBox.BackColor = Color.AntiqueWhite;
            dueBox.BorderStyle = BorderStyle.None;
            dueBox.Location = new Point(497, 180);
            dueBox.Name = "dueBox";
            dueBox.ReadOnly = true;
            dueBox.Size = new Size(174, 22);
            dueBox.TabIndex = 14;
            dueBox.Text = "Термін";
            dueBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 116);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 15;
            label1.Text = "Статус заходу:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 181);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 16;
            label2.Text = "Термін виконання:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 351);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 17;
            label3.Text = "Відповідальні:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-11, 423);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 62);
            panel2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(13, 3);
            label4.Name = "label4";
            label4.Size = new Size(349, 45);
            label4.TabIndex = 0;
            label4.Text = "Національний університет України \"Університет\" © 2023-2024\r\nПідтримка: тел. +38(044)-111-11-11\r\nУсі права захищено";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(13, 280);
            label5.Name = "label5";
            label5.Size = new Size(267, 22);
            label5.TabIndex = 19;
            label5.Text = "Очікуваний результат заходу:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(15, 223);
            label6.Name = "label6";
            label6.Size = new Size(128, 22);
            label6.TabIndex = 20;
            label6.Text = "Розділ плану:";
            // 
            // sectionBox
            // 
            sectionBox.BackColor = Color.AntiqueWhite;
            sectionBox.BorderStyle = BorderStyle.None;
            sectionBox.Location = new Point(17, 248);
            sectionBox.Name = "sectionBox";
            sectionBox.ReadOnly = true;
            sectionBox.Size = new Size(306, 22);
            sectionBox.TabIndex = 21;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Linen;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(546, 382);
            editButton.Name = "editButton";
            editButton.Size = new Size(112, 35);
            editButton.TabIndex = 22;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(497, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 29);
            dateTimePicker1.TabIndex = 23;
            // 
            // statusCombo
            // 
            statusCombo.BackColor = Color.White;
            statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCombo.FlatStyle = FlatStyle.Flat;
            statusCombo.FormattingEnabled = true;
            statusCombo.Location = new Point(497, 108);
            statusCombo.Name = "statusCombo";
            statusCombo.Size = new Size(188, 29);
            statusCombo.TabIndex = 24;
            // 
            // sectionCombo
            // 
            sectionCombo.BackColor = Color.White;
            sectionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectionCombo.FlatStyle = FlatStyle.Flat;
            sectionCombo.FormattingEnabled = true;
            sectionCombo.Location = new Point(17, 248);
            sectionCombo.Name = "sectionCombo";
            sectionCombo.Size = new Size(306, 29);
            sectionCombo.TabIndex = 25;
            // 
            // EventPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(698, 481);
            Controls.Add(editButton);
            Controls.Add(sectionBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dueBox);
            Controls.Add(resultBox);
            Controls.Add(statusBox);
            Controls.Add(descriptionBox);
            Controls.Add(eventName);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(statusCombo);
            Controls.Add(sectionCombo);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "EventPage";
            Text = "Подія";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label roleLabel;
        private LinkLabel linkLabel2;
        private TextBox eventName;
        private RichTextBox descriptionBox;
        private TextBox statusBox;
        private TextBox resultBox;
        private TextBox dueBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox sectionBox;
        private Button editButton;
        private DateTimePicker dateTimePicker1;
        private ComboBox statusCombo;
        private ComboBox sectionCombo;
    }
}