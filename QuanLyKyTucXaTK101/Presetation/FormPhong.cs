using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormPhong
    {
        DoHoa dh = new DoHoa(100,55);
        PhongBLL p = new PhongBLL();
        DayPhongBLL DPBLL = new DayPhongBLL();
        public static MenuChinh menu = new MenuChinh();
        public void ChucNangPhong()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
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
            dh.ve("╔", 19, 12);
            dh.ve("╚", 19, 24);
            dh.ve("╗", 79, 12);
            dh.ve("╝", 79, 24);

            dh.ve("═══════════════════════════════════════════════════════════", 20, 12);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 24);

            for (int i = 13; i < 24; ++i)
            {
                dh.ve("║", 19, i);
                dh.ve("║", 79, i);
            }
            dh.ve("╠", 19, 20);
            dh.ve("╠", 19, 22);
            dh.ve("╠", 19, 18);
            dh.ve("╠", 19, 16);
            dh.ve("╣", 79, 22);
            dh.ve("╣", 79, 20);
            dh.ve("╣", 79, 18);
            dh.ve("╣", 79, 16);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 22);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 20);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 18);
            dh.ve("═══════════════════════════════════════════════════════════", 20, 16);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve("║", 27, i);
            }
            dh.ve("╦", 27, 16);
            dh.ve("╩", 27, 24);
            dh.ve("╬", 27, 22);
            dh.ve("╬", 27, 20);
            dh.ve("╬", 27, 18);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("CAC CHUC NANG QUAN LY PHONG", 37, 14);
            dh.ve("F1", 23, 17); dh.ve("Them Phong", 35, 17);
            dh.ve("F2", 23, 19); dh.ve("Sua Phong", 35, 19);
            dh.ve("F3", 23, 21); dh.ve("Xoa Phong", 35, 21);
            dh.ve("F4", 23, 23); dh.ve("Hien Thi Thong Tin Phong", 35, 23);
            dh.ve("Tro ve nhan F10", 23, 27);
            dh.ve("Thoat khoi chuong trinh nhan Esc", 23, 28);
            dh.ve("Ban nhap mot phim chuc nang: ", 45, 35);
           tem: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                      Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    ThemPhong();
                    break;
                case ConsoleKey.F2:
                      Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    SuaPhong();
                    break;
                case ConsoleKey.F3:
                      Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    XoaPhong();
                    break;
                case ConsoleKey.F4:
                      Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    HienThi();
                    break;
                case ConsoleKey.F10:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor=ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang!!!", 23, 29);
                    goto tem;
            }
        }
        #region Them phong
        public void ThemPhong()
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
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("              ***  QUAN LY KY TUC XA  ***      ", 2, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 5);
            dh.ve("╚", 9, 16);
            dh.ve("╗", 89, 5);
            dh.ve("╝", 89, 16);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 5);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 7);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 16);
            for (int i = 6; i < 16; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 7);
            dh.ve("╣", 89, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 17);
            dh.ve("╠", 0, 17);
            dh.ve("╣", 99, 17);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("THEM PHONG", 45, 6);
            dh.ve("Ma Phong: ", 11, 9);
            dh.ve("Ten Phong: ", 30, 9);
            dh.ve("Loai Phong: ", 70, 9);
            dh.ve("Tinh Trang: ", 11, 12);
            dh.ve("Gia Phong: ", 37, 12);
            dh.ve("Suc Chua: ", 70, 12);
            dh.ve("Ma Day: ", 30, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 3, 19);
            dh.ve("╚", 3, 45);
            dh.ve("╗", 97, 19);
            dh.ve("╝", 97, 45);
            
                dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 19);
                dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 21);
                dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 23);
                dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 45);
            
            for (int i = 20; i < 45; ++i)
            {
                dh.ve("║", 3, i);
                dh.ve("║", 97, i);
            }
            dh.ve("╠", 3, 21);
            dh.ve("╣", 97, 21);
            dh.ve("╠", 3, 23);
            dh.ve("╣", 97, 23);
            for (int i = 22; i < 45; ++i)
            {
                dh.ve("║", 13, i);
                dh.ve("║", 28, i);
                dh.ve("║", 43, i);
                dh.ve("║", 57, i);
                dh.ve("║", 67, i);
                dh.ve("║", 77, i);
                dh.ve("║", 87, i);
            }
            dh.ve("╦", 13, 21);
            dh.ve("╦", 28, 21);
            dh.ve("╦", 43, 21);
            dh.ve("╦", 57, 21);
            dh.ve("╦", 67, 21);
            dh.ve("╦", 77, 21);
            dh.ve("╦", 87, 21);
            dh.ve("╩", 13, 45);
            dh.ve("╩", 28, 45);
            dh.ve("╩", 43, 45);
            dh.ve("╩", 57, 45);
            dh.ve("╩", 67, 45);
            dh.ve("╩", 77, 45);
            dh.ve("╩", 87, 45);
            dh.ve("╬", 13, 23);
            dh.ve("╬", 28, 23);
            dh.ve("╬", 43, 23);
            dh.ve("╬", 57, 23);
            dh.ve("╬", 67, 23);
            dh.ve("╬", 77, 23);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH PHONG TRONG KY TUC XA", 35, 20);
            dh.ve("MAPH", 7, 22);
            dh.ve("TEN PHONG", 16, 22);
            dh.ve("LOAI PHONG", 31, 22);
            dh.ve("TINH TRANG", 45, 22);
            dh.ve("GIA PHONG", 58, 22);
            dh.ve("SUC CHUA", 69, 22);
            dh.ve("SVHT", 80, 22);
            dh.ve("MA DAY", 89, 22);
          den:  Node<Phong> tg = p.TTPhong().Head;
            int a = 24;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg.Data.Maphong), 7, a);
                    dh.ve(tg.Data.Tenphong, 16, a);
                    dh.ve(tg.Data.Loaiphong, 34, a);
                    dh.ve(tg.Data.Tinhtrang, 45, a);
                    dh.ve(Convert.ToString(tg.Data.Giaphong), 60, a);
                    dh.ve(Convert.ToString(tg.Data.Succhua ), 72, a);
                    dh.ve(Convert.ToString(tg.Data.Sosinhvienhientai ), 82, a);
                    dh.ve(Convert.ToString(tg.Data.Maday), 92, a);
                    tmp++;
                    a = a + 2;
                    tg = tg.Link;
                }
                else break;
            }
      maph:int maphong;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("", 20, 9);
                try
                {
                  maphong = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 15, 52);
                            dh.ve("        ", 20, 9);
                            Console.ResetColor();
                            goto maph;
                    }
                }
                if (p.KTMaPhong(maphong))
                {
                tenph:  dh.ve("", 40, 9); string tenphong;
                     tenphong = Console.ReadLine();
                     if (tenphong == "")
                     {
                         ConsoleKeyInfo kt = Console.ReadKey();
                         dh.ve("day la thong tin bat buoc! nhan phim bat ki de nhap lai!", 15, 52);
                         switch (kt.Key)
                         {
                             case ConsoleKey.Enter:
                                 Console.BackgroundColor = ConsoleColor.Black;
                                 dh.ve("                                                         ", 15, 52);
                                 dh.ve("        ", 81, 9);
                                 Console.ResetColor();
                                 goto tenph;
                         }
                     }
                loaiphong: dh.ve("", 81, 9); string loaiphong;
                    loaiphong = Console.ReadLine();
                    if (loaiphong.ToLower() != "nam" && loaiphong.ToLower() != "nu")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Loai phong phai la nam hoac nu! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgt = Console.ReadKey();
                        switch (ktgt.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("        ", 81, 9);
                                Console.ResetColor();
                                goto loaiphong;
                        }
                    } 
                    dh.ve("", 22, 12); string tinhtrang = Console.ReadLine();
                    //=======================================================
                giaphong:  dh.ve("", 47, 12);double giaphong;
                try
                {
                    giaphong = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("gia phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 15, 52);
                            dh.ve("          ", 47, 12);
                            Console.ResetColor();
                            goto giaphong;
                    }
                }
                    if (giaphong <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Gia phong phai lon hon 0! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgp = Console.ReadKey();
                        switch (ktgp.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("           ", 47, 12);
                                Console.ResetColor();
                                goto giaphong;
                        }
                    }
                    //===========================================================
                succhua: dh.ve("", 79, 12);int succhua;
                try
                {
                    succhua = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Suc chua phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 15, 52);
                            dh.ve("         ", 79, 12);
                            Console.ResetColor();
                            goto succhua;
                    }
                }
                    if (succhua < 4||succhua>10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Suc chua chi tu 4 den 10! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgp = Console.ReadKey();
                        switch (ktgp.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("      ", 79, 12);
                                Console.ResetColor();
                                goto succhua;
                        }
                    }
                maday:
                    dh.ve("", 37, 15); int maday;
                try
                {
                    maday = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma day phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 15, 52);
                            dh.ve("          ", 37, 15);
                            Console.ResetColor();
                            goto maday;
                    }
                }
                    if (DPBLL.KTMaDayPhong(maday))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ma day khong ton tai! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktmd = Console.ReadKey();//kiem tra ma day
                        switch (ktmd.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("          ", 37, 15);
                                Console.ResetColor();
                                goto maday;
                        }
                    }
                    Phong ph = new Phong(maphong, tenphong, loaiphong, tinhtrang, giaphong, succhua,0, maday);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve("Tro lai chuong trinh nhan    F12", 10, 48);
                    dh.ve("Tro lai menu chinh nhan      F10", 10, 48);
                    dh.ve("Thoat khoi chuong trinh      Esc", 10, 49);
                    dh.ve("Nhan Enter de them tiep!!! ", 10, 50);
                    dh.ve("Nhan BacckSpace de luu va tro lai!!! ", 10, 51);
                    ConsoleKeyInfo kt2 = Console.ReadKey();
                    switch (kt2.Key)
                    {
                        case ConsoleKey.Enter:
                            p.Them(ph);
                             Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                          ", 10, 48);
                            dh.ve("                                                          ", 10, 49);
                            dh.ve("                                                          ", 9, 50);
                            dh.ve("                                                          ", 9, 51);

                            dh.ve("                             ", 10, 51);
                            for (int i = 24; i < 45; ++i)
                            {
                                dh.ve("        ", 4, i);
                                dh.ve("             ", 14, i);
                                dh.ve("             ", 29, i);
                                dh.ve("            ", 44, i);
                                dh.ve("        ", 58, i);
                                dh.ve("        ", 68, i);
                                dh.ve("        ", 78, i);
                                dh.ve("        ", 88, i);
                            }
                            dh.ve("          ", 20, 9);
                            dh.ve("                         ", 40, 9);
                            dh.ve("        ", 81, 9);
                            dh.ve("               ", 22, 12);
                            dh.ve("                       ", 47, 12);
                            dh.ve("         ", 79, 12);
                            dh.ve("         ", 19, 15);
                            dh.ve("          ", 37, 15);
                            Console.ResetColor();
                            goto den;
                     case ConsoleKey.Escape:
                            break;
                    case ConsoleKey.F12:
                      Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    ChucNangPhong();
                    break;
                        case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                    case ConsoleKey.Backspace:
                    p.Them(ph);
                    Console.Clear();
                    ChucNangPhong();
                    break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong da ton tai!!! Nhan Enter de nhap lai! ", 10, 50);
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                          ", 9, 50);
                             dh.ve("                               ", 10, 47);
                            dh.ve("                                            ", 10, 49);
                            dh.ve("                             ", 10, 51);
                            dh.ve("             ", 20, 9);
                            Console.ResetColor();
                            goto maph;
                        default:
                            Console.Clear();
                            ChucNangPhong();
                            break;
                    }
                }
            } while (true);
        }
        #endregion
        #region Hien thi danh sach phong
        public void HienThi()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
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
            /////==============================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 3, 9);
            dh.ve("╚", 3, 35);
            dh.ve("╗", 97, 9);
            dh.ve("╝", 97, 35);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 9);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 11);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 13);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 35);
            for (int i = 10; i < 35; ++i)
            {
                dh.ve("║", 3, i);
                dh.ve("║", 97, i);
            }
            dh.ve("╠", 3, 11);
            dh.ve("╣", 97, 11);
            dh.ve("╠", 3, 13);
            dh.ve("╣", 97, 13);
            for (int i = 12; i < 35; ++i)
            {
                dh.ve("║", 13, i);
                dh.ve("║", 28, i);
                dh.ve("║", 43, i);
                dh.ve("║", 57, i);
                dh.ve("║", 67, i);
                dh.ve("║", 77, i);
                dh.ve("║", 87, i);
            }
            dh.ve("╦", 13, 11);
            dh.ve("╦", 28, 11);
            dh.ve("╦", 43, 11);
            dh.ve("╦", 57, 11);
            dh.ve("╦", 67, 11);
            dh.ve("╦", 77, 11);
            dh.ve("╦", 87, 11);
            dh.ve("╩", 13, 35);
            dh.ve("╩", 28, 35);
            dh.ve("╩", 43, 35);
            dh.ve("╩", 57, 35);
            dh.ve("╩", 67, 35);
            dh.ve("╩", 77, 35);
            dh.ve("╩", 87, 35);
            dh.ve("╬", 13, 13);
            dh.ve("╬", 28, 13);
            dh.ve("╬", 43, 13);
            dh.ve("╬", 57, 13);
            dh.ve("╬", 67, 13);
            dh.ve("╬", 77, 13);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH PHONG TRONG KY TUC XA", 35, 10);
            dh.ve("MAPH", 7, 12);
            dh.ve("TEN PHONG", 16, 12);
            dh.ve("LOAI PHONG", 31, 12);
            dh.ve("TINH TRANG", 45, 12);
            dh.ve("GIA PHONG", 58, 12);
            dh.ve("SUC CHUA", 69, 12);
            dh.ve("SVHT", 80, 12);
            dh.ve("MA DAY", 89, 12);
            dh.ve("Tro lai nhan F12", 10, 36);
            dh.ve("Tro ve menu chinh nhan F10", 10, 37);
            dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 38);
            dh.ve("Ban chon phim chuc nang: ", 55, 38);
            Node<Phong>tg = p.TTPhong().Head;
            int soluongphong = 1;
            while (tg.Link != null)
            {
                soluongphong++;
                tg = tg.Link;
            }
            if (soluongphong > 0)
            {
                int sodong = 10;
                int tongsotrang;
                if (soluongphong >= sodong)
                {
                    tongsotrang = soluongphong % sodong == 0 ? soluongphong / sodong : soluongphong / sodong + 1;
                }
                else
                    tongsotrang = 1;
                int trang = 1;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            den1:
                VeTrang(trang);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("", 60, 36); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                goto den;
            den: do
                {

                    dh.ve("", 80, 38);
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
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangPhong();
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                } while (true);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Hien Tai Trong He Thong khong co phong Nao!", 10, 35);
            }
        }
        public void VeTrang(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 14; i < 35; ++i)
            {
                dh.ve("        ", 4, i);
                dh.ve("             ", 14, i);
                dh.ve("             ", 29, i);
                dh.ve("            ", 44, i);
                dh.ve("        ", 58, i);
                dh.ve("        ", 68, i);
                dh.ve("        ", 78, i);
                dh.ve("        ", 88, i);
            }
            Console.ResetColor();
            int a = 14;
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<Phong> tg1 = p.TTPhong().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                            Console.ForegroundColor = ConsoleColor.White;
                            dh.ve(Convert.ToString(tg1.Data.Maphong), 7, a);
                            dh.ve(tg1.Data.Tenphong, 16, a);
                            dh.ve(tg1.Data.Loaiphong, 34, a);
                            dh.ve(tg1.Data.Tinhtrang, 45, a);
                            dh.ve(Convert.ToString(tg1.Data.Giaphong), 60, a);
                            dh.ve(Convert.ToString(tg1.Data.Succhua), 72, a);
                            dh.ve(Convert.ToString(tg1.Data.Sosinhvienhientai), 82, a);
                            dh.ve(Convert.ToString(tg1.Data.Maday), 92, a);
                           dem++;
                            a = a + 2;
                            tg1 = tg1.Link;
                        }
                        else break;
                    }
              }
        #endregion
        #region Xoa Phong
        public void XoaPhong()
        {
            do
        {
        Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 41);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 41);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 41);
            for (int i = 1; i < 41; ++i)
            {
                dh.ve("║", 0, i);
                dh.ve("║", 99, i);
            }
            dh.ve("╠", 0, 3);
            dh.ve("╣", 99, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            /////==============================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 3, 9);
            dh.ve("╚", 3, 35);
            dh.ve("╗", 97, 9);
            dh.ve("╝", 97, 35);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 9);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 11);
                dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 13);
                dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 35);
            
            for (int i = 10; i < 35; ++i)
            {
                dh.ve("║", 3, i);
                dh.ve("║", 97, i);
            }
            dh.ve("╠", 3, 11);
            dh.ve("╣", 97, 11);
            dh.ve("╠", 3, 13);
            dh.ve("╣", 97, 13);
            for (int i = 12; i < 35; ++i)
            {
                dh.ve("║", 13, i);
                dh.ve("║", 28, i);
                dh.ve("║", 43, i);
                dh.ve("║", 57, i);
                dh.ve("║", 67, i);
                dh.ve("║", 77, i);
                dh.ve("║", 87, i);
            }
            dh.ve("╦", 13, 11);
            dh.ve("╦", 28, 11);
            dh.ve("╦", 43, 11);
            dh.ve("╦", 57, 11);
            dh.ve("╦", 67, 11);
            dh.ve("╦", 77, 11);
            dh.ve("╦", 87, 11);
            dh.ve("╩", 13, 35);
            dh.ve("╩", 28, 35);
            dh.ve("╩", 43, 35);
            dh.ve("╩", 57, 35);
            dh.ve("╩", 67, 35);
            dh.ve("╩", 77, 35);
            dh.ve("╩", 87, 35);
            dh.ve("╬", 13, 33);
            dh.ve("╬", 28, 13);
            dh.ve("╬", 43, 13);
            dh.ve("╬", 57, 13);
            dh.ve("╬", 67, 13);
            dh.ve("╬", 77, 13);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH PHONG TRONG KY TUC XA", 35, 10);
            dh.ve("MAPH", 7, 12);
            dh.ve("TEN PHONG", 16, 12);
            dh.ve("LOAI PHONG", 31, 12);
            dh.ve("TINH TRANG", 45, 12);
            dh.ve("GIA PHONG", 58, 12);
            dh.ve("SUC CHUA", 69, 12);
            dh.ve("SVHT", 80, 12);
            dh.ve("MA DAY", 89, 12);
          
             dh.ve("Ban nhap ma phong muon xoa: ", 10, 4);
         den1: Node<Phong> tg = p.TTPhong().Head;
             int a = 14;
             int tmp = 0;
             while (tg != null)
             {
                 if (tmp < 10)
                 {
                     Console.ForegroundColor = ConsoleColor.White;
                     dh.ve(Convert.ToString(tg.Data.Maphong), 7, a);
                     dh.ve(tg.Data.Tenphong, 16, a);
                     dh.ve(tg.Data.Loaiphong, 34, a);
                     dh.ve(tg.Data.Tinhtrang, 45, a);
                     dh.ve(Convert.ToString(tg.Data.Giaphong), 60, a);
                     dh.ve(Convert.ToString(tg.Data.Succhua), 72, a);
                     dh.ve(Convert.ToString(tg.Data.Sosinhvienhientai), 82, a);
                     dh.ve(Convert.ToString(tg.Data.Maday), 92, a);
                     tmp++;
                     a = a + 2;
                     tg = tg.Link;
                 }
                 else break;

             }
            den:
            int maphong;  
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("", 37, 4);
                try
                {
                    maphong = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 15, 52);
                            dh.ve("                       ", 37, 4);
                            Console.ResetColor();
                            goto den;
                    }
                }
                if (p.KTMaPhong(maphong) == false)
                {
                    if (p.MaPhongTrong(maphong))
                    {
                        dh.ve("Tro lai nhan F12", 10, 36);
                        dh.ve("Tro lai menu chinh nhan F10", 10, 37);
                        dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 38);
                        dh.ve("Nhan Enter de xoa tiep!!! ", 10, 39);
                        dh.ve("Nhan BackSpace de luu va tro lai!!! ", 10, 40);
                        ConsoleKeyInfo kt1 = Console.ReadKey();
                        switch (kt1.Key)
                        {
                            case ConsoleKey.Enter:
                                p.XoaPhong(maphong);
                                Console.BackgroundColor = ConsoleColor.Black;
                                for (int i = 14; i < 35; ++i)
                                {
                                    dh.ve("        ", 4, i);
                                    dh.ve("             ", 14, i);
                                    dh.ve("             ", 29, i);
                                    dh.ve("            ", 44, i);
                                    dh.ve("        ", 58, i);
                                    dh.ve("        ", 68, i);
                                    dh.ve("        ", 78, i);
                                    dh.ve("        ", 88, i);
                                }
                                dh.ve("                       ", 10, 36);
                                dh.ve("                                          ", 10, 37);
                                dh.ve("                                          ", 50, 38);
                                dh.ve("                                          ", 50, 39);
                                dh.ve("                                          ", 50, 40);
                                dh.ve("                   ", 37, 4);
                                Console.ResetColor();
                                goto den1;
                            case ConsoleKey.Escape:
                                return;
                            case ConsoleKey.F10:
                                Console.Clear();
                                menu.MenuChinh1();
                                break;
                            case ConsoleKey.Backspace:
                                p.XoaPhong(maphong);
                                Console.Clear();
                                ChucNangPhong();
                                break;
                            case ConsoleKey.F12:
                                Console.Clear();
                                ChucNangPhong();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ma phong nay hien dang co sinh vien thue!! Nhan Enter de nhap lai! ", 15, 38);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt1 = Console.ReadKey();
                        switch (kt1.Key)
                        {
                            case ConsoleKey.Enter:
                                dh.ve("                  ", 37, 4);
                                dh.ve("                                                                          ", 15, 38);
                                goto den;
                            default:
                                Console.Clear();
                                ChucNangPhong();
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong khong ton tai!! Nhan Enter de nhap lai! ", 15, 38);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            dh.ve("                  ", 37, 4);
                            dh.ve("                                                             ", 15, 38);
                            goto den;
                        default:
                            Console.Clear();
                            ChucNangPhong();
                            break;
                    }
                }
            } while (true);
        }
        #endregion
        #region sua phong
        public void SuaPhong()
           {
            do     
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
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("              ***  QUAN LY KY TUC XA  ***      ", 2, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 5);
            dh.ve("╚", 9, 16);
            dh.ve("╗", 89, 5);
            dh.ve("╝", 89, 16);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 5);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 7);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 16);
            for (int i = 6; i < 16; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 7);
            dh.ve("╣", 89, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 17);
            dh.ve("╠", 0, 17);
            dh.ve("╣", 99, 17);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("SUA THONG TIN PHONG", 45, 6);
            dh.ve("Ten Phong: ", 30, 9);
            dh.ve("Loai Phong: ", 70, 9);
            dh.ve("Tinh Trang: ", 11, 12);
            dh.ve("Gia Phong: ", 37, 12);
            dh.ve("Suc Chua: ", 70, 12);
            dh.ve("So SVHT: ", 11, 15);
            dh.ve("Ma Day: ", 30, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 3, 19);
            dh.ve("╚", 3, 45);
            dh.ve("╗", 97, 19);
            dh.ve("╝", 97, 45);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 19);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 21);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 23);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════════", 4, 45);
            for (int i = 20; i < 45; ++i)
            {
                dh.ve("║", 3, i);
                dh.ve("║", 97, i);
            }
            dh.ve("╠", 3, 21);
            dh.ve("╣", 97, 21);
            dh.ve("╠", 3, 23);
            dh.ve("╣", 97, 23);
            for (int i = 22; i < 45; ++i)
            {
                dh.ve("║", 13, i);
                dh.ve("║", 28, i);
                dh.ve("║", 43, i);
                dh.ve("║", 57, i);
                dh.ve("║", 67, i);
                dh.ve("║", 77, i);
                dh.ve("║", 87, i);
            }
            dh.ve("╦", 13, 21);
            dh.ve("╦", 28, 21);
            dh.ve("╦", 43, 21);
            dh.ve("╦", 57, 21);
            dh.ve("╦", 67, 21);
            dh.ve("╦", 77, 21);
            dh.ve("╦", 87, 21);
            dh.ve("╩", 13, 45);
            dh.ve("╩", 28, 45);
            dh.ve("╩", 43, 45);
            dh.ve("╩", 57, 45);
            dh.ve("╩", 67, 45);
            dh.ve("╩", 77, 45);
            dh.ve("╩", 87, 45);
            dh.ve("╬", 13, 23);
            dh.ve("╬", 28, 23);
            dh.ve("╬", 43, 23);
            dh.ve("╬", 57, 23);
            dh.ve("╬", 67, 23);
            dh.ve("╬", 77, 23);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH PHONG TRONG KY TUC XA", 35, 20);
            dh.ve("MAPH", 7, 22);
            dh.ve("TEN PHONG", 16, 22);
            dh.ve("LOAI PHONG", 31, 22);
            dh.ve("TINH TRANG", 45, 22);
            dh.ve("GIA PHONG", 58, 22);
            dh.ve("SUC CHUA", 69, 22);
            dh.ve("MA DAY", 89, 22);
            Console.ForegroundColor = ConsoleColor.White;
        den1: Node<Phong> tg = p.TTPhong().Head;
            int a = 24;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg.Data.Maphong), 7, a);
                    dh.ve(tg.Data.Tenphong, 16, a);
                    dh.ve(tg.Data.Loaiphong, 34, a);
                    dh.ve(tg.Data.Tinhtrang, 45, a);
                    dh.ve(Convert.ToString(tg.Data.Giaphong), 60, a);
                    dh.ve(Convert.ToString(tg.Data.Succhua), 72, a);
                    dh.ve(Convert.ToString(tg.Data.Sosinhvienhientai), 82, a);
                    dh.ve(Convert.ToString(tg.Data.Maday), 92, a);
                    tmp++;
                    a = a + 2;
                    tg = tg.Link;
                }
                else break;
            }
        den: Console.ForegroundColor = ConsoleColor.White;
        int maphong;
            dh.ve("Ban nhap ma phong can sua: ", 50, 49);
                dh.ve("", 76, 49);
                try
                {
                    maphong = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                   ", 15, 52);
                            dh.ve("                       ", 37, 4);
                            Console.ResetColor();
                            goto den;
                    }
                }   
                //kiem ta xem ma phong co ton tại trong danh sach khong? neu khong ton tại thi them phong moi
                if (p.KTMaPhong(maphong)==false)
                {
                    Node<Phong> tg1 = p.TTPhong().Head;
                    while (tg1 != null)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if (tg1.Data.Maphong == maphong)
                        {
                            dh.ve(tg1.Data.Tenphong, 40, 9);
                            dh.ve(tg1.Data.Loaiphong, 81, 9);
                            dh.ve(tg1.Data.Tinhtrang, 22, 12);
                            dh.ve(Convert.ToString(tg1.Data.Giaphong), 47, 12);
                            dh.ve(Convert.ToString(tg1.Data.Succhua), 79, 12);
                            dh.ve(Convert.ToString(tg1.Data.Sosinhvienhientai), 19, 15);
                            dh.ve(Convert.ToString(tg1.Data.Maday), 37, 15);
                            break;
                        }
                        else
                        {
                            tg1 = tg1.Link;
                        }
                    }
                    dh.ve("", 40, 9);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                              ", 40, 9);
                    Console.ResetColor();
                tenph:   dh.ve("", 40, 9); string tenphongmoi;
                    tenphongmoi = Console.ReadLine();
                    if (tenphongmoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("day la thong tin bat buoc! nhan phim bat ki de nhap lai!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("                  ", 40, 9);
                                Console.ResetColor();
                                goto tenph;
                        }
                    }
                    dh.ve("", 81, 9);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("      ",81, 9);
                    Console.ResetColor();
                loaiphong: dh.ve("", 81, 9); string loaiphongmoi;
                    loaiphongmoi = Console.ReadLine();
                    if (loaiphongmoi.ToLower() != "nam" && loaiphongmoi.ToLower() != "nu")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Loai phong phai la nam hoac nu! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgt = Console.ReadKey();
                        switch (ktgt.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("        ", 81, 9);
                                Console.ResetColor();
                                goto loaiphong;
                        }
                    } 
                    dh.ve("", 22, 12);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("              ", 22,12);
                    Console.ResetColor();
                    dh.ve("", 22, 12);
                    string tinhtrangmoi = Console.ReadLine();
                    dh.ve("", 47, 12);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("               ", 47, 12);
                    Console.ResetColor();
                    dh.ve("", 47, 12);
                giaphong: dh.ve("", 47, 12); double giaphongmoi;
                    try
                    {
                        giaphongmoi = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("gia phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                   ", 15, 52);
                                dh.ve("          ", 47, 12);
                                Console.ResetColor();
                                goto giaphong;
                        }
                    }
                    if (giaphongmoi <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Gia phong phai lon hon 0! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgp = Console.ReadKey();
                        switch (ktgp.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("           ", 47, 12);
                                Console.ResetColor();
                                goto giaphong;
                        }
                    }
                    dh.ve("", 79, 12);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("      ", 79, 12);
                    Console.ResetColor();
                    dh.ve("", 79, 12);
                succhua: dh.ve("", 79, 12); int succhuamoi;
                    try
                    {
                        succhuamoi = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Suc chua phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                   ", 15, 52);
                                dh.ve("         ", 79, 12);
                                Console.ResetColor();
                                goto succhua;
                        }
                    }
                    if (succhuamoi < 4 || succhuamoi > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Suc chua chi tu 4 den 10! nhan Enter de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgp = Console.ReadKey();
                        switch (ktgp.Key)
                        {
                            case ConsoleKey.Enter:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                         ", 15, 52);
                                dh.ve("      ", 79, 12);
                                Console.ResetColor();
                                goto succhua;
                        }
                    }
                    Console.ReadKey();
                    int svhtmoi = p.NhanSoSVHT(maphong);
                    dh.ve("", 37, 15);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("        ", 37, 15);
                    Console.ResetColor();
                    dh.ve("", 37, 15);
                maday:
                    dh.ve("", 37, 15); int madaymoi;
                    try
                    {
                        madaymoi = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ma day phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                   ", 15, 52);
                                dh.ve("          ", 37, 15);
                                Console.ResetColor();
                                goto maday;
                        }
                    }

                    Phong ph = new Phong(maphong, tenphongmoi, loaiphongmoi, tinhtrangmoi, giaphongmoi, succhuamoi, svhtmoi, madaymoi);
                   
                    dh.ve("                                        ", 50, 49);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve("Tro lai nhan F12", 10, 47);
                    dh.ve("Tro lai menu chinh nhan F10", 10, 48);
                    dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 49);
                    dh.ve("Nhan Enter de sua tiep!!! ", 10, 50);
                    dh.ve("Nhan BackSpace de luu va tro lai! ", 10, 51);
                    ConsoleKeyInfo kt2 = Console.ReadKey();
                    switch (kt2.Key)
                    {
                        case ConsoleKey.Enter:
                             p.XoaPhong(maphong);
                             p.Them(ph);
                           Console.BackgroundColor = ConsoleColor.Black;
                               dh.ve("                                            ", 10,47);
                               dh.ve("                                            ", 10, 48);
                            dh.ve("                                               ", 10, 49);
                            dh.ve("                                               ", 10,50 );
                            dh.ve("                                               ", 10, 51);
                            for (int i = 24; i < 45; ++i)
                            {
                                dh.ve("        ", 4, i);
                                dh.ve("            ", 14, i);
                                dh.ve("            ", 29, i);
                                dh.ve("             ", 44, i);
                                dh.ve("        ", 58, i);
                                dh.ve("        ", 68, i);
                                dh.ve("        ", 78, i);
                                dh.ve("        ", 88, i);
                            }
                            dh.ve("                     ", 40, 9);
                            dh.ve("        ", 81, 9);
                            dh.ve("                ", 22, 12);
                            dh.ve("                 ", 47, 12);
                            dh.ve("         ", 79, 12);
                            dh.ve("         ", 19, 15);
                            dh.ve("          ", 37, 15);
                            dh.ve("       ", 50, 49);
                         
                            Console.ResetColor();
                            goto den1;
                        case ConsoleKey.Backspace:
                             p.XoaPhong(maphong);
                             p.Them(ph);
                             Console.Clear();
                             ChucNangPhong();
                             break;
                        case ConsoleKey.F10:
                             Console.Clear();
                             menu.MenuChinh1();
                             break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangPhong();
                            break;
                        case  ConsoleKey.Escape:
                            return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma phong khong ton tai!! Ban nhan Enter de nhap lai! ", 12, 53);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                           ", 12, 53);
                            dh.ve("            ", 76, 49);
                             dh.ve("                               ", 10,47);
                            dh.ve("                                            ", 10, 49);
                            dh.ve("                             ", 10,51 );
                            Console.ResetColor();
                            goto den;
                        default:
                            Console.Clear();
                            ChucNangPhong();
                            break;
                    }
                }
            } while (true);
           }
        #endregion
    }  
}