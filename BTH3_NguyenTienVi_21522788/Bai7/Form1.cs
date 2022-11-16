namespace Bai7
{
    public partial class Form1 : Form
    {
        Seat[] seats = new Seat[15];
        int price = 0;
        List<int> selectedIndex = new List<int>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                seats[i] = new Seat(i + 1);
            }
        }

        private void BtnSeat_Cick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.Text);
            if (seats[id - 1].IsSold == true)
            {
                MessageBox.Show("Vị trí này đã bán!");
            } 
            else
            {
                button.BackColor = Color.Blue;
                button.ForeColor = Color.White;
                selectedIndex.Add(id);
            }

        }

        private void ChangeBtnColor(int index, Color BackgroundColor, Color ForegroundColor)
        {
            switch (index)
            {
                case 1:
                    button1.BackColor = BackgroundColor;
                    button1.ForeColor = ForegroundColor;
                    break;
                case 2:
                    button2.BackColor = BackgroundColor;
                    button2.ForeColor = ForegroundColor;
                    break;
                case 3:
                    button3.BackColor = BackgroundColor;
                    button3.ForeColor = ForegroundColor;
                    break;
                case 4:
                    button4.BackColor = BackgroundColor;
                    button4.ForeColor = ForegroundColor;
                    break;
                case 5:
                    button5.BackColor = BackgroundColor;
                    button5.ForeColor = ForegroundColor;
                    break;
                case 6:
                    button6.BackColor = BackgroundColor;
                    button6.ForeColor = ForegroundColor;
                    break;
                case 7:
                    button7.BackColor = BackgroundColor;
                    button7.ForeColor = ForegroundColor;
                    break;
                case 8:
                    button8.BackColor = BackgroundColor;
                    button8.ForeColor = ForegroundColor;
                    break;
                case 9:
                    button9.BackColor = BackgroundColor;
                    button9.ForeColor = ForegroundColor;
                    break;
                case 10:
                    button10.BackColor = BackgroundColor;
                    button10.ForeColor = ForegroundColor;
                    break;
                case 11:
                    button11.BackColor = BackgroundColor;
                    button11.ForeColor = ForegroundColor;
                    break;
                case 12:
                    button12.BackColor = BackgroundColor;
                    button12.ForeColor = ForegroundColor;
                    break;
                case 13:
                    button13.BackColor = BackgroundColor;
                    button13.ForeColor = ForegroundColor;
                    break;
                case 14:
                    button14.BackColor = BackgroundColor;
                    button14.ForeColor = ForegroundColor;
                    break;
                case 15:
                    button15.BackColor = BackgroundColor;
                    button15.ForeColor = ForegroundColor;
                    break;
            }
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            // change property isSold of these seat into true
            for (int i = 0; i < selectedIndex.Count; i++)
            {
                seats[selectedIndex[i] - 1].IsSold = true;
            }

            // change color of buttons into yello which are selected
            for (int i = 0; i < selectedIndex.Count; i++)
            {
                ChangeBtnColor(selectedIndex[i], Color.Yellow, Color.Black);
            }

            // calculate sum of price and display it
            for (int i = 0; i < selectedIndex.Count; i++)
            {
                seats[selectedIndex[i] - 1].IsSold = true;
                price += seats[selectedIndex[i] - 1].Price;
            }
            PriceDisplay.Text = price.ToString();   

            // clear selectedIndex
            selectedIndex.Clear();
            price = 0;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            // change color of buttons into white which is selected
            for (int i = 0; i < selectedIndex.Count; i++)
            {
                ChangeBtnColor(selectedIndex[i], Color.White, Color.Black);
            }

            // clear selectedIndex
            selectedIndex.Clear();
            price = 0;

            // display 0
            PriceDisplay.Text = price.ToString();
        }
        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}