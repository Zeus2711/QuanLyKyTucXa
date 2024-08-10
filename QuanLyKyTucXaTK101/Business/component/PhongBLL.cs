using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class PhongBLL
    {
       PhongDAL PDAL = new PhongDAL();
       ThuePhongBLL thuephong = new ThuePhongBLL();
       TraPhongBLL traphng = new TraPhongBLL();
        public List<Phong> TTPhong()
        {
             List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
             return ds;
        }
        public void Them(Phong d)
        {
            List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
            Node <Phong> tg = ds.Head;
            d.Tenphong = CongCu.ChuanHoaXau(d.Tenphong);
            d.Loaiphong = CongCu.ChuanHoaXau(d.Loaiphong);
            d.Tinhtrang = CongCu.ChuanHoaXau(d.Tinhtrang);
            ds.AddHead(d);
            PDAL.WriteList("Data/Phong.txt", ds);
        }
        public bool KTMaPhong(int x)
        {
            List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
            Node<Phong> tg = ds.Head;
            bool kt = true;
            while (tg != null)
            {
                if (tg.Data.Maphong ==x)
                {
                    kt = false;
                    break;
                }
                else
                    tg = tg.Link;
            }
            return kt;
        }
        public void XoaPhong(int maphong)
        {
            List<Phong> listDP = PDAL.ReadList("Data/Phong.txt");
            Node<Phong> tg = listDP.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    listDP.Xoaq(tg);
                    break;
                }
                else
                    tg = tg.Link;
            }
            PDAL.WriteList("Data/Phong.txt", listDP);
        }
        public void XoaPhongTheoMaDay(int maday)
        {
            List<Phong> listDP = PDAL.ReadList("Data/Phong.txt");
            Node<Phong> tg = listDP.Head;
            while (tg != null)
            {
                if (tg.Data.Maday == maday)
                {
                    listDP.Xoaq(tg);
                    break;
                }
                else
                    tg = tg.Link;
            }
            PDAL.WriteList("Data/Phong.txt", listDP);
        }
       public void SuaPhong(int maphong)
       {
            List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
            Node<Phong> tg = listP.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    
                    break;
                }
                else
                    tg = tg.Link;
            }
            PDAL.WriteList("Data/Phong.txt", listP);
        }
       public Phong TimKiemTheoMaPhong(int maphong)
       {
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = listP.Head;
           Phong p = new Phong();
           while (tg != null)
           {
               if (tg.Data.Maphong == maphong)
               {
                   p = tg.Data;
                   break;
               }
               else
                   tg = tg.Link;
           }
           return p;
       }
       public List<Phong> TimKiemTheoTenPhong(string tenphong)
       {
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           List<Phong> ListNew = new List<Phong>();
           Node<Phong> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Tenphong.ToUpper() ==tenphong.ToUpper())
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
       public List<Phong> TimKiemPhongNam()
       {
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           List<Phong> ListNew = new List<Phong>();
           Node<Phong> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Loaiphong.ToUpper()=="NAM")
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
       public List<Phong> TimKiemPhongNu()
       {
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           List<Phong> ListNew = new List<Phong>();
           Node<Phong> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Loaiphong.ToUpper() == "NU")
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
       public List<Phong> TimKiemPhongConTrong()
       {
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           List<Phong> ListNew = new List<Phong>();
           Node<Phong> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Succhua-tg.Data.Sosinhvienhientai>0)
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
       public void UpdateSoSVHT(int maphong)
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           List<Phong> ListNew=new List<Phong>();
             Node<Phong> tg = ds.Head;
             while (tg != null)
             {
                 if (tg.Data.Maphong != maphong)
                 {

                     ListNew.AddHead(tg.Data);
                     tg = tg.Link;
                 }
                 else
                 {
                     int Sosvht=thuephong.GetSoLuongSVHT(tg.Data.Maphong)-traphng.GetSoLuongSVHT(tg.Data.Maphong);
                     Phong p = new Phong(tg.Data.Maphong, tg.Data.Tenphong, tg.Data.Loaiphong, tg.Data.Tinhtrang, tg.Data.Giaphong, tg.Data.Succhua, Sosvht, tg.Data.Maday);
                     ListNew.AddHead(p);
                     tg = tg.Link;
                 }
             }
             PDAL.WriteList("Data/Phong.txt", ListNew);
       }
       public bool KTMaPhongTrong(int maphong)
       {
           List<Phong> ds = TimKiemPhongConTrong();
           bool kt=false;
            Node<Phong> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    kt = true;
                    break;
                }
                else
                {
                    tg = tg.Link;
                }
            }
            return kt;
       }
       public bool MaPhongTrong(int maphong)//phuc vu cho viec kiem tra ma phong khong co sinh vien nao thu de co the coa phong nay di
       {
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           bool kt = false;
           Node<Phong> tg = listP.Head;
           while (tg != null)
           {
               if ((tg.Data.Sosinhvienhientai == 0) && (tg.Data.Maphong == maphong))
               {
                   kt = true;
                   break;
               }
               else
                   tg = tg.Link;
           }
           return kt;
       }
       public int NhanSoSVHT(int maphong)
       {
           int svht = 0;
           List<Phong> listP = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = listP.Head;
           while (tg != null)
           {
               if (tg.Data.Maphong == maphong)
               {
                   svht = tg.Data.Sosinhvienhientai;
                   break;
               }
               else
                   tg = tg.Link;
           }
           return svht;
       }
       public int TongSoPhongNam()
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg=ds.Head;
           int tongphongnam = 0;
           while (tg != null)
           {
               if (tg.Data.Loaiphong.ToUpper() == "NAM")
               {
                   tongphongnam++;
                   tg = tg.Link;
               }
               else tg = tg.Link;
           }
           return tongphongnam;
       }
       public int TongSoPhongNu()
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = ds.Head;
           int tongphongnu = 0;
           while (tg != null)
           {
               if (tg.Data.Loaiphong.ToUpper() == "NU")
               {
                   tongphongnu++;
                   tg = tg.Link;
               }
               else tg = tg.Link;
           }
           return tongphongnu;
       }
       public int TongSoPhongConTrong()
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = ds.Head;
           int tongphongcontrong = 0;
           while (tg != null)
           {
               if (tg.Data.Sosinhvienhientai < tg.Data.Succhua)
               {
                   tongphongcontrong++;
                   tg = tg.Link;
               }
               else tg = tg.Link;
           }
           return tongphongcontrong;
       }
       public int TongSoSinhVienTrongKiTuc()
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = ds.Head;
           int tong = 0;
           while (tg != null)
           {
                   tong=tong+tg.Data.Sosinhvienhientai;
                   tg = tg.Link;
           }
           return tong;
       }
       public int TongSoSinhVienNamTrongKiTuc()
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = ds.Head;
           int tong = 0;
           while (tg != null)
           {
               if (tg.Data.Loaiphong.ToUpper() == "NAM")
               {
                   tong = tong + tg.Data.Sosinhvienhientai;
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return tong;
       }
       public int TongSoSinhVienNuTrongKiTuc()
       {
           List<Phong> ds = PDAL.ReadList("Data/Phong.txt");
           Node<Phong> tg = ds.Head;
           int tong = 0;
           while (tg != null)
           {
               if (tg.Data.Loaiphong.ToUpper() == "NU")
               {
                   tong = tong + tg.Data.Sosinhvienhientai;
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return tong;
       }
    }
}