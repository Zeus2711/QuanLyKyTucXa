using System;
using System.Linq;
using System.Text;
namespace QuanLyKyTucXaTK101.Entities
{
   public class TraPhong
    {
       #region thanh phan du lieu
       private int id;
       private int masv;
       private int maphong;
       private DateTime ngaytra;
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
        public DateTime Ngaytra
        {
            get { return ngaytra; }
            set { ngaytra = value; }
        }
       #endregion
       #region cac phuong thuc
        public TraPhong() { }
        public TraPhong(int id, int masv, int maphong, DateTime ngaythue)
        {
            this.id = id;
            this.masv = masv;
            this.maphong=maphong;
            this.ngaytra = ngaythue;
        }
        public TraPhong(TraPhong tp)
        {
            this.id = tp.id;
            this.masv = tp.masv;
            this.maphong = tp.maphong;
            this.ngaytra = tp.ngaytra;
        }
        #endregion
   }
}