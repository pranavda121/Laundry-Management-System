namespace Mainp
{
    partial class Form10servicecheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10servicecheck));
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(204, 93);
            button1.Name = "button1";
            button1.Size = new Size(56, 29);
            button1.TabIndex = 2;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 150);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 210);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 4;
            label3.Text = "Update Laundry Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "Done" });
            comboBox1.Location = new Point(252, 202);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(77, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 272);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 6;
            label4.Text = "Update Payment Status";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Unpaid", "Paid" });
            comboBox2.Location = new Point(252, 264);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(77, 28);
            comboBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(252, 321);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 364);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 9;
            label5.Text = "View Feedback";
            // 
            // button3
            // 
            button3.Location = new Point(252, 364);
            button3.Name = "button3";
            button3.Size = new Size(77, 29);
            button3.TabIndex = 10;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(-1, 419);
            button4.Name = "button4";
            button4.Size = new Size(56, 29);
            button4.TabIndex = 11;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(642, 89);
            button5.Name = "button5";
            button5.Size = new Size(56, 29);
            button5.TabIndex = 13;
            button5.Text = "Check";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 93);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 14;
            label1.Text = "Pending Orders";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 97);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 15;
            label6.Text = "Completed Orders";
            // 
            // Form10servicecheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form10servicecheck";
            Text = "Form10servicecheck";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Button button2;
        private Label label5;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
        private Label label1;
        private Label label6;
    }
}