using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
     class Seat
    {
        // field
        int id;
        int price = 0;
        bool isSold = false; // 0: chua ban, 1: da ban

        // property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Price
        { get { return price; } set { price = value; } }
        public bool IsSold
        { get { return isSold; } set { isSold = value; } }

        public Seat(int id)
        {
            this.id = id;
            if (id >=1 && id <= 5)
            {
                price = 5000;
            }
            else if (id >=5 && id <= 10)
            {
                price = 6500;
            }
            else
            {
                price = 8000;
            }
        }
    }
}
