using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
   class SinhVienBLL
    {
       SinhVienDAL SVDAL=new SinhVienDAL();
       ThuePhongBLL ThuePH=new ThuePhongBLL();
       TraPhongBLL TraPH=new TraPhongBLL();
        public List<SinhVien> TTSinhVien()
        {
             List<SinhVien> ds = SVDAL.ReadList("Data/SinhVien.txt");
             return ds;
        }
        public void Them(SinhVien sv)
        {
            List<SinhVien> ds = SVDAL.ReadList("Data/SinhVien.txt");
            Node<SinhVien> tg = ds.Head;
            sv.Hoten = CongCu.ChuanHoaXau(sv.Hoten);
            sv.Gioitinh = CongCu.ChuanHoaXau(sv.Gioitinh);
            sv.Diachi = CongCu.ChuanHoaXau(sv.Diachi);
            sv.Email = CongCu.CatXau(sv.Email);
            sv.SoCMT = CongCu.CatXau(sv.SoCMT);
            sv.Sodienthoai = CongCu.CatXau(sv.Sodienthoai);
            ds.AddHead(sv);
            SVDAL.WriteList("Data/SinhVien.txt", ds);
        }
        public bool KTMaSinhVien(int x)
        {
            List<SinhVien> ds = SVDAL.ReadList("Data/SinhVien.txt");
            Node<SinhVien> tg = ds.Head;
            bool kt = true;
            while (tg != null)
            {
                if (tg.Data.Masinhvien ==x)
                {
                    kt = false;
                    break;
                }
                else
                    tg = tg.Link;
            }
            return kt;
        }
        public void XoaSinhVien(int maSV)
        {
            List<SinhVien> listSV = SVDAL.ReadList("Data/SinhVien.txt");
            Node<SinhVien> tg = listSV.Head;
            while (tg != null)
            {
                if (tg.Data.Masinhvien == maSV)
                {
                    listSV.Xoaq(tg);
                    break;
                }
                else
                    tg = tg.Link;
            }
            SVDAL.WriteList("Data/SinhVien.txt", listSV);
        }
       public void SuaThongtinSV(int maSV)
       {
            List<SinhVien> listSV = SVDAL.ReadList("Data/SinhVien.txt");
            Node<SinhVien> tg = listSV.Head;
            while (tg != null)
            {
                if (tg.Data.Masinhvien == maSV)
                {
                    
                    break;
                }
                else
                    tg = tg.Link;
            }
            SVDAL.WriteList("Data/DayPhong.txt", listSV);
        }
       public SinhVien TimKiemTheoMaSV(int maSV)
       {
           List<SinhVien> listSV = SVDAL.ReadList("Data/SinhVien.txt");
           Node<SinhVien> tg = listSV.Head;
           while (tg != null)
           {
               if (tg.Data.Masinhvien == maSV)
               {
                   break;
               }
               else
                   tg = tg.Link;
           }
           SinhVien SV = new SinhVien(tg.Data);
           return SV;
       }
       public List<SinhVien> TimKiemTheoTenSV(string tenSV)
       {
           List<SinhVien> listP = SVDAL.ReadList("Data/SinhVien.txt");
           List<SinhVien> ListNew = new List<SinhVien>();
           Node<SinhVien> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Hoten.ToUpper() == tenSV.ToUpper())
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
       public List<SinhVien> TimKiemTheoKhoa(int Makhoa)
       {
           List<SinhVien> listP = SVDAL.ReadList("Data/SinhVien.txt");
           List<SinhVien> ListNew = new List<SinhVien>();
           Node<SinhVien> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Makhoa== Makhoa)
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
       public bool KiemTraSVConThuePH(int masv)
       {
           bool kt;
           if (ThuePH.DemSoMaSVThuePH(masv) - TraPH.DemSoMaSVTraPH(masv) == 1)//neu kt bang false tuc la sinh vien do dang thue phong
           {
               kt = false;
               return kt;
           }
           else//neu kt bang true tuc la sinh vien da tra phong
           {
               kt = true;
               return kt;
           }
       }
       //ham tim kiem sinh vien theo phong
       public List<SinhVien> TimKiemTheoMaPhong(int maphong)
       {
           List<SinhVien> listP = SVDAL.ReadList("Data/SinhVien.txt");
           List<SinhVien> ListNew = new List<SinhVien>();
           List<int> Listmasv = ListMSVTrongPhong(maphong);
           Node<SinhVien> tg = listP.Head;
           Node<int> tg1 = Listmasv.Head;
           while (tg1 != null)
           {
               while (tg != null)
               {
                   if (tg.Data.Masinhvien == tg1.Data)
                   {
                       ListNew.AddHead(tg.Data);
                       break;
                   }
                   tg = tg.Link;
               }
                   tg1 = tg1.Link;
           }
           return ListNew;
       }
       public List<int> ListMSVTrongPhong(int maphong)
       {
           List<ThuePhong> ds = ThuePH.GetAllData();
           List<int> ListMaSV=new List<int>();
           Node<ThuePhong> tg = ds.Head;
           while (tg != null)
           {
               if ((tg.Data.Maphong == maphong) && KiemTraSVConThuePH(tg.Data.Masv) == false)
               {
                   ListMaSV.AddHead(tg.Data.Masv);
               }
               tg = tg.Link;
           }
           return ListMaSV;
       }
       public bool KiemtraGmail(string gmail)
       {
           bool kt = false;
           for (int i = 0; i < gmail.Length; ++i)
           {
               if (gmail[i] == '@')
               {
                   kt = true;
                   break;
               }
           }
           return kt;
       }
       public bool KiemtraHoTen(string hoten)
       {
           bool kt = false;
           for (int i = 0; i < hoten.Length; ++i)
           {
               if (hoten[i] == '0' || hoten[i] == '1' ||hoten[i] == '2' || hoten[i] == '3'||hoten[i] == '4' || hoten[i] == '5' || hoten[i] == '6' || hoten[i] == '7' || hoten[i] == '8' || hoten[i] == '9')
               {
                   kt = true;
                   break;
               }
           }
           return kt;
       }
       public bool KiemTraGioiTinh(int masv)
       {
           bool kt = false;
         List<SinhVien> ds=SVDAL.ReadList("Data/SinhVien.txt");
           Node<SinhVien> tg=ds.Head;
           while (tg != null)
           {
               if (tg.Data.Masinhvien == masv)
               {
                   if (tg.Data.Gioitinh.ToUpper() == "NAM")
                   {
                       kt = true;
                       break;
                   }
                   break;
               }
               else
                   tg = tg.Link;
           }
           return kt;
       }
    }
}