using System;
using System.Linq;
using System.Text;

namespace QuanLyKyTucXaTK101.Entities
{
   public  class Phong
   {
       #region Các thành phần dữ liệu
       private int maphong;
       private string tenphong;
       private string loaiphong;
       private string tinhtrang;
       private double giaphong;
       private int succhua;
       private int sosinhvienhientai;
       private int maday;
       #endregion
       #region Các thuộc tính 

       public int Maphong
       {
           get { return maphong; }
           set 
           {
               if (value >= 1)
                   maphong = value;
           }
       }

       public string Tenphong
       {
           get { return tenphong; }
           set
           {
               if (value != "")
               tenphong = value; 
           }
       }

       public string Loaiphong
       {
           get { return loaiphong; }
           set
           {
               if(value =="nam"||value=="nu")
               loaiphong = value; }
       }

       public string Tinhtrang
       {
           get { return tinhtrang; }
           set { tinhtrang = value; }
       }
 
       public double Giaphong
       {
           get { return giaphong; }
           set 
           { 
               if(value>0)
               giaphong = value;
           }
       }
       public int Succhua
       {
           get { return succhua; }
           set 
           {
               if(value>0)
               succhua = value; }
       }
       public int Sosinhvienhientai
       {
           get { return sosinhvienhientai; }
           set 
           {
               if(value>0&&value<=succhua)
               sosinhvienhientai = value;
           }
       }
       public int Maday
       {
           get { return maday; }
           set 
           {
               if(value>=1)
               maday = value; 
           }
       }
       #endregion
       #region Các phương thức
       //Phương thức khởi tạo không tham số
       public Phong()
       { }
       //Phương thức khởi tạo có tham số
       public Phong(int maphong, string tenphong, string loaiphong, string tinhtrang, double giaphong, int succhua, int sosinhvienhientai, int maday)
       {
           this.maphong = maphong;
           this.tenphong = tenphong;
           this.loaiphong = loaiphong;
           this.tinhtrang = tinhtrang;
           this.giaphong = giaphong;
           this.succhua = succhua;
           this.sosinhvienhientai = sosinhvienhientai;
           this.maday = maday;
       }
       //Phương thức sao chép
       public Phong(Phong t)
       {
           this.maphong = t.maphong;
           this.tenphong = t.tenphong;
           this.loaiphong = t.loaiphong;
           this.tinhtrang = t.tinhtrang;
           this.giaphong = t.giaphong;
           this.succhua = t.succhua;
           this.sosinhvienhientai = t.sosinhvienhientai;
           this.maday = t.maday;
       }
       #endregion
   }
}
