using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
     class QuanLyThongTin
    {
        private List<DiaOc> list;

        public QuanLyThongTin()
        {
            list = new List<DiaOc>();
        }
        public void XuatDanhSach()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Khu dat thu " + (i + 1) + ": ");
                list[i].Output();
            }
        }
        public void XuatTongTheoTungLoai()
        {
            int tongGiaKhuDat = 0;
            int tongGiaNhaPho = 0;
            int tongGiaChungCu = 0;
            foreach (DiaOc item in list)
            {
                switch (item.Loai)
                {
                    case "KhuDat":
                        tongGiaKhuDat += item.GiaBan;
                        break;
                    case "NhaPho":
                        tongGiaNhaPho += item.GiaBan;
                        break;
                    case "ChungCu":
                        tongGiaChungCu += item.GiaBan;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Tong gia ban Khu Dat: " + tongGiaKhuDat);
            Console.WriteLine("Tong gia ban Nha Pho: " + tongGiaNhaPho);
            Console.WriteLine("Tong gia ban Chung Cu: " + tongGiaChungCu);
        }
        public void XuatTheoYeuCau()
        {
            int count = 0;
            foreach (DiaOc item in list)
            {
                if (item.Loai == "KhuDat")
                {
                    KhuDat temp = (KhuDat)item;
                    if (temp.DienTich > 100)
                    {
                        count++;
                        Console.WriteLine($"Khu dat thu {count} thoa man");
                        item.Output();
                    }
                }
                else if (item.Loai == "NhaPho")
                {
                    NhaPho temp = (NhaPho)item;
                    if (temp.DienTich > 60 && temp.NamXayDung >= 2019)
                    {
                        count++;
                        Console.WriteLine($"Khu dat thu {count} thoa man");
                        item.Output();
                    }
                }
            }
        }
        public void TimKiem()
        {
            Console.Write("Nhap dia diem can tim: ");
            string diaDiem = Console.ReadLine().ToLower();
            Console.Write("Nhap gia ban can tim: ");
            int giaBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich can tim: ");
            double dienTich = double.Parse(Console.ReadLine());

            int count = 0;

            Console.WriteLine("KET QUA TIM KIEM: ");
            foreach (DiaOc item in list)
            {
                if ((item.Loai == "NhaPho" && item.Loai == "ChungCu") || (item.DiaDiem.ToLower().Contains(diaDiem) && item.GiaBan <= giaBan && item.DienTich >= dienTich))
                {
                    count++;
                    item.Output();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("!!! Khong co ket qua phu hop.");
            }
        }
        public void Execute()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============");
                Console.WriteLine("1. Them khu dat");
                Console.WriteLine("2. Them nha pho");
                Console.WriteLine("3. Them chung cu");
                Console.WriteLine("4. Xem danh sach");
                Console.WriteLine("5. Xuat tong gia ban dat");
                Console.WriteLine("6. Xuat cac Khu Dat co dien tich > 100m2 hoặc Nha Pho có dien tich > 60m2 và nam xay dung >= 2019");
                Console.WriteLine("7. Tim kiem");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("===============");
                Console.Write("Nhap lua chon: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    return;
                }
                else if (choice == 1)
                {
                    DiaOc tmp = new KhuDat();
                    tmp.Input();
                    list.Add(tmp);
                }
                else if (choice == 2)
                {
                    DiaOc tmp = new NhaPho();
                    tmp.Input();
                    list.Add(tmp);
                }
                else if (choice == 3)
                {
                    DiaOc tmp = new ChungCu();
                    tmp.Input();
                    list.Add(tmp);
                }
                else if (choice == 4)
                {
                    XuatDanhSach();
                }
                else if (choice == 5)
                {
                    XuatTongTheoTungLoai();
                }
                else if (choice == 6)
                {
                    XuatTheoYeuCau();
                }
                else if (choice == 7)
                {
                    TimKiem();
                }
                else
                        {
                    Console.WriteLine("Nhap lua chon khac.");
                }

                Console.WriteLine("Nhan Enter de tiep tuc");
                Console.ReadKey();
            }
        }
    }
}
