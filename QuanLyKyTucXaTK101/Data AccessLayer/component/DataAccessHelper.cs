using System;
using System.Linq;
using System.Text;
using System.IO;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
  public class DataAccessHelper
    {
        private string filename; // biến thành viên private lưu trữ tên tệp
        public string FileName // thuộc tính fileName cung cấp phương thức truy cập để đọc và ghi giá trị của biến filename
        {
            get
            {
                // trả về tên tệp hiện tại 
                return filename;
            }
            set
            {
                // gán giá trị mới cho filename nếu giá trị không rỗng
                if (value != "")
                    filename = value;
            }
        }
        // phương thức khởi tạo không tham số (constructor) mặc định
        public DataAccessHelper() { }
        //phương thức khởi tạo có tham số, khởi tạo giá trị của filename với tham số đầu vào
        public DataAccessHelper(string filename)
        {
            this.filename = filename;
        }
        // puhowng thức WriteData ghi một chuỗi văn bản (obj) vào tệp được chỉ định bởi filename
        public void WriteData(string ọbj)
        {
            // Mở StreamWriter để ghi vào tệp với tên được lưu trong thuộc tính FileName
            StreamWriter s = new StreamWriter(FileName);
            // ghi chuỗi obj vào tệp
            s.WriteLine(ọbj);
            // Giải phóng tài nguyên sử dụng bởi StreamWriter
            s.Dispose();
        }
        // Phương thức RemoveAll xóa toàn bộ nội dung của tệp được chỉ định bởi filename
        public void RemoveAll()
        {
            // Mở StreamWriter để ghi vào tệp, ghi đè toàn bộ nội dugn bằng một chuỗi rỗng
            StreamWriter sw = new StreamWriter(filename);
            // Ghi chuỗi rỗng để xóa toàn bộ nội dung của tệp
            sw.Write("");
            // Giải phóng tài nguyên sử dụng bởi StreamWriter
            sw.Dispose();
        }
    }
}
