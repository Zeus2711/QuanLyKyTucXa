using System;
using System.Linq;
using System.Text;

namespace QuanLyKyTucXaTK101.Entities
{
   public class Khoa
   {
       #region các thành phần dữ liệu
       private int makhoa;
       private string tenkhoa;
       private string email;
       private string sodienthoai;
       #endregion
       #region các thuộc tính
       public int Makhoa
       {
           get { return makhoa; }
           set
           { 
               if(value>=1)
               makhoa = value; 
           }
       }
       public string Tenkhoa
       {
           get { return tenkhoa; }
           set 
           {
               if(value!="")
               tenkhoa = value;
           }
       }
       public string Email
       {
           get { return email; }
           set { email = value; }
       }
       public string Sodienthoai
       {
           get { return sodienthoai; }
           set { sodienthoai = value; }
       }
       #endregion
       #region các phương thức
       //phương thức khởi tạo không tham số
       public Khoa()
       { }
       //phương thức khởi tạo có tham số
       public Khoa( int makhoa,string tenkhoa, string email, string sodienthoai)
       {
           this.makhoa = makhoa;
           this.tenkhoa = tenkhoa;
           this.email = email;
           this.sodienthoai = sodienthoai;
       }
       //phương thức sao chép
       public Khoa(Khoa t)
       {
           this.makhoa = t.makhoa;
           this.tenkhoa = t.tenkhoa;
           this.email = t.email;
           this.sodienthoai = t.sodienthoai;
       }
       #endregion
   }
}
