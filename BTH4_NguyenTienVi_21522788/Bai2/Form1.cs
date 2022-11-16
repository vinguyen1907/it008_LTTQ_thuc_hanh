namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}