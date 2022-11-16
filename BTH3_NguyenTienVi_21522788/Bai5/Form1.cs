namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = (float.Parse(textBox1.Text) / float.Parse(textBox2.Text)).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        
    }
}