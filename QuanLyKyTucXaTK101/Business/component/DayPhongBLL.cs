using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class DayPhongBLL
    {
        DayPhongDAL DPD = new DayPhongDAL();
        public List<DayPhong> TTdayPhong()
        {
             List<DayPhong> ds = DPD.ReadList("Data/DayPhong.txt");
             return ds;
        }
        public void Them(DayPhong d)
        {
            List<DayPhong> ds = DPD.ReadList("Data/DayPhong.txt");
            Node < DayPhong > tg = ds.Head;
            d.Tenday = CongCu.ChuanHoaXau(d.Tenday);
            d.Vitri = CongCu.ChuanHoaXau(d.Vitri);
            ds.AddHead(d);
            DPD.WriteList("Data/DayPhong.txt", ds);
        }
        public bool KTMaDayPhong(int x)
        {
            List<DayPhong> ds = DPD.ReadList("Data/DayPhong.txt");
            Node<DayPhong> tg = ds.Head;
            bool kt = true;
            while (tg != null)
            {
                if (tg.Data.Maday ==x)
                {
                    kt = false;
                    break;
                }
                else
                    tg = tg.Link;
            }
            return kt;
        }
        public void XoaDay(int maday)
        {
            List<DayPhong> listDP = DPD.ReadList("Data/DayPhong.txt");
            Node<DayPhong> tg = listDP.Head;
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
            DPD.WriteList("Data/DayPhong.txt", listDP);
        }
       public void SuaDay(int maday,string tendaymoi,string vitrimoi)
       {
           List<DayPhong> listDP = DPD.ReadList("Data/DayPhong.txt");
            Node<DayPhong> tg = listDP.Head;
            while (tg != null)
            {
                if (tg.Data.Maday == maday)
                {
                    tg.Data.Tenday = tendaymoi;
                    tg.Data.Vitri = vitrimoi;
                    break;
                }
                else
                    tg = tg.Link;
            }
            DPD.WriteList("Data/DayPhong.txt", listDP);
        }
       public DayPhong TimKiemTheoMaDayPhong(int maday)
       {
           List<DayPhong> listDP = DPD.ReadList("Data/DayPhong.txt");
            Node<DayPhong> tg = listDP.Head;
            while (tg != null)
            {
                if (tg.Data.Maday == maday)
                {
                   break;
                }
                else
                    tg = tg.Link;
            }
           DayPhong dp=new DayPhong(tg.Data);
           return dp;
        }
       public List<DayPhong>TimKiemTheoTenDayPhong(string tendayphong)
       {
           List<DayPhong> listDP = DPD.ReadList("Data/DayPhong.txt");
           List<DayPhong> ListNew = new List<DayPhong>();
           Node<DayPhong> tg = listDP.Head;
           while (tg != null)
           {
               if (CongCu.ChuanHoaXau(tg.Data.Tenday)==CongCu.ChuanHoaXau(tendayphong))
               {
                   ListNew.AddHead(tg.Data);
                   tg = tg.Link;
               }
               else
                   tg = tg.Link;
           }
           return ListNew;
       }
    }
}
