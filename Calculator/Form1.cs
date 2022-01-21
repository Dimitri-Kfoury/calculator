using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Regex regex = new Regex(@"^([0-9]+)([\+\-\/\*])([0-9]+)$"); // regex for pattern of an operation (ie : 1 + 1)

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {




            Match m = regex.Match(textBox1.Text);


            if (m.Success) // check if input text matches pattern
            {
             

                switch (m.Groups[2].Value)
                {

                    case "+":
                        textBox2.Text = (int.Parse(m.Groups[1].Value) + int.Parse(m.Groups[3].Value)).ToString();
                        break;
                    case "-": 
                        textBox2.Text = (int.Parse(m.Groups[1].Value) - int.Parse(m.Groups[3].Value)).ToString();
                        break;
                    case "*":
                        textBox2.Text = (int.Parse(m.Groups[1].Value) * int.Parse(m.Groups[3].Value)).ToString();
                        break;
                    case "/":

                        if (m.Groups[3].Value != "0")
                        {
                            textBox2.Text = (int.Parse(m.Groups[1].Value) / int.Parse(m.Groups[3].Value)).ToString();
                        }
                        else
                        {
                            // toggle message color to red to indicate error
                            if (message.ForeColor == Color.Green)
                            {
                                message.ForeColor = Color.Red;
                            }

                            return;

                        }
                        break;




                }
                

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