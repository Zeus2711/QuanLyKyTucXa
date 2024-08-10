using System;
using System.Linq;
using System.Text;
namespace QuanLyKyTucXaTK101.Entities
{
   public class ThuePhong
   {
       #region thanh phan du lieu
       private int id;
       private int masv;
       private int maphong;
       private DateTime ngaythue;
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
        public DateTime Ngaythue
        {
            get { return ngaythue; }
            set { ngaythue = value; }
        }
       #endregion
       #region cac phuong thuc
        public ThuePhong() { }
        public ThuePhong(int id, int masv, int maphong, DateTime ngaythue)
        {
            this.id = id;
            this.masv = masv;
            this.maphong=maphong;
            this.ngaythue = ngaythue;
        }
        public ThuePhong(ThuePhong tp)
        {
            this.id = tp.id;
            this.masv = tp.masv;
            this.maphong = tp.maphong;
            this.ngaythue = tp.ngaythue;
        }
        #endregion
   }
}
