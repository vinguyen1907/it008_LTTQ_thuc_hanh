namespace Bai9
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string ChuyenNganh { get; set; }
        public string GioiTinh { get; set; }
        public int SoMonHoc { get; set; }
        public List<String> CacMonHocThamGia { get; set; } = new List<String>();

        public SinhVien()
        {

        }

        public SinhVien(string maSV, string hoTen, string chuyenNganh, string gioiTinh, int soMonHoc, List<string> cacMonHocThamGia)
        {
            MaSV=maSV;
            HoTen=hoTen;
            ChuyenNganh=chuyenNganh;
            GioiTinh=gioiTinh;
            SoMonHoc=soMonHoc;
            CacMonHocThamGia=cacMonHocThamGia;
        }
    }
}