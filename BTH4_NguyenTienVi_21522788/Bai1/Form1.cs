using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Tọa độ: ({e.X}, {e.Y})", "Click chuột");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            MessageBox.Show($"Phím: {e.KeyValue}\nKey code: {e.KeyCode}", "Nhấn phím");
        }
    }
}