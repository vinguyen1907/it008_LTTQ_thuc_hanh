using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class DiaOc
    {

        private string _diaDiem;
        private int _giaBan;
        private double _dienTich;
        private string _loai;

        public virtual string DiaDiem { get => _diaDiem; set => _diaDiem = value; }
        public virtual int GiaBan { get => _giaBan; set => _giaBan = value; }
        public virtual double DienTich { get => _dienTich; set => _dienTich = value; }
        public virtual string Loai { get => _loai; set => _loai = value; }

        public DiaOc(string DiaDiem = "", int GiaBan = 0, double DienTich = 0)
        {
            this._diaDiem = DiaDiem;
            this._giaBan = GiaBan;
            this._dienTich = DienTich;
        }
        public virtual void Input()
        {
            Console.Write(" - Nhap dia diem: ");
            _diaDiem = Console.ReadLine();
            Console.Write(" - Nhap gia ban: ");
            _giaBan = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap dien tich: ");
            _dienTich = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine(" - Dia diem: " + _diaDiem);
            Console.WriteLine(" - Gia ban: " + _giaBan);
            Console.WriteLine(" - Dien tich: " + _dienTich);
        }
    }
}
