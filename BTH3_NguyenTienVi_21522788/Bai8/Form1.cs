namespace Bai8
{
    public partial class Form1 : Form
    {
        List<Account> accountsList = new List<Account>();
        ListViewItem item1 = new ListViewItem("STT");
        ListViewItem item2 = new ListViewItem("Mã tài khoản");
        ListViewItem item3 = new ListViewItem("Tên khách hàng");
        ListViewItem item4 = new ListViewItem("Địa chỉ");
        ListViewItem item5 = new ListViewItem("Số tiền");
        public Form1()
        {
            InitializeComponent();
        }
        
        // **REUSABLE FUNCTION
        private bool checkAccountIsExisted(int accountNumber)
        {
            foreach (Account account in accountsList)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return true;
                }
            }
            return false;
        }
        private void reloadAccountsList()
        {
            ListView.Items.Clear();
            for (int i = 0; i < accountsList.Count; i++)
            {
                String[] row = { accountsList.Count.ToString(), (accountsList[i].AccountNumber).ToString(), accountsList[i].Name, accountsList[i].Address, accountsList[i].Money.ToString() };
                ListViewItem item = new ListViewItem(row);
                ListView.Items.Add(item);
            }
        }
        private void UpdateAccount(Account account)
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountsList[i].AccountNumber == account.AccountNumber)
                {
                    accountsList[i] = account;
                }    
            }
            reloadAccountsList();
        }
        private void AddAccount(Account account)
        {
            accountsList.Add(account);
            String[] row = { accountsList.Count.ToString(), (account.AccountNumber).ToString(), account.Name, account.Address, account.Money.ToString() };
            ListViewItem item = new ListViewItem(row);
            ListView.Items.Add(item);
        }
        private void DeleteAccount(String accountNumber)
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountsList[i].AccountNumber.ToString() == accountNumber)
                {
                    accountsList.Remove(accountsList[i]);
                    reloadAccountsList();
                }
            }
        }

        // **EVENT HANDLER
        private void TextBoxAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TextBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void BtnAddAndUpdate_Click(object sender, EventArgs e)
        {
            if (TextBoxAccountNumber.Text == String.Empty || TextBoxName.Text == String.Empty || TextBoxAddress.Text == String.Empty || TextBoxMoney.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (checkAccountIsExisted(int.Parse(TextBoxAccountNumber.Text)))
                {
                    // update
                    Account temp = new Account(int.Parse(TextBoxAccountNumber.Text), TextBoxName.Text, TextBoxAddress.Text, int.Parse(TextBoxMoney.Text));
                    UpdateAccount(temp);

                    // notify
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                else
                {
                    // add account into accountsList
                    Account temp = new Account(int.Parse(TextBoxAccountNumber.Text), TextBoxName.Text, TextBoxAddress.Text, int.Parse(TextBoxMoney.Text));
                    AddAccount(temp);

                    // notify
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (TextBoxAccountNumber.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập STK");
            }
            else
            {
                if (!checkAccountIsExisted(int.Parse(TextBoxAccountNumber.Text)))
                {
                    MessageBox.Show("“Không tìm thấy số tài khoản cần xóa.");
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Bạn có chắc xóa STK này không", "", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        DeleteAccount(TextBoxAccountNumber.Text);
                    }
                } 
            } 
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = (ListView)sender;
            if (listview.SelectedItems.Count > 0)
            {
                ListViewItem item = listview.SelectedItems[0];
                TextBoxAccountNumber.Text = item.SubItems[1].Text;
                TextBoxName.Text = item.SubItems[2].Text;
                TextBoxAddress.Text = item.SubItems[3].Text;
                TextBoxMoney.Text = item.SubItems[4].Text;
            }
        }
    }
}