using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Regex regex = new Regex(@"^[0-9]+\+[0-9]+$"); // regex for pattern of a sum (ie : 1 + 1)

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && regex.IsMatch(textBox1.Text)) // check if input text is not empty and matches pattern of a sum
            {

                // display sum

                textBox2.Text = textBox1.Text.Split("+").Aggregate(0, (a, b) => a + int.Parse(b)).ToString();

                // toggle message color to green to indicate success

                if (message.ForeColor == Color.Red)
                {
                    message.ForeColor = Color.Green;

                }
            }

            else
            {
                // toggle message color to red to indicate error
                if (message.ForeColor == Color.Green)
                {
                    message.ForeColor = Color.Red;                }

            }

        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}