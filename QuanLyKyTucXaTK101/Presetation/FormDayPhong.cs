using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormDayPhong
    {
        DayPhongBLL d = new DayPhongBLL();
        PhongBLL PBLL = new PhongBLL();
        DoHoa dh = new DoHoa(100, 55);
        public static MenuChinh menu = new MenuChinh();
        public void ChucNangDayPhong()
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
            dh.ve("CAC CHUC NANG QUAN LY DAY", 37, 14);
            dh.ve("F1", 23, 17); dh.ve("Them Day", 35, 17);
            dh.ve("F2", 23, 19); dh.ve("Sua Day", 35, 19);
            dh.ve("F3", 23, 21); dh.ve("Xoa Day", 35, 21);
            dh.ve("F4", 23, 23); dh.ve("Hien Thi Thong Tin Day", 35, 23); 
            dh.ve("Tro lai Menu chinh nhan F10", 23, 27);
            dh.ve("Thoat khoi chuong trinh nhan Esc", 23, 28);
            dh.ve("Ban nhap mot phim chuc nang: ", 45, 35);
          tem:
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    themday();
                    break;
                case ConsoleKey.F2:
                     Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    SuaDayPhong();
                    break;

                case ConsoleKey.F3:
                     Console.BackgroundColor =ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    XoaDayPhong();
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
        #region them day
        public void themday()
        {
      do
        {
            Console.Clear();
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
            dh.ve("              ***  QUAN LY KY TUC XA  ***", 2, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 5);
            dh.ve("╚", 9, 15);
            dh.ve("╗", 89, 5);
            dh.ve("╝", 89, 15);
            
                dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 5);
                dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 7);
                dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 15);
            
            for (int i = 6; i < 15; ++i)
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
            dh.ve("THEM DAY", 45, 6);
            dh.ve("Ma Day: ", 11, 9);
            dh.ve("Ten Day: ", 47, 9);
            dh.ve("Vi tri: ", 11, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 19);
            dh.ve("╚", 9, 45);
            dh.ve("╗", 89, 19);
            dh.ve("╝", 89, 45);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 19);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 21);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 23);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 45);
            for (int i = 20; i < 45; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 21);
            dh.ve("╣", 89, 21);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 21);
            dh.ve("╠", 9, 23);
            dh.ve("╣", 89, 23);
            for (int i = 22; i < 45; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 45, i);
            }
            dh.ve("╦", 20, 21);
            dh.ve("╦", 45, 21);
            dh.ve("╩", 20, 45);
            dh.ve("╩", 45, 45);
            dh.ve("╬", 20, 23);
            dh.ve("╬", 45, 23);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH DAY TRONG KY TUC XA", 35, 20);
            dh.ve("MA DAY", 12, 22);
            dh.ve("TEN DAY", 30, 22);
            dh.ve("VI TRI", 64, 22);
        den1: Node<DayPhong> tg = d.TTdayPhong().Head;
             int a = 24;
             int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                  dh.ve(Convert.ToString(tg.Data.Maday),13,a);
                    dh.ve(tg.Data.Tenday,30,a);
                    dh.ve(tg.Data.Vitri,62,a);
                    tg = tg.Link;
                }
                else break; 
                tmp++;
                a = a + 2; ;
            }
            Console.ForegroundColor = ConsoleColor.White;
      den: 
           
                m: int maday;
                dh.ve("", 18, 9);
                try
                {
                    maday = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap khong dung kieu du lieu!!! Nhan Enter de nhap lai ", 10, 52);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    if (kt.Key == ConsoleKey.Enter)
                    {
                        dh.ve("                                                          ", 10, 52);
                        dh.ve("                  ", 18, 9);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto m;
                    }
                    else
                    {
                        return;
                    }
                }
                if (d.KTMaDayPhong(maday))
                {
                   
                tenday:   dh.ve("", 55, 9); string tenday = Console.ReadLine();
                    if (tenday == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Day la thong tin bat buoc! nhan phim bat ky de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                   ", 15, 52);
                                dh.ve1("                      ", 55, 9);
                                Console.ResetColor();
                                goto tenday;
                        }
                    }

                vitri: dh.ve("", 18, 12); string vitri = Console.ReadLine();
                    if(vitri=="")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Day la thong tin bat buoc! nhan phim bat ky de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                   ", 15, 52);
                                dh.ve("                            ", 18,12);
                                Console.ResetColor();
                                goto vitri;
                        }
                    }
                    DayPhong dp = new DayPhong(maday, tenday, vitri);
                   // dh.ve("", 36, 51);
                 
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve("Tro lai nhan F12", 10, 47);
                    dh.ve("Tro lai menu chinh nhan F10", 10, 48);
                    dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 49);
                    dh.ve("Nhan Enter de them tiep!!! ", 10, 50);
                    dh.ve("Nhan BackSpace de luu va tro lai!", 10, 51);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            d.Them(dp);
                            Console.BackgroundColor = ConsoleColor.Black;
                         
                            for (int i = 24; i < 45; ++i)
                            {
                                dh.ve("          ", 10, i);
                                dh.ve("                       ", 21, i);
                                dh.ve("                           ", 46, i);
                            }
                             dh.ve("                                               ", 10, 47);
                             dh.ve("                                               ", 10, 48);
                            dh.ve("                                                ", 10, 49);
                            dh.ve("                                                ", 10, 50);
                            dh.ve("                                                ", 10, 51);
                            dh.ve("                   ", 18, 9);
                            dh.ve("                        ", 55, 9);
                            dh.ve("                                     ", 18, 12);
                            Console.ResetColor();
                            goto den1;
                        case  ConsoleKey.Backspace:
                            d.Them(dp);
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma day phong nay da ton tai!!! Nhan Enter de nhap lai!", 8, 53);
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                      ", 10, 47);
                            dh.ve("                                                      ", 10, 49);
                            dh.ve("                                                      ", 10, 51);
                            dh.ve("                                                      ", 8, 53);
                            dh.ve("                          ", 17, 9);
                            Console.ResetColor();
                            goto den;
                        default:
                            Console.Clear();
                          ChucNangDayPhong();
                          break;
                    }
                }
            } while (true);
        }
        #endregion
        #region hien thi
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
            
                dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 4);
                dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 38);
            
            for (int i = 4; i < 38; ++i)
            {
                dh.ve("*", 2, i);
                dh.ve("*", 97, i);
            }
            //=================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 6);
            dh.ve("╚", 9, 32);
            dh.ve("╗", 89, 6);
            dh.ve("╝", 89, 32);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 6);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 8);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 32);
            
            for (int i = 7; i < 32; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 8);
            dh.ve("╣", 89, 8);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 10);
            dh.ve("╠", 9, 10);
            dh.ve("╣", 89, 10);
            for (int i = 9; i < 32; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 45, i);
            }
            dh.ve("╦", 20, 8);
            dh.ve("╦", 45, 8);
            dh.ve("╩", 20, 32);
            dh.ve("╩", 45, 32);
            dh.ve("╬", 20, 10);
            dh.ve("╬", 45, 10);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH DAY TRONG KY TUC XA", 32, 7);
            dh.ve("MA DAY", 12, 9);
            dh.ve("TEN DAY", 30, 9);
            dh.ve("VI TRI", 64, 9);
            dh.ve("Tro lai nhan F12", 10, 34);
            dh.ve("Tro ve Menu chinh nhan F10", 10, 35);
            dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 36);
            dh.ve("Ban chon phim chuc nang: ", 65, 36);
            Node<DayPhong> tg = d.TTdayPhong().Head;
            int soluongdayphong = 1;
            while (tg.Link != null)
            {
                soluongdayphong++;
                tg = tg.Link;
            }
            if (soluongdayphong > 0)
            {
                int sodong = 10;
                int tongsotrang;
                if (soluongdayphong >= sodong)
                {
                    tongsotrang = soluongdayphong % sodong == 0 ? soluongdayphong / sodong : soluongdayphong / sodong + 1;
                }
                else
                    tongsotrang = 1;
                int trang = 1;
            
            //Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            den1:   
                VeTrang(trang);
            Console.ForegroundColor = ConsoleColor.White;
                dh.ve("", 68, 34); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                goto den;
            den :do
                    {
                        
                        dh.ve("", 90, 36);
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
                                ChucNangDayPhong();
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
                dh.ve(" ==>Hien Tai Trong He Thong khong co day phong Nao!", 10, 35);
            }
        }
        public void VeTrang(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 11; i < 32; ++i)
            {
                dh.ve("          ", 10, i);
                dh.ve("                       ", 21, i);
                dh.ve("                           ", 46, i);
            }
            Console.ResetColor();
            int a =12;//vi tri ve bat dau cua dong dau tien
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<DayPhong> tg1 = d.TTdayPhong().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                            Console.ForegroundColor = ConsoleColor.White;
                            dh.ve(Convert.ToString(tg1.Data.Maday), 13, a);
                            dh.ve(tg1.Data.Tenday, 30, a);
                            dh.ve(tg1.Data.Vitri, 62, a);
                            tg1 = tg1.Link;
                        a = a + 2; ;
                        dem++;
                }
                else
                {
                    tg1 = tg1.Link;
                }
            }
        }
        #endregion
        #region xoa day phong
        public void XoaDayPhong()
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
            dh.ve("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 17);
            dh.ve("╠", 0, 17);
            dh.ve("╣", 99, 17);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("              ***  QUAN LY KY TUC XA  ***      ", 2, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 5);
            dh.ve("╚", 9, 15);
            dh.ve("╗", 89, 5);
            dh.ve("╝", 89, 15);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 5);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 15);

            for (int i = 6; i < 15; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("BAN NHAP MA DAY PHONG CAN XOA: ", 20, 10);
            //Khung danh sach====================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 19);
            dh.ve("╚", 9, 45);
            dh.ve("╗", 89, 19);
            dh.ve("╝", 89, 45);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 19);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 45);

            for (int i = 20; i < 45; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 21);
            dh.ve("╣", 89, 21);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 21);
            dh.ve("════════════════════════════════════════════════════════════════════════════════", 10, 23);
            dh.ve("╠", 9, 23);
            dh.ve("╣", 89, 23);
            for (int i = 22; i < 45; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 45, i);
            }
            dh.ve("╦", 20, 21);
            dh.ve("╦", 45, 21);
            dh.ve("╩", 20, 45);
            dh.ve("╩", 45, 45);
            dh.ve("╬", 20, 23);
            dh.ve("╬", 45, 23);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH DAY TRONG KY TUC XA", 35, 20);
            dh.ve("MA DAY", 12, 22);
            dh.ve("TEN DAY", 30, 22);
            dh.ve("VI TRI", 64, 22);
        den2: Node<DayPhong> tg = d.TTdayPhong().Head;
            int a = 24;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg.Data.Maday), 13, a);
                    dh.ve(tg.Data.Tenday, 30, a);
                    dh.ve(tg.Data.Vitri, 62, a);
                    tg = tg.Link;
                }
                else break;
                tmp++;
                a = a + 2; ;
            }
            do
            {
            m: int maday;
                dh.ve("", 51, 10);
                try
                {
                    maday = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap khong dung kieu du lieu!!! Nhan Enter de nhap lai ", 10, 52);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    if (kt.Key == ConsoleKey.Enter)
                    {
                        dh.ve("                                                               ", 10, 52);
                        dh.ve("                  ", 51, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto m;
                    }
                    else
                    {
                        return;
                    }
                }
                if (d.KTMaDayPhong(maday) == false)
                {

                    dh.ve("Tro lai nhan F12", 10, 47);
                    dh.ve("Tro lai menu chinh nhan F10", 10, 48);
                    dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 49);
                    dh.ve("Nhan Enter de xoa tiep!!! ", 10, 50);
                    dh.ve("Nhan BackSpace de luu va tro lai! ", 10, 51);
                    dh.ve("", 35, 51);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            d.XoaDay(maday);
                            PBLL.XoaPhongTheoMaDay(maday);
                            Console.BackgroundColor = ConsoleColor.Black;

                            dh.ve("                              ", 50, 10);
                            dh.ve("                                                          ", 10, 47);
                            dh.ve("                                                          ", 10, 48);
                            dh.ve("                                                          ", 10, 49);
                            dh.ve("                                                          ", 10, 50);
                            dh.ve("                                                          ", 110, 51);
                            for (int i = 24; i < 45; ++i)
                            {
                                dh.ve("          ", 10, i);
                                dh.ve("                       ", 21, i);
                                dh.ve("                           ", 46, i);
                            }
                            Console.ResetColor();
                            goto den2;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.Backspace:
                            d.XoaDay(maday);
                            PBLL.XoaPhongTheoMaDay(maday);
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                }

                else
                {
                    dh.ve("Ma day phong khong ton tai!!! Nhan Enter de nhap lai!", 15, 53);
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                           ", 15, 53);
                            dh.ve("                     ", 50, 10);
                            Console.ResetColor();
                            goto m;
                        default:
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                    }
                }
            } while (true);
        }
        
        #endregion
        #region sua day phong
        public void SuaDayPhong()
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
            dh.ve("              ***  CHUONG TRINH QUAN LY KY TUC XA TRUONG DAI HOC SPKT HUNG YEN  ***      ", 2, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 5);
            dh.ve("╚", 9, 15);
            dh.ve("╗", 89, 5);
            dh.ve("╝", 89, 15);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 5);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 7);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 15);
            
            for (int i = 6; i < 15; ++i)
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
            dh.ve("SUA THONG TIN DAY PHONG", 45, 6);
            dh.ve("Ten day moi: ", 11, 11);
            dh.ve("vi tri moi: ", 47, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 19);
            dh.ve("╚", 9, 45);
            dh.ve("╗", 89, 19);
            dh.ve("╝", 89, 45);

            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 19);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 21);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 45);
            
            for (int i = 20; i < 45; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 89, i);
            }
            dh.ve("╠", 9, 21);
            dh.ve("╣", 89, 21);
            dh.ve("═══════════════════════════════════════════════════════════════════════════════", 10, 23);
            dh.ve("╠", 9, 23);
            dh.ve("╣", 89, 23);
            for (int i = 22; i < 45; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 45, i);
            }
            dh.ve("╦", 20, 21);
            dh.ve("╦", 45, 21);
            dh.ve("╩", 20, 45);
            dh.ve("╩", 45, 45);
            dh.ve("╬", 20, 23);
            dh.ve("╬", 45, 23);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("DANH SACH DAY TRONG KY TUC XA", 35, 20);
            dh.ve("MA DAY", 12, 22);
            dh.ve("TEN DAY", 30, 22);
            dh.ve("VI TRI", 64, 22);
        den: Node<DayPhong> tg = d.TTdayPhong().Head;
            int a = 24;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg.Data.Maday), 13, a);
                    dh.ve(tg.Data.Tenday, 30, a);
                    dh.ve(tg.Data.Vitri, 62, a);
                    tg = tg.Link;
                }
                else break;
                tmp++;
                a = a + 2; ;
            }
            den1:   int maday;
            Console.ForegroundColor = ConsoleColor.White;
                dh.ve("Ban nhap ma day can sua: ", 11, 9);
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    maday = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap khong dung kieu du lieu!!! Nhan Enter de nhap lai ", 10, 52);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    if (kt.Key == ConsoleKey.Enter)
                    {
                        dh.ve("                                                               ", 10, 52);
                        dh.ve("                  ", 51, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto den1;
                    }
                    else
                    {
                        return;
                    }
                }
                if (d.KTMaDayPhong(maday)==false)//neu ton tai ma thi se ket qua la false
                {
                    Node<DayPhong> tg1 = d.TTdayPhong().Head;
                    while (tg1 != null)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if (tg1.Data.Maday == maday)
                        {
                            dh.ve(tg1.Data.Tenday, 23, 11);
                            dh.ve(tg1.Data.Vitri, 58, 11);
                            break;
                        }
                        else
                        {
                            tg1 = tg1.Link;
                        }
                    }
                 dh.ve("", 27, 11);
                 Console.ReadKey();
                 Console.BackgroundColor = ConsoleColor.Black;
                 dh.ve("                      ", 23, 11);
                 Console.ResetColor();
                tenday: dh.ve("", 23, 11);
                    string tendaymoi = Console.ReadLine();
                        if (tendaymoi == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("Day la thong tin bat buoc! nhan phim bat ky de nhap lai!!!", 15, 52);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktht = Console.ReadKey();
                            switch (ktht.Key)
                            {
                                default:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    dh.ve("                                                                   ", 15, 52);
                                    dh.ve("                    ", 23, 11);
                                    Console.ResetColor();
                                    goto tenday;
                            }
                        }
                 dh.ve("", 58, 11);
                 Console.ReadKey();
                 Console.BackgroundColor = ConsoleColor.Black;
                 dh.ve("                       ", 58, 11);
                 Console.ResetColor();
                vitri:  dh.ve("", 58, 11);
                  string vitrimoi = Console.ReadLine();
                  if (vitrimoi == "")
                  {
                      Console.ForegroundColor = ConsoleColor.Red;
                      dh.ve1("Day la thong tin bat buoc! nhan phim bat ky de nhap lai!!!", 15, 52);
                      Console.ForegroundColor = ConsoleColor.White;
                      ConsoleKeyInfo ktht = Console.ReadKey();
                      switch (ktht.Key)
                      {
                          default:
                              Console.BackgroundColor = ConsoleColor.Black;
                              dh.ve("                                                                   ", 15, 52);
                              dh.ve("                 ", 58, 11); 
                              Console.ResetColor();
                              goto vitri;
                      }
                  }
                 DayPhong dp = new DayPhong(maday, tendaymoi, vitrimoi);
                 dh.ve("", 31, 51);
                 Console.ForegroundColor = ConsoleColor.White;
                 dh.ve("Tro lai nhan F12", 10, 47);
                 dh.ve("Tro lai menu chinh nhan F10", 10, 48);
                 dh.ve("Thoat khoi chuong trinh nhan Esc", 10, 49);
                 dh.ve("Nhan Enter de sua tiep!!! ", 10, 50);
                 dh.ve("Nhan BackSpace de luu va tro lai! ", 10, 51);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                             d.XoaDay(maday);
                             d.Them(dp);
                             Console.BackgroundColor = ConsoleColor.Black;
                             dh.ve("                      ", 23, 11);
                             dh.ve("               ", 58, 11);
                            dh.ve("                                              ", 10, 47);
                            dh.ve("                                              ", 10, 48);
                            dh.ve("                                              ", 10, 49);
                            dh.ve("                                              ", 10, 50);
                            dh.ve("                                              ", 10, 51);
                            dh.ve("                        ", 35, 9);
                            for (int i = 24; i < 45; ++i)
                            {
                                dh.ve("          ", 10, i);
                                dh.ve("                       ", 21, i);
                                dh.ve("                           ", 46, i);
                            }
                            Console.ResetColor();
                            goto den;
                        case ConsoleKey.Backspace:
                             d.XoaDay(maday);
                             d.Them(dp);
                             Console.Clear();
                             ChucNangDayPhong();
                             break;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma day phong khong ton tai!! Nhan Enter de nhap lai! ", 10, 53);
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                         ", 10, 53);
                            dh.ve("                        ", 36, 9);
                            Console.ResetColor();
                            goto den1;
                        default:
                            Console.Clear();
                            ChucNangDayPhong();
                            break;
                    }
                }
            } while (true);
        }
        #endregion
    }
}

