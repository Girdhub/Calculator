namespace Calculator
{
    public partial class Form1 : Form
    {
        double Num1;
        char[] Operator = new char[] {'+', '-', '*', '/'};
        string OP = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        

        private void Button_Number(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Tag;
            textBox2.Text += ((Button)sender).Tag;
        }

        private void Button_Operate(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox2.Text);
            textBox1.Text = Num1.ToString() + Operator[Convert.ToInt16(((Button)sender).Tag)];
            textBox2.Text = "";
            OP = Operator[Convert.ToInt16(((Button)sender).Tag)].ToString();

        }

        private void Button_Eual(object sender, EventArgs e)
        {
            switch (OP)
            {
                case "+":
                    textBox2.Text = (Num1 + Double.Parse(textBox2.Text)).ToString();
                    break;

                case "-":
                    textBox2.Text = (Num1 - Double.Parse(textBox2.Text)).ToString();
                    break;

                case "*":
                    textBox2.Text = (Num1 * Double.Parse(textBox2.Text)).ToString();
                    break;

                case "/":
                    textBox2.Text = (Num1 / Double.Parse(textBox2.Text)).ToString();
                    break;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains(".")) return;
            textBox1.Text += "."; textBox2.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Num1 = 0;
            textBox1.Text = ""; textBox2.Text = "0";
            OP = "";


        }

        private void button16_Click(object sender, EventArgs e)
        {
            double Num = Double.Parse(textBox2.Text);
            textBox1.Text = (-Num).ToString();
            textBox2.Text = (-Num).ToString();
        }
    }
}