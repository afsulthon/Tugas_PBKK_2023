namespace WinFormsApp_SimpleCalculator
{
    public partial class Form1 : Form
    {
        decimal result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                result = decimal.Parse(textBox1.Text) + decimal.Parse(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            catch (System.FormatException) { return; }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            try
            {
                result = decimal.Parse(textBox1.Text) - decimal.Parse(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            catch (System.FormatException) { return; }
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            try
            {
                result = decimal.Parse(textBox1.Text) * decimal.Parse(textBox2.Text);
                textBox3.Text = result.ToString();
            }
            catch (System.FormatException) { return; }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    result = decimal.Parse(textBox1.Text) / decimal.Parse(textBox2.Text);
                    textBox3.Text = result.ToString();
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Denominator cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException) { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}