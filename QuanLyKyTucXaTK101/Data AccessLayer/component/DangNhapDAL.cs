using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using System.IO;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class DangNhapDAL // xử lý logic truy cập dữ liệu
    {
        DataAccessHelper dah = new DataAccessHelper("Data/Login.txt");
        public string O2S(DangNhap d) // Chuyển một đối tượng DangNhap thành chuỗi 
        {
            return d.Urser+ "#" + d.Pass; // Chuỗi kết quả chứa tên người dùng và mật khẩu ngân cách bởi ký tự '#'
        }
        public DangNhap S2O(string s) // chuyển đổi một chuỗi trở lại thành đối tượng DangNhap
        {
            s = CongCu.CatXau(s); // Cắt bỏ các khoảng trắng thừa hoặc các ký tự không mong muốn từ chuỗi đầu vào
            string[] tmp = s.Split('#'); // Tách chuỗi thành một mảng các chuỗi con bằng cách sử dụng ký tự '#' làm dấu phân cách 
            DangNhap tmpObj = new DangNhap(tmp[0], tmp[1]); // Tạo một đối tượng DangNhap mới bằng cách sử dụng tên người dùng và mật khẩu đã được tách 
            return tmpObj;
        }
        public void Write(string fileName, DangNhap d) // Lưu đối tượng DangNhap vào tệp
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write); // Mơ tệp được chỉ định để ghi, tạo mới nếu cần
            StreamWriter sw = new StreamWriter(fs); // StreamWriter được sử dụng để ghi văn bản vào tệp
            sw.WriteLine(O2S(d)); // Ghi đại diện chuỗi của đối tượng DangNhap vào tệp
            sw.Close(); // Đóng StreamWriter và FileStream để giải phóng tài nguyên
            fs.Close();
        }
        public DangNhap Read(string fileName) // Phương thức read đọc dòng đầu tiên của một tệp và chuyển đổi nó
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Mở tệp được chỉ định để đọc
            StreamReader sr = new StreamReader(fs);// StreamReader được sử dụng để đọc văn bản từ tệp 
            string kq = sr.ReadLine(); // Đọc dòng đầu tiên của tệp
            return S2O(kq); // Chuyển đổi chuỗi đã đọc trở lại thành đối tượng DangNhap
        }
        //public void Insert(DangNhap t)
        //{

        //    FileStream fs = new FileStream("Data/Login.txt", FileMode.Create, FileAccess.Write);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.WriteLine(t.Urser + "#" + t.Pass);
        //    sw.Close();
        //}
    }
}
