using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Utility;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
namespace QuanLyKyTucXaTK101.Presetation
{
   class FormDangNhap
    {
       DoHoa dh = new DoHoa(100, 55);
        DanhNhapBLL DangNB = new DanhNhapBLL();
        MenuChinh menu = new MenuChinh();
        public void KhoiDong()
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
            //=======================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 22, 20);
            dh.ve("╚", 22, 32);
            dh.ve("╗", 78, 20);
            dh.ve("╝", 78, 32);
            
                dh.ve("═══════════════════════════════════════════════════════", 23, 20);
                dh.ve("═══════════════════════════════════════════════════════", 23, 23);
                dh.ve("═══════════════════════════════════════════════════════", 23, 26);
                dh.ve("═══════════════════════════════════════════════════════", 23, 32);
                dh.ve("═══════════════════════════════", 47, 29);
               

            
            for (int i = 21; i < 32; ++i)
            {
                dh.ve("║", 22, i);
                dh.ve("║", 78, i);
                if (i > 23)
                {
                    dh.ve("║", 47, i);
                }
            }
            dh.ve("╠", 22, 23);
            dh.ve("╣", 78, 23);
            dh.ve("╦", 47, 23);
            dh.ve("╬", 47, 26);
            dh.ve("╠", 22, 26);
            dh.ve("╣", 78, 26);
            dh.ve("╠", 47, 29);
            dh.ve("╣", 78, 29);
            dh.ve("╩", 47, 32);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("QUAN LY KY TUC XA", 24, 21);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("         ───────────────────────────────────", 24, 22);
            dh.ve("  GIAM DOC ", 23, 25);
            dh.ve("HA THANH DAT", 50, 25);
            dh.ve("CHAM SOC KHACH HANG", 25, 29);
            dh.ve("NGUYEN VAN A", 50, 28);
            dh.ve("NGUYEN VAN B", 50, 31);
            dh.ve("Nhan ENTER de dang nhap!", 35, 34);
            ConsoleKeyInfo kt = Console.ReadKey(); 
            switch (kt.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    Dangnhap();
                    break;
                default:
                    return;
            }
        }
        public void Dangnhap()
        {
           string user;
            string pass;
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
                
                    dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 4);
                    dh.ve("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 2, 38);
                
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
                dh.ve("               DANG NHAP HE THONG      ", 25, 11);
               dh.ve("USER", 28, 16);
                dh.ve("PASS", 28, 19);
            den: 
            Console.BackgroundColor = ConsoleColor.Green;
            string s="                                 ";
            dh.ve(s, 33, 16);
            dh.ve(s, 33, 19);
            Console.ForegroundColor = ConsoleColor.Red;
      
            dh.ve("", 34, 16); user = Console.ReadLine();
                dh.ve("", 34, 19); pass = NhapPass();
                Console.ResetColor();
                if (DangNB.KiemTraNick(user, pass) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban nhap sai tai khoan !!! ", 28, 27);
                    dh.ve("Nhan Enter de nhap lai !!!", 28, 28);
                    Console.BackgroundColor = ConsoleColor.Green;
                    string s2 = " ";
                    dh.ve(s2, 80, 35);
                    Console.ResetColor();
                dem:
                    Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("", 80, 35);
                    ConsoleKeyInfo kt = Console.ReadKey();
                Console.ResetColor();
                 switch (kt.Key)
                    {
                     case ConsoleKey.Enter:
                             Console.BackgroundColor = ConsoleColor.Black;
                             string s1="                                                     ";
                             dh.ve(s1, 27, 27);
                             dh.ve(s1, 27, 28);
                             Console.ResetColor();
                          string s3="                           ";
                             dh.ve(s3, 59, 35);
                             Console.ResetColor();
                        
                            goto den;
                        case ConsoleKey.Escape:
                            return;
                        default:

                          Console.BackgroundColor = ConsoleColor.Black;
                          Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve("Ban go sai phim!!!  ", 60, 35);
                          
                            goto dem;
                    }
                }
                else
                {
                    Console.Clear();
                    menu.MenuChinh1();
                }

        }
        
        public string NhapPass()
        {
            string s = null;
            ConsoleKeyInfo kt;
            do
            {
                kt = Console.ReadKey(true);
                if (kt.Key != ConsoleKey.Enter)
                {
                    Console.Write("*");
                    s = s + kt.KeyChar.ToString();
                }
                else break;
            } while (true);
            return s;
        }
        public bool kiemtrataikhoan(DangNhap t)
        {
            bool ok = false;
            if (DangNB.KiemTraNick(t.Urser,t.Pass))
            { ok = true; }
            return ok;

        }
    }
}
