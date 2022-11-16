using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class ChungCu : DiaOc
    {
        public int _tang;
        private string _loai = "ChungCu";

        public override string Loai { get => _loai; set => _loai = value; }

        public override void Input()
        {
            base.Input();
            Console.Write(" - Nhap tang: ");
            _tang = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine(" - Tang: " + _tang);
        }
    }
}
