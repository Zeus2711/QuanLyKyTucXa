using System;
using System.Linq;
using System.Text;

namespace QuanLyKyTucXaTK101.Entities
{
   public class Dien
   {
       #region các thành phần dữ liệu
       private int iddien;
       private int nam;
       private int thang;
       private int maphong;
       private int socongtothangnay;
       private int sodiendadung;
       #endregion
       #region các thuộc tính
       public int Iddien
       {
           get { return iddien; }
           set 
           {
               if(value>=0)
               iddien = value;
           }
       }
       public int Nam
       {
           get { return nam; }
           set 
           { 
               if(value<=DateTime.Now.Year)
               nam = value; 
           }
       }
       public int Thang
       {
           get { return thang; }
           set
           {
               if(value>=1&&value<=12)
               thang = value;
           }
       }
       public int Maphong
       {
           get { return maphong; }
           set
           {
               if(value>=1)
               maphong = value; 
           }
       }
       public int Socngtothangnay
       {
           get { return socongtothangnay; }
           set 
           {
               if (value >= 1)
                   socongtothangnay = value; 
           }
       }
       public int Sodiendadung
       {
           get { return sodiendadung; }
           set 
           {
               if (value >= 0)
                   sodiendadung = value;
           }
       }
       #endregion
       #region các phương thức
       public Dien() { }
       public Dien(int iddien, int thang, int nam, int maphong, int socongtothangnay, int sodiendadung)
       {
           this.iddien = iddien;
           this.thang = thang;
           this.nam = nam;
           this.maphong = maphong;
           this.socongtothangnay = socongtothangnay;
           this.Sodiendadung = sodiendadung;
       }
       public Dien(Dien d)
       {
           this.iddien = d.iddien;
           this.thang = d.thang;
           this.nam = d.nam;
           this.maphong = d.maphong;
           this.socongtothangnay = d.socongtothangnay;
           this.sodiendadung = d.sodiendadung;
       }
       #endregion
   }
}
