using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
     class Account
    {
        int accountNumber;
        string name;
        string address;
        int money;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }


        public Account()
        {

        }

        public Account(int accountNumber, string name, string address, int money)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.address = address;
            this.money = money;
        }
    }
}
