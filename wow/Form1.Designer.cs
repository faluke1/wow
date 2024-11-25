namespace wow
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(32, 12);
            button1.Name = "button1";
            button1.Size = new Size(144, 75);
            button1.TabIndex = 0;
            button1.Text = "Array1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Location = new Point(32, 93);
            button2.Name = "button2";
            button2.Size = new Size(144, 73);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(635, 54);
            label1.Name = "label1";
            label1.Size = new Size(159, 383);
            label1.TabIndex = 2;
            label1.Text = ".";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(327, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 396);
            textBox1.TabIndex = 3;
            textBox1.Text = ".";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(321, 23);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "พิมพ์รายชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(635, 23);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 5;
            label3.Text = "รายชื่อที่บันทึกแล้ว";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(486, 54);
            button3.Name = "button3";
            button3.Size = new Size(141, 122);
            button3.TabIndex = 6;
            button3.Text = "GetData";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Location = new Point(487, 211);
            button4.Name = "button4";
            button4.Size = new Size(142, 103);
            button4.TabIndex = 7;
            button4.Text = "GetNumber";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Cyan;
            button5.Location = new Point(32, 172);
            button5.Name = "button5";
            button5.Size = new Size(144, 71);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(833, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(833, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(113, 44);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(833, 172);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(159, 92);
            checkedListBox1.TabIndex = 11;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1042, 547);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
    }
}
