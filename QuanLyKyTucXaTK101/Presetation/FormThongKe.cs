using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Entities;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormThongKe
    {
        DoHoa dh = new DoHoa(100, 55);
        public static MenuChinh menu = new MenuChinh();
        PhongBLL PBLL = new PhongBLL();
        HoaDonThanhToanBLL HDBLL = new HoaDonThanhToanBLL();
        #region chuc nang thong ke
        public void ThongKe()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 54);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 54);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 54);
            for (int i = 1; i < 54; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("lUSACO", 6, 2);
            dh.ve("KI TUC XA TRUONG DT", 2, 4);
            dh.ve("─────────────────────────────", 3, 6);
            dh.ve("CONG HOA XA HOI CHU NGHIA VIET NAM", 62, 2);
            dh.ve("Doc lap - Tu do - Hanh phuc", 66, 4);
            dh.ve("─────────────────────────────", 67, 6);
            dh.ve("BAO CAO TONG KET THANG", 45, 10);
            dh.ve("CUA KY TUC XA DAI HOC SPKT HUNG YEN", 38, 11);
            dh.ve("Hung Yen, ngay    thang    nam", 60, 13);
            dh.ve("Kinh gui: Truong ban quan ly KTX dai hoc spkt Hung Yen cung hoi dong truong dai hoc", 10, 15);
            dh.ve("SPKT Hung Yen", 10, 17);
            dh.ve("Ki Tuc Xa gui lai bao cao thong ke quy cu the nhu sau :", 6, 20);
            dh.ve("1. Tong so luong SV hien tai co trong ki tuc xa la:", 10, 22);
            dh.ve("   Tong so luong SV nam la:                        ", 10, 24);
            dh.ve("   Tong so luong SV nu la: ", 10, 26);
            dh.ve("2. Tong so phong hien co cua ki tuc xa la:", 10, 28);
            dh.ve("   Tong so phong danh cho nam la:", 10, 30);
            dh.ve("   Tong so phong danh cho nu la:", 10, 32);
            dh.ve("   Tong so phong hien dang con cho trong hoac chua co nguoi o la:", 10, 34);
            dh.ve("3. Tong so tien thu duoc trong thang la:", 10, 36);
            dh.ve("Nguoi lap bao cao", 72, 42);
            dh.ve("<Ki ten, dong dau>", 72, 43);
            DateTime ngayhethong = DateTime.Now;
            dh.ve(Convert.ToString(ngayhethong.Day), 75, 13);
            dh.ve(Convert.ToString(ngayhethong.Month), 84, 13);
            dh.ve(Convert.ToString(ngayhethong.Year), 91, 13);
            int soluongsv = PBLL.TongSoSinhVienTrongKiTuc();
            int soluongsvnam = PBLL.TongSoSinhVienNamTrongKiTuc();
            int soluongsvnu = PBLL.TongSoSinhVienNuTrongKiTuc();
            int tongsophongnam = PBLL.TongSoPhongNam();
            int tongsophongnu = PBLL.TongSoPhongNu();
            int tongphongcontrong = PBLL.TongSoPhongConTrong();
            double tongsotien = HDBLL.TongTien();
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve(Convert.ToString(soluongsv), 64, 22);
            dh.ve(Convert.ToString(soluongsvnam), 38, 24);
            dh.ve(Convert.ToString(soluongsvnu), 37, 26);
            dh.ve(Convert.ToString(tongsophongnam), 44, 30);
            dh.ve(Convert.ToString(tongsophongnu), 43, 32);
            dh.ve(Convert.ToString(tongphongcontrong), 76, 34);
            dh.ve(Convert.ToString(tongsotien), 52, 36);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("De tro lai menu chinh   Enter", 65, 50);
            dh.ve("Thoat chuong trinh       Esc", 65, 51);
            dh.ve("Ban nhan phim chuc nang:  ", 65, 52);
        t: ConsoleKeyInfo k = Console.ReadKey();
            switch (k.Key)
            {

                case ConsoleKey.Enter:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap sai phim nhap lai!!!", 6, 53);
                    goto t;
            }
        }
        #endregion
    }
}