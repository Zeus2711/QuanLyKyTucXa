using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Presetation
{
   class FormSinhVien
    {
        DoHoa dh = new DoHoa(140,55);
        PhongBLL PBLL = new PhongBLL();
        FormTimKiem frmtimkiem = new FormTimKiem();
        KhoaBLL KBLL = new KhoaBLL();
        SinhVienBLL SVBLL = new SinhVienBLL();
        ThuePhongBLL TPBLL = new ThuePhongBLL();
        public static MenuChinh menu = new MenuChinh();
        #region Chuc nang quan ly sinh vien
        public void ChucNangQLSinhVien()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 20, 0);
            dh.ve1("╚", 20, 39);
            dh.ve1("╚", 20, 39);
            dh.ve1("╗", 119, 0);
            dh.ve1("╝", 119, 39);

            dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════════════", 21, 0);
            dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════════════", 21, 3);
            dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════════════", 21, 39);
            
            for (int i = 1; i < 39; ++i)
            {
                dh.ve1("║", 20, i);
                dh.ve1("║", 119, i);
            }
            dh.ve1("╠", 20, 3);
            dh.ve1("╣", 119, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("                 ***QUAN LY KY TUC XA***      ", 22, 1);
            /////===============================================================================================
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 24, 5);
            dh.ve1("╚", 24, 37);
            dh.ve1("╗", 115, 5);
            dh.ve1("╝", 115, 37);
            
                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════", 25, 5);
                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════", 25, 37);
            
            for (int i = 6; i < 37; ++i)
            {
                dh.ve1("║", 24, i);
                dh.ve1("║", 115, i);
            }
            ///====================================================================================================

            Console.ForegroundColor = ConsoleColor.Green;

            dh.ve1("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 22, 4);
            dh.ve1("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 22, 38);
            
            for (int i = 4; i < 38; ++i)
            {
                dh.ve1("*", 22, i);
                dh.ve1("*", 117, i);
            }
            dh.ve1("╔", 39, 12);
            dh.ve1("╚", 39, 24);
            dh.ve1("╗", 99, 12);
            dh.ve1("╝", 99, 24);

            dh.ve1("═══════════════════════════════════════════════════════════", 40, 12);
            dh.ve1("═══════════════════════════════════════════════════════════", 40, 24);

            for (int i = 13; i < 24; ++i)
            {
                dh.ve1("║", 39, i);
                dh.ve1("║", 99, i);
            }
            dh.ve1("╠", 39, 20);
            dh.ve1("╠", 39, 22);
            dh.ve1("╠", 39, 18);
            dh.ve1("╠", 39, 16);
            dh.ve1("╣", 99, 22);
            dh.ve1("╣", 99, 20);
            dh.ve1("╣", 99, 18);
            dh.ve1("╣", 99, 16);
            dh.ve1("═══════════════════════════════════════════════════════════", 40, 22);
            dh.ve1("═══════════════════════════════════════════════════════════", 40, 20);
            dh.ve1("═══════════════════════════════════════════════════════════", 40, 18);
            dh.ve1("═══════════════════════════════════════════════════════════", 40, 16);

            for (int i = 17; i < 24; ++i)
            {
                dh.ve1("║", 47, i);
            }
            dh.ve1("╦", 47, 16);
            dh.ve1("╩", 47, 24);
            dh.ve1("╬", 47, 22);
            dh.ve1("╬", 47, 20);
            dh.ve1("╬", 47, 18);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("CAC CHUC NANG QUAN LY SINH VIEN", 57, 14);
            dh.ve1("F1", 43, 17); dh.ve1("Them Sinh Vien", 55, 17);
            dh.ve1("F2", 43, 19); dh.ve1("Sua thong tin sinh vien", 55, 19);
            dh.ve1("F3", 43, 21); dh.ve1("Xoa Sinh vien", 55, 21);
            dh.ve1("F4", 43, 23); dh.ve1("Hien Thi danh sach sinh vien", 55, 23);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("Tro ve menu chinh nhan F10", 43, 27);
            dh.ve1("Thoat khoi chuong trinh nhan Esc", 43, 28);
            dh.ve1("Ban nhap mot phim chuc nang: ", 65, 35);
        tem: Console.SetWindowSize(135, 55);
          ConsoleKeyInfo kt = Console.ReadKey();
        
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    ThemSV();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    SuaThongtinSV();
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    XoaSV();
                    break;
                case ConsoleKey.F4:
                    Console.Clear();
                    HienThi();
                    break;
                case ConsoleKey.F10:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
                case ConsoleKey.Escape:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve("Ban go sai phim chuc nang!!!", 40, 29);
                    goto tem;
            }
        }
        #endregion
        #region Them sinh vien
        public void ThemSV()
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
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("THEM SINH VIEN", 60, 6);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("Ma SV : ", 30, 9);
            dh.ve1("HoTen SV : ", 70, 9);
            dh.ve1("NgaySinh : ", 30, 11);
            dh.ve1("GioiTinh : ", 70, 11);
            dh.ve1("CMT : ", 30, 13);
            dh.ve1("SDT : ", 70, 13);
            dh.ve1("MaKhoa : ", 70, 15);
            dh.ve1("DiaChi : ", 30, 15);
            dh.ve1("Email  : ", 30, 17);
            Console.ForegroundColor = ConsoleColor.Red;

            //DANH SACH SINH VIEN
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
            dh.ve1("Ho Ten SV", 27, 25);
            dh.ve1("Ngay Sinh", 49, 25);
            dh.ve1("Gioi Tinh", 64, 25);
            dh.ve1("Dia Chi", 89, 25);
            dh.ve1("SDT", 115, 25);
            dh.ve1("Ma Khoa", 126, 25);
            Node<SinhVien> tg = SVBLL.TTSinhVien().Head;
            int a = 28;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve1(Convert.ToString(tg.Data.Masinhvien), 8, a);
                    dh.ve1(tg.Data.Hoten, 22, a);
                    dh.ve1(Convert.ToString(tg.Data.Ngaysinh.Day + "/" + tg.Data.Ngaysinh.Month + "/" + tg.Data.Ngaysinh.Year), 49, a);
                    dh.ve1(tg.Data.Gioitinh, 67, a);
                    dh.ve1(tg.Data.Diachi, 85, a);
                    dh.ve1(tg.Data.Sodienthoai, 110, a);
                    dh.ve1(Convert.ToString(tg.Data.Makhoa), 129, a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    tg = tg.Link;
                    tmp++;
                    a = a + 2;
                }
                else break;
            }
        masv: int masv;
            string tensv, gioitinh, diachi, sodienthoai, gmail, SoCMT;
            DateTime ngaysinh;
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    dh.ve1("", 37, 9); masv = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve1("                                                                   ", 15, 52);
                            dh.ve1("                ", 37, 9);
                            Console.ResetColor();
                            goto masv;
                    }
                }
                //kiem ta xem ma phong co ton tại trong danh sach khong? neu khong ton tại thi them phong moi
                if (SVBLL.KTMaSinhVien(masv))
                {
                hoten: dh.ve1("", 80, 9); tensv = Console.ReadLine();
                    if (tensv == "")
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
                                dh.ve1("                            ", 80, 9);
                                Console.ResetColor();
                                goto hoten;
                        }
                    }
                    else
                    {
                        if (SVBLL.KiemtraHoTen(tensv))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("Ho ten khong the chua ki tu so! nhan phim bat ky de nhap lai!", 15, 52);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktht = Console.ReadKey();
                            switch (ktht.Key)
                            {
                                default:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    dh.ve1("                                                                              ", 15, 52);
                                    dh.ve1("                            ", 80, 9);
                                    Console.ResetColor();
                                    goto hoten;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                   
                ngaysinh:
                    try
                    {
                        dh.ve1("", 40, 11); ngaysinh = DateTime.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Nhap khong dung kieu du lieu ngay sinh! nhan phim bat ki de nhap lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                          ", 15, 52);
                                dh.ve1("                 ", 40, 11);
                                Console.ResetColor();
                                goto ngaysinh;
                        }
                    }
                    DateTime ngayhethong=DateTime.Now;
                    if((ngaysinh.Day>31||ngaysinh.Day<1)||(ngaysinh.Month<1||((ngaysinh.Month>12)||(ngayhethong.Year-ngaysinh.Year<18))))
                    {
                         Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Sinh vien chua du 18 tuoi! Nhan phim bat ki de nhap lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                        ", 15, 52);
                                dh.ve1("                 ", 40, 11);
                                Console.ResetColor();
                                goto ngaysinh;
                        }
                    }
                    if ((ngaysinh.Day > 31 || ngaysinh.Day < 1) || (ngaysinh.Month < 1 || ((ngaysinh.Month > 12) || (ngayhethong.Year - ngaysinh.Year > 100))))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Sinh vien khong the vuot qua 100 tuoi! Nhan phim bat ki de nhap lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                           ", 15, 52);
                                dh.ve1("                 ", 40, 11);
                                Console.ResetColor();
                                goto ngaysinh;
                        }
                    }
                gioitinh: dh.ve1("", 81, 11); gioitinh = Console.ReadLine();
                    if (gioitinh.ToLower() != "nam" && gioitinh.ToLower() != "nu")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Gioi tinh phai la nam hoac nu! nhan phim bat ky de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgt = Console.ReadKey();
                        switch (ktgt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                 ", 15, 52);
                                dh.ve1("             ", 81, 11);
                                Console.ResetColor();
                                goto gioitinh;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                socmt: dh.ve1("", 35, 13); SoCMT = Console.ReadLine();
                if (SoCMT == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Day la thong tin bat buoc khong duoc de trong!Nhan phim bat ki de tro lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        default:
                        dh.ve1("                                                                          ", 15, 52);
                            dh.ve1("                       ", 35, 13);
                            goto socmt;
                    }
                }
                    for (int i = 0; i < SoCMT.Length; ++i)
                    {
                        if (SoCMT[i] != '0' && SoCMT[i] != '1' && SoCMT[i] != '2' && SoCMT[i] != '3' && SoCMT[i] != '4' && SoCMT[i] != '5' && SoCMT[i] != '6' && SoCMT[i] != '7' && SoCMT[i] != '8' && SoCMT[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("So CMT khong the co ki tu!!! nhan phim bat ki de nhap lai!", 15, 52);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktgt = Console.ReadKey();
                            switch (ktgt.Key)
                            {
                                default:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    dh.ve1("                                                                                 ", 15, 52);
                                    dh.ve1("                 ", 35, 13);
                                    Console.ResetColor();
                                    goto socmt;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                sodt: dh.ve1("", 75, 13); sodienthoai = Console.ReadLine();
                    int dodaisdt = sodienthoai.Length;
                    for (int i = 0; i < sodienthoai.Length; ++i)
                    {
                        if ((sodienthoai[i] != '0' && sodienthoai[i] != '1' && sodienthoai[i] != '2' && sodienthoai[i] != '3' && sodienthoai[i] != '4' && sodienthoai[i] != '5' && sodienthoai[i] != '6' && sodienthoai[i] != '7' && sodienthoai[i] != '8' && sodienthoai[i] != '9') || dodaisdt > 11)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("So dien thoai khong the co ki tu va lon hon 11 so!!! nhan phim bat ky de nhap lai!", 15, 52);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktsdt = Console.ReadKey();
                            switch (ktsdt.Key)
                            {
                                default:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    dh.ve1("                                                                                              ", 15, 52);
                                    dh.ve1("                                    ", 75, 13);
                                    Console.ResetColor();
                                    goto sodt;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                diachi:dh.ve1("", 38, 15); diachi = Console.ReadLine();
                    if (diachi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Day la thong tin bat buoc khong duoc de trong!Nhan phim bat ki de tro lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            default:
                                dh.ve1("                                                                          ", 15, 52);
                                dh.ve1("                       ", 38, 15);
                                goto diachi;
                        }
                    }
                    List<Khoa> dsKhoa = KBLL.ListKhoa();
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
                    Console.ForegroundColor = ConsoleColor.White;
                makhoa:  int makhoa;
                    dh.ve1("", 79, 15);
                    try
                    {
                        makhoa = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ma khoa phai la kieu so! nhan phim bat ki de nhap lai", 30, 19);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                   ", 30, 19);
                                dh.ve1("              ", 79, 15);
                                Console.ResetColor();
                                goto makhoa;
                        }
                    }
                    if (KBLL.KiemTraMaKhoa(makhoa)==false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ma khoa khong ton tai trong he thong! nhan phim bat ky de nhap lai!!!", 30, 19);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgt = Console.ReadKey();
                        switch (ktgt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                               ", 30, 19);
                                dh.ve1("                 ", 79, 15);
                                Console.ResetColor();
                                goto makhoa;
                        }
                    }
                    dh.ve1("", 38, 17);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                                                                                                                              ", 5, 50);
                    dh.ve1("                                                                                                                              ", 5, 52);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                //==========================================
                gmail: dh.ve1("", 38, 17); gmail = Console.ReadLine();

                    if (SVBLL.KiemtraGmail(gmail) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Nhap sai dinh dang gmail!!! nhan phim bat ky de nhap lai!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktsdt = Console.ReadKey();
                        switch (ktsdt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                                            ", 15, 52);
                                dh.ve1("                                                                         ", 38, 17);
                                Console.ResetColor();
                                goto gmail;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Nhan F1 de tim phong cho sinh vien thue!", 70, 19);
                    Console.ForegroundColor = ConsoleColor.White;
                    SinhVien sv = new SinhVien(masv, tensv, gioitinh, ngaysinh, diachi, sodienthoai, gmail, SoCMT, makhoa);
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve1("De nhap tiep                  Enter", 60, 49);
                    dh.ve1("Luu va tro lai                BackSpace", 60, 50);
                    dh.ve1("Tro Lai Chuong Trinh          F12", 60, 51);
                    dh.ve1("Tro Lai Menu Chinh            F10", 60, 52);
                    dh.ve1("Thoat Khoi Chuong Trinh       Esc", 60, 53);
                t: ConsoleKeyInfo k = Console.ReadKey();
                    switch (k.Key)
                    {

                        case ConsoleKey.F1:
                            Console.Clear();
                            LienKetThuePhong(sv, masv);
                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();
                            SVBLL.Them(sv);
                            ThemSV();
                            break;
                        case ConsoleKey.Backspace:
                            SVBLL.Them(sv);
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("Ban nhap sai phim nhap lai!!!", 6, 52);
                            goto t;
                    }
                }
             else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Ma sinh vien da ton tai trong he thong! nhan phim bat ki de nhap lai!", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktsdt = Console.ReadKey();
                    switch (ktsdt.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve1("                                                                         ", 15, 52);
                             dh.ve1("                ", 37, 9);
                            Console.ResetColor();
                            goto masv;
                    }
                }
        }
        #endregion
        #region Sua thong tin sinh vien
        public void SuaThongtinSV()
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
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("SUA HO SO SINH VIEN", 55, 6);
            Console.ForegroundColor = ConsoleColor.White;
           // dh.ve1("Ma SV : ", 30, 9);
            dh.ve1("HoTen SV : ", 70, 9);
            dh.ve1("NgaySinh : ", 30, 11);
            dh.ve1("GioiTinh : ", 70, 11);
            dh.ve1("CMT : ", 30, 13);
            dh.ve1("SDT : ", 70, 13);
            dh.ve1("MaKhoa : ", 70, 15);
            dh.ve1("DiaChi : ", 30, 15);
            dh.ve1("Email  : ", 30, 17);
            dh.ve1("Ban nhap ma sinh vien can sua: ", 45, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            //DANH SACH SINH VIEN
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
        den: Node<SinhVien> tg = SVBLL.TTSinhVien().Head;
            int a = 28;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve1(Convert.ToString(tg.Data.Masinhvien), 8, a);
                    dh.ve1(tg.Data.Hoten, 22, a);
                    dh.ve1(Convert.ToString(tg.Data.Ngaysinh.Day + "/" + tg.Data.Ngaysinh.Month + "/" + tg.Data.Ngaysinh.Year), 49, a);
                    dh.ve1(tg.Data.Gioitinh, 67, a);
                    dh.ve1(tg.Data.Diachi, 85, a);
                    dh.ve1(tg.Data.Sodienthoai, 110, a);
                    dh.ve1(Convert.ToString(tg.Data.Makhoa), 129, a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    tg = tg.Link;
                    tmp++;
                    a = a + 2;
                }
                else break;
            }
        den1: Console.ForegroundColor = ConsoleColor.White;
            int masv;
            string tensvmoi, gioitinhmoi, diachimoi, sodienthoaimoi, gmailmoi, SoCMTmoi;
            DateTime ngaysinhmoi;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    dh.ve1("", 75, 18); masv = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve1("                                                                   ", 15, 52);
                            dh.ve1("                ", 75, 18);
                            Console.ResetColor();
                            goto den1;
                    }
                }
              
                if (SVBLL.KTMaSinhVien(masv)==false)
                {
                    Node<SinhVien> tg1 = SVBLL.TTSinhVien().Head;
            while (tg1 != null)
            {
                if (tg1.Data.Masinhvien == masv)
                {
                    dh.ve1(tg1.Data.Hoten, 80, 9);
                    dh.ve1(Convert.ToString (tg1.Data.Ngaysinh), 40, 11);
                    dh.ve1(tg1.Data.Gioitinh, 81, 11);
                    dh.ve1(tg1.Data.SoCMT, 35, 13);
                    dh.ve1(tg1.Data.Sodienthoai, 75, 13);
                    dh.ve1(tg1.Data.Diachi, 38, 15);
                    dh.ve1(Convert.ToString(tg1.Data.Makhoa), 79, 15);
                    dh.ve1(tg1.Data.Email, 38, 17);
                    break;
                }
                else tg1 = tg1.Link;
            }
           
            dh.ve1("", 80, 9);
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
            dh.ve1("                                ", 80, 9);
            Console.ResetColor();
                dh.ve1("", 80, 9);
            hoten: dh.ve1("", 80, 9); tensvmoi = Console.ReadLine();
                if (tensvmoi == "")
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
                            dh.ve1("                            ", 80, 9);
                            Console.ResetColor();
                            goto hoten;
                    }
                }
                else
                {
                    if (SVBLL.KiemtraHoTen(tensvmoi))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ho ten khong the chua ki tu so! nhan phim bat ky de nhap lai!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                              ", 15, 52);
                                dh.ve1("                            ", 80, 9);
                                Console.ResetColor();
                                goto hoten;
                        }
                    }
                }
                    //==========================
                    dh.ve1("", 40, 11);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("              ", 40, 11);
                    Console.ResetColor();
                    dh.ve1("", 40, 11);
                    ngaysinhmoi = DateTime.Parse(Console.ReadLine());
                    //=========================
                    dh.ve1("", 81, 11);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("             ", 81, 11);
                    Console.ResetColor();

                gioitinh: dh.ve1("", 81, 11);
                  gioitinhmoi = Console.ReadLine();

                    if (gioitinhmoi.ToLower() != "nam" && gioitinhmoi.ToLower() != "nu")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Gioi tinh phai la nam hoac nu! nhan phim bat ky de nhap lai!!!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgt = Console.ReadKey();
                        switch (ktgt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                 ", 15, 52);
                                dh.ve1("                        ", 81, 11);
                                Console.ResetColor();
                                goto gioitinh;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    //=======================
                    dh.ve1("", 35, 13);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                    ", 35, 13);
                    Console.ResetColor();
                socmt:dh.ve1("", 35, 13); SoCMTmoi = Console.ReadLine();
                if (SoCMTmoi == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Day la thong tin bat buoc khong duoc de trong!Nhan phim bat ki de tro lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktcmts = Console.ReadKey();
                    switch (ktcmts.Key)
                    {
                        default:
                            dh.ve1("                                                                          ", 15, 52);
                            dh.ve1("                       ", 35, 13);
                            goto socmt;
                    }
                }
                    for (int i = 0; i < SoCMTmoi.Length; ++i)
                    {
                        if (SoCMTmoi[i] != '0' && SoCMTmoi[i] != '1' && SoCMTmoi[i] != '2' && SoCMTmoi[i] != '3' && SoCMTmoi[i] != '4' && SoCMTmoi[i] != '5' && SoCMTmoi[i] != '6' && SoCMTmoi[i] != '7' && SoCMTmoi[i] != '8' && SoCMTmoi[i] != '9')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("So CMT khong the co ki tu!!! nhan phim bat ki de nhap lai!", 15, 52);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktgt = Console.ReadKey();
                            switch (ktgt.Key)
                            {
                                default:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    dh.ve1("                                                                                 ", 15, 52);
                                    dh.ve1("                 ", 35, 13);
                                    Console.ResetColor();
                                    goto socmt;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    //======================
                    dh.ve1("", 75, 13);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                    ", 75, 13);
                    Console.ResetColor();
                sodt1: dh.ve1("", 75, 13); sodienthoaimoi = Console.ReadLine();
                    int dodaisdt = sodienthoaimoi.Length;
                    for (int i = 0; i < sodienthoaimoi.Length; ++i)
                    {
                        if ((sodienthoaimoi[i] != '0' && sodienthoaimoi[i] != '1' && sodienthoaimoi[i] != '2' && sodienthoaimoi[i] != '3' && sodienthoaimoi[i] != '4' && sodienthoaimoi[i] != '5' && sodienthoaimoi[i] != '6' && sodienthoaimoi[i] != '7' && sodienthoaimoi[i] != '8' && sodienthoaimoi[i] != '9') || dodaisdt > 11)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            dh.ve1("So dien thoai khong the co ki tu va lon hon 11 so!!! nhan phim bat ky de nhap lai!", 15, 52);
                            Console.ForegroundColor = ConsoleColor.White;
                            ConsoleKeyInfo ktsdt1 = Console.ReadKey();
                            switch (ktsdt1.Key)
                            {
                                default:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    dh.ve1("                                                                                              ", 15, 52);
                                    dh.ve1("                                ", 75, 13);
                                    Console.ResetColor();
                                    goto sodt1;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    //=================
                    dh.ve1("", 38, 15);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                      ", 38, 15);
                    Console.ResetColor();
                dcmoi:dh.ve1("", 38, 15);
                    diachimoi = Console.ReadLine();
                    if (diachimoi == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Day la thong tin bat buoc khong duoc de trong!Nhan phim bat ki de tro lai", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktdcmoi = Console.ReadKey();
                        switch (ktdcmoi.Key)
                        {
                            default:
                                dh.ve1("                                                                          ", 15, 52);
                                dh.ve1("                       ", 38, 15);
                                goto dcmoi;
                        }
                    }
                    //======================
                    dh.ve1("", 79, 15);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                ", 79, 15);
                    Console.ResetColor();
                    dh.ve1("", 79, 15);
                    List<Khoa> dsKhoa = KBLL.ListKhoa();
                    Node<Khoa> tg2 = dsKhoa.Head;
                    int i1 = 15;
                    int i2 = 15;
                    while (tg2 != null)
                    {
                        if (tg2.Data.Makhoa <= 4)
                        {
                            dh.ve1(CongCu.ChuanHoaXau(tg2.Data.Tenkhoa) + "(Ma so " + Convert.ToString(tg2.Data.Makhoa) + ")", i1, 50);
                            i1 = i1 + 30;
                        }
                        else
                        {
                            dh.ve1(CongCu.ChuanHoaXau(tg2.Data.Tenkhoa) + "(Ma so " + Convert.ToString(tg2.Data.Makhoa) + ")", i2, 52);
                            i2 = i2 + 30;
                        }
                        tg2 = tg2.Link;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                makhoa: int makhoamoi;
                    dh.ve1("", 79, 15);
                    try
                    {
                        makhoamoi = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ma khoa phai la kieu so! nhan phim bat ki de nhap lai", 30, 19);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktht = Console.ReadKey();
                        switch (ktht.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                   ", 30, 19);
                                dh.ve1("              ", 79, 15);
                                Console.ResetColor();
                                goto makhoa;
                        }
                    }
                    if (KBLL.KiemTraMaKhoa(makhoamoi) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Ma khoa khong ton tai trong he thong! nhan phim bat ky de nhap lai!!!", 30, 19);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktgt = Console.ReadKey();
                        switch (ktgt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                               ", 30, 19);
                                dh.ve1("                 ", 79, 15);
                                Console.ResetColor();
                                goto makhoa;
                        }
                    }
                    dh.ve1("", 38, 17);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                                                                                                                              ", 5, 50);
                    dh.ve1("                                                                                                                              ", 5, 52);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    //======================
                    dh.ve1("", 38, 17);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    dh.ve1("                         ", 38, 17);
                    Console.ResetColor();
                    dh.ve1("", 38, 17);
                gmail: dh.ve1("", 38, 17); gmailmoi = Console.ReadLine();
                    if (SVBLL.KiemtraGmail(gmailmoi) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Nhap sai dinh dang gmail!!! nhan phim bat ky de nhap lai!", 15, 52);
                        Console.ForegroundColor = ConsoleColor.White;
                        ConsoleKeyInfo ktsdt = Console.ReadKey();
                        switch (ktsdt.Key)
                        {
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                                                            ", 15, 52);
                                dh.ve1("                                                                         ", 38, 17);
                                Console.ResetColor();
                                goto gmail;
                        }
                    }
                    //======================
                    SinhVien sv = new SinhVien(masv, tensvmoi, gioitinhmoi, ngaysinhmoi, diachimoi, sodienthoaimoi, gmailmoi, SoCMTmoi, makhoamoi);

                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve1("Nhan Enter de sua tiep!", 20, 49);
                    dh.ve1("Nhan Backspace de luu va tro lai!", 20, 50);
                    dh.ve1("Tro lai nhan F12", 20, 51);
                    dh.ve1("Tro lai nhan F12", 20, 52);
                    dh.ve1("Thoat khoi chuong trinh nhan Esc", 20, 53);
                    ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                             SVBLL.XoaSinhVien(masv);
                             SVBLL.Them(sv);
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve1("            ", 75, 19);
                            dh.ve1("                                             ", 20, 49);
                            dh.ve1("                                              ", 20, 50);
                            dh.ve1("                                              ", 20, 51);
                            dh.ve1("                                              ", 20, 52);
                            dh.ve1("                                            ", 20, 53);
                            dh.ve1("                         ", 37, 9);
                            dh.ve1("                        ", 80, 9);
                            dh.ve1("                        ", 40, 11);
                            dh.ve1("                         ", 81, 11);
                            dh.ve1("                     ", 35, 13);
                            dh.ve1("                       ", 75, 13);
                            dh.ve1("                       ", 38, 15);
                            dh.ve1("                       ", 79, 15);
                            dh.ve1("                          ", 38, 17);
                            for (int i = 28; i < 48; i++)
                            {
                                dh.ve1("       ", 6, i);
                                dh.ve1("                             ", 15, i);
                                dh.ve1("             ", 45, i);
                                dh.ve1("            ", 62, i);
                                dh.ve1("                                ", 76, i);
                                dh.ve1("             ", 109, i);
                                dh.ve1("         ", 124, i);
                                Console.ResetColor();
                            }
                            goto den;
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.Backspace:
                             SVBLL.XoaSinhVien(masv);
                             SVBLL.Them(sv);
                              Console.Clear();
                              ChucNangQLSinhVien();
                              break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Ma SV khong ton tai!! Ban nhan Enter de nhap lai! ", 45, 52);
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                            dh.ve1("                                                    ", 45, 52);
                            dh.ve1("                       ", 75, 19);
                            goto den1;
                        default:
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                    }
                }
            } while (true);
        }
        #endregion
        #region Xoa Sinh vien
        public void XoaSV()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 3, 0);
            dh.ve1("╚", 3, 54);
            dh.ve1("╗", 137, 0);
            dh.ve1("╝", 137, 54);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 4, 0);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 4, 3);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 4, 54);
            for (int i = 1; i < 54; ++i)
            {
                dh.ve1("║", 3, i);
                dh.ve1("║", 137, i);
            }
            dh.ve1("╠", 3, 3);
            dh.ve1("╣", 137, 3);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("***  QUAN LY KY TUC XA  ***", 36, 1);
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
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 4, 21);
            dh.ve1("╠", 3, 21);
            dh.ve1("╣", 137, 21);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("XOA SINH VIEN", 61, 6);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("Ban nhap ma sinh vien can xoa: ", 45, 15);
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
        den: Node<SinhVien> tg = SVBLL.TTSinhVien().Head;
            int a = 28;
            int tmp = 0;
            while (tg != null)
            {
                if (tmp < 10)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve1(Convert.ToString(tg.Data.Masinhvien), 8, a);
                    dh.ve1(tg.Data.Hoten, 22, a);
                    dh.ve1(Convert.ToString(tg.Data.Ngaysinh.Day + "/" + tg.Data.Ngaysinh.Month + "/" + tg.Data.Ngaysinh.Year), 49, a);
                    dh.ve1(tg.Data.Gioitinh, 67, a);
                    dh.ve1(tg.Data.Diachi, 85, a);
                    dh.ve1(tg.Data.Sodienthoai, 110, a);
                    dh.ve1(Convert.ToString(tg.Data.Makhoa), 129, a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    tg = tg.Link;
                    tmp++;
                    a = a + 2;
                }
                else break;
            }
          den1:  int masv;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    dh.ve1("", 75, 15); masv = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Ma sinh vien phai la kieu so! nhan phim bat ki de nhap lai", 15, 52);
                    Console.ForegroundColor = ConsoleColor.White;
                    ConsoleKeyInfo ktht = Console.ReadKey();
                    switch (ktht.Key)
                    {
                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            dh.ve1("                                                                   ", 15, 52);
                            dh.ve1("                       ", 75, 15);
                            Console.ResetColor();
                            goto den1;
                    }
                }
                    //kiem ta xem ma phong co ton tại trong danh sach khong? neu khong ton tại thi them phong moi
                if (SVBLL.KTMaSinhVien(masv)==false)
                {
                    if (SVBLL.KiemTraSVConThuePH(masv))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Nhan Enter de xoa tiep!", 20, 49);
                        dh.ve1("Nhan Backspace de luu va tro lai", 20, 50);
                        dh.ve1("Tro lai nhan F12", 20, 51);
                        dh.ve1("Tro lai menu chinh nhan F10", 20, 52);
                        dh.ve1("Thoat khoi chuong trinh nhan Esc", 20, 53);
                        ConsoleKeyInfo kt = Console.ReadKey();
                        switch (kt.Key)
                        {
                            case ConsoleKey.Enter:
                                SVBLL.XoaSinhVien(masv);
                                Console.BackgroundColor = ConsoleColor.Black;
                                dh.ve1("                                                         ", 20, 49);
                                dh.ve1("                                                     ", 20, 50);
                                dh.ve1("                                                    ", 20, 51);
                                dh.ve1("                                                    ", 20, 52);
                                dh.ve1("                                                   ", 20, 53);
                                dh.ve1("                          ", 75, 15);
                                for (int i = 27; i < 48; i++)
                                {
                                    dh.ve1("       ", 6, i);
                                    dh.ve1("                             ", 15, i);
                                    dh.ve1("             ", 45, i);
                                    dh.ve1("            ", 62, i);
                                    dh.ve1("                                ", 76, i);
                                    dh.ve1("             ", 109, i);
                                    dh.ve1("         ", 124, i);
                                    Console.ResetColor();
                                }
                                goto den;
                            case ConsoleKey.Escape:
                                return;
                            case ConsoleKey.Backspace:
                                SVBLL.XoaSinhVien(masv);
                                Console.Clear();
                                ChucNangQLSinhVien();
                                break;
                            case ConsoleKey.F10:
                                Console.Clear();
                                menu.MenuChinh1();
                                break;
                            case ConsoleKey.F12:
                                Console.Clear();
                                ChucNangQLSinhVien();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        dh.ve1("Sinh vien co ma nay dang thue phong!! Ban nhan Enter de nhap lai! ", 45, 52);
                        ConsoleKeyInfo kt2 = Console.ReadKey();
                        switch (kt2.Key)
                        {
                            case ConsoleKey.Enter:
                                dh.ve1("                                                                        ", 45, 52);
                                dh.ve1("                          ", 75, 15);
                                dh.ve1("                  ", 37, 9);
                                goto den1;
                            default:
                                Console.Clear();
                                ChucNangQLSinhVien();
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    dh.ve1("Ma SV khong ton tai!! Ban nhan Enter de nhap lai! ", 45, 52);
                    ConsoleKeyInfo kt1 = Console.ReadKey();
                    switch (kt1.Key)
                    {
                        case ConsoleKey.Enter:
                    dh.ve1("                                                    ", 45, 52);
                    dh.ve1("                          ", 75, 15);
                    dh.ve1("                  ", 37, 9);
                            goto den1;
                        default:
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                    }
                }
            } while (true);
        }
        #endregion
        #region Hien thi dsanh sach sinh vien
        public void HienThi()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 4, 0);
            dh.ve1("╚", 4, 34);
            dh.ve1("╗", 136, 0);
            dh.ve1("╝", 136, 34);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 0);
            dh.ve1("═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 5, 34);
            for (int i = 1; i < 34; ++i)
            {
                dh.ve1("║", 4, i);
                dh.ve1("║", 136, i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dh.ve1("╔", 5, 2);
            dh.ve1("╚", 5, 28);
            dh.ve1("╗", 135, 2);
            dh.ve1("╝", 135, 28);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 2);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 4);
            dh.ve1("═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════", 6, 28);
            for (int i = 3; i < 28; ++i)
            {
                dh.ve1("║", 5, i);
                dh.ve1("║", 135, i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("DANH SACH SINH VIEN TRONG KY TUC XA", 53, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 5; i < 28; ++i)
            {
                dh.ve1("│", 14, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 44, i);
                dh.ve1("│", 61, i);
                dh.ve1("│", 74, i);
                dh.ve1("│", 108, i);
                dh.ve1("│", 123, i);
            }
            dh.ve1("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────", 6, 6);

            dh.ve1("╤", 14, 4); dh.ve1("╧", 14, 28);
            dh.ve1("╤", 44, 4); dh.ve1("╧", 44, 28);
            dh.ve1("╤", 44, 4); dh.ve1("╧", 44, 28);
            dh.ve1("╤", 61, 4); dh.ve1("╧", 61, 28);
            dh.ve1("╤", 74, 4); dh.ve1("╧", 74, 28);
            dh.ve1("╤", 108, 4); dh.ve1("╧", 108, 28);
            dh.ve1("╤", 123, 4); dh.ve1("╧", 123, 28);
            dh.ve1("┼", 14, 6);
            dh.ve1("┼", 44, 6);
            dh.ve1("┼", 61, 6);
            dh.ve1("┼", 74, 6);
            dh.ve1("┼", 108, 6);
            dh.ve1("┼", 123, 6);
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve1("MaSV", 8, 5);
            dh.ve1("HoTenSV", 27, 5);
            dh.ve1("NgaySinh", 49, 5);
            dh.ve1("GioiTinh", 64, 5);
            dh.ve1("DiaChi", 89, 5);
            dh.ve1("SDT", 115, 5);
            dh.ve1("MaKhoa", 126, 5);
            dh.ve1("Tro lai nhan F12", 20, 30);
            dh.ve1("Tro lai menu chinh nhan F10", 20, 31);
            dh.ve1("Thoat khoi chuong trinh nhan Esc", 20, 32);
            dh.ve1("Ban chon phim chuc nang ", 75, 32);
            Node<SinhVien> tg = SVBLL.TTSinhVien().Head;
            int soluongsinhvien = 1;
            while (tg.Link != null)
            {
                soluongsinhvien++;
                tg = tg.Link;
            }
            if (soluongsinhvien > 0)
            {
                int sodong = 10;
                int tongsotrang;
                if (soluongsinhvien >= sodong)
                {
                    tongsotrang = soluongsinhvien % sodong == 0 ? soluongsinhvien / sodong : soluongsinhvien / sodong + 1;
                }
                else
                    tongsotrang = 1;
                int trang = 1;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            den1:
                VeTrang(trang);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("", 75, 30); Console.WriteLine("{0}/{1} trang ◄ {2} ►", trang, tongsotrang, trang);
                goto den;
            den: do
            {
                    dh.ve1("", 100, 32);
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
                            ChucNangQLSinhVien();
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                } while (true);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dh.ve1("Hien Tai Trong He Thong khong co sinh vien nao!", 10, 35);
            }
        }
        public void VeTrang(int chisotrang)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 8; i < 28; i++)
            {
                dh.ve1("       ", 6, i);
                dh.ve1("                             ", 15, i);
                dh.ve1("               ", 45, i);
                dh.ve1("            ", 62, i);
                dh.ve1("                                ", 76, i);
                dh.ve1("              ", 109, i);
                dh.ve1("         ", 124, i);
            }
            Console.ResetColor();
            int a = 8;
            int dem1 = 0;//chi so dem den day phong thu i
            int sodong = 10;
            Node<SinhVien> tg1 = SVBLL.TTSinhVien().Head;
            int dem = (chisotrang - 1) * sodong + 1;
            while (tg1 != null)
            {
                dem1++;
                if ((dem1 >= dem) && (dem1 <= chisotrang * 10))
                {
                            Console.ForegroundColor = ConsoleColor.White;
                            dh.ve1(Convert.ToString(tg1.Data.Masinhvien), 8, a);
                            dh.ve1(tg1.Data.Hoten, 22, a);
                            dh.ve1(Convert.ToString(tg1.Data.Ngaysinh.Day + "/" + tg1.Data.Ngaysinh.Month + "/" + tg1.Data.Ngaysinh.Year), 49, a);
                            dh.ve1(tg1.Data.Gioitinh, 67, a);
                            dh.ve1(tg1.Data.Diachi, 85, a);
                            dh.ve1(tg1.Data.Sodienthoai, 110, a);
                            dh.ve1(Convert.ToString(tg1.Data.Makhoa), 129, a);
                            Console.ForegroundColor = ConsoleColor.Green;
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
        #region Lien ket sinh vien den bang thue phong
        public void LienKetThuePhong(SinhVien sv, int masv)
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
            dh.ve("                SV THUE PHONG", 26, 4);
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
            dh.ve("Nhap ma phong can thue:", 35, 9);
            dh.ve("DANH SACH PHONG CON TRONG", 35, 16);
            dh.ve("MAPH", 7, 18);
            dh.ve("TEN PHONG", 16, 18);
            dh.ve("LOAI PHONG", 31, 18);
            dh.ve("TINH TRANG", 45, 18);
            dh.ve("GIA PHONG", 58, 18);
            dh.ve("SUC CHUA", 69, 18);
            dh.ve("SVHT", 80, 18);
            dh.ve("MA DAY", 89, 18);
            Node<Phong> tg2 = PBLL.TimKiemPhongConTrong().Head;
            int a2 = 22;
            int tmp2 = 0;
            while (tg2 != null)
            {
                if ((tmp2 < 10)&&(tg2.Data.Loaiphong.ToUpper()==sv.Gioitinh.ToUpper()))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    dh.ve(Convert.ToString(tg2.Data.Maphong),7,a2);
                    dh.ve( tg2.Data.Tenphong,17,a2);
                    dh.ve(tg2.Data.Loaiphong,34,a2);
                    dh.ve(tg2.Data.Tinhtrang,45,a2);
                    dh.ve(Convert.ToString(tg2.Data.Giaphong),60,a2);
                    dh.ve(Convert.ToString(tg2.Data.Succhua),73,a2);
                    dh.ve(Convert.ToString( tg2.Data.Sosinhvienhientai),81,a2);
                    dh.ve(Convert.ToString(tg2.Data.Maday), 92, a2);
                    tg2 = tg2.Link;
                    a2 = a2 + 2;
                    tmp2++;
                }
                else
                {
                    tg2 = tg2.Link;
                }
            }
            dh.ve("", 58, 9);
            int maphong = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            dh.ve("Nhan Enter de nhap tiep!", 60, 46);
            dh.ve("Nhan BackSpace de luu va tro lai!", 60, 47);
            dh.ve("Tro Lai Chuong Trinh          F12", 60, 48);
            dh.ve("Tro Lai Menu Chinh            F10", 60, 49);
            dh.ve("Thoat Khoi Chuong Trinh       Esc", 60, 50);
            dh.ve("Ban chon mot phim chuc nang   ", 60, 51);
            System.DateTime ngaythue = System.DateTime.Now;
            ThuePhong thuephong = new ThuePhong(TPBLL.GetID(), masv, maphong, ngaythue);
            ConsoleKeyInfo kt = Console.ReadKey();
                    switch (kt.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.Clear();
                           TPBLL.ThemSVThuePhong(thuephong);
                           SVBLL.Them(sv);
                           PBLL.UpdateSoSVHT(maphong);
                            ThemSV();
                            break;
                        case ConsoleKey.Backspace:
                            TPBLL.ThemSVThuePhong(thuephong);
                            SVBLL.Them(sv);
                            PBLL.UpdateSoSVHT(maphong);
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.F10:
                            Console.Clear();
                            menu.MenuChinh1();
                            break;
                        case ConsoleKey.F12:
                            Console.Clear();
                            ChucNangQLSinhVien();
                            break;
                    }
        }
        #endregion
    }
}
