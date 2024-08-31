using System;
using System.Linq;
using System.Text;
namespace QuanLyKyTucXaTK101.Entities
{
    public class DayPhong
    {
        #region Các thành phần dữ liệu
        private int maday;        // Mã dãy phòng
        private string tenday;   // Tên dãy phòng
        private string vitri;    // Vị trí dãy phòng
        #endregion

        #region Các thuộc tính
        // Thuộc tính để truy cập và thiết lập mã dãy phòng
        public int Maday
        {
            get { return maday; }
            set
            {
                // Kiểm tra giá trị nhập vào phải lớn hơn hoặc bằng 1
                if (value >= 1)
                    maday = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập tên dãy phòng
        public string Tenday
        {
            get { return tenday; }
            set
            {
                // Kiểm tra giá trị nhập vào không được rỗng
                if (!string.IsNullOrEmpty(value))
                    tenday = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập vị trí dãy phòng
        public string Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        #endregion

        #region Các phương thức khởi tạo
        // Phương thức khởi tạo không tham số
        public DayPhong()
        { }

        // Phương thức khởi tạo có tham số
        public DayPhong(int maday, string tenday, string vitri)
        {
            this.maday = maday;
            this.tenday = tenday;
            this.vitri = vitri;
        }

        // Phương thức khởi tạo sao chép từ đối tượng DayPhong khác
        public DayPhong(DayPhong tmp)
        {
            this.maday = tmp.maday;
            this.tenday = tmp.tenday;
            this.vitri = tmp.vitri;
        }
        #endregion
    }

}
