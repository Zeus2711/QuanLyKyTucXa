using System;
using System.Linq;
using System.Text;

namespace QuanLyKyTucXaTK101.Entities
{
   public class SinhVien
   {
       #region các thành phần dữ liệu
       private int masinhvien;
       private string hoten;
       private string gioitinh;
       private DateTime  ngaysinh;
       private string diachi;
       private string sodienthoai;
       private string email;
       private string soCMT;
       private int makhoa;
       #endregion
       #region các thuộc tính
       public int Masinhvien
       {
           get { return masinhvien; }
           set
           {
               if(value>=1)
               masinhvien = value;
           }
       }
       public string Hoten
       {
           get { return hoten; }
           set
           {
               if(value!="")
               hoten = value; }
       }
       public string Gioitinh
       {
           get { return gioitinh; }
           set 
           {
               if(value=="nam"||value=="nu")
               gioitinh = value;
           }
       }
       public DateTime Ngaysinh
       {
           get { return ngaysinh; }
           set { ngaysinh = value; }
       }
       public string Diachi
       {
           get { return diachi; }
           set { diachi = value; }
       }
       public string Sodienthoai
       {
           get { return sodienthoai; }
           set { sodienthoai = value; }
       }
       public string Email
       {
           get { return email; }
           set { email = value; }
       }
      
       public string SoCMT
       {
           get { return soCMT; }
           set { soCMT = value; }
       }
       public int Makhoa
       {
           get { return makhoa; }
           set 
           {
               if (value >= 1)
               makhoa = value; 
           }
       }
       #endregion
       #region các phương thức 
       public SinhVien() { }
       public SinhVien(int masinhvien, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string sodienthoai, string email, string soCMT, int makhoa)
       {
           this.masinhvien = masinhvien;
           this.hoten = hoten;
           this.gioitinh = gioitinh;
           this.ngaysinh = ngaysinh;
           this.diachi = diachi;
           this.sodienthoai = sodienthoai;
           this.email = email;
           this.soCMT = soCMT;
           this.makhoa = makhoa;
       }
       public SinhVien(SinhVien t)
       {
           this.masinhvien = t.masinhvien;
           this.hoten = t.hoten;
           this.gioitinh = t.gioitinh;
           this.ngaysinh = t.ngaysinh;
           this.diachi = t.diachi;
           this.sodienthoai = t.sodienthoai;
           this.email = t.email;
           this.soCMT = t.soCMT;
           this.makhoa = t.makhoa;
       }
       #endregion
   }
}
