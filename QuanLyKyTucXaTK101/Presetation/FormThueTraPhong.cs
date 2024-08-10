using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormThueTraPhong
    {
        ThuePhongBLL ThuePHBLL = new ThuePhongBLL();
        TraPhongBLL TraPHBLL = new TraPhongBLL();
        PhongBLL PBLL = new PhongBLL();
        DoHoa dh = new DoHoa(100, 50);
        public static MenuChinh menu = new MenuChinh();
        SinhVienBLL SVBLL = new SinhVienBLL();
        HoaDonThanhToanBLL HDBLL = new HoaDonThanhToanBLL();
        public void ThueTra()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 39);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 39);

            for (int i = 1; i < 39; ++i)
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
            dh.ve("╚", 4, 37);
            dh.ve("╗", 95, 5);
            dh.ve("╝", 95, 37);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 5);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 37);

            for (int i = 6; i < 37; ++i)
            {
                dh.ve("║", 4, i);
                dh.ve("║", 95, i);
            }
            ///====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;

            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 38);

            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            dh.ve("╔", 19, 16);
            dh.ve("╚", 19, 24);
            dh.ve("╗", 79, 16);
            dh.ve("╝", 79, 24);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 16);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 24);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve("║", 19, i);
                dh.ve("║", 79, i);
            }
            dh.ve("╠", 19, 20);
            dh.ve("╠", 19, 22);


            dh.ve("╣", 79, 22);
            dh.ve("╣", 79, 20);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 22);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 20);


            for (int i = 21; i < 24; ++i)
            {
                dh.ve("║", 27, i);
            }

            dh.ve("╦", 27, 20);
            dh.ve("╩", 27, 24);
            dh.ve("╬", 27, 22);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Chuc Nang Quan Ly Thue Tra", 35, 18);
            dh.ve("F1", 23, 21); dh.ve("Quan Ly Thue Phong", 35, 21);
            dh.ve("F2", 23, 23); dh.ve("Quan Ly Tra Phong", 35, 23);;
            dh.ve("Tro lai chuong trinh nhan F12", 19, 26);
            dh.ve("Thoat chuong trinh nhan   Esc", 19, 27);
            dh.ve("Ban chon phim chuc nang: ", 19, 28);
        tem:
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    ChucNangThuePhong();
                    break;
                case ConsoleKey.F2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    ChucNangTraPhong();
                    break;

                case ConsoleKey.F12:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang!!!", 23, 30);
                    goto tem;
            }
        }
        public void ChucNangThuePhong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 39);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 39);

            for (int i = 1; i < 39; ++i)
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
            dh.ve("╚", 4, 37);
            dh.ve("╗", 95, 5);
            dh.ve("╝", 95, 37);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 5);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 37);

            for (int i = 6; i < 37; ++i)
            {
                dh.ve("║", 4, i);
                dh.ve("║", 95, i);
            }
            ///====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;

            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 38);

            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            dh.ve("╔", 19, 16);
            dh.ve("╚", 19, 24);
            dh.ve("╗", 79, 16);
            dh.ve("╝", 79, 24);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 16);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 24);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve("║", 19, i);
                dh.ve("║", 79, i);
            }
            dh.ve("╠", 19, 20);
            dh.ve("╠", 19, 22);


            dh.ve("╣", 79, 22);
            dh.ve("╣", 79, 20);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 22);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 20);


            for (int i = 21; i < 24; ++i)
            {
                dh.ve("║", 27, i);
            }

            dh.ve("╦", 27, 20);
            dh.ve("╩", 27, 24);
            dh.ve("╬", 27, 22);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Chuc Nang Quan Ly Thue Phong", 35, 18);
            dh.ve("F1", 23, 21); dh.ve("Them Ho So Thue Phong", 35, 21);
            dh.ve("F2", 23, 23); dh.ve("Hien Thi Danh Sach Ho So Thue Phong", 35, 23);
            dh.ve("Tro lai chuong trinh nhan F12", 19, 25);
            dh.ve("Tro lai Menu chinh nhan F10", 19, 26);
            dh.ve("Thoat chuong trinh nhan Esc", 19, 27);
            dh.ve("Ban chon phim chuc nang: ", 19, 28);
        tem:
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    ThuePhong();
                    break;
                case ConsoleKey.F2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    DanhSachThuePhong();
                    break;
                case ConsoleKey.F12:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    ThueTra();
                    break;
                case ConsoleKey.F10:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang!!!", 23, 30);
                    goto tem;
            }

        }
        public void ChucNangTraPhong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 39);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 39);

            for (int i = 1; i < 39; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***QUAN LY KY TUC XA    ***      ", 2, 1);
            /////===============================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 4, 5);
            dh.ve("╚", 4, 37);
            dh.ve("╗", 95, 5);
            dh.ve("╝", 95, 37);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 5);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 37);

            for (int i = 6; i < 37; ++i)
            {
                dh.ve("║", 4, i);
                dh.ve("║", 95, i);
            }
            ///====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;

            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 3, 38);

            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            dh.ve("╔", 19, 16);
            dh.ve("╚", 19, 24);
            dh.ve("╗", 79, 16);
            dh.ve("╝", 79, 24);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 16);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 24);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve("║", 19, i);
                dh.ve("║", 79, i);
            }
            dh.ve("╠", 19, 20);
            dh.ve("╠", 19, 22);


            dh.ve("╣", 79, 22);
            dh.ve("╣", 79, 20);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 22);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 20);


            for (int i = 21; i < 24; ++i)
            {
                dh.ve("║", 27, i);
            }

            dh.ve("╦", 27, 20);
            dh.ve("╩", 27, 24);
            dh.ve("╬", 27, 22);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Chuc Nang Quan Ly Tra Phong", 35, 18);
            dh.ve("F1", 23, 21); dh.ve("Them Ho So Tra Phong", 35, 21);
            dh.ve("F2", 23, 23); dh.ve("Hien Thi Danh Sach Ho So Tra Phong", 35, 23);
            dh.ve("Tro lai chuong trinh nhan F12", 19, 26);
            dh.ve("Tro lai Menu chinh nhan F10", 19, 26);
            dh.ve("Thoat chuong trinh nhan Esc", 19, 27);
            dh.ve("Ban chon phim chuc nang: ", 19, 28);
        tem:
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    TraPhong();
                    break;
                case ConsoleKey.F2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    DanhSachTraPhong();
                    break;
                case ConsoleKey.F12:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    ThueTra();
                    break;
                case ConsoleKey.F10:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang!!!", 23, 30);
                    goto tem;
            }
        }
        public void ThuePhong()
        {
          tmp:  Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 54);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 54);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            dh.ve("                 THUE PHONG", 26, 4);
            dh.ve("                ─────────────────", 24, 5);
            //-----------------------DANH SACH TIM KIEM
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 3, 15);
            dh.ve("╚", 3, 45);
            dh.ve("╗", 97, 15);
            dh.ve("╝", 97, 45);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 15);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 17);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 19);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 45);

            for (int i = 16; i < 45; ++i)
            {
                dh.ve("║", 3, i);
                dh.ve("║", 97, i);
            }
            dh.ve("╠", 3, 17);
            dh.ve("╣", 97, 17);
            dh.ve("╠", 3, 19);
            dh.ve("╣", 97, 19);
            for (int i = 18; i < 45; ++i)
            {
                dh.ve("║", 13, i);
                dh.ve("║", 28, i);
                dh.ve("║", 43, i);
                dh.ve("║", 57, i);
                dh.ve("║", 67, i);
                dh.ve("║", 77, i);
                dh.ve("║", 87, i);
            }
            dh.ve("╦", 13, 17);
            dh.ve("╦", 28, 17);
            dh.ve("╦", 43, 17);
            dh.ve("╦", 57, 17);
            dh.ve("╦", 67, 17);
            dh.ve("╦", 77, 17);
            dh.ve("╦", 87, 17);
            dh.ve("╩", 13, 45);
            dh.ve("╩", 28, 45);
            dh.ve("╩", 43, 45);
            dh.ve("╩", 57, 45);
            dh.ve("╩", 67, 45);
            dh.ve("╩", 77, 45);
            dh.ve("╩", 87, 45);
            dh.ve("╬", 13, 19);
            dh.ve("╬", 28, 19);
            dh.ve("╬", 43, 19);
            dh.ve("╬", 57, 19);
            dh.ve("╬", 67, 19);
            dh.ve("╬", 77, 19);


            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Nhap MaSV can thue: ", 5, 9);
            dh.ve("Nhap MaPH can thue: ", 55, 9);
            dh.ve("DANH SACH PHONG CON TRONG", 35, 16);
            dh.ve("MAPH", 7, 18);
            dh.ve("TEN PHONG", 16, 18);
            dh.ve("LOAI PHONG", 31, 18);
            dh.ve("TINH TRANG", 45, 18);
            dh.ve("GIA PHONG", 58, 18);
            dh.ve("SUC CHUA", 69, 18);
            dh.ve("SVHT", 80, 18);
            dh.ve("MA DAY", 89, 18);
        nhapmasv:
            int masv;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                dh.ve("", 25, 9);
                masv = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 25, 14);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                   ", 25, 14);
                        dh.ve("                 ", 25, 9);
                        Console.ResetColor();
                        goto nhapmasv;
                }
            }
            if (SVBLL.KTMaSinhVien(masv)==false)
            {
                if (SVBLL.KiemTraSVConThuePH(masv))
                {
                    Node<Phong> tg2 = PBLL.TimKiemPhongConTrong().Head;
                    int a2 = 22;
                    int tmp2 = 0;
                    while (tg2 != null)
                    {
                        if(SVBLL.KiemTraGioiTinh(masv))
                        {
                            if ((tg2.Data.Loaiphong.ToUpper() == "NAM") && (tmp2 < 10))
                            {
                                dh.ve("", 5, a2);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" {0,-10}{1,-16}{2,-13}{3,-14}{4,-13}{5,-9}{6,-9}{7,-5}", tg2.Data.Maphong, tg2.Data.Tenphong, tg2.Data.Loaiphong, tg2.Data.Tinhtrang, tg2.Data.Giaphong, tg2.Data.Succhua, tg2.Data.Sosinhvienhientai, tg2.Data.Maday);
                                Console.ForegroundColor = ConsoleColor.Green;
                                dh.ve("║ ", 13, a2); dh.ve("║ ", 28, a2); dh.ve("║ ", 43, a2); dh.ve("║ ", 57, a2); dh.ve("║ ", 67, a2); dh.ve("║ ", 77, a2); dh.ve("║ ", 87, a2);
                                tg2 = tg2.Link;
                                tmp2++;
                                a2 = a2 + 2;
                            }
                            else
                                tg2 = tg2.Link;
                        }
                        else
                        {
                            if ((tg2.Data.Loaiphong.ToUpper() == "NU") && (tmp2 < 10))
                            {
                                dh.ve("", 5, a2);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" {0,-10}{1,-16}{2,-13}{3,-14}{4,-13}{5,-9}{6,-9}{7,-5}", tg2.Data.Maphong, tg2.Data.Tenphong, tg2.Data.Loaiphong, tg2.Data.Tinhtrang, tg2.Data.Giaphong, tg2.Data.Succhua, tg2.Data.Sosinhvienhientai, tg2.Data.Maday);
                                Console.ForegroundColor = ConsoleColor.Green;
                                dh.ve("║ ", 13, a2); dh.ve("║ ", 28, a2); dh.ve("║ ", 43, a2); dh.ve("║ ", 57, a2); dh.ve("║ ", 67, a2); dh.ve("║ ", 77, a2); dh.ve("║ ", 87, a2);
                                tg2 = tg2.Link;
                                tmp2++;
                                a2 = a2 + 2;
                            }
                            else
                                tg2 = tg2.Link;
                        }
                      
                    }
                nhapmaphong: int maphong;
                    Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    dh.ve("", 75, 9);  maphong = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong phai la kieu so! nhan phim bat ki de nhap lai", 25, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 25, 14);
                            dh.ve("                   ", 75, 9);
                            Console.ResetColor();
                            goto nhapmaphong;
                    }
                }
                    if (PBLL.KTMaPhongTrong(maphong))
                    {
                        dh.ve("De cho thue tiep              Enter", 60, 47);
                        dh.ve("Cho thue phong va tro lai     BackSpace", 60, 48);
                        dh.ve("Tro Lai Chuong Trinh          F12", 60, 49);
                        dh.ve("Tro Lai Menu Chinh            F10", 60, 50);
                        dh.ve("Thoat Khoi Chuong Trinh       Esc", 60, 51);
                        dh.ve("Ban chon mot phim chuc nang   ", 60, 52);
                        System.DateTime ngaythue = System.DateTime.Now;
                        ThuePhong thuephong = new ThuePhong(ThuePHBLL.GetID(), masv, maphong, ngaythue);
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.Clear();
                                ThuePHBLL.ThemSVThuePhong(thuephong);
                                PBLL.UpdateSoSVHT(maphong);
                                goto tmp;
                            case ConsoleKey.Backspace:
                                ThuePHBLL.ThemSVThuePhong(thuephong);
                                PBLL.UpdateSoSVHT(maphong);
                                Console.Clear();
                                ChucNangThuePhong();
                                break;
                            case ConsoleKey.Escape:
                                return;
                            case ConsoleKey.F10:
                                Console.Clear();
                                menu.MenuChinh1();
                                break;
                            case ConsoleKey.F12:
                                Console.Clear();
                                ChucNangThuePhong();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ma phong khong ton tai trong he thong hoac da day! Enter de nhap lai ", 10, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                             ", 10, 53);
                                dh.ve("            ", 75, 9);
                                Console.ResetColor();
                                goto nhapmaphong;
                            default:
                                Console.Clear();
                                ChucNangThuePhong();
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Sinh vien nay hien van dang thue phong! Enter de nhap lai ma khac ", 10, 53);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo k1 = Console.ReadKey();
                    switch (k1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                                  ", 10, 53);
                            dh.ve("                     ",25, 9);
                            Console.ResetColor();
                            goto nhapmasv;
                        default:
                            Console.Clear();
                            ChucNangThuePhong();
                            break;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma sinh vien khong ton tai trong he thong! Enter de nhap lai ", 10, 53);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                      dh.ve("                                                                                  ", 10, 53);
                      dh.ve("                     ", 25, 9);
                      Console.ResetColor();
                      goto nhapmasv;
                    default:
                      Console.Clear();
                      ChucNangThuePhong();
                      break;
                }
            }
        }
        public void DanhSachThuePhong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 54);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 54);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);
            dh.ve("╔", 9, 10);
            dh.ve("╚", 9, 37);
            dh.ve("╗", 89, 10);
            dh.ve("╝", 89, 37);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 10);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 13);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 37);

            for (int i = 11; i < 37; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 13);
            dh.ve("╣", 89, 13);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 15);
            dh.ve("╠", 9, 15);
            dh.ve("╣", 89, 15);
            for (int i = 14; i < 37; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 40, i);
                dh.ve("║", 60, i);
            }
            dh.ve("╦", 20, 13);
            dh.ve("╦", 40, 13);
            dh.ve("╦", 60, 13);
            dh.ve("╩", 20, 37);
            dh.ve("╩", 40, 37);
            dh.ve("╩", 60, 37);
            dh.ve("╬", 20, 15);
            dh.ve("╬", 40, 15);
            dh.ve("╬", 60, 15);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            dh.ve("                         THUE PHONG", 20, 5);
            dh.ve("                   ─────────────", 24, 6);
            dh.ve("                DANH SACH THUE PHONG", 23, 11);
            dh.ve("ID Thue", 11, 14);
            dh.ve("Ma Sinh Vien", 23, 14);
            dh.ve("Ma Phong", 45, 14);
            dh.ve("Ngay Thue Phong", 66, 14);
            dh.ve("Tro Lai Chuong Trinh          F12", 60, 40);
            dh.ve("Tro Lai Menu Chinh            F10", 60, 41);
            dh.ve("Thoat Khoi Chuong Trinh       Esc", 60, 42);
            dh.ve("Ban chon mot phim chuc nang   ", 60, 43);
            Node<ThuePhong> tg = ThuePHBLL.GetAllData().Head;
            int soluonghoso = 1;
            while (tg.Link != null)
            {
                soluonghoso++;
                tg = tg.Link;
            }
            if (soluonghoso > 0)
            {
                int sodong = 10;
                int tongsotrang;
                if (soluonghoso >= sodong)
                {
                    tongsotrang = soluonghoso % sodong == 0 ? soluonghoso / sodong : soluonghoso / sodong + 1;
                }
                else
                    tongsotrang = 1;
                int trang = 1;
            
            //Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            den1:   
                VeTrangthuephong(trang);
            Console.ForegroundColor = ConsoleColor.White;
                dh.ve("", 68, 38); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                goto den;
            den :do
                    {
                        
                        dh.ve("", 90, 43);
                        ConsoleKeyInfo phim;
                        phim = Console.ReadKey();
                        switch (phim.Key)
                        {
                               
                            case ConsoleKey.LeftArrow:
                                {
                                    if (trang == 1)
                                    {
                                        trang = 1;
                                        goto den;
                                    }
                                    else
                                    {
                                        trang--;
                                        goto den1;
                                    }
                                   
                                }
                            case ConsoleKey.RightArrow:
                                {
                                    if (trang == tongsotrang)
                                    {
                                        trang = tongsotrang;
                                        goto den;
                                    }
                                    else
                                    {
                                        trang++;
                                        goto den1;
                                    }
                                   
                                }
                         case ConsoleKey.F12:
                                Console.Clear();
                                ChucNangThuePhong();
                                break;
                         case ConsoleKey.F10:
                                Console.Clear();
                                menu.MenuChinh1();
                                break;
                            case ConsoleKey.Escape:
                                return;
                        }
                    } while (true);
                }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve(" ==>Hien Tai Trong He Thong khong co ho so thue phong nao!", 10, 35);
            }
        }
        public void VeTrangthuephong(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 17; i < 36; ++i)
            {
                dh.ve("        ", 10, i);
                dh.ve("                   ", 21, i);
                dh.ve("                   ", 41 , i);
                dh.ve("                        ",61 , i);
            }
            Console.ResetColor();
            int a = 17;//vi tri ve bat dau cua dong dau tien
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<ThuePhong> tg1 = ThuePHBLL.GetAllData().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                    dh.ve("", 12, a);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg1.Data.Id), 14, a);
                    dh.ve(Convert.ToString(tg1.Data.Masv), 28, a);
                    dh.ve(Convert.ToString(tg1.Data.Maphong), 48, a);
                    dh.ve(Convert.ToString(tg1.Data.Ngaythue.Day + "/" + tg1.Data.Ngaythue.Month + "/"+tg1.Data.Ngaythue.Year), 69, a);
                    tg1 = tg1.Link;
                    a = a + 2;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        }
        public void DanhSachTraPhong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 54);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 54);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);
            dh.ve("╔", 9, 10);
            dh.ve("╚", 9, 37);
            dh.ve("╗", 89, 10);
            dh.ve("╝", 89, 37);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 10);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 13);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 37);

            for (int i = 11; i < 37; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 13);
            dh.ve("╣", 89, 13);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 15);
            dh.ve("╠", 9, 15);
            dh.ve("╣", 89, 15);
            for (int i = 14; i < 37; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 40, i);
                dh.ve("║", 60, i);
            }
            dh.ve("╦", 20, 13);
            dh.ve("╦", 40, 13);
            dh.ve("╦", 60, 13);
            dh.ve("╩", 20, 37);
            dh.ve("╩", 40, 37);
            dh.ve("╩", 60, 37);
            dh.ve("╬", 20, 15);
            dh.ve("╬", 40, 15);
            dh.ve("╬", 60, 15);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            dh.ve("                         TRA PHONG", 20, 5);
            dh.ve("                   ─────────────", 24, 6);
            dh.ve("                DANH SACH TRA PHONG", 23, 11);
            dh.ve("ID Tra", 11, 14);
            dh.ve("Ma Sinh Vien", 23, 14);
            dh.ve("Ma Phong", 45, 14);
            dh.ve("Ngay Tra Phong", 67, 14);

            dh.ve("Tro Lai Chuong Trinh          F12", 60, 41);
            dh.ve("Tro Lai Menu Chinh            F10", 60, 42);
            dh.ve("Thoat Khoi Chuong Trinh       Esc", 60, 43);
            dh.ve("Ban chon mot phim chuc nang   ", 60, 44);
            Node<TraPhong> tg = TraPHBLL.GetAllData().Head;
            int soluonghoso = 1;
            while (tg.Link != null)
            {
                soluonghoso++;
                tg = tg.Link;
            }
            if (soluonghoso > 0)
            {
                int sodong = 10;
                int tongsotrang;
                if (soluonghoso >= sodong)
                {
                    tongsotrang = soluonghoso % sodong == 0 ? soluonghoso / sodong : soluonghoso / sodong + 1;
                }
                else
                    tongsotrang = 1;
                int trang = 1;
                Console.ForegroundColor = ConsoleColor.White;
            den1:   
                VeTrangtraphong(trang);
            Console.ForegroundColor = ConsoleColor.White;
                dh.ve("", 68, 39); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                goto den;
            den :do
                    {
                        
                        dh.ve("", 90, 44);
                        ConsoleKeyInfo phim;
                        phim = Console.ReadKey();
                        switch (phim.Key)
                        {
                               
                            case ConsoleKey.LeftArrow:
                                {
                                    if (trang == 1)
                                    {
                                        trang = 1;
                                        goto den;
                                    }
                                    else
                                    {
                                        trang--;
                                        goto den1;
                                    }
                                   
                                }
                            case ConsoleKey.RightArrow:
                                {
                                    if (trang == tongsotrang)
                                    {
                                        trang = tongsotrang;
                                        goto den;
                                    }
                                    else
                                    {
                                        trang++;
                                        goto den1;
                                    }
                                   
                                }
                         case ConsoleKey.F12:
                                Console.Clear();
                                ChucNangTraPhong();
                                break;
                         case ConsoleKey.F10:
                                Console.Clear();
                                menu.MenuChinh1();
                                break;
                            case ConsoleKey.Escape:
                                return;
                        }
                    } while (true);
                }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve(" ==>Hien Tai Trong He Thong khong co ho so thue phong nao!", 10, 35);
            }
        }
        public void VeTrangtraphong(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 17; i < 36; ++i)
            {
                dh.ve("        ", 10, i);
                dh.ve("                   ", 21, i);
                dh.ve("                   ", 41 , i);
                dh.ve("                        ",61 , i);
            }
            Console.ResetColor();
            int a = 17;//vi tri ve bat dau cua dong dau tien
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<TraPhong> tg1 = TraPHBLL.GetAllData().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                    dh.ve("", 12, a);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg1.Data.Id), 14, a);
                    dh.ve(Convert.ToString(tg1.Data.Masv), 28, a);
                    dh.ve(Convert.ToString(tg1.Data.Maphong), 48, a);
                    dh.ve(Convert.ToString(tg1.Data.Ngaytra.Day + "/" + tg1.Data.Ngaytra.Month + "/"+tg1.Data.Ngaytra.Year), 69, a);
                    tg1 = tg1.Link;
                    a = a + 2;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        }
        public void TraPhong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 54);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 54);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);

            //Danh Sach Tra Phong
            dh.ve("╔", 9, 15);
            dh.ve("╚", 9, 42);
            dh.ve("╗", 89, 15);
            dh.ve("╝", 89, 42);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 15);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 18);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 42);

            for (int i = 16; i < 42; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 18);
            dh.ve("╣", 89, 18);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 20);
            dh.ve("╠", 9, 20);
            dh.ve("╣", 89, 20);
            for (int i = 19; i < 42; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 40, i);
                dh.ve("║", 60, i);
            }
            dh.ve("╦", 20, 18);
            dh.ve("╦", 40, 18);
            dh.ve("╦", 60, 18);
            dh.ve("╩", 20, 42);
            dh.ve("╩", 40, 42);
            dh.ve("╩", 60, 42);
            dh.ve("╬", 20, 20);
            dh.ve("╬", 40, 20);
            dh.ve("╬", 60, 20);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***CHUONG TRINH QUAN LY KY TUC XA TRUONG DAI HOC SPKT HUNG YEN***      ", 2, 1);
            dh.ve("                    TRA PHONG", 26, 4);
            dh.ve("                    ─────────────", 24, 5);
            dh.ve("Nhap ma SV can tra phong:", 35, 9);
            dh.ve("                DANH SACH TRA PHONG", 20, 16);
            dh.ve("ID Tra", 11, 19);
            dh.ve("Ma Sinh Vien", 23, 19);
            dh.ve("Ma Phong", 45, 19);
            dh.ve("Ngay Tra Phong", 67, 19);
          tmp:   int a = 22;//vi tri ve bat dau cua dong dau tien
            int dem1 = 0;//chi so dem den day phong thu i
            Node<TraPhong> tg1 = TraPHBLL.GetAllData().Head;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 <= 10))
                {
                    dh.ve("", 12, a);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg1.Data.Id), 14, a);
                    dh.ve(Convert.ToString(tg1.Data.Masv), 28, a);
                    dh.ve(Convert.ToString(tg1.Data.Maphong), 48, a);
                    dh.ve(Convert.ToString(tg1.Data.Ngaytra.Day + "/" + tg1.Data.Ngaytra.Month + "/" + tg1.Data.Ngaytra.Year), 69, a);
                    tg1 = tg1.Link;
                    a = a + 2;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        nhapmasv: int masvcantraphong;
            try
            {
                dh.ve("", 61, 9);
                 masvcantraphong = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 25, 14);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                   ", 25, 14);
                        dh.ve("                       ", 61, 9);
                        Console.ResetColor();
                        goto nhapmasv;
                }
            }
            DateTime ngayhethong=DateTime.Now;
            if (SVBLL.KTMaSinhVien(masvcantraphong) == false)
            {
                if (SVBLL.KiemTraSVConThuePH(masvcantraphong) == false)
                {
                    if (HDBLL.KiemTradathanhtoanKTX(masvcantraphong, ngayhethong))
                    {
                        dh.ve("De them sinh vien tra phong   Enter", 60, 44);
                        dh.ve("Them SV tra phong va  tro lai BackSpace", 60, 45);
                        dh.ve("Tro Lai Chuong Trinh          F12", 60, 46);
                        dh.ve("Tro Lai Menu Chinh            F10", 60, 47);
                        dh.ve("Thoat Khoi Chuong Trinh       Esc", 60, 48);
                        dh.ve("Ban chon mot phim chuc nang   ", 60, 50);
                        System.DateTime ngaytra = System.DateTime.Now;
                        TraPhong traphong = new TraPhong(TraPHBLL.GetID(), masvcantraphong, ThuePHBLL.NhanMaPhong(masvcantraphong), ngaytra);
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Enter:
                                TraPHBLL.ThemSVTraPhong(traphong);
                                PBLL.UpdateSoSVHT(ThuePHBLL.NhanMaPhong(masvcantraphong));
                                for (int i = 22; i < 41; ++i)
                                {
                                    dh.ve("        ", 10, i);
                                    dh.ve("                   ", 21, i);
                                    dh.ve("                   ", 41, i);
                                    dh.ve("                        ", 61, i);
                                }
                                dh.ve("                                   ", 60, 44);
                                dh.ve("                                       ", 60, 45);
                                dh.ve("                                          ", 60, 46);
                                dh.ve("                                   ", 60, 47);
                                dh.ve("                                   ", 60, 48);
                                dh.ve("                                   ", 60, 50);
                                dh.ve("                  ", 61, 9);
                                goto tmp;
                            case ConsoleKey.Backspace:
                                TraPHBLL.ThemSVTraPhong(traphong);
                                PBLL.UpdateSoSVHT(ThuePHBLL.NhanMaPhong(masvcantraphong));
                                Console.Clear();
                                ChucNangTraPhong();
                                break;
                            case ConsoleKey.Escape:
                                return;
                            case ConsoleKey.F10:
                                Console.Clear();
                                menu.MenuChinh1();
                                break;
                            case ConsoleKey.F12:
                                Console.Clear();
                                ChucNangTraPhong();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ma sinh vien nay chua thanh toan het tien! Nhan Enter de nhap lai ", 10, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo k = Console.ReadKey();
                        switch (k.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                                        ", 10, 52);
                                dh.ve("                     ", 61, 9);
                                Console.ResetColor();
                                goto nhapmasv;
                            default:
                                Console.Clear();
                                ChucNangThuePhong();
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma sinh vien nay da tra phong! Enter de nhap lai ", 10, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo k = Console.ReadKey();
                    switch (k.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                                  ", 10, 52);
                            dh.ve("                     ", 61, 9);
                            Console.ResetColor();
                            goto nhapmasv;
                        default:
                            Console.Clear();
                            ChucNangThuePhong();
                            break;
                    }
                }
            }
            else
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma sinh vien khong ton tai trong he thong! Enter de nhap lai ", 10, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo k = Console.ReadKey();
                    switch (k.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                                  ", 10, 52);
                            dh.ve("                     ", 61, 9);
                            Console.ResetColor();
                            goto nhapmasv;
                        default:
                            Console.Clear();
                            ChucNangThuePhong();
                            break;
                    }
                }
            }
        }
    }
