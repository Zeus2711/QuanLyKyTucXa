using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class ThuePhongBLL
    {
        ThuePhongDAL TPDAL = new ThuePhongDAL();
        public List<ThuePhong> GetAllData()
        {
            return TPDAL.ReadList("Data/ThuePhong.txt");
        }
        public int GetID()
        {
            List<ThuePhong> ListThuePhong = TPDAL.ReadList("Data/ThuePhong.txt");
            Node<ThuePhong> tg = ListThuePhong.Head;
            return tg.Data.Id + 1;
        }
        public int GetSoLuongSVHT(int maphong)
        {
            List<ThuePhong> ListThuePhong = TPDAL.ReadList("Data/ThuePhong.txt");
            int dem = 0;
            Node<ThuePhong> tg = ListThuePhong.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    dem++;
                    tg = tg.Link;
                }
                else
                    tg = tg.Link;
            }
            return dem;
        }
        //ham dem so ma sinh vien phuc vu cho viec kiem tra sinh vien con dang thue phong khong????
        public int DemSoMaSVThuePH(int maSV)
        {
            List<ThuePhong> ListThuePhong = TPDAL.ReadList("Data/ThuePhong.txt");
            int dem = 0;
            Node<ThuePhong> tg = ListThuePhong.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == maSV)
                {
                    dem++;
                    tg = tg.Link;
                }
                else
                    tg = tg.Link;
            }
            return dem;
        }
        public void ThemSVThuePhong(ThuePhong thuePH)
        {
            List<ThuePhong> ds = TPDAL.ReadList("Data/ThuePhong.txt");
            ds.AddHead(thuePH);
            TPDAL.WriteList("Data/ThuePhong.txt", ds);
        }
        public int DemSVThuePhong(int masv)
        {
            List<ThuePhong> ListThuePhong = TPDAL.ReadList("Data/ThuePhong.txt");
            int dem = 0;
            Node<ThuePhong> tg = ListThuePhong.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == masv)
                {
                    dem++;
                    tg = tg.Link;
                }
                else
                {
                    tg = tg.Link;
                }
            }
            return dem;
        }
        public int NhanMaPhong(int masv)//phuc vu cho viec tim ma phong de sinh vien can tra phong
        {
            List<ThuePhong> ListThuePhong = TPDAL.ReadList("Data/ThuePhong.txt");
            List<ThuePhong> ListNew = new List<ThuePhong>();//tao list moi se chua tat ca cac ho so co cung ma sinh vien
            Node<ThuePhong> tg = ListThuePhong.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == masv)
                {
                    ListNew.AddHead(tg.Data);
                    tg = tg.Link;
                }
                else
                    tg = tg.Link;
            }
            //tiep theo se tim ra ma phong ma sinh vien thue co id cao nhat
            int maphong = 0;
            Node<ThuePhong> tg1 = ListNew.Head;
            while (tg1 != null)
            {
                if (tg1.Link == null)
                {
                    maphong = tg1.Data.Maphong;
                    break;
                }
                else
                    tg = tg.Link;
            }
            return maphong;
        }
        public int NhanMaPhongSVDangThue(int masv)
        {
            List<ThuePhong> ListThuePhong = TPDAL.ReadList("Data/ThuePhong.txt");
            int maphong = 0;
            Node<ThuePhong> tg = ListThuePhong.Head;
            List<ThuePhong> ListNew = new List<ThuePhong>();
            while (tg != null)
            {
                if (tg.Data.Masv == masv)
                {
                    ListNew.AddHead(tg.Data);
                    tg = tg.Link;
                }
                else
                    tg = tg.Link;
            }
           //duyet danh sach list de lay ra ma phong ma co id la cao nhat
             Node<ThuePhong> tg1 = ListNew.Head;
              int idmax =tg1.Data.Id;
            while (tg1.Link!= null)
            {
                if (tg1.Data.Id < tg1.Link.Data.Id)
                {
                    idmax = tg1.Link.Data.Id;
                    tg1 = tg1.Link;
                }
                else
                    tg1 = tg1.Link;
            }
            while (tg1 != null)
            {
                if (tg1.Data.Id==idmax)
                {
                    maphong = tg1.Data.Maphong;
                    break;
                }
                else
                    tg1 = tg1.Link;
            }
            return maphong;
        }
    }
}