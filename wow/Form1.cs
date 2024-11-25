namespace wow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "คิม";
            student[1] = "นมผงอ้วน";
            student[2] = "เขต";
            student[3] = "ต้า";
            student[4] = "คิว";
            string test = "โอปอ";
            int n = student.Length;
            for (int i = 0; i < 5; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "แอปเปิ้ล", "แตงโม", "มะม่วง", "ทุเรียน" };
            string myFruit = "";
            foreach (string str in Fruits)
            {
                myFruit += str + ", ";
            }
            MessageBox.Show(myFruit, "ผลไม้ของฉัน");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; //นำข้อมูลแต่ละบรรทัดไปใส่ในอาเรย์
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }
                label1.Text = result;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0; // ตัวแปรเก็บผลรวม
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    sum += x; // บวกค่าของตัวเลขที่แปลงสำเร็จ
                    result += x.ToString() + Environment.NewLine;

                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "ผลรวมของตัวเลข");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "คิมมี่";
            student[0, 1] = "หนองบัวลำภู";
            student[1, 0] = "คิวปี้";
            student[1, 1] = "บึงกาฬ";
            student[2, 0] = "เขตทอมโสด";
            student[2, 1] = "หนองบัวลำภู";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + "-";
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "แสดงข้อมูลใน array 2 มิติ");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + "-";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "-";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "แอปเปิ้ล", "แตงโม", "มะม่วง", "ทุเรียน" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }
    }
}
