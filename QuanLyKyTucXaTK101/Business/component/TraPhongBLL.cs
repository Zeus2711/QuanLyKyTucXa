using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class TraPhongBLL
    {
        TraPhongDAL TPDAL = new TraPhongDAL();
        public List<TraPhong> GetAllData()
        {
            return TPDAL.ReadList("Data/TraPhong.txt");
        }
        public int GetID()
        {
            List<TraPhong> ListTraPhong = TPDAL.ReadList("Data/TraPhong.txt");
            Node<TraPhong> tg = ListTraPhong.Head;
            return tg.Data.Id + 1;
        }
        public int GetSoLuongSVHT(int maphong)
        {
            List<TraPhong> ListTraPhong = TPDAL.ReadList("Data/TraPhong.txt");
            int dem = 0;
            Node<TraPhong> tg = ListTraPhong.Head;
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
        public int DemSoMaSVTraPH(int masv)
        {
            List<TraPhong> ListTraPhong = TPDAL.ReadList("Data/TraPhong.txt");
            int dem = 0;
            Node<TraPhong> tg = ListTraPhong.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == masv)
                {
                    dem++;
                    tg = tg.Link;
                }
                else
                    tg = tg.Link;
            }
            return dem;
        }
        public void ThemSVTraPhong(TraPhong traPH)
        {
            List<TraPhong> ds = TPDAL.ReadList("Data/TraPhong.txt");
            ds.AddHead(traPH);
            TPDAL.WriteList("Data/TraPhong.txt", ds);
        }
        public int DemSVTraPhong(int masv)
        {
            List<TraPhong> ListTraPhong = TPDAL.ReadList("Data/TraPhong.txt");
            int dem = 0;
            Node<TraPhong> tg = ListTraPhong.Head;
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
    }
}
