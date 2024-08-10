using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormTimKiem
    {
        DoHoa dh = new DoHoa(100, 55);
        private DayPhongBLL DPBLL = new DayPhongBLL();
        private PhongBLL PBLL = new PhongBLL();
        private SinhVienBLL SVBLL = new SinhVienBLL();
        KhoaBLL KBLL = new KhoaBLL();
        public static MenuChinh menu = new MenuChinh();
        #region Chuc nang tim kiem
        public void ChucNangTimKiem()
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
            //====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;

            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 38);

            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 23, 10);
            dh.ve("╚", 23, 25);
            dh.ve("╗", 73, 10);
            dh.ve("╝", 73, 25);

            dh.ve("═════════════════════════════════════════════════", 24, 10);
            dh.ve("═════════════════════════════════════════════════", 24, 13);
            dh.ve("═════════════════════════════════════════════════", 24, 25);

            for (int i = 11; i < 25; ++i)
            {
                dh.ve("║", 23, i);
                dh.ve("║", 73, i);
            }
            dh.ve("╠", 23, 13);
            dh.ve("╣", 73, 13);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("               CHUC NANG TIM KIEM", 25, 11);
            dh.ve("             ──────────────────────", 25, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 25, 16);
            dh.ve("╚", 25, 22);
            dh.ve("╗", 71, 16);
            dh.ve("╝", 71, 22);
            dh.ve("═════════════════════════════════════════════", 26, 16);
            dh.ve("═════════════════════════════════════════════", 26, 18);
            dh.ve("═════════════════════════════════════════════", 26, 20);
            dh.ve("═════════════════════════════════════════════", 26, 22);
            dh.ve("║", 25, 17); dh.ve("║", 25, 18); dh.ve("║", 25, 19); dh.ve("║", 25, 20); dh.ve("║", 25, 21);
            dh.ve("║", 71, 17); dh.ve("║", 71, 18); dh.ve("║", 71, 19); dh.ve("║", 71, 20); dh.ve("║", 71, 21);

            for (int i = 17; i < 22; ++i)
            {
                dh.ve("│", 33, i);
            }
            dh.ve("╤", 33, 16);
            dh.ve("╧", 33, 22);
            dh.ve("╪", 33, 18);
            dh.ve("╪", 33, 20);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 29, 17); dh.ve("Tim Kiem Day Phong", 40, 17);
            dh.ve("F2", 29, 19); dh.ve("Tim Kiem Phong", 40, 19);
            dh.ve("F3", 29, 21); dh.ve("Tim Kiem Sinh Vien", 40, 21);
            dh.ve("Tro Lai menu chinh nhan F10", 50, 31);
            dh.ve("Thoat Khoi Chuong Trinh Nhan ESC", 50, 32);
            dh.ve("Ban chon mot phim chuc nang:", 50, 33);
        sai: dh.ve("", 80, 33);
            ConsoleKeyInfo kt = Console.ReadKey();
            dh.ve("                                      ", 50, 34);
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    TimKiemDay();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    TimKiemPhong();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    TimKiemSV();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                    
                case ConsoleKey.Escape:
                    return;
                default :
                    dh.ve("Ban Nhap Sai Phim vui long chon lai!",50,34);
                    goto sai;
            }
        }
        #endregion
        #region Chuc nang tim kiem day phong
        public void TimKiemDay()
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
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 38);
            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 23, 10);
            dh.ve("╚", 23, 25);
            dh.ve("╗", 73, 10);
            dh.ve("╝", 73, 25);

            dh.ve("═════════════════════════════════════════════════", 24, 10);
            dh.ve("═════════════════════════════════════════════════", 24, 13);
            dh.ve("═════════════════════════════════════════════════", 24, 25);

            for (int i = 11; i < 25; ++i)
            {
                dh.ve("║", 23, i);
                dh.ve("║", 73, i);
            }
            dh.ve("╠", 23, 13);
            dh.ve("╣", 73, 13);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("               TIM KIEM DAY PHONG", 25, 11);
            dh.ve("             ──────────────────────", 24, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 25, 16);
            dh.ve("╚", 25, 20);
            dh.ve("╗", 71, 16);
            dh.ve("╝", 71, 20);
            dh.ve("═════════════════════════════════════════════", 26, 16);
            dh.ve("═════════════════════════════════════════════", 26, 18);
            dh.ve("═════════════════════════════════════════════", 26, 20);
            dh.ve("║", 25, 17); dh.ve("║", 25, 18); dh.ve("║", 25, 19);
            dh.ve("║", 71, 17); dh.ve("║", 71, 18); dh.ve("║", 71, 19);

            for (int i = 17; i < 20; ++i)
            {
                dh.ve("│", 33, i);
            }
            dh.ve("╤", 33, 16);
            dh.ve("╧", 33, 20);
            dh.ve("╪", 33, 18);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 29, 17); dh.ve("Tim Kiem Theo MaDay", 40, 17);
            dh.ve("F2", 29, 19); dh.ve("Tim Kiem Theo TenDay", 40, 19);

            dh.ve("Tro lai nhan F12", 50, 29);
            dh.ve("Tro lai menu chinh nhan F10", 50, 30);
            dh.ve("Thoat Khoi Chuong Trinh nhan Esc", 50, 31);
            dh.ve("Ban chon mot phim chuc nang:   ", 50, 32);
         tmp:   dh.ve("", 79, 32);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    TimKiemMaDay();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    TimKiemTenDay();
                    break;
                case ConsoleKey.F12:
                    Console.Clear();
                    ChucNangTimKiem();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor=ConsoleColor.Red;
                    dh.ve("Ban nhap sao phim!!!",50,33);
                    Console.ForegroundColor=ConsoleColor.White;
                    goto tmp;
            }
        }
        # endregion
        #region Tim kiem day phong theo ma day
        public void TimKiemMaDay()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 39);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 39);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 38);

            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }

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

            //----------------------------BANG TIM KIEM DAY PHONG
            dh.ve("╔", 8, 7);
            dh.ve("╚", 8, 30);
            dh.ve("╗", 90, 7);
            dh.ve("╝", 90, 30);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 7);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 9);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 15);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 17);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 30);

            for (int i = 8; i < 30; ++i)
            {
                dh.ve("║", 8, i);
                dh.ve("║", 90, i);
                if (i > 15)
                {
                    dh.ve("║", 25, i);
                    dh.ve("║", 60, i);
                }
            }
            dh.ve("╠", 8, 9);
            dh.ve("╣", 90, 9);
            dh.ve("╠", 8, 17);
            dh.ve("╣", 90, 17);
            dh.ve("╠", 8, 15);
            dh.ve("╣", 90, 15);
            //===================
            dh.ve("╦", 25, 15);
            dh.ve("╦", 60, 15);
            dh.ve("╩", 25, 30);
            dh.ve("╩", 60, 30);
            dh.ve("╬", 25, 17);
            dh.ve("╬", 60, 17);
            //   ╦  ╩   ╬
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("TIM KIEM DAY PHONG", 39, 8);
            dh.ve("BAN NHAP MA DAY CAN TIM KIEM: ", 30, 12);
            dh.ve("MA DAY PHONG", 11, 16);
            dh.ve("TEN DAY PHONG", 36, 16);
            dh.ve("VI TRI", 73, 16);
        den: int n;
            try
            {
                dh.ve("", 60, 12);
                 n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma day phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 14);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                        ", 15, 14);
                        dh.ve("                    ", 60, 12);
                        Console.ResetColor();
                        goto den;
                }
            }
            if (DPBLL.KTMaDayPhong(n) == false)
            {
                DayPhong dp = DPBLL.TimKiemTheoMaDayPhong(n);
                dh.ve(Convert.ToString(dp.Maday), 15, 19);
                dh.ve(dp.Tenday, 40, 19);
                dh.ve(dp.Vitri, 70, 19);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Nhan Enter de tim kiem tiep!", 15, 33);
                dh.ve("Nhan F12 de tro lai", 15, 34);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 35);
                dh.ve("Nhan Esc de thoat", 15, 36);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        dh.ve("                  ", 60, 12);
                        dh.ve("        ", 15, 19);
                        dh.ve("                  ", 40, 19);
                        dh.ve("                 ", 70, 19);
                        dh.ve("                                  ", 15, 33);
                        dh.ve("                                  ", 15, 34);
                        dh.ve("                                  ", 15, 35);
                        dh.ve("                                  ", 15, 36);
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemDay();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Ma day phong nay khong ton tai trong he thong!!!", 15, 32);
                dh.ve("Nhan Enter de nhap lai!", 15, 33);
                dh.ve("Nhan F12 de tro lai", 15, 34);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 35);
                dh.ve("Nhan Esc de thoat", 15, 36);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("         ", 60, 12);
                        dh.ve("                                                                   ", 15, 32);
                        dh.ve("                                  ", 15, 33);
                        dh.ve("                                  ", 15, 34);
                        dh.ve("                                  ", 15, 35);
                        dh.ve("                                  ", 15, 36);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemDay();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
        #endregion
        #region Tim kiem day phong theo ten
        public void TimKiemTenDay()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 0, 0);
            dh.ve("╚", 0, 39);
            dh.ve("╗", 99, 0);
            dh.ve("╝", 99, 39);

            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 3);
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 39);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 38);

            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }

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

            //----------------------------BANG TIM KIEM DAY PHONG
            dh.ve("╔", 8, 7);
            dh.ve("╚", 8, 30);
            dh.ve("╗", 90, 7);
            dh.ve("╝", 90, 30);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 7);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 9);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 15);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 17);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════", 9, 30);

            for (int i = 8; i < 30; ++i)
            {
                dh.ve("║", 8, i);
                dh.ve("║", 90, i);
                if (i > 15)
                {
                    dh.ve("║", 25, i);
                    dh.ve("║", 60, i);
                }
            }
            dh.ve("╠", 8, 9);
            dh.ve("╣", 90, 9);
            dh.ve("╠", 8, 17);
            dh.ve("╣", 90, 17);
            dh.ve("╠", 8, 15);
            dh.ve("╣", 90, 15);
            //===================
            dh.ve("╦", 25, 15);
            dh.ve("╦", 60, 15);
            dh.ve("╩", 25, 30);
            dh.ve("╩", 60, 30);
            dh.ve("╬", 25, 17);
            dh.ve("╬", 60, 17);
            //   ╦  ╩   ╬
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("TIM KIEM DAY PHONG", 39, 8);
            dh.ve("BAN NHAP TEN DAY PHONG CAN TIM KIEM:", 30, 12);
            dh.ve("MA DAY PHONG", 11, 16);
            dh.ve("TEN DAY PHONG", 36, 16);
            dh.ve("VI TRI", 73, 16);
        den: dh.ve("", 66, 12);
            string tendayphong = Console.ReadLine();
            List<DayPhong> ds = DPBLL.TimKiemTheoTenDayPhong(tendayphong);
            Node<DayPhong> tg = ds.Head;
            if (tg != null)
            {
                int i = 19;
                while (tg != null)
                {
                    dh.ve(Convert.ToString(tg.Data.Maday), 15, i);
                    dh.ve(tg.Data.Tenday, 40, i);
                    dh.ve(tg.Data.Vitri, 70, i);
                    tg = tg.Link;
                    i = i + 2;
                }
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Nhan enter de tim kiem tiep!", 15, 33);
                dh.ve("Nhan F12 de tro lai", 15, 34);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 35);
                dh.ve("Nhan Esc de thoat", 15, 36);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        dh.ve("                  ", 66, 12);

                        for (int i1 = 18; i1 < 30; ++i1)
                        {
                            dh.ve("        ", 15, i1);
                            dh.ve("                  ", 40, i1);
                            dh.ve("                 ", 70, i1);
                        }
                        dh.ve("                                  ", 15, 33);
                        dh.ve("                                  ", 15, 34);
                        dh.ve("                                  ", 15, 35);
                        dh.ve("                                  ", 15, 36);
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemDay();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Ten day phong nay khong ton tai trong he thong!!!", 15, 32);
                dh.ve("Nhan enter de nhap lai!", 15, 33);
                dh.ve("Nhan F12 de tro lai", 15, 34);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 35);
                dh.ve("Nhan Esc de thoat", 15, 36);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("         ", 66, 12);
                        dh.ve("                                                             ", 15, 32);
                        dh.ve("                                  ", 15, 33);
                        dh.ve("                                  ", 15, 34);
                        dh.ve("                                  ", 15, 35);
                        dh.ve("                                  ", 15, 36);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemDay();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }

        }
        #endregion
        #region Chu nang tim kiem phong
        public void TimKiemPhong()
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
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 38);
            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 23, 10);
            dh.ve("╚", 23, 25);
            dh.ve("╗", 73, 10);
            dh.ve("╝", 73, 25);

            dh.ve("═════════════════════════════════════════════════", 24, 10);
            dh.ve("═════════════════════════════════════════════════", 24, 13);
            dh.ve("═════════════════════════════════════════════════", 24, 25);

            for (int i = 11; i < 25; ++i)
            {
                dh.ve("║", 23, i);
                dh.ve("║", 73, i);
            }
            dh.ve("╠", 23, 13);
            dh.ve("╣", 73, 13);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("               TIM KIEM PHONG", 26, 11);
            dh.ve("               ─────────────────", 24, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 25, 16);
            dh.ve("╚", 25, 24);
            dh.ve("╗", 71, 16);
            dh.ve("╝", 71, 24);
            dh.ve("═════════════════════════════════════════════", 26, 16);
            dh.ve("═════════════════════════════════════════════", 26, 18);
            dh.ve("═════════════════════════════════════════════", 26, 20);
            dh.ve("═════════════════════════════════════════════", 26, 22);
            dh.ve("═════════════════════════════════════════════", 26, 24);
            dh.ve("║", 25, 17); dh.ve("║", 25, 18); dh.ve("║", 25, 19); dh.ve("║", 25, 20); dh.ve("║", 25, 21); dh.ve("║", 25, 22); dh.ve("║", 25, 23);
            dh.ve("║", 71, 17); dh.ve("║", 71, 18); dh.ve("║", 71, 19); dh.ve("║", 71, 20); dh.ve("║", 71, 21); dh.ve("║", 71, 22); dh.ve("║", 71, 23);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve("│", 33, i);
            }
            dh.ve("╤", 33, 16);
            dh.ve("╧", 33, 24);
            dh.ve("╪", 33, 18);
            dh.ve("╪", 33, 20);
            dh.ve("╪", 33, 22);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 29, 17); dh.ve("Tim Kiem Theo Ma Phong", 40, 17);
            dh.ve("F2", 29, 19); dh.ve("Tim Kiem Theo Ten Phong", 40, 19);
            dh.ve("F3", 29, 21); dh.ve("Tim Kiem Phong Con Trong", 40, 21);
            dh.ve("F4", 29, 23); dh.ve("Tim Kiem Loai Phong", 40, 23);
            dh.ve("Tro Lai Chuong Trinh nhan F12", 60, 48);
            dh.ve("Tro Lai Menu chinh nhan F10", 60, 49);
            dh.ve("Thoat Khoi Chuong Trinh       Esc", 60, 50);
            dh.ve("Ban chon mot phim chuc nang:   ", 60, 51);
          tmp:  dh.ve("",88,51);
            ConsoleKeyInfo kt=Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    TimKiemMaPhong();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    TimKiemPhongTheoTen();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    TimKiemPhongConTrong();
                    break;
                     case ConsoleKey.F4:
                    Console.Clear();
                    TimKiemTheoLoaiPhong();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.F12:
                    Console.Clear();
                    ChucNangTimKiem();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor=ConsoleColor.Red;
                    dh.ve("Ban nhap sai phim!!!",40,52);
                          Console.ForegroundColor=ConsoleColor.White;
                          goto tmp;
                    
            }
        }
        #endregion 
        #region tim kiem phong theo ma
        public void TimKiemMaPhong()
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
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            dh.ve("                TIM KIEM PHONG", 26, 4);
            dh.ve("                ─────────────────", 24, 5);
            dh.ve("NHAP MA PHONG CAN TIM KIEM: ", 36, 10);

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
            dh.ve("DANH SACH TIM KIEM", 40, 16);
            dh.ve("MAPH", 7, 18);
            dh.ve("TEN PHONG", 16, 18);
            dh.ve("LOAI PHONG", 31, 18);
            dh.ve("TINH TRANG", 45, 18);
            dh.ve("GIA PHONG", 58, 18);
            dh.ve("SUC CHUA", 69, 18);
            dh.ve("SHHT", 80, 18);
            dh.ve("MA DAY", 89, 18);
        den: int n;
            try
            {
                dh.ve("", 63, 10);
                 n = int.Parse(Console.ReadLine());
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
                        dh.ve("                               ", 63, 10);
                        Console.ResetColor();
                        goto den;
                }
            }
            if (PBLL.KTMaPhong(n) == false)
            {
                Phong p = PBLL.TimKiemTheoMaPhong(n);
                dh.ve(Convert.ToString(p.Maphong), 7,21);
                dh.ve(p.Tenphong, 16, 21);
                dh.ve(p.Loaiphong, 34, 21);
                dh.ve(p.Tinhtrang, 45, 21);
                dh.ve(Convert.ToString(p.Giaphong), 59, 21);
                dh.ve(Convert.ToString(p.Succhua), 72, 21);
                dh.ve(Convert.ToString(p.Sosinhvienhientai), 83, 21);
                dh.ve(Convert.ToString(p.Maday), 92, 21);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Nhan Enter de tim kiem tiep!", 15, 48);
                dh.ve("Nhan F12 de tro lai", 15, 49);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 50);
                dh.ve("Nhan Esc de thoat", 15, 51);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        dh.ve("      ", 63, 10);
                        dh.ve("      ", 7, 21);
                        dh.ve("           ", 16, 21);
                        dh.ve("           ", 31, 21);
                        dh.ve("           ", 45, 21);
                        dh.ve("       ", 58, 21);
                        dh.ve("       ", 69, 21);
                        dh.ve("       ", 80, 21);
                        dh.ve("       ", 89, 21);
                         dh.ve("                                          ", 15, 48);
                        dh.ve("                                          ", 15, 49);
                        dh.ve("                                         ", 15, 50);
                        dh.ve("                                         ", 15, 51);
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemPhong();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma phong nay khong ton tai trong he thong!!!", 15, 48);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Nhan Enter de nhap lai!", 15, 49);
                dh.ve("Nhan F12 de tro lai", 15, 50);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 51);
                dh.ve("Nhan Esc de thoat", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("         ", 63, 10);
                        dh.ve("                                                             ", 15, 48);
                        dh.ve("                                          ", 15, 49);
                        dh.ve("                                        ", 15, 50);
                        dh.ve("                                        ", 15, 51);
                        dh.ve("                                       ", 15, 52);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemPhong();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
#endregion 
        #region chuc nang tin kiem phong theo ten
        public void TimKiemPhongTheoTen()
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
            dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
            dh.ve("                TIM KIEM PHONG", 26, 4);
            dh.ve("                ─────────────────", 24, 5);
            dh.ve("NHAP TEN PHONG CAN TIM KIEM: ", 36, 10);

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
            dh.ve("DANH SACH TIM KIEM", 40, 16);
            dh.ve("MAPH", 7, 18);
            dh.ve("TEN PHONG", 16, 18);
            dh.ve("LOAI PHONG", 31, 18);
            dh.ve("TINH TRANG", 45, 18);
            dh.ve("GIA PHONG", 58, 18);
            dh.ve("SUC CHUA", 69, 18);
            dh.ve("SHHT", 80, 18);
            dh.ve("MA DAY", 89, 18);
             den: dh.ve("", 64, 10);
            string tenphong = Console.ReadLine();
            List<Phong> ds = PBLL.TimKiemTheoTenPhong(tenphong);
            Node<Phong> tg = ds.Head;
            if (tg != null)
            {
                int i = 21;
                while (tg != null)
                {

                    dh.ve(Convert.ToString(tg.Data.Maphong), 7, i);
                    dh.ve(tg.Data.Tenphong, 16, i);
                    dh.ve(tg.Data.Loaiphong, 34, i);
                    dh.ve(tg.Data.Tinhtrang, 45, i);
                    dh.ve(Convert.ToString(tg.Data.Giaphong), 59, i);
                    dh.ve(Convert.ToString(tg.Data.Succhua), 72, i);
                    dh.ve(Convert.ToString(tg.Data.Sosinhvienhientai), 83, i);
                    dh.ve(Convert.ToString(tg.Data.Maday), 92, i);
                    tg = tg.Link;
                    i = i + 2;
                }
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Nhan Enter de tim kiem tiep!", 15, 48);
                dh.ve("Nhan F12 de tro lai", 15, 49);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 50);
                dh.ve("Nhan Esc de thoat", 15, 51);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        dh.ve("                        ", 64, 10);
                        for (int i1 = 21; i1 < 40; ++i1)
                        {
                            dh.ve("      ", 7, i1);
                            dh.ve("           ", 16, i1);
                            dh.ve("           ", 31, i1);
                            dh.ve("           ", 45, i1);
                            dh.ve("       ", 58, i1);
                            dh.ve("       ", 69, i1);
                            dh.ve("       ", 80, i1);
                            dh.ve("       ", 89, i1);
                        }
                        dh.ve("                                          ", 15, 48);
                        dh.ve("                                          ", 15, 49);
                        dh.ve("                                           ", 15, 50);
                        dh.ve("                                          ", 15, 51);
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemPhong();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Ten phong nay khong ton tai trong he thong!!!", 15, 48);
                dh.ve("Nhan Enter de nhap lai!", 15, 49);
                dh.ve("Nhan F12 de tro lai", 15, 50);
                dh.ve("Nhan F10 de tro lai menu chinh", 15, 51);
                dh.ve("Nhan Esc de thoat", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("         ", 63, 10);
                        dh.ve("                                                             ", 15, 48);
                        dh.ve("                                  ", 15, 49);
                        dh.ve("                                    ", 15, 50);
                        dh.ve("                                        ", 15, 51);
                        dh.ve("                               ", 15, 52);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemPhong();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
        #endregion
        #region tim kiem phong con trong
        public void TimKiemPhongConTrong()
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
            dh.ve("SHHT", 80, 12);
            dh.ve("MA DAY", 89, 12);
            dh.ve("Tro lai nhan F12", 10, 36);
            dh.ve("Tro lai menu chinh nhan F10", 10, 37);
            dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 38);
            dh.ve("Ban chon phim chuc nang: ", 55, 38);
            Node<Phong> tg = PBLL.TimKiemPhongConTrong().Head;
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
                            ChucNangTimKiem();
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
             Node<Phong> tg1 = PBLL.TimKiemPhongConTrong().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                        dh.ve("", 5, a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" {0,-10}{1,-16}{2,-13}{3,-14}{4,-13}{5,-9}{6,-9}{7,-5}", tg1.Data.Maphong, tg1.Data.Tenphong, tg1.Data.Loaiphong, tg1.Data.Tinhtrang, tg1.Data.Giaphong, tg1.Data.Succhua, tg1.Data.Sosinhvienhientai, tg1.Data.Maday);
                        Console.ForegroundColor = ConsoleColor.Green;
                        dh.ve("║ ", 13, a); dh.ve("║ ", 28, a); dh.ve("║ ", 43, a); dh.ve("║ ", 57, a); dh.ve("║ ", 67, a); dh.ve("║ ", 77, a); dh.ve("║ ", 87, a);
                        tg1 = tg1.Link;
                        a=a+2;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        }
        #endregion
        #region Tim kiem Loai Phong
        public void TimKiemTheoLoaiPhong()
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
                dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5 ,5);
                dh.ve("══════════════════════════════════════════════════════════════════════════════════════════", 5, 37);
            for (int i = 6; i < 37; ++i)
            {
                dh.ve("║", 4, i);
                dh.ve("║", 95, i);
            }
            ///====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 38);
            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 23, 10);
            dh.ve("╚", 23, 25);
            dh.ve("╗", 73, 10);
            dh.ve("╝", 73, 25);

            dh.ve("═════════════════════════════════════════════════", 24, 10);
            dh.ve("═════════════════════════════════════════════════", 24, 13);
            dh.ve("═════════════════════════════════════════════════", 24, 25);

            for (int i = 11; i < 25; ++i)
            {
                dh.ve("║", 23, i);
                dh.ve("║", 73, i);
            }
            dh.ve("╠", 23, 13);
            dh.ve("╣", 73, 13);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("               TIM KIEM DAY PHONG", 25, 11);
            dh.ve("             ──────────────────────", 24, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 25, 16);
            dh.ve("╚", 25, 20);
            dh.ve("╗", 71, 16);
            dh.ve("╝", 71, 20);
            dh.ve("═════════════════════════════════════════════", 26, 16);
            dh.ve("═════════════════════════════════════════════", 26, 18);
            dh.ve("═════════════════════════════════════════════", 26, 20);
            dh.ve("║", 25, 17); dh.ve("║", 25, 18); dh.ve("║", 25, 19); 
            dh.ve("║", 71, 17); dh.ve("║", 71, 18); dh.ve("║", 71, 19); 

            for (int i = 17; i < 20; ++i)
            {
                dh.ve("│", 33, i);
            }
            dh.ve("╤", 33, 16);
            dh.ve("╧", 33, 20);
            dh.ve("╪", 33, 18);
 
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 29, 17); dh.ve("Tim Kiem Phong Nam", 40, 17);
            dh.ve("F2", 29, 19); dh.ve("Tim Kiem Phong Nu", 40, 19);
            dh.ve("Tro Lai Chuong Trinh nhan F12", 50, 30);
            dh.ve("Tro Lai menu chinh nhan F12", 50, 31);
            dh.ve("Thoat Khoi Chuong Trinh nhan Esc", 50, 32);
            dh.ve("Ban chon mot phim chuc nang   ", 50, 33);
            tmp: dh.ve("", 78, 33);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    TimKiemPhongnam();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    TimKiemPhongNu();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.F12:
                    Console.Clear();
                    ChucNangTimKiem();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap sao phim!!!", 50, 33);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tmp;
            }
        }
        #endregion
        #region tim kiem phong nu
        public void TimKiemPhongNu()
        {
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
                dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
                dh.ve("                TIM KIEM PHONG", 26, 4);
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
                dh.ve("DANH SACH PHONG NU", 40, 16);
                dh.ve("MAPH", 7, 18);
                dh.ve("TEN PHONG", 16, 18);
                dh.ve("LOAI PHONG", 31, 18);
                dh.ve("TINH TRANG", 45, 18);
                dh.ve("GIA PHONG", 58, 18);
                dh.ve("SUC CHUA", 69, 18);
                dh.ve("SHHT", 80, 18);
                dh.ve("MA DAY", 89, 18);

                dh.ve("Tro Lai Chuong Trinh nhan F12", 60, 49);
                dh.ve("Tro Lai Chuong Trinh nhan F10", 60, 50);
                dh.ve("Thoat Khoi Chuong Trinh nhan Esc", 60, 51);
                dh.ve("Ban chon mot phim chuc nang   ", 60, 52);
                   Node<Phong> tg = PBLL.TimKiemPhongNu().Head;
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
                    VeTrangNu(trang);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve("", 68, 47); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                    goto den;
                den: do
                    {

                        dh.ve("", 88, 51);
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
                                ChucNangTimKiem();
                                break;
                            case ConsoleKey.Escape:
                                return;
                        }
                    } while (true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Hien Tai Trong He Thong khong co phong Nao!", 10, 52);
                }
            }
        }
        #endregion
        #region ve trang phong nu
        public void VeTrangNu(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 21; i < 45; ++i)
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
            int a = 21;
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<Phong> tg1 = PBLL.TimKiemPhongNu().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                    dh.ve("", 5, a);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" {0,-10}{1,-16}{2,-13}{3,-14}{4,-13}{5,-9}{6,-9}{7,-5}", tg1.Data.Maphong, tg1.Data.Tenphong, tg1.Data.Loaiphong, tg1.Data.Tinhtrang, tg1.Data.Giaphong, tg1.Data.Succhua, tg1.Data.Sosinhvienhientai, tg1.Data.Maday);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dh.ve("║ ", 13, a); dh.ve("║ ", 28, a); dh.ve("║ ", 43, a); dh.ve("║ ", 57, a); dh.ve("║ ", 67, a); dh.ve("║ ", 77, a); dh.ve("║ ", 87, a);
                    tg1 = tg1.Link;
                    a = a + 2;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        }
        #endregion
        #region tim kiem phong nam
        public void TimKiemPhongnam()
        {
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
                dh.ve("                 ***QUAN LY KY TUC XA***      ", 2, 1);
                dh.ve("                TIM KIEM PHONG", 26, 4);
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
                dh.ve("DANH SACH PHONG NAM", 39, 16);
                dh.ve("MAPH", 7, 18);
                dh.ve("TEN PHONG", 16, 18);
                dh.ve("LOAI PHONG", 31, 18);
                dh.ve("TINH TRANG", 45, 18);
                dh.ve("GIA PHONG", 58, 18);
                dh.ve("SUC CHUA", 69, 18);
                dh.ve("SHHT", 80, 18);
                dh.ve("MA DAY", 89, 18);

                dh.ve("Tro Lai Chuong Trinh nhan F12", 60, 49);
                dh.ve("Tro Lai Chuong Trinh nhan F12", 60, 50);
                dh.ve("Thoat Khoi Chuong Trinh nhan Esc", 60, 51);
                dh.ve("Ban chon mot phim chuc nang   ", 60, 52);
                Node<Phong> tg = PBLL.TimKiemPhongNam().Head;
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
                    VeTrangNam(trang);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve("", 68, 47); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                    goto den;
                den: do
                    {

                        dh.ve("", 88, 51);
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
                                ChucNangTimKiem();
                                break;
                            case ConsoleKey.Escape:
                                return;
                        }
                    } while (true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Hien Tai Trong He Thong khong co phong Nao!", 10,52);
                }
            }
        }
        #endregion
        #region ve trang phong nam
        public void VeTrangNam(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 21; i <45; ++i)
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
            int a = 21;
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<Phong> tg1 = PBLL.TimKiemPhongNam().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                    dh.ve("", 5, a);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" {0,-10}{1,-16}{2,-13}{3,-14}{4,-13}{5,-9}{6,-9}{7,-5}", tg1.Data.Maphong, tg1.Data.Tenphong, tg1.Data.Loaiphong, tg1.Data.Tinhtrang, tg1.Data.Giaphong, tg1.Data.Succhua, tg1.Data.Sosinhvienhientai, tg1.Data.Maday);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dh.ve("║ ", 13, a); dh.ve("║ ", 28, a); dh.ve("║ ", 43, a); dh.ve("║ ", 57, a); dh.ve("║ ", 67, a); dh.ve("║ ", 77, a); dh.ve("║ ", 87, a);
                    tg1 = tg1.Link;
                    a = a + 2;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        }
        #endregion
        #region Chuc nang tim kiem sinh vien
        public void TimKiemSV()
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

            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 4);
            dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *", 2, 38);
            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 23, 10);
            dh.ve("╚", 23, 25);
            dh.ve("╗", 73, 10);
            dh.ve("╝", 73, 25);

            dh.ve("═════════════════════════════════════════════════", 24, 10);
            dh.ve("═════════════════════════════════════════════════", 24, 13);
            dh.ve("═════════════════════════════════════════════════", 24, 25);

            for (int i = 11; i < 25; ++i)
            {
                dh.ve("║", 23, i);
                dh.ve("║", 73, i);
            }
            dh.ve("╠", 23, 13);
            dh.ve("╣", 73, 13);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("               TIM KIEM SINH VIEN", 24, 11);
            dh.ve("             ──────────────────────", 24, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 25, 16);
            dh.ve("╚", 25, 24);
            dh.ve("╗", 71, 16);
            dh.ve("╝", 71, 24);
            dh.ve("═════════════════════════════════════════════", 26, 16);
            dh.ve("═════════════════════════════════════════════", 26, 18);
            dh.ve("═════════════════════════════════════════════", 26, 20);
            dh.ve("═════════════════════════════════════════════", 26, 22);
            dh.ve("═════════════════════════════════════════════", 26, 24);
            dh.ve("║", 25, 17); dh.ve("║", 25, 18); dh.ve("║", 25, 19); dh.ve("║", 25, 20); dh.ve("║", 25, 21); dh.ve("║", 25, 22); dh.ve("║", 25, 23);
            dh.ve("║", 71, 17); dh.ve("║", 71, 18); dh.ve("║", 71, 19); dh.ve("║", 71, 20); dh.ve("║", 71, 21); dh.ve("║", 71, 22); dh.ve("║", 71, 23);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve("│", 33, i);
            }
            dh.ve("╤", 33, 16);
            dh.ve("╧", 33, 24);
            dh.ve("╪", 33, 18);
            dh.ve("╪", 33, 20);
            dh.ve("╪", 33, 22);

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 29, 17); dh.ve("Tim Kiem Theo MaSV", 40, 17);
            dh.ve("F2", 29, 19); dh.ve("Tim Kiem Theo TenSV", 40, 19);
            dh.ve("F3", 29, 21); dh.ve("Tim Kiem Theo Phong", 40, 21);
            dh.ve("F4", 29, 23); dh.ve("Tim Kiem Theo Khoa", 40, 23);
            dh.ve("Tro Lai Chuong Trinh nhan F12", 50, 30);
            dh.ve("Tro Lai  menu chinh nhan F10", 50, 31);
            dh.ve("Thoat Khoi Chuong Trinh nhan Esc", 50, 32);
            dh.ve("Ban chon mot phim chuc nang: ", 50, 33);
              tmp:  dh.ve("",77,33);
            ConsoleKeyInfo kt=Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    TimKiemMaSV();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    TimKiemHoTenSV();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    TimKiemPhongSV();
                    break;
                     case ConsoleKey.F4:
                    Console.Clear();
                    TimKiemKhoaSV();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.F12:
                    Console.Clear();
                    ChucNangTimKiem();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor=ConsoleColor.Red;
                    dh.ve("Ban nhap sai phim!!!",40,52);
                          Console.ForegroundColor=ConsoleColor.White;
                          goto tmp;
        }
        }
        #endregion
        #region tim kiem sinh vien theo ma sinh vien
        public void TimKiemMaSV()
        {
            DoHoa dh = new DoHoa(137, 55);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 4, 0);
            dh.ve1("╚", 4, 54);
            dh.ve1("╗", 136, 0);
            dh.ve1("╝", 136, 54);

            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 0);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 3);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve1("║", 4, i);
                dh.ve1("║", 136, i);
            }
            dh.ve1("╠", 4, 3);
            dh.ve1("╣", 136, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("***  QUAN LY KY TUC XA ***", 36, 1);
            dh.ve1("TIM KIEM SINH VIEN", 60, 6);
            dh.ve1("NHAP MA SINH VIEN CAN TIM:", 55, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 25, 5);
            dh.ve1("╚", 25, 20);
            dh.ve1("╗", 115, 5);
            dh.ve1("╝", 115, 20);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 5);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 7);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 20);
            
            for (int i = 6; i < 20; ++i)
            {
                dh.ve1("║", 25, i);
                dh.ve1("║", 115, i);
            }
            dh.ve1("╠", 25, 7);
            dh.ve1("╣", 115, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 21);
            dh.ve1("╠", 4, 21);
            dh.ve1("╣", 136, 21);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 5, 22);
            dh.ve1("╚", 5, 48);
            dh.ve1("╗", 135, 22);
            dh.ve1("╝", 135, 48);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 22);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 24);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 48);

            for (int i = 23; i < 48; ++i)
            {
                dh.ve1("║", 5, i);
                dh.ve1("║", 135, i);
            }

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("DANH SACH SINH VIEN TRONG KY TUC XA", 53, 23);


            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 25; i < 48; ++i)
            {
                dh.ve1("│", 14, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 61, i);
                dh.ve1("│", 74, i);
                dh.ve1("│", 108, i);
                dh.ve1("│", 123, i);
            }

            dh.ve1("╤", 14, 24); dh.ve1("╧", 14, 48);
            dh.ve1("╤", 44, 24); dh.ve1("╧", 44, 48);
            dh.ve1("╤", 61, 24); dh.ve1("╧", 61, 48);
            dh.ve1("╤", 74, 24); dh.ve1("╧", 74, 48);
            dh.ve1("╤", 108, 24); dh.ve1("╧", 108, 48);
            dh.ve1("╤", 123, 24); dh.ve1("╧", 123, 48);
            dh.ve1("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────", 6, 26);
            dh.ve1("┼", 14, 26);
            dh.ve1("┼", 44, 26);
            dh.ve1("┼", 61, 26);
            dh.ve1("┼", 74, 26);
            dh.ve1("┼", 108, 26);
            dh.ve1("┼", 123, 26);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("MaSV", 8, 25);
            dh.ve1("HoTenSV", 27, 25);
            dh.ve1("NgaySinh", 49, 25);
            dh.ve1("GioiTinh", 64, 25);
            dh.ve1("DiaChi", 89, 25);
            dh.ve1("SDT", 115, 25);
            dh.ve1("MaKhoa", 126, 25);
            Console.ForegroundColor = ConsoleColor.White;
        den: dh.ve1("", 82, 13);
          int masv = int.Parse(Console.ReadLine());
            if (SVBLL.KTMaSinhVien(masv)== false)
            {
                SinhVien SV = SVBLL.TimKiemTheoMaSV(masv);
                dh.ve1(Convert.ToString(SV.Masinhvien), 8, 27);
                dh.ve1(SV.Hoten,23, 27);
                dh.ve1(Convert.ToString(SV.Ngaysinh.Day + "/" +SV.Ngaysinh.Month + "/" +SV.Ngaysinh.Year), 49, 27);
                dh.ve1(SV.Gioitinh, 67, 27);
                dh.ve1(SV.Diachi, 85, 27);
                dh.ve1(SV.Sodienthoai, 111, 27);
                dh.ve1(Convert.ToString(SV.Makhoa), 126, 27);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Nhan Enter de tim kiem tiep!", 15, 49);
                dh.ve1("Nhan F12 de tro lai", 15, 50);
                dh.ve1("Nhan F10 de tro lai menu chinh", 15, 51);
                dh.ve1("Nhan Esc de thoat", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("       ", 81, 13);
                       dh.ve1("      ", 8, 27);
                dh.ve1("                    ",23, 27);
                dh.ve1("          ", 49, 27);
                dh.ve1("      ", 67, 27);
                dh.ve1("                       ", 85, 27);
                dh.ve1("           ", 111, 27);
                dh.ve1("        ", 126, 27);
                        dh.ve1("                                          ", 15, 49);
                        dh.ve1("                                              ", 15, 50);
                        dh.ve1("                                            ", 15, 51);
                        dh.ve1("                                           ", 15, 52);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Ma SV nay khong ton tai trong he thong!!!", 15, 49);
                dh.ve1("Nhan Enter de nhap lai!", 15, 50);
                dh.ve1("Nhan F12 de tro lai", 15, 51);
                dh.ve1("Nhan F10 de tro lai menu chinh", 15, 52);
                dh.ve1("Nhan Esc de thoat", 15, 53);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("         ", 63, 10);
                        dh.ve1("                                                             ", 15, 49);
                        dh.ve1("                                               ", 15, 50);
                        dh.ve1("                                               ", 15, 51);
                        dh.ve1("                                           ", 15, 52);
                        dh.ve1("                                            ", 15, 53);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
#endregion
        #region tim kiem sinh vien theo ten
         public void TimKiemHoTenSV()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 4, 0);
            dh.ve1("╚", 4, 54);
            dh.ve1("╗", 136, 0);
            dh.ve1("╝", 136, 54);

            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 0);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 3);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve1("║", 4, i);
                dh.ve1("║", 136, i);
            }
            dh.ve1("╠", 4, 3);
            dh.ve1("╣", 136, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("***  QUAN LY KY TUC XA  ***", 36, 1);
            dh.ve1("TIM KIEM SINH VIEN", 60, 6);
            dh.ve1("NHAP HO TEN SINH VIEN CAN TIM: ", 55, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 25, 5);
            dh.ve1("╚", 25, 20);
            dh.ve1("╗", 115, 5);
            dh.ve1("╝", 115, 20);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 5);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 7);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 20);

            for (int i = 6; i < 20; ++i)
            {
                dh.ve1("║", 25, i);
                dh.ve1("║", 115, i);
            }
            dh.ve1("╠", 25, 7);
            dh.ve1("╣", 115, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 21);
            dh.ve1("╠", 4, 21);
            dh.ve1("╣", 136, 21);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 5, 22);
            dh.ve1("╚", 5, 48);
            dh.ve1("╗", 135, 22);
            dh.ve1("╝", 135, 48);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 22);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 24);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 48);

            for (int i = 23; i < 48; ++i)
            {
                dh.ve1("║", 5, i);
                dh.ve1("║", 135, i);
            }

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("DANH SACH SINH VIEN TRONG KY TUC XA", 53, 23);


            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 25; i < 48; ++i)
            {
                dh.ve1("│", 14, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 61, i);
                dh.ve1("│", 74, i);
                dh.ve1("│", 108, i);
                dh.ve1("│", 123, i);
            }

            dh.ve1("╤", 14, 24); dh.ve1("╧", 14, 48);
            dh.ve1("╤", 44, 24); dh.ve1("╧", 44, 48);
            dh.ve1("╤", 61, 24); dh.ve1("╧", 61, 48);
            dh.ve1("╤", 74, 24); dh.ve1("╧", 74, 48);
            dh.ve1("╤", 108, 24); dh.ve1("╧", 108, 48);
            dh.ve1("╤", 123, 24); dh.ve1("╧", 123, 48);
            dh.ve1("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────", 6, 26);
            dh.ve1("┼", 14, 26);
            dh.ve1("┼", 44, 26);
            dh.ve1("┼", 61, 26);
            dh.ve1("┼", 74, 26);
            dh.ve1("┼", 108, 26);
            dh.ve1("┼", 123, 26);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("MaSV", 8, 25);
            dh.ve1("HoTenSV", 27, 25);
            dh.ve1("NgaySinh", 49, 25);
            dh.ve1("GioiTinh", 64, 25);
            dh.ve1("DiaChi", 89, 25);
            dh.ve1("SDT", 115, 25);
            dh.ve1("MaKhoa", 126, 25);
        den: dh.ve1("", 86, 13);
        Console.ForegroundColor = ConsoleColor.White;
            string tensv = Console.ReadLine();
            List<SinhVien> ds = SVBLL.TimKiemTheoTenSV(tensv);
            Node<SinhVien> tg = ds.Head;
            if (tg != null)
            {
                int i = 27;
                while (tg != null)
                {

                    dh.ve1(Convert.ToString(tg.Data.Masinhvien), 8, 27);
                    dh.ve1(tg.Data.Hoten, 23, 27);
                    dh.ve1(Convert.ToString(tg.Data.Ngaysinh.Day + "/" + tg.Data.Ngaysinh.Month + "/" + tg.Data.Ngaysinh.Year), 49, 27);
                    dh.ve1(tg.Data.Gioitinh, 67, 27);
                    dh.ve1(tg.Data.Diachi, 85, 27);
                    dh.ve1(tg.Data.Sodienthoai, 111, 27);
                    dh.ve1(Convert.ToString(tg.Data.Makhoa), 126, 27);
                    tg = tg.Link;
                    i = i + 2;
                }
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Nhan Enter de tim kiem tiep!", 15, 49);
                dh.ve1("Nhan F12 de tro lai", 15, 50);
                dh.ve1("Nhan F10 de tro lai menu chinh", 15, 51);
                dh.ve1("Nhan Esc de thoat", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("                               ",84, 13);
                        for (int i1 = 27; i1 < 48; ++i1)
                        {
                            dh.ve1("      ", 7, i1);
                            dh.ve1("                           ", 15, i1);
                            dh.ve1("              ", 45, i1);
                            dh.ve1("            ", 62, i1);
                            dh.ve1("                                ", 75, i1);
                            dh.ve1("              ", 109, i1);
                            dh.ve1("          ", 124, i1);
                        }
                        dh.ve1("                                          ", 15, 49);
                        dh.ve1("                                         ", 15, 50);
                        dh.ve1("                                        ", 15, 51);
                        dh.ve1("                                       ", 15, 52);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ban go sai phim!", 15, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Ten SV nay khong ton tai trong he thong!!!", 15, 49);
                dh.ve1("Nhan Enter de nhap lai!", 15, 50);
                dh.ve1("Nhan F12 de tro lai", 15, 51);
                dh.ve1("Nhan F10 de tro lai menu chinh", 15, 52);
                dh.ve1("Nhan Esc de thoat", 15, 53);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("                               ", 84, 13);
                        dh.ve1("                                                             ", 15, 49);
                        dh.ve1("                                        ", 15, 50);
                        dh.ve1("                                          ", 15, 51);
                        dh.ve1("                                          ", 15, 52);
                        dh.ve1("                                          ", 15, 53);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
        #endregion
        #region tim kiem sinh vien theo phong
         public void TimKiemPhongSV()
        {
            DoHoa dh = new DoHoa(137, 55);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 4, 0);
            dh.ve1("╚", 4, 54);
            dh.ve1("╗", 136, 0);
            dh.ve1("╝", 136, 54);

            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 0);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 3);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 54);

            for (int i = 1; i < 54; ++i)
            {
                dh.ve1("║", 4, i);
                dh.ve1("║", 136, i);
            }
            dh.ve1("╠", 4, 3);
            dh.ve1("╣", 136, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("***  QUAN LY KY TUC XA  ***", 36, 1);
            dh.ve1("TIM KIEM SINH VIEN", 60, 6);
            dh.ve1("NHAP MA PHONG CUA SINH VIEN CAN TIM: ", 48, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 25, 5);
            dh.ve1("╚", 25, 20);
            dh.ve1("╗", 115, 5);
            dh.ve1("╝", 115, 20);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 5);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 7);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 20);

            for (int i = 6; i < 20; ++i)
            {
                dh.ve1("║", 25, i);
                dh.ve1("║", 115, i);
            }
            dh.ve1("╠", 25, 7);
            dh.ve1("╣", 115, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 21);
            dh.ve1("╠", 4, 21);
            dh.ve1("╣", 136, 21);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 5, 22);
            dh.ve1("╚", 5, 48);
            dh.ve1("╗", 135, 22);
            dh.ve1("╝", 135, 48);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 22);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 24);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 48);

            for (int i = 23; i < 48; ++i)
            {
                dh.ve1("║", 5, i);
                dh.ve1("║", 135, i);
            }

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("DANH SACH SINH VIEN TRONG KY TUC XA", 53, 23);


            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 25; i < 48; ++i)
            {
                dh.ve1("│", 14, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 61, i);
                dh.ve1("│", 74, i);
                dh.ve1("│", 108, i);
                dh.ve1("│", 123, i);
            }

            dh.ve1("╤", 14, 24); dh.ve1("╧", 14, 48);
            dh.ve1("╤", 44, 24); dh.ve1("╧", 44, 48);
            dh.ve1("╤", 61, 24); dh.ve1("╧", 61, 48);
            dh.ve1("╤", 74, 24); dh.ve1("╧", 74, 48);
            dh.ve1("╤", 108, 24); dh.ve1("╧", 108, 48);
            dh.ve1("╤", 123, 24); dh.ve1("╧", 123, 48);
            dh.ve1("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────", 6, 26);
            dh.ve1("┼", 14, 26);
            dh.ve1("┼", 44, 26);
            dh.ve1("┼", 61, 26);
            dh.ve1("┼", 74, 26);
            dh.ve1("┼", 108, 26);
            dh.ve1("┼", 123, 26);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("MaSV", 8, 25);
            dh.ve1("HoTenSV", 27, 25);
            dh.ve1("NgaySinh", 49, 25);
            dh.ve1("GioiTinh", 64, 25);
            dh.ve1("DiaChi", 89, 25);
            dh.ve1("SDT", 115, 25);
            dh.ve1("MaKhoa", 126, 25);
            Console.ForegroundColor = ConsoleColor.White;
        den:
            int maphong;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
               dh.ve1("", 86, 13);
                maphong = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve1("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 35, 16);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("                                                                   ", 35, 16);
                        dh.ve1("                    ", 86, 13);
                        Console.ResetColor();
                        goto den;
                }
            }
            if (PBLL.KTMaPhong(maphong) == false)
            {
                if (PBLL.MaPhongTrong(maphong)==false)
                {
                    List<SinhVien> ListSV = SVBLL.TimKiemTheoMaPhong(maphong);
                    Node<SinhVien> tg = ListSV.Head;
                    int a = 28;
                    int dem = 0;
                    while (tg != null)
                    {
                        if (dem < 10)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            dh.ve1(Convert.ToString(tg.Data.Masinhvien), 8, a);
                            dh.ve1(tg.Data.Hoten, 23, a);
                            dh.ve1(Convert.ToString(tg.Data.Ngaysinh.Day + "/" + tg.Data.Ngaysinh.Month + "/" + tg.Data.Ngaysinh.Year), 49, a);
                            dh.ve1(tg.Data.Gioitinh, 67, a);
                            dh.ve1(tg.Data.Diachi, 85, a);
                            dh.ve1(tg.Data.Sodienthoai, 111, a);
                            dh.ve1(Convert.ToString(tg.Data.Makhoa), 126, a);
                            a = a + 2;
                            dem++;
                            tg = tg.Link;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve1("Nhan Enter de tim kiem tiep!", 15, 49);
                    dh.ve1("Nhan F12 de tro lai", 15, 50);
                    dh.ve1("Nhan F10 de tro lai menu chinh", 15, 51);
                    dh.ve1("Nhan Esc de thoat", 15, 52);
                tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            for (int i = 28; i < 48; ++i)
                            {
                                dh.ve1("       ", 81, i);
                                dh.ve1("      ", 8, i);
                                dh.ve1("                    ", 23, i);
                                dh.ve1("            ", 49, i);
                                dh.ve1("      ", 67, i);
                                dh.ve1("                       ", 85, i);
                                dh.ve1("           ", 111, i);
                                dh.ve1("        ", 126, i);
                            }
                            dh.ve1("              ", 86, 13);
                            dh.ve1("                                          ", 15, 49);
                            dh.ve1("                                              ", 15, 50);
                            dh.ve1("                                            ", 15, 51);
                            dh.ve1("                                           ", 15, 52);
                            Console.ResetColor();
                            goto den;
                        case ConsoleKey.F12:
                            Console.Clear();
                            TimKiemSV();
                            break;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.Escape:
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("Ban go sai phim!", 15, 37);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto tmp1;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve("Ma phong nay hien dang trong khong co sinh vien nao!!!", 15, 49);
                    dh.ve("Nhan Enter de nhap lai!", 15, 50);
                    dh.ve("Nhan F12 de tro lai", 15, 51);
                    dh.ve("Nhan F12\0 de tro lai menu chinh", 15, 52);
                    dh.ve("Nhan Esc de thoat", 15, 53);
                tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve1("         ", 63, 10);
                            dh.ve1("              ", 86, 13);
                            dh.ve1("                                                             ", 15, 49);
                            dh.ve1("                                               ", 15, 50);
                            dh.ve1("                                               ", 15, 51);
                            dh.ve1("                                           ", 15, 52);
                            dh.ve1("                                            ", 15, 53);
                            Console.ResetColor();
                            goto den;
                        case ConsoleKey.F12:
                            Console.Clear();
                            TimKiemSV();
                            break;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.Escape:
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("Ban go sai phim!", 15, 53);
                            Console.ForegroundColor = ConsoleColor.White;
                            goto tmp1;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Ma phong nay khong ton tai trong he thong!!!", 15, 49);
                dh.ve1("Nhan Enter de nhap lai!", 15, 50);
                dh.ve1("Nhan F12 de tro lai", 15, 51);
                dh.ve1("Nhan F12\0 de tro lai menu chinh", 15, 52);
                dh.ve1("Nhan Esc de thoat", 15, 53);
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("              ", 86, 13);
                        dh.ve1("         ", 63, 10);
                        dh.ve1("                                                             ", 15, 49);
                        dh.ve1("                                               ", 15, 50);
                        dh.ve1("                                               ", 15, 51);
                        dh.ve1("                                           ", 15, 52);
                        dh.ve1("                                            ", 15, 53);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ban go sai phim!", 15, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
#endregion
        #region tim kiem sinh vien theo khoa
         public void TimKiemKhoaSV()
        {
            DoHoa dh = new DoHoa(137, 55);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 4, 0);
            dh.ve1("╚", 4, 53);
            dh.ve1("╗", 136, 0);
            dh.ve1("╝", 136, 53);

            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 0);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 3);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 53);

            for (int i = 1; i < 53; ++i)
            {
                dh.ve1("║", 4, i);
                dh.ve1("║", 136, i);
            }
            dh.ve1("╠", 4, 3);
            dh.ve1("╣", 136, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("***  QUAN LY KY TUC XA  ***", 36, 1);
            dh.ve1("TIM KIEM SINH VIEN", 60, 6);
            dh.ve1("NHAP MA KHOA CUA SINH VIEN CAN TIM: ", 50, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 25, 5);
            dh.ve1("╚", 25, 20);
            dh.ve1("╗", 115, 5);
            dh.ve1("╝", 115, 20);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 5);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 7);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════", 26, 20);

            for (int i = 6; i < 20; ++i)
            {
                dh.ve1("║", 25, i);
                dh.ve1("║", 115, i);
            }
            dh.ve1("╠", 25, 7);
            dh.ve1("╣", 115, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 21);
            dh.ve1("╠", 4, 21);
            dh.ve1("╣", 136, 21);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 5, 22);
            dh.ve1("╚", 5, 48);
            dh.ve1("╗", 135, 22);
            dh.ve1("╝", 135, 48);

            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 22);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 24);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 48);

            for (int i = 23; i < 48; ++i)
            {
                dh.ve1("║", 5, i);
                dh.ve1("║", 135, i);
            }

            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("DANH SACH SINH VIEN TRONG KY TUC XA", 53, 23);


            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 25; i < 48; ++i)
            {
                dh.ve1("│", 14, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 61, i);
                dh.ve1("│", 74, i);
                dh.ve1("│", 108, i);
                dh.ve1("│", 123, i);
            }

            dh.ve1("╤", 14, 24); dh.ve1("╧", 14, 48);
            dh.ve1("╤", 44, 24); dh.ve1("╧", 44, 48);
            dh.ve1("╤", 61, 24); dh.ve1("╧", 61, 48);
            dh.ve1("╤", 74, 24); dh.ve1("╧", 74, 48);
            dh.ve1("╤", 108, 24); dh.ve1("╧", 108, 48);
            dh.ve1("╤", 123, 24); dh.ve1("╧", 123, 48);
            dh.ve1("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────", 6, 26);
            dh.ve1("┼", 14, 26);
            dh.ve1("┼", 44, 26);
            dh.ve1("┼", 61, 26);
            dh.ve1("┼", 74, 26);
            dh.ve1("┼", 108, 26);
            dh.ve1("┼", 123, 26);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("MaSV", 8, 25);
            dh.ve1("HoTenSV", 27, 25);
            dh.ve1("NgaySinh", 49, 25);
            dh.ve1("GioiTinh", 64, 25);
            dh.ve1("DiaChi", 89, 25);
            dh.ve1("SDT", 115, 25);
            dh.ve1("MaKhoa", 126, 25);
            Console.ForegroundColor = ConsoleColor.White;
        den: List<Khoa> dsKhoa = KBLL.ListKhoa();
            Node<Khoa> tg1 = dsKhoa.Head;
            int i1 = 15;
            int i2 = 15;
            while (tg1 != null)
            {
                if (tg1.Data.Makhoa <= 4)
                {
                    dh.ve1(CongCu.ChuanHoaXau(tg1.Data.Tenkhoa) + "(Ma so " + Convert.ToString(tg1.Data.Makhoa) + ")", i1, 50);
                    i1 = i1 + 30;
                }
                else
                {
                    dh.ve1(CongCu.ChuanHoaXau(tg1.Data.Tenkhoa) + "(Ma so " + Convert.ToString(tg1.Data.Makhoa) + ")", i2, 52);
                    i2 = i2 + 30;
                }
                tg1 = tg1.Link;
            }
        
           int makhoa;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                 dh.ve1("", 86, 13);
                 makhoa = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve1("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 35, 16);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve1("                                                                   ", 35, 16);
                        dh.ve1("                    ", 86, 13);
                        Console.ResetColor();
                        goto den;
                }
            }
            dh.ve1("", 86, 13);
            Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                                                                                                                              ", 5, 50);
                    dh.ve1("                                                                                                                              ", 5, 52);
                    if (KBLL.KiemTraMaKhoa(makhoa))
            {
                List<SinhVien> ListSV = SVBLL.TimKiemTheoKhoa(makhoa);
                Node<SinhVien> tg = ListSV.Head;
                int a = 28;
                int dem = 0;
                while (tg != null)
                {
                    if (dem < 10)
                    {
                        dh.ve1(Convert.ToString(tg.Data.Masinhvien), 8, a);
                        dh.ve1(tg.Data.Hoten, 23, a);
                        dh.ve1(Convert.ToString(tg.Data.Ngaysinh.Day + "/" + tg.Data.Ngaysinh.Month + "/" + tg.Data.Ngaysinh.Year), 49, a);
                        dh.ve1(tg.Data.Gioitinh, 67, a);
                        dh.ve1(tg.Data.Diachi, 85, a);
                        dh.ve1(tg.Data.Sodienthoai, 111, a);
                        dh.ve1(Convert.ToString(tg.Data.Makhoa), 126, a);
                        a = a + 2;
                        dem++;
                        tg = tg.Link;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Nhan Enter de tim kiem tiep!", 15, 49);
                dh.ve1("Nhan F12 de tro lai", 15, 50);
                dh.ve1("Nhan F10 de tro lai menu chinh", 15, 51);
                dh.ve1("Nhan Esc de thoat", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;
                        for (int i = 28; i < 48; ++i)
                        {
                            dh.ve1("       ", 81, i);
                            dh.ve1("      ", 8, i);
                            dh.ve1("                    ", 23, i);
                            dh.ve1("            ", 49, i);
                            dh.ve1("      ", 67, i);
                            dh.ve1("                       ", 85, i);
                            dh.ve1("           ", 111, i);
                            dh.ve1("        ", 126, i);
                        }
                        dh.ve1("              ", 86, 13);
                        dh.ve1("                                          ", 15, 49);
                        dh.ve1("                                              ", 15, 50);
                        dh.ve1("                                            ", 15, 51);
                        dh.ve1("                                           ", 15, 52);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ban go sai phim!", 15, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Ma khoa nay khong ton tai trong he thong!!!", 15, 49);
                dh.ve1("Nhan Enter de nhap lai!", 15, 50);
                dh.ve1("Nhan F12 de tro lai", 15, 51);
                dh.ve1("Nhan F12\0 de tro lai menu chinh", 15, 52);
                dh.ve1("Nhan Esc de thoat", 15, 53);
                Console.ForegroundColor = ConsoleColor.White;
            tmp1: ConsoleKeyInfo kt1 = Console.ReadKey();
                switch (kt1.Key)
                {
                    case ConsoleKey.Enter:
                        Console.BackgroundColor = ConsoleColor.Black;//nhan phim sau thi xoa du lieu trong bang di
                        dh.ve1("         ", 63, 10);
                        dh.ve1("                                                             ", 15, 49);
                        dh.ve1("                                               ", 15, 50);
                        dh.ve1("                                               ", 15, 51);
                        dh.ve1("                                           ", 15, 52);
                        dh.ve1("                                            ", 15, 53);
                        Console.ResetColor();
                        goto den;
                    case ConsoleKey.F12:
                        Console.Clear();
                        TimKiemSV();
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        menu.MenuChinh1();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ban go sai phim!", 15, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto tmp1;
                }
            }
        }
#endregion
        }
    }

