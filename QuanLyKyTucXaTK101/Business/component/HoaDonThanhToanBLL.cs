using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class HoaDonThanhToanBLL
    {
        HoaDonThanhToanDAL HDDAL = new HoaDonThanhToanDAL();
        public List<HoaDonThanhToan> DSHoaDon()
        {
            List<HoaDonThanhToan> ds = HDDAL.ReadList("Data/HoaDonThanhToan.txt");
            return ds;
        }
        public void Them(HoaDonThanhToan hd)
        {
            List<HoaDonThanhToan> ds = HDDAL.ReadList("Data/HoaDonThanhToan.txt");
            Node<HoaDonThanhToan> tg = ds.Head;
            ds.AddHead(hd);
            HDDAL.WriteList("Data/HoaDonThanhToan.txt", ds);
        }
        public int NhanIDHDTT()
        {
           List<HoaDonThanhToan> ds = HDDAL.ReadList("Data/HoaDonThanhToan.txt");
           int idhoadon=0;
           Node<HoaDonThanhToan> tg = ds.Head;
           if (tg == null)
           {
               idhoadon = 1;
           }
           else
           {
               idhoadon = tg.Data.Id + 1;
           }
           return idhoadon;
        }
        public double TongTien()
        {
            List<HoaDonThanhToan> ds = HDDAL.ReadList("Data/HoaDonThanhToan.txt");
            double tongtien = 0;
            Node<HoaDonThanhToan> tg = ds.Head;
            while (tg != null)
            {
                tongtien = tongtien + tg.Data.Tongtien;
                tg = tg.Link;
            }
            return tongtien;
        }
        public bool KiemTradathanhtoanKTX(int masv,DateTime ngaythanhtoan)
        {
            List<HoaDonThanhToan> ds = HDDAL.ReadList("Data/HoaDonThanhToan.txt");
            bool kt = false;
            Node<HoaDonThanhToan> tg = ds.Head;
            while (tg != null)
            {
                if ((tg.Data.Masv == masv) && (ngaythanhtoan.Month == tg.Data.Ngaythanhtoan.Month && ngaythanhtoan.Year == tg.Data.Ngaythanhtoan.Year))
                {
                    kt = true;
                    break;
                }
                else
                    tg = tg.Link;
            }
            return kt;
        }
    }
}
