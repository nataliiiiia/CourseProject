namespace CourseProject.Forms
{
    partial class ReviewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewPage));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            unameLabel = new Label();
            departmentCombo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            reviewText = new RichTextBox();
            title = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(-9, -8);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 50);
            panel1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(310, 15);
            button2.Name = "button2";
            button2.Size = new Size(133, 30);
            button2.TabIndex = 7;
            button2.Text = "Скасувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Cancel;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(449, 15);
            button1.Name = "button1";
            button1.Size = new Size(133, 30);
            button1.TabIndex = 6;
            button1.Text = "Надіслати відгук";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SendReview;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(21, 22);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            linkLabel2.LinkClicked += GoToMain;
            // 
            // unameLabel
            // 
            unameLabel.AutoSize = true;
            unameLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            unameLabel.ForeColor = Color.Black;
            unameLabel.Location = new Point(13, 63);
            unameLabel.Margin = new Padding(4, 0, 4, 0);
            unameLabel.Name = "unameLabel";
            unameLabel.Size = new Size(122, 21);
            unameLabel.TabIndex = 6;
            unameLabel.Text = "Автор відгуку";
            // 
            // departmentCombo
            // 
            departmentCombo.FormattingEnabled = true;
            departmentCombo.Location = new Point(13, 119);
            departmentCombo.Name = "departmentCombo";
            departmentCombo.Size = new Size(560, 29);
            departmentCombo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(407, 21);
            label1.TabIndex = 9;
            label1.Text = "Оберіть кафедру, про яку хочете написати відгук:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 157);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 10;
            label2.Text = "Заголовок відгуку:";
            // 
            // reviewText
            // 
            reviewText.BorderStyle = BorderStyle.FixedSingle;
            reviewText.Location = new Point(12, 256);
            reviewText.Name = "reviewText";
            reviewText.Size = new Size(561, 240);
            reviewText.TabIndex = 11;
            reviewText.Text = "";
            // 
            // title
            // 
            title.Location = new Point(13, 185);
            title.Name = "title";
            title.Size = new Size(560, 29);
            title.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 225);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 13;
            label3.Text = "Текст відгуку:";
            // 
            // ReviewPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(585, 508);
            Controls.Add(label3);
            Controls.Add(title);
            Controls.Add(reviewText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(departmentCombo);
            Controls.Add(unameLabel);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ReviewPage";
            Text = "Відгук про роботу кафедри";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label unameLabel;
        private LinkLabel linkLabel2;
        private ComboBox departmentCombo;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private RichTextBox reviewText;
        private TextBox title;
        private Label label3;
    }
}