using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QuanLyKyTucXaTK101.Entities
{
   public class HoaDonThanhToan
   {
       #region cac thanh phan du lieu
       private int id;
        private int masv;
        private int maphong;
        private DateTime ngaythanhtoan;
        private double tienphong;
        private double tiendien;
        private double tongtien;
       #endregion
       #region cac thuoc tinh
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Masv
        {
            get { return masv; }
            set { masv = value; }
        }
        public int Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        public DateTime Ngaythanhtoan
        {
            get { return ngaythanhtoan; }
            set { ngaythanhtoan = value; }
        }
        public double Tienphong
        {
            get { return tienphong; }
            set { tienphong = value; }
        }
        public double Tiendien
        {
            get { return tiendien; }
            set { tiendien = value; }
        }
        public double Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        #endregion
       #region cac phuong thuc
        public HoaDonThanhToan()
        { }
        public HoaDonThanhToan(int id, int masv, int maphong, DateTime ngaythanhtoan, double tienphong, double tiendien, double tongtien)
       {
           this.id = id;
           this.masv  = masv;
           this.maphong = maphong;
           this.ngaythanhtoan = ngaythanhtoan;
           this.tienphong = tienphong;
           this.Tiendien = tiendien;
           this.tongtien = tongtien;
       }
        public HoaDonThanhToan(HoaDonThanhToan hd)
        {
            this.id = hd.id;
            this.masv = hd.masv;
            this.maphong = hd.maphong;
            this.ngaythanhtoan = hd.ngaythanhtoan;
            this.tienphong = hd.tienphong;
            this.Tiendien = hd.tiendien;
            this.tongtien = hd.tongtien;
        }
       #endregion
   }
}
