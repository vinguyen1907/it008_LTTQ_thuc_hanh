using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public 
     partial class Form2 : Form
    {
        public string id;
        public string name;
        public string department;
        public string point;
        public Form2()
        {
            InitializeComponent();
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == String.Empty || textBoxName.Text == String.Empty || textBoxPoint.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK);
            }
            else
            {
                id = textBoxID.Text;
                name = textBoxName.Text;
                department = comboBoxDepartment.SelectedItem.ToString();
                point = textBoxPoint.Text;
                Close();
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPoint_KeyPress(object sender, KeyPressEventArgs e)
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
