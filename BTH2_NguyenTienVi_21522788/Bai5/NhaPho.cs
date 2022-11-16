using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class NhaPho : DiaOc
    {
        private int _namXayDung;
        private int _soTang;

        private string _loai = "NhaPho";

        public int NamXayDung { get => _namXayDung; set => _namXayDung = value; }
        public override string Loai { get => _loai; set => _loai = value; }

        public override void Input()
        {
            base.Input();
            Console.Write(" - Nhap nam xay dung: ");
            _namXayDung = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap so tang: ");
            _soTang = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine(" - Nam xay dung: " + _namXayDung);
            Console.WriteLine(" - So tang: " + _soTang);
        }
    }
}
