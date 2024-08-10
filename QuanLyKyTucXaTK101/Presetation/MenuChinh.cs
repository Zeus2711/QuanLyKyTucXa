using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    public class MenuChinh
    {
        DoHoa dh = new DoHoa(100, 55);
        FormDayPhong dayphong = new FormDayPhong();
        FormPhong phong = new FormPhong();
        FormSinhVien sinhvien = new FormSinhVien();
        FormTimKiem timkiem = new FormTimKiem();
        FormThueTraPhong thuetra = new FormThueTraPhong();
        FormThongTinKhac Thongtinkhac = new FormThongTinKhac();
        FormDienNuoc diennuoc = new FormDienNuoc();
        FormThongKe thongke = new FormThongKe();
      static  FormDangNhap dangnhap1 = new FormDangNhap();
        public void MenuChinh1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 45);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 45);
                dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
                dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
                dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 45);
            
            for (int i = 1; i < 45; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            /////===============================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 4, 5);
            dh.ve("╚", 4, 43);
            dh.ve("╗", 95, 5);
            dh.ve("╝", 95, 43);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 5);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 43);

            for (int i = 6; i < 43; ++i)
            {
                dh.ve("║", 4, i);
                dh.ve("║", 95, i);
            }
            ///====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 44);
            for (int i = 4; i < 44; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            //=============================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 19, 12);
            dh.ve("╚", 19, 34);
            dh.ve("╗", 79, 12);
            dh.ve("╝", 79, 34);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 12);
            
            for (int i = 13; i < 34; ++i)
            {
                dh.ve("║", 19, i);
                dh.ve("║", 79, i);
            }
            dh.ve("╠", 19, 16);
            dh.ve("╠", 19, 18);
            dh.ve("╠", 19, 20);
            dh.ve("╠", 19, 22);
            dh.ve("╠", 19, 24);
            dh.ve("╠", 19, 26);
            dh.ve("╠", 19, 28);
            dh.ve("╠", 19, 30);
            dh.ve("╠", 19, 32);

            dh.ve("╣", 79, 16);
            dh.ve("╣", 79, 18);
            dh.ve("╣", 79, 20);
            dh.ve("╣", 79, 22);
            dh.ve("╣", 79, 24);
            dh.ve("╣", 79, 26);
            dh.ve("╣", 79, 28);
            dh.ve("╣", 79, 30);
            dh.ve("╣", 79, 32);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 16);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 18);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 20);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 22);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 24);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 26);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 28);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 30);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 32);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 34);



            for (int i = 17; i < 34; ++i)
            {
                dh.ve("║", 25, i);
            }

            dh.ve("╦", 25, 16);
            dh.ve("╩", 25, 34);
            dh.ve("╬", 25, 18);
            dh.ve("╬", 25, 20);
            dh.ve("╬", 25, 22);
            dh.ve("╬", 25, 24);
            dh.ve("╬", 25, 26);
            dh.ve("╬", 25, 28);
            dh.ve("╬", 25, 30);
            dh.ve("╬", 25, 32);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                   CAC CHUC NANG             ", 25, 14);
            dh.ve("F1", 22, 17);
            dh.ve("F2", 22, 19);
            dh.ve("F3", 22, 21);
            dh.ve("F4", 22, 23);
            dh.ve("F5", 22, 25);
            dh.ve("F6", 22, 27);
            dh.ve("F7", 22, 29);
            dh.ve("F8", 22, 31);
            dh.ve("F9", 22, 33);

            dh.ve("Quan Ly Day Phong", 32, 17);
            dh.ve("Quan Ly Phong", 32, 19);
            dh.ve("Quan Ly Sinh Vien", 32, 21);
            dh.ve("Quan Ly Thue-Tra Phong", 32, 23);
            dh.ve("Quan Ly Dich Vu Dien-Nuoc", 32, 25);
            dh.ve("Thong ke", 32, 27);
            dh.ve("Tim Kiem", 32, 29);
            dh.ve("Thong Tin Khac", 32, 31);
            dh.ve("Thong Tin Phan Mem", 32, 33);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Nhan F11 de dang xuat", 19, 37);
            dh.ve("Thoat khoi chuong trinh nhan Esc", 19, 38);
            dh.ve("Ban Nhap Phim Chuc Nang: ", 60, 39);
       den1: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    dayphong.ChucNangDayPhong();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    phong.ChucNangPhong();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    sinhvien.ChucNangQLSinhVien();
                    break;
                case ConsoleKey.F4:
                    Console.Clear();
                    thuetra.ThueTra();
                    break;
                case ConsoleKey.F5:
                    Console.Clear();
                    diennuoc.FormDichVu();
                    break;
                case ConsoleKey.F6:
                    Console.Clear();
                    thongke.ThongKe();
                    break;
                case ConsoleKey.F7:
                    Console.Clear();
                    timkiem.ChucNangTimKiem();
                    break;
                case ConsoleKey.F8:
                    Console.Clear();
                    Thongtinkhac.ThongTinKhac();
                    break;
                case ConsoleKey.F9:
                    Console.Clear();
                    CongCu.trogiup();
                    break;
                case ConsoleKey.F11:
                    Console.Clear();
                    dangnhap1.Dangnhap();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap sai phim chuc nang!!!", 19, 35);
                    goto den1;
            }
        }
    }
}
