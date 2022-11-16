namespace Bai6
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        double firstNumber, secondNumber;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnOperator_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                BtnEqual.PerformClick();
            }

            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = Double.Parse(TxtDisplay.Text);
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    break;
            }
            TxtDisplay.Text = result.ToString();
            operation = String.Empty;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
            result = 0;
            firstNumber = 0;
            secondNumber = 0;
            operation = String.Empty;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }

        private void BtnReverseSign_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = (-Double.Parse(TxtDisplay.Text)).ToString();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (operation != String.Empty)
            {
                TxtDisplay.Clear();
            }
            bool hasFirstNumber = false;
            if (TxtDisplay.Text == "0")
            {
                TxtDisplay.Clear();
            }
            else 
            {
                hasFirstNumber = true;
            }

            Button button =  (Button)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay.Text.Contains('.'))
                {
                    TxtDisplay.Text += button.Text;
                }
            }
            else
            {
                TxtDisplay.Text += button.Text;
            }

            if (hasFirstNumber == true)
            {
                secondNumber = double.Parse(TxtDisplay.Text);
            }
            else
            {
                firstNumber = double.Parse(TxtDisplay.Text);
            }

        }
    }
}