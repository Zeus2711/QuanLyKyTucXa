using System;
using System.Linq;
using System.Text;
using System.IO;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class HoaDonThanhToanDAL
    {
        // Khởi tạo một trợ giúp để truy cập dữ liệu, chỉ định đường dẫn tệp cho dữ liệu "HoaDonThanhToan"
        DataAccessHelper dah = new DataAccessHelper("Data/HoaDonThanhToan.txt");

        // Chuyển đổi một đối tượng HoaDonThanhToan thành một chuỗi, với các trường được phân tách bằng "#"
        public string O2S(HoaDonThanhToan hd)
        {
            return hd.Id + "#" + hd.Masv + "#" + hd.Maphong + "#" + hd.Ngaythanhtoan + "#" + hd.Tienphong + "#" + hd.Tiendien + "#" + hd.Tongtien;
        }

        // Chuyển đổi một chuỗi (từ tệp) trở lại thành một đối tượng HoaDonThanhToan
        public HoaDonThanhToan S2O(string s)
        {
            s = CongCu.CatXau(s); // Cắt chuỗi để loại bỏ các khoảng trắng thừa (sử dụng phương thức tiện ích)
            string[] tmp = s.Split('#'); // Tách chuỗi thành một mảng sử dụng "#" làm ký tự phân tách
                                         // Tạo và trả về một đối tượng HoaDonThanhToan mới sử dụng các giá trị từ mảng
            HoaDonThanhToan tmpObj = new HoaDonThanhToan(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2]), DateTime.Parse(tmp[3]), double.Parse(tmp[4]), double.Parse(tmp[5]), double.Parse(tmp[6]));
            return tmpObj;
        }

        // Ghi một đối tượng HoaDonThanhToan vào tệp
        public void Write(string fileName, HoaDonThanhToan hd)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write); // Mở tệp ở chế độ ghi thêm
            StreamWriter sw = new StreamWriter(fs); // Tạo một StreamWriter để ghi vào tệp
            sw.WriteLine(O2S(hd)); // Ghi đối tượng dưới dạng chuỗi
            sw.Close(); // Đóng StreamWriter
            fs.Close(); // Đóng FileStream
        }

        // Đọc một đối tượng HoaDonThanhToan từ tệp
        public HoaDonThanhToan Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Mở tệp ở chế độ đọc
            StreamReader sr = new StreamReader(fs); // Tạo một StreamReader để đọc từ tệp
            string kq = sr.ReadLine(); // Đọc một dòng từ tệp
            sr.Close(); // Đóng StreamReader
            fs.Close(); // Đóng FileStream
            return S2O(kq); // Chuyển đổi chuỗi thành đối tượng HoaDonThanhToan và trả về
        }

        // Ghi danh sách các đối tượng HoaDonThanhToan vào tệp
        public void WriteList(string fileName, List<HoaDonThanhToan> Listhd)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write); // Mở tệp ở chế độ tạo mới (ghi đè nếu tồn tại)
            StreamWriter sw = new StreamWriter(fs); // Tạo một StreamWriter để ghi vào tệp
            Node<HoaDonThanhToan> tg = Listhd.Head; // Bắt đầu với phần đầu của danh sách
            while (tg != null) // Duyệt qua danh sách
            {
                sw.WriteLine(O2S(tg.Data)); // Ghi từng đối tượng HoaDonThanhToan vào tệp
                tg = tg.Link; // Di chuyển đến nút tiếp theo trong danh sách
            }
            sw.Close(); // Đóng StreamWriter
            fs.Close(); // Đóng FileStream
        }

        // Đọc danh sách các đối tượng HoaDonThanhToan từ tệp
        public List<HoaDonThanhToan> ReadList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Mở tệp ở chế độ đọc
            StreamReader sr = new StreamReader(fs); // Tạo một StreamReader để đọc từ tệp
            List<HoaDonThanhToan> list = new List<HoaDonThanhToan>(); // Tạo một danh sách rỗng để chứa các đối tượng
            string s = sr.ReadLine(); // Đọc dòng đầu tiên từ tệp
            while (s != null) // Lặp lại cho đến khi hết tệp
            {
                if (s != "") // Nếu dòng không rỗng
                {
                    list.AddTail(S2O(s)); // Chuyển đổi chuỗi thành đối tượng và thêm vào danh sách
                }
                s = sr.ReadLine(); // Đọc dòng tiếp theo từ tệp
            }
            sr.Close(); // Đóng StreamReader
            fs.Close(); // Đóng FileStream
            return list; // Trả về danh sách các đối tượng HoaDonThanhToan
        }
    }

}
