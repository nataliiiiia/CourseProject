namespace CourseProject.Forms
{
    partial class ScedulePage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScedulePage));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            roleLabel = new Label();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            addEventButton = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SandyBrown;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(-4, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SandyBrown;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(988, 432);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 40);
            panel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel1.Location = new Point(73, 11);
            linkLabel1.Margin = new Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 17);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Кафедра";
            linkLabel1.LinkClicked += GoToDepartmentPage;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleLabel.ForeColor = Color.FromArgb(128, 64, 0);
            roleLabel.Location = new Point(776, 11);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(46, 17);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Вітаю";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(7, 11);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Головна";
            linkLabel2.LinkClicked += GoToMainPage;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 8;
            label1.Text = "Назва плану";
            // 
            // addEventButton
            // 
            addEventButton.BackColor = Color.SandyBrown;
            addEventButton.FlatStyle = FlatStyle.Flat;
            addEventButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addEventButton.Location = new Point(772, 527);
            addEventButton.Name = "addEventButton";
            addEventButton.Size = new Size(166, 27);
            addEventButton.TabIndex = 9;
            addEventButton.Text = "Додати нову подію";
            addEventButton.UseVisualStyleBackColor = false;
            addEventButton.Click += AddEventButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(558, 527);
            button1.Name = "button1";
            button1.Size = new Size(166, 27);
            button1.TabIndex = 10;
            button1.Text = "Видалити подію";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(23, 527);
            button2.Name = "button2";
            button2.Size = new Size(189, 27);
            button2.TabIndex = 11;
            button2.Text = "Докладніше про подію";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ScedulePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(984, 566);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addEventButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScedulePage";
            Text = "План роботи";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label roleLabel;
        private LinkLabel linkLabel2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button addEventButton;
        private Button button1;
        private Button button2;
    }
}