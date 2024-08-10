using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormThongTinKhac
    {
        DoHoa dh = new DoHoa(100,55);
        public static MenuChinh menu = new MenuChinh();
        KhoaBLL KBLL = new KhoaBLL();
        public void ThongTinKhac()
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
            dh.ve("THONG TIN KHAC", 44, 8);
            dh.ve("──────────────", 44, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 9, 20);
            dh.ve("╚", 9, 24);
            dh.ve("╗", 90, 20);
            dh.ve("╝", 90, 24);

            dh.ve("════════════════════════════════════════════════════════════════════════════════", 10, 20);
            dh.ve("════════════════════════════════════════════════════════════════════════════════", 10, 24);
            for (int i = 21; i < 24; ++i)
            {
                dh.ve("║", 9, i);
                dh.ve("║", 90, i);
                dh.ve("│", 15, i);
            }
            dh.ve("────────────────────────────────────────────────────────────────────────────────", 10, 22);
            dh.ve("┼", 15, 22);
            dh.ve("╤", 15, 20);
            dh.ve("╧", 15, 24);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 12, 21); dh.ve("Danh Sach Cac Dia Diem Ky Tuc Xa", 20, 21);
            dh.ve("F2", 12, 23); dh.ve("Nhung Dieu Khoan Quy Dinh Khi O Ki Tuc Xa DT", 20, 23);
              dh.ve("Tro ve Menu chinh  F10", 12, 26);
              dh.ve("Thoat chuong trinh Esc", 12, 27);
              dh.ve("Ban chon phim chu nang: ", 12, 28);
        tem:
              dh.ve("",35,28);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    DsKhoa();
                    break;
                case ConsoleKey.F2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 30);
                    Console.ResetColor();
                    Console.Clear();
                    QuyDinh();
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
                    dh.ve("Ban go sai phim chuc nang! Xin nhan lai", 23, 30);
                    goto tem;
            }
        }
        public void DsKhoa()
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
            dh.ve("DANH SACH KHOA", 44, 8);
            dh.ve("──────────────", 44, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 5, 15);
            dh.ve("╚", 5, 42);
            dh.ve("╗", 95, 15);
            dh.ve("╝", 95, 42);

            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 15);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 17);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 42);
            for (int i = 16; i < 42; ++i)
            {
                dh.ve("║", 5, i);
                dh.ve("║", 95, i);
            }
            for (int i = 18; i < 42; ++i)
            {
                dh.ve("│", 15, i);
                dh.ve("│", 45, i);
                dh.ve("│", 75, i);
            }
            dh.ve("╤", 15, 17);
            dh.ve("╤", 45, 17);
            dh.ve("╤", 75, 17); 
            dh.ve("╧", 15, 42);
            dh.ve("╧", 45, 42);
            dh.ve("╧", 75, 42);
            dh.ve("─────────────────────────────────────────────────────────────────────────────────────────", 6, 19);
            dh.ve("┼", 15, 19); dh.ve("┼", 45, 19); dh.ve("┼", 75, 19);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Thong Tin lUSACO", 30, 16);
            dh.ve("GIAM DOC", 7, 18);
            dh.ve("CSKH", 27, 18);
            dh.ve("Email", 54, 18);
            dh.ve("SDT", 84, 18);
            Node<Khoa> tg = KBLL.ListKhoa().Head;
            int a = 21;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg.Data.Makhoa), 10, a);
                    dh.ve(tg.Data.Tenkhoa,21, a);
                    dh.ve(tg.Data.Email,48, a);
                    dh.ve(tg.Data.Sodienthoai, 80, a);
                    tg = tg.Link;
                }
                else break;
                tmp++;
                a = a + 2;
            }
            dh.ve("Tro Lai Chuong Trinh           F12", 20, 48);
            dh.ve("Tro Lai Menu Chinh             F10", 20, 49);
            dh.ve("Thoat khoi chuong trinh        ESC", 20, 50);
            dh.ve("Ban chon phim chu nang:", 20, 51);
        tem:
            dh.ve("",82, 53);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F12:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 51);
                    Console.ResetColor();
                    Console.Clear();
                    ThongTinKhac();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang! Xin nhan lai", 23, 52);
                    goto tem;
            }
        }
        public void QuyDinh()
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

            dh.ve("* * * QUY DINH CHUNG KI TUC XA LUSACO * * *", 25, 5);
            dh.ve("────────────────────────────────", 35, 6);
            dh.ve("Tat ca HSSV o tai KTX deu phai chap hanh nhung quy dinh sau:", 3, 10);
            dh.ve("1. Hoc sinh, sinh vien o tai ky tuc xa phai chap hanh day da cac  quy dinh cua doi tu quan va", 5, 12);
            dh.ve("Ban quan ly Ky tuc xa, o dung so phong, so giuong da dang ky.", 8, 13);
            dh.ve("2. Giu gin trat tu tri an trong Ki Tuc Xa, khong gay go danh nhau, cam danh co, danh bai duoi", 5, 15);
            dh.ve("moi hinh thuc, cam uong bia, ruou, cac chat kich thich, cam dung chat de chay no trong KTX", 8, 16);
            dh.ve("3. Co Trach nhiem bao quan tai san, phuong tien trang bi chung cua tap the  va  tu  trang  ca", 5, 18);
            dh.ve("nhan.  Khi khong o ki tuc xa phai tra lai day du cac phuong tien, tai san duoc trang bi va", 8, 19);
            dh.ve("cho muon cho can bo quan ly. Moi mat mat hu hong phai boi hoan 100%", 8, 20);
            dh.ve("4. Giu ve sinh phong o va  ki tuc xa, tu  trang  gon  gang  sach dep, van minh, cam viet, ve,", 5, 22);
            dh.ve("   treo dan len tuong va cua.", 5, 23);
            dh.ve("5. Cam nau an, nau nuoc trong phong duoi moi hinh thuc va thuc hien tiet kiem nuoc.", 5, 25);
            dh.ve("6. Khong tiep khach trong gio hoc, buoi toi khong tiep khach qua 22 gio.", 5, 27);
            dh.ve("7. Khong cho phep nguoi ngoai, sinh vien ngoai tru vao o trong khu noi tru.", 5, 29);
            dh.ve("Tren day la mot so  quy  dinh sinh  hoat o  ki tuc xa. Yeu cau HSSV nghiem chinh tu giac chap", 5, 32);
            dh.ve("hanh. Neu vi pham nhung quy dinh tren, tuy theo muc do se xu ly theo quy dinh cua nha truong.", 5, 33);
            dh.ve("TRUONG DAI HOC SU PHAM KI THUAT HUNG YEN", 44, 38);
            dh.ve("(Hung Yen University of Technology and Education)", 40, 39);
            dh.ve("PGS.TS, Hieu truong Tran Trung", 50, 42);
            dh.ve("(Da Ki)", 59, 43);
            dh.ve("Tro Lai Chuong Trinh           F12", 20, 49);
            dh.ve("Tro Lai Menu Chinh             F10", 20, 50);
            dh.ve("Thoat khoi chuong trinh        ESC", 20, 51);
            dh.ve("Ban chon phim chuc nang: ", 20, 52);
        tem:
            dh.ve("", 82, 53);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F12:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 53);
                    Console.ResetColor();
                    Console.Clear();
                    ThongTinKhac();
                    break;
                case ConsoleKey.F10:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 53);
                    Console.ResetColor();
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang! Xin nhan lai", 23, 53);
                    goto tem;
            }
        }
    }
}
