namespace CourseProject.Forms
{
    partial class AddEventPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventPage));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            eventResult = new TextBox();
            sectionCombo = new ComboBox();
            eventName = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            professorsCombo = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            helpLabel = new Label();
            toolTip1 = new ToolTip(components);
            addButton = new Button();
            exitButton = new Button();
            addProfButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 1;
            label1.Text = "Назва події:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 2;
            label2.Text = "Розділ події:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(200, 21);
            label3.TabIndex = 3;
            label3.Text = "Очікуваний результат:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(155, 21);
            label4.TabIndex = 4;
            label4.Text = "Термін виконання:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(185, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // eventResult
            // 
            eventResult.Location = new Point(218, 59);
            eventResult.Name = "eventResult";
            eventResult.Size = new Size(496, 29);
            eventResult.TabIndex = 6;
            // 
            // sectionCombo
            // 
            sectionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sectionCombo.FlatStyle = FlatStyle.Flat;
            sectionCombo.FormattingEnabled = true;
            sectionCombo.Location = new Point(152, 100);
            sectionCombo.Name = "sectionCombo";
            sectionCombo.Size = new Size(224, 29);
            sectionCombo.TabIndex = 7;
            // 
            // eventName
            // 
            eventName.Location = new Point(131, 16);
            eventName.Name = "eventName";
            eventName.Size = new Size(583, 29);
            eventName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 9;
            label5.Text = "Опис події:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(12, 224);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(364, 165);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(399, 103);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 11;
            label6.Text = "Відповідальні:";
            // 
            // professorsCombo
            // 
            professorsCombo.BackColor = Color.White;
            professorsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            professorsCombo.FlatStyle = FlatStyle.Flat;
            professorsCombo.FormattingEnabled = true;
            professorsCombo.Location = new Point(399, 140);
            professorsCombo.Name = "professorsCombo";
            professorsCombo.Size = new Size(315, 29);
            professorsCombo.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.AntiqueWhite;
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(399, 222);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(315, 170);
            checkedListBox1.TabIndex = 13;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(470, 186);
            label7.Name = "label7";
            label7.Size = new Size(184, 21);
            label7.TabIndex = 14;
            label7.Text = "Обрані відповідальні:";
            // 
            // helpLabel
            // 
            helpLabel.AutoSize = true;
            helpLabel.BorderStyle = BorderStyle.FixedSingle;
            helpLabel.Location = new Point(444, 184);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(20, 23);
            helpLabel.TabIndex = 15;
            helpLabel.Text = "?";
            // 
            // addButton
            // 
            addButton.BackColor = Color.SandyBrown;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(484, 415);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 36);
            addButton.TabIndex = 16;
            addButton.Text = "Додати подію";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.SandyBrown;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(106, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 36);
            exitButton.TabIndex = 17;
            exitButton.Text = "Скасувати";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button2_Click;
            // 
            // addProfButton
            // 
            addProfButton.BackColor = Color.SandyBrown;
            addProfButton.FlatStyle = FlatStyle.Flat;
            addProfButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addProfButton.Location = new Point(531, 99);
            addProfButton.Name = "addProfButton";
            addProfButton.Size = new Size(183, 30);
            addProfButton.TabIndex = 18;
            addProfButton.Text = "Додати відповідального";
            addProfButton.UseVisualStyleBackColor = false;
            addProfButton.Click += addProfButton_Click;
            // 
            // AddEventPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(732, 463);
            Controls.Add(addProfButton);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(helpLabel);
            Controls.Add(label7);
            Controls.Add(checkedListBox1);
            Controls.Add(professorsCombo);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(eventName);
            Controls.Add(sectionCombo);
            Controls.Add(eventResult);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddEventPage";
            Text = "Додання події";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox eventResult;
        private ComboBox sectionCombo;
        private TextBox eventName;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
        private ComboBox professorsCombo;
        private CheckedListBox checkedListBox1;
        private Label label7;
        private Label helpLabel;
        private ToolTip toolTip1;
        private Button addButton;
        private Button exitButton;
        private Button addProfButton;
    }
}