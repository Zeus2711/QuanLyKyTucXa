using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
namespace QuanLyKyTucXaTK101.Business.component
{
    class DienBLL
    {
        DienDAL dienDAL = new DienDAL();
        public List<Dien> DSDien()
        {
            return dienDAL.ReadList("Data/Dien.txt");
        }
        public int NhanSoCongToThangTruoc(int maphong,int thang)
        {
            int socongtothangtruoc = 0;
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            Node<Dien> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    if (tg.Data.Thang == thang - 1)
                    {
                        socongtothangtruoc = tg.Data.Socngtothangnay;
                        break;
                    }
                }
                    tg = tg.Link;
            }
            return socongtothangtruoc;
        }
        public int NhanSoDienDaDung(int maphong,DateTime thoigian)
        {
            int sodiendadung = 0;
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            Node<Dien> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Thang==thoigian.Month&&tg.Data.Nam ==thoigian.Year&& tg.Data.Maphong==maphong)
                {
                    sodiendadung = tg.Data.Sodiendadung;
                    break;
                }
                tg = tg.Link;
            }
            return sodiendadung;
        }
        public int NhanSoCongToThangNay(int maphong, int thang)
        {
            int socongtothangnay = 0;
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            Node<Dien> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    if (tg.Data.Thang == thang)
                    {
                        socongtothangnay = tg.Data.Socngtothangnay;
                        break;
                    }
                }
                tg = tg.Link;
            }
            return socongtothangnay;
        }
        public int GetIDDien()//phuc vu cho viec danh so tu dong
        {
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            Node<Dien> tg = ds.Head;
            int iddien=0;
            while (tg != null)
            {
                iddien++;
                tg = tg.Link;
            }
            return iddien + 1;
        }
        public int LayIDDien(int maphong)//phuc vu cho viec lay id dien cua doi tuong co ma phong dc truyen vao
        {
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            Node<Dien> tg = ds.Head;
            int iddien = 0;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    iddien = tg.Data.Iddien;
                    break;
                }
                else
                tg = tg.Link;
            }
            return iddien;
        }
        public bool KiemTraPhongDaNhapSoDien(int maphong)
        {
            bool kt = false;
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            Node<Dien> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong == maphong)
                {
                    if (tg.Data.Thang == System.DateTime.Now.Month)
                    {
                        kt = true;
                        break;
                    }
                }
                else
                    tg = tg.Link;
            }
            return kt;
        }
        public void ThemHoSoDien(Dien dien)
        {
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            ds.AddHead(dien);
            dienDAL.WriteList("Data/Dien.txt", ds);
        }
        public void XoaHoSoDien(int maphong)//phuc vu cho viec sua ho so dien
        {
            List<Dien> ds = dienDAL.ReadList("Data/Dien.txt");
            List<Dien> listNew = new List<Dien>();
            Node<Dien> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Maphong != maphong)
                {
                    listNew.AddHead(tg.Data);
                }
                tg = tg.Link;
            }
            dienDAL.WriteList("Data/Dien.txt", listNew);
        }
    }
}
