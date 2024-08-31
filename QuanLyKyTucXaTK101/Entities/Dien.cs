using System;
using System.Linq;
using System.Text;

namespace QuanLyKyTucXaTK101.Entities
{
    public class Dien
    {
        #region Các thành phần dữ liệu
        private int iddien;                   // ID của điện
        private int nam;                      // Năm ghi chỉ số điện
        private int thang;                   // Tháng ghi chỉ số điện
        private int maphong;                 // Mã phòng
        private int socongtothangnay;        // Số công tơ của tháng hiện tại
        private int sodiendadung;            // Số điện đã dùng
        #endregion

        #region Các thuộc tính
        // Thuộc tính để truy cập và thiết lập ID của điện
        public int Iddien
        {
            get { return iddien; }
            set
            {
                // ID của điện phải không âm
                if (value >= 0)
                    iddien = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập năm ghi chỉ số điện
        public int Nam
        {
            get { return nam; }
            set
            {
                // Năm ghi chỉ số điện không được lớn hơn năm hiện tại
                if (value <= DateTime.Now.Year)
                    nam = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập tháng ghi chỉ số điện
        public int Thang
        {
            get { return thang; }
            set
            {
                // Tháng ghi chỉ số điện phải nằm trong khoảng từ 1 đến 12
                if (value >= 1 && value <= 12)
                    thang = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập mã phòng
        public int Maphong
        {
            get { return maphong; }
            set
            {
                // Mã phòng phải lớn hơn hoặc bằng 1
                if (value >= 1)
                    maphong = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập số công tơ của tháng hiện tại
        public int Socongtothangnay
        {
            get { return socongtothangnay; }
            set
            {
                // Số công tơ phải lớn hơn hoặc bằng 1
                if (value >= 1)
                    socongtothangnay = value;
            }
        }

        // Thuộc tính để truy cập và thiết lập số điện đã dùng
        public int Sodiendadung
        {
            get { return sodiendadung; }
            set
            {
                // Số điện đã dùng phải không âm
                if (value >= 0)
                    sodiendadung = value;
            }
        }
        // Lưu trữ số công tơ tháng này 
        public int Socngtothangnay { get; internal set; }

        #endregion

        #region Các phương thức
        // Phương thức khởi tạo không tham số
        public Dien() { }

        // Phương thức khởi tạo với tất cả các tham số
        public Dien(int iddien, int thang, int nam, int maphong, int socongtothangnay, int sodiendadung)
        {
            this.iddien = iddien;
            this.thang = thang;
            this.nam = nam;
            this.maphong = maphong;
            this.socongtothangnay = socongtothangnay;
            this.sodiendadung = sodiendadung;
        }

        // Phương thức khởi tạo sao chép từ đối tượng Dien khác
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
