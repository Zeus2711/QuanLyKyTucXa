using System;
using System.Linq;
using System.Text;
namespace QuanLyKyTucXaTK101.Entities
{
    public class DayPhong
    {
        #region Các thành phần dữ liệu
        private int maday;
        private string tenday;
        private string vitri;
        #endregion
        #region Các thuộc tính
        public int Maday
        {
            get { return maday; }
            set 
            {
                if(value>=1)
                maday = value; 
            }
        }
        public string Tenday
        {
            get { return tenday; }
            set
            {
                if(value!="")
                tenday = value;
            }
        }

        public string Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        #endregion
        #region Các phương thức khoi tao
        //Phương thức thiết lập không tham số
        public DayPhong()
        { }
        //Phương thức thiết lập có tham số
        public DayPhong(int maday,string tenday,string vitri)
        {
            this.maday = maday;
            this.tenday = tenday;
            this.vitri = vitri;
        }
        //Phương thức thiết lập sao chép
        public DayPhong(DayPhong tmp)
        {
            this.maday = tmp.maday;
            this.tenday = tmp.tenday;
            this.vitri = tmp.vitri;
        }
        #endregion
    }
}
