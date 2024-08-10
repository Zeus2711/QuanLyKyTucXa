using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
    class FormDienNuoc
    {
        DoHoa dh = new DoHoa(100,55);
        public static MenuChinh menu = new MenuChinh();
        DienBLL dienbll = new DienBLL();
        PhongBLL pbll = new PhongBLL();
        ThuePhongBLL thuephongbll = new ThuePhongBLL();
        SinhVienBLL svbll = new SinhVienBLL();
        DienBLL diendll = new DienBLL();
        HoaDonThanhToanBLL HDBLL = new HoaDonThanhToanBLL();
        #region Form dich vu
        public void FormDichVu()
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
            dh.ve("DICH VU",42,5);
            dh.ve("──────────", 41, 6);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 20, 20);
            dh.ve("╚", 20, 26);
            dh.ve("╗", 79, 20);
            dh.ve("╝", 79, 26);
            dh.ve("══════════════════════════════════════════════════════════", 21, 20);
            dh.ve("══════════════════════════════════════════════════════════", 21, 22);
            dh.ve("══════════════════════════════════════════════════════════", 21, 24);
            dh.ve("══════════════════════════════════════════════════════════", 21, 26);
            for (int i = 21; i < 26; ++i)
            {
                dh.ve("║", 20, i);
                dh.ve("║", 30, i);
                dh.ve("║", 79, i);
            }
            dh.ve("╩",30,26);
            dh.ve("╦",30,20);
            dh.ve("╬", 30, 22); dh.ve("╬", 30, 24);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("F1", 25, 21); dh.ve("Nhap Thong Tin Ve Dien", 35, 21);
            dh.ve("F2", 25, 23); dh.ve("Danh Sach Thong Tin Dien Da Nhap", 35, 23);
            dh.ve("F3", 25, 25); dh.ve("Thanh Toan Phi Dich Vu KTX Cho SV", 35, 25);
            dh.ve("Tro lai menu chinh      F10", 25, 30);
            dh.ve("thoat chuong trinh      Esc", 25, 32); 
            dh.ve("Ban chon phim chuc nang:   ", 25, 34);
        tem: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    NhapSoCTDien();
                    break;
                case ConsoleKey.F2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    DanhSachDienDaNhap();
                    break;
                case ConsoleKey.F3:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                      ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    HoaDonKTX();
                    break;
                case ConsoleKey.F10:
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve("                                                 ", 23, 29);
                    Console.ResetColor();
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang!!!", 23, 29);
                    goto tem;
            }
        }
        #endregion
        #region Nhap so cong to dien
        public void NhapSoCTDien()
        {
        tmp: Console.ForegroundColor = ConsoleColor.Green;
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
            dh.ve("NHAP THONG TIN VE DIEN", 36, 5);
            dh.ve("──────────────────────", 36, 6);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 5, 20);
            dh.ve("╚", 5, 47);
            dh.ve("╗", 95, 20);
            dh.ve("╝", 95, 47);

            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 20);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 47);
            for (int i = 21; i < 47; ++i)
            {
                dh.ve("║", 5, i);
                dh.ve("║", 95, i);
            }
            for (int i = 21; i < 47; ++i)
            {
                dh.ve("│", 15, i);
                dh.ve("│", 32, i);
                dh.ve("│", 55, i);
                dh.ve("│", 76, i);
            }
            dh.ve("╤", 15, 20); dh.ve("╧", 15, 47);
            dh.ve("╤", 32, 20); dh.ve("╧", 32, 47);
            dh.ve("╤", 55, 20); dh.ve("╧", 55, 47);
            dh.ve("╤", 76, 20); dh.ve("╧", 76, 47);
            dh.ve("─────────────────────────────────────────────────────────────────────────────────────────", 6, 23);
            dh.ve("┼", 15, 23); dh.ve("┼", 32, 23); dh.ve("┼", 55, 23); dh.ve("┼", 76, 23);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Ma Phong : ", 10, 12);
            dh.ve("So Cong To Dien : ", 10, 15);
            dh.ve("Thang      Nam", 65, 12);
            dh.ve("ID Dien", 7, 21);
            dh.ve("Ma Phong", 20, 21);
            dh.ve("So Cong To Dien", 37, 21); dh.ve("Thang Truoc", 39, 22);
            dh.ve("So Cong To Dien", 58, 21); dh.ve("Thang Nay", 61, 22);
            dh.ve("Tong So Dien", 80, 21); dh.ve("Da Dung", 82, 22);
            List<Dien> ds = dienbll.DSDien();
            Node<Dien> tg = ds.Head;
            int dem = 0;
            int a = 24;
            while (tg != null)
            {
                if (dem < 10)
                {
                    dh.ve(Convert.ToString(tg.Data.Iddien), 8, a);
                    dh.ve(Convert.ToString(tg.Data.Maphong), 24, a);
                    dh.ve(Convert.ToString(dienbll.NhanSoCongToThangTruoc(tg.Data.Maphong, tg.Data.Thang)), 43, a);
                    dh.ve(Convert.ToString(tg.Data.Socngtothangnay), 63, a);
                    dh.ve(Convert.ToString(tg.Data.Sodiendadung), 87, a);
                    a += 2;
                    tg = tg.Link;
                }
                else
                {
                    break;
                }
            }
            DateTime ngayhethong = DateTime.Now;
            dh.ve(Convert.ToString(ngayhethong.Month), 72, 12);
            dh.ve(Convert.ToString(ngayhethong.Year), 80, 12);
        maphong: int maphong;
            int socongtothangnay;
            try
            {
                dh.ve("", 20, 12);
                maphong = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma phong phai la kieu so! nhan phim bat ki de nhap lai", 15, 53);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                   ", 15, 53);
                        dh.ve("                 ", 20, 12);
                        Console.ResetColor();
                        goto maphong;
                }
            }
            if (pbll.KTMaPhong(maphong) == false)//ma phong co ton tai trong he thong
            {
                if (dienbll.KiemTraPhongDaNhapSoDien(maphong) == false)//ma phong chua nhap so dien thang nay
                {
                socongtothangnay:
                    try
                    {
                        dh.ve("", 27, 15);
                        socongtothangnay = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("So cong to phai la kieu so! nhan phim bat ki de nhap lai", 15, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                   ", 15, 53);
                                dh.ve("                    ", 27, 15);
                                Console.ResetColor();
                                goto socongtothangnay;
                        }
                    }
                    if (socongtothangnay < dienbll.NhanSoCongToThangTruoc(maphong, ngayhethong.Month))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("So cong to thang nay phai lon hon hoac bang thang truoc! nhap lai", 15, 53);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                    ", 15, 53);
                                dh.ve("               ", 27, 15);
                                Console.ResetColor();
                                goto socongtothangnay;
                        }
                    }
                    dh.ve("Nhap Tiep                      Enter", 20, 48);
                    dh.ve("Luu va tro lai                 BackSpace", 20, 49);
                    dh.ve("Tro Lai                        F12", 20, 50);
                    dh.ve("Tro Lai Menu Chinh             F10", 20, 51);
                    dh.ve("Thoat khoi chuong trinh        ESC", 20, 52);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.Clear();
                            int sodiendadung = socongtothangnay - dienbll.NhanSoCongToThangTruoc(maphong, ngayhethong.Month);
                            Dien dien1 = new Dien(dienbll.GetIDDien(), ngayhethong.Month, ngayhethong.Year, maphong, socongtothangnay, sodiendadung);
                            dienbll.ThemHoSoDien(dien1);
                            goto tmp;
                        case ConsoleKey.Backspace:
                            Console.Clear();
                            int sodiendadung1 = socongtothangnay - dienbll.NhanSoCongToThangTruoc(maphong, ngayhethong.Month);
                            Dien tiendien1 = new Dien(dienbll.GetIDDien(), ngayhethong.Month, ngayhethong.Year, maphong, socongtothangnay, sodiendadung1);
                            dienbll.ThemHoSoDien(tiendien1);
                            FormDichVu();
                            break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            FormDichVu();
                            break;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                }
                else//truong hop ma phong da nhap so dien
                {
                    int soctthangnay = dienbll.NhanSoCongToThangNay(maphong, ngayhethong.Month);
                    dh.ve(Convert.ToString(soctthangnay),28,15);
                    Console.ForegroundColor=ConsoleColor.Red;
                    dh.ve("Phong co ma nay da nhap so cong to thang nay roi!", 20, 17);
                    Console.ForegroundColor=ConsoleColor.White;
                    dh.ve("De sua so cong to dien         Enter", 20, 48);
                    dh.ve("De nhap lai ma phong           F11", 20, 49);
                    dh.ve("Tro Lai  chuong trinh          F12", 20, 50);
                    dh.ve("Tro Lai Menu Chinh             F10", 20, 51);
                    dh.ve("Thoat khoi chuong trinh        ESC", 20, 52);
                    
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            //Console.Clear();
                             dh.ve("                                                 ", 20, 17);
                             dh.ve("                                                 ", 20, 48);
                             dh.ve("                                                 ", 20, 49);
                             dh.ve("                                        ", 20, 50);
                             dh.ve("                                        ", 20, 51);
                             dh.ve("                                        ", 20, 52);
                             dh.ve("              ", 28, 15);
                             dh.ve("                   ", 28, 15);
                    scttn:dh.ve("", 28, 15);
                             int scttn;
                             try
                             {
                                 scttn = int.Parse(Console.ReadLine());
                             }
                             catch
                             {
                                 Console.ForegroundColor = ConsoleColor.Red;
                                 dh.ve("So cong to phai la kieu so! nhan phim bat ki de nhap lai", 15, 53);
                                 Console.ForegroundColor = ConsoleColor.White;
                                 ConsoleKeyInfo ktht = Console.ReadKey();
                                 switch (ktht.Key)
                                 {
                                     default:
                                         Console.BackgroundColor = ConsoleColor.Black;
                                         dh.ve("                                                                   ", 15, 53);
                                         dh.ve("                    ", 27, 15);
                                         Console.ResetColor();
                                         goto scttn;
                                 }
                             }
                             dh.ve("Luu va nhap moi ma phong       Enter", 20, 48);
                             dh.ve("Luu va tro lai chuong trinh    BackSpace", 20, 49);
                             dh.ve("Tro Lai  chuong trinh          F12", 20, 50);
                             dh.ve("Tro Lai Menu Chinh             F10", 20, 51);
                             dh.ve("Thoat khoi chuong trinh        ESC", 20, 52);
                             ConsoleKeyInfo kt2 = Console.ReadKey();
                             switch (kt2.Key)
                             {
                                 case ConsoleKey.Enter:
                                     int sodiendadung = scttn - dienbll.NhanSoCongToThangTruoc(maphong, ngayhethong.Month);
                                     int iddien = dienbll.LayIDDien(maphong);//gan iddien cua doi tuong can sua 
                                     dienbll.XoaHoSoDien(maphong);
                                     Dien dien = new Dien(iddien, ngayhethong.Month, ngayhethong.Year, maphong, scttn, sodiendadung);
                                     dienbll.ThemHoSoDien(dien);
                                     Console.Clear();
                                     goto tmp;
                                 case ConsoleKey.Backspace:
                                     int sodiendadung1 = scttn - dienbll.NhanSoCongToThangTruoc(maphong, ngayhethong.Month);
                                     int iddien1 = dienbll.LayIDDien(maphong);
                                     dienbll.XoaHoSoDien(maphong);
                                     Dien dien1 = new Dien(iddien1, ngayhethong.Month, ngayhethong.Year, maphong, scttn, sodiendadung1);
                                     dienbll.ThemHoSoDien(dien1);
                                     Console.Clear();
                                     FormDichVu();
                                     break;
                                 case ConsoleKey.F12:
                                     Console.Clear();
                                     FormDichVu();
                                     break;
                                 case ConsoleKey.F10:
                                     Console.Clear();
                                     menu.MenuChinh1();
                                     break;
                                 case ConsoleKey.Escape:
                                     return;
                             }
                             break;
                       case  ConsoleKey.F11:
                             Console.Clear();
                             goto tmp;
                       case ConsoleKey.F12:
                             Console.Clear();
                             FormDichVu();
                             break;
                       case ConsoleKey.F10:
                             Console.Clear();
                             menu.MenuChinh1();
                             break;
                       case ConsoleKey.Escape:
                             return;
                             
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma phong nay khong ton tai! nhan phim bat ki de nhap lai", 15, 53);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                   ", 15, 53);
                        dh.ve("               ", 20, 12);
                        Console.ResetColor();
                        goto maphong;
                }
            }
        }
        #endregion
        #region Danh sach dien da nhap
        public void DanhSachDienDaNhap()
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
            dh.ve("DANH SACH THONG TIN DIEN DA NHAP", 36, 10);
            dh.ve("────────────────────────────────", 36, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 5, 20);
            dh.ve("╚", 5, 47);
            dh.ve("╗", 95, 20);
            dh.ve("╝", 95, 47);

            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 20);

            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 47);
            for (int i = 21; i < 47; ++i)
            {
                dh.ve("║", 5, i);
                dh.ve("║", 95, i);
            }
            for (int i = 21; i < 47; ++i)
            {
                dh.ve("│", 15, i);
                dh.ve("│", 32, i);
                dh.ve("│", 55, i);
                dh.ve("│", 76, i);
            }
            dh.ve("╤", 15, 20); dh.ve("╧", 15, 47);
            dh.ve("╤", 32, 20); dh.ve("╧", 32, 47);
            dh.ve("╤", 55, 20); dh.ve("╧", 55, 47);
            dh.ve("╤", 76, 20); dh.ve("╧", 76, 47);
            dh.ve("─────────────────────────────────────────────────────────────────────────────────────────", 6, 23);
            dh.ve("┼", 15, 23); dh.ve("┼", 32, 23); dh.ve("┼", 55, 23); dh.ve("┼", 76, 23);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("ID Dien", 7, 21);
            dh.ve("Ma Phong", 20, 21);
            dh.ve("So Cong To Dien", 37, 21); 
            dh.ve("Thang Truoc", 39, 22);
            dh.ve("So Cong To Dien", 58, 21); 
            dh.ve("Thang Nay", 61, 22);
            dh.ve("Tong So Dien", 80, 21); dh.ve("Da Dung", 82, 22);
            dh.ve("Tro Lai                        F12", 20, 50);
            dh.ve("Tro Lai Menu Chinh             F10", 20, 51);
            dh.ve("Thoat khoi chuong trinh        ESC", 20, 52);
            dh.ve("Ban chon phim chu nang sau:", 60, 52);
            Node<Dien> tg = dienbll.DSDien().Head;
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
                dh.ve("", 68, 49); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                goto den;
            den :do
                    {
                        
                        dh.ve("", 90, 53);
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
                                FormDichVu();
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
                dh.ve(" ==>Hien Tai Trong He Thong khong co ban ghi nao!", 10, 35);
            }
        }
        #endregion
        #region ve trang danh sach dien
        public void VeTrang(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 24; i < 46; ++i)
            {
                dh.ve("        ", 7, i);
                dh.ve("          ", 20, i);
                dh.ve("          ", 40, i);
                dh.ve("          ", 60, i);
                dh.ve("          ", 83, i);
            }
            Console.ResetColor();
            int a = 25;//vi tri ve bat dau cua dong dau tien
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<Dien> tg = dienbll.DSDien().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg != null)
            {
               dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                    dh.ve(Convert.ToString(tg.Data.Iddien), 8, a);
                    dh.ve(Convert.ToString(tg.Data.Maphong), 24, a);
                    dh.ve(Convert.ToString(dienbll.NhanSoCongToThangTruoc(tg.Data.Maphong, tg.Data.Thang)), 43, a);
                    dh.ve(Convert.ToString(tg.Data.Socngtothangnay), 63, a);
                    dh.ve(Convert.ToString(tg.Data.Sodiendadung), 85, a);
                    a += 2;
                    tg = tg.Link;
                }
                else
                {
                    tg = tg.Link;
                }
            }
            
        }
        #endregion
        #region hoa don thanh toan
        public void HoaDonKTX()
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
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve("╔", 5, 8);
            dh.ve("╚", 5, 47);
            dh.ve("╗", 95, 8);
            dh.ve("╝", 95, 47);

            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 8);
            dh.ve("═════════════════════════════════════════════════════════════════════════════════════════", 6, 47);
            for (int i = 9; i < 47; ++i)
            {
                dh.ve("║", 5, i);
                dh.ve("║", 95, i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("QUAN LY KY TUC XA", 52, 10);
            dh.ve("CONG HOA XA HOI CHU NGHIA VIET NAM", 7, 10);
            dh.ve("Doc Lap - Tu Do - Hanh Phuc", 11, 11);
            dh.ve("PHONG KE HOACH-TAI VU", 60, 11);
            dh.ve("Ma don vi CQHVNS: 1055599", 58, 12);
            dh.ve("DT: 03213713082", 63, 13);
            dh.ve("HOA DON THU TIEN KTX DHSPKTHY", 37, 17);
            dh.ve("─────────────────────────", 39, 18);
            
            dh.ve("Ky Tuc Xa Dai Hoc lusacp, Ngay      Thang      Nam ", 15, 23);
            dh.ve("Ma SV      :", 19, 25);
            dh.ve("Ho Ten SV  :", 19, 27);
            dh.ve("Ma Phong   :", 19, 29);
            dh.ve("Tien Phong :              dong", 19, 31);
            dh.ve("Tien Dien  :              dong", 19, 33);
            dh.ve("Tien Nuoc  :              dong", 19, 35);
            dh.ve("─────────────────────────────────────────", 15, 36);
            dh.ve("Tong Tien  :              dong", 19, 37);
            dh.ve("Nguoi Nop Tien", 19, 39); dh.ve("Nguoi Thu Tien", 69, 39);
            dh.ve("(Ki Ten)", 23, 40); dh.ve("(Ki Ten)", 73, 40);
            dh.ve("(*)Quy Dinh : Tien Dien Duoc Tinh Theo Gia 3,000 d/1kwh", 19, 43);
            dh.ve("Tien Nuoc Duoc Tinh Theo Gia 50,000 d/thang/1SV", 33, 44);
            DateTime ngayhethong = DateTime.Now;
            dh.ve(Convert.ToString(ngayhethong.Day) , 54, 23);
            dh.ve(Convert.ToString(ngayhethong.Month), 64, 23);
            dh.ve(Convert.ToString(ngayhethong.Year), 73, 23);
      masv: int masv;
            try
            {
                dh.ve("", 32, 25);
                masv = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktht = Console.ReadKey();
                switch (ktht.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                   ", 15, 52);
                        dh.ve("                      ", 32, 25);
                        Console.ResetColor();
                        goto masv;
                }
            }
            HoaDonThanhToan hd=new HoaDonThanhToan();
            if (svbll.KTMaSinhVien(masv) == false)
            {
                if (svbll.KiemTraSVConThuePH(masv) == false)
                {
                    if (HDBLL.KiemTradathanhtoanKTX(masv, ngayhethong) == false)
                    {
                        SinhVien sv = svbll.TimKiemTheoMaSV(masv);
                        Phong phong = pbll.TimKiemTheoMaPhong(thuephongbll.NhanMaPhongSVDangThue(masv));
                        double tiendien = (diendll.NhanSoDienDaDung(thuephongbll.NhanMaPhongSVDangThue(masv), ngayhethong) * 3000) / (float)phong.Sosinhvienhientai;
                        double tongtienphaitra = phong.Giaphong + tiendien + 50000;
                        hd = new HoaDonThanhToan(HDBLL.NhanIDHDTT(), masv, phong.Maphong, ngayhethong, phong.Giaphong, tiendien, tongtienphaitra);
                        Console.ForegroundColor = ConsoleColor.Green;
                        dh.ve(sv.Hoten, 32, 27);
                        dh.ve(Convert.ToString(phong.Maphong), 32, 29);
                        dh.ve(Convert.ToString(phong.Giaphong), 32, 31);
                        dh.ve(Convert.ToString(tiendien), 32, 33);
                        dh.ve(Convert.ToString(50000), 32, 35);
                        dh.ve(Convert.ToString(tongtienphaitra), 32, 37);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve("Ma sinh vien nay da thanh toan thang nay! nhan phim bat ki de nhap lai!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktsdt = Console.ReadKey();
                        switch (ktsdt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve("                                                                               ", 15, 52);
                                dh.ve("                    ", 32, 25);
                                Console.ResetColor();
                                goto masv;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ma sinh vien nay da khong con thue phong! nhan phim bat ki de nhap lai!", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktsdt = Console.ReadKey();
                    switch (ktsdt.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve("                                                                               ", 15, 52);
                            dh.ve("                    ", 32, 25);
                            Console.ResetColor();
                            goto masv;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve("Ma sinh vien khong ton tai trong he thong! nhan phim bat ki de nhap lai!", 15, 52);
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo ktsdt = Console.ReadKey();
                switch (ktsdt.Key)
                {
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        dh.ve("                                                                         ", 15, 52);
                        dh.ve("                     ", 32, 25);
                        Console.ResetColor();
                        goto masv;
                }
            } 
            dh.ve("De in hoa don va tro lai      Backspace", 9, 49);
            dh.ve("De tro lai chuong trinh       F12", 9, 50);
            dh.ve("Tro lai Menu chinh            F10", 9, 51);
            dh.ve("Thoat chuong trinh            Esc", 9, 52);
            dh.ve("Ban chon phim chuc nang :     ", 55, 48);
        tmp: ConsoleKeyInfo k = Console.ReadKey();
            switch (k.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    HDBLL.Them(hd);
                    HoaDonKTX();
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    HDBLL.Them(hd);
                    FormDichVu();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban chon sai phim chuc nang!", 55, 50);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto tmp;
            }
        }
         #endregion
    }
}
