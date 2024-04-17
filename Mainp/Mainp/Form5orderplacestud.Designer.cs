namespace Mainp
{
    partial class Form5orderplacestud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5orderplacestud));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            label9 = new Label();
            button3 = new Button();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            button4 = new Button();
            button5 = new Button();
            label12 = new Label();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 16);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 0;
            label1.Text = "Click to veiw laundry service menu";
            // 
            // button1
            // 
            button1.Location = new Point(305, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(185, 60);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Order ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(149, 141);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 4;
            label3.Text = "Choose service type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dry Cleaning", "Wash", "Iron", "Wash and Iron", "Dry cleaning and Iron", "Wash and fold", "Stain remover" });
            comboBox1.Location = new Point(305, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(197, 185);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 6;
            label4.Text = "Choose item";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(186, 235);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 10;
            label6.Text = "Enter Quantity";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 27);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(165, 288);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 12;
            label7.Text = "Enter payment ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(617, 377);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 14;
            label8.Text = "Total cost";
            // 
            // button2
            // 
            button2.Location = new Point(696, 375);
            button2.Name = "button2";
            button2.Size = new Size(56, 24);
            button2.TabIndex = 15;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(86, 337);
            label9.Name = "label9";
            label9.Size = new Size(203, 20);
            label9.TabIndex = 16;
            label9.Text = "Proceed to payment gateway";
            // 
            // button3
            // 
            button3.Location = new Point(305, 337);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Click";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(248, 100);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 18;
            label10.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(305, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(94, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(540, 30);
            label11.Name = "label11";
            label11.Size = new Size(150, 20);
            label11.TabIndex = 20;
            label11.Text = "Previous Order Status";
            // 
            // button4
            // 
            button4.Location = new Point(696, 26);
            button4.Name = "button4";
            button4.Size = new Size(55, 29);
            button4.TabIndex = 21;
            button4.Text = "Click";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 420);
            button5.Name = "button5";
            button5.Size = new Size(62, 29);
            button5.TabIndex = 22;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(608, 77);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 23;
            label12.Text = "Edit Profile";
            // 
            // button6
            // 
            button6.Location = new Point(696, 75);
            button6.Name = "button6";
            button6.Size = new Size(56, 24);
            button6.TabIndex = 24;
            button6.Text = "Click";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "T-Shirt", "Jeans", "Socks", "Underwear", "Dresses", "Shirts/blouses", "Pants/trousers", "Skirts", "Shorts", "Sweater" });
            comboBox3.Location = new Point(305, 177);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(147, 28);
            comboBox3.TabIndex = 26;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Form5orderplacestud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(button6);
            Controls.Add(label12);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form5orderplacestud";
            Text = "Form5orderplacestud";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private Button button2;
        private Label label9;
        private Button button3;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Button button4;
        private Button button5;
        private Label label12;
        private Button button6;
        private PictureBox pictureBox1;
        private ComboBox comboBox3;
    }
}