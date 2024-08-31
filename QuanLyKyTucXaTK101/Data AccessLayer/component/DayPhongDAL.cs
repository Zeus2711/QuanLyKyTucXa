using System;
using System.Linq;
using System.Text;
using System.IO;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class DayPhongDAL
    {
        // Tạo một đối tượng DataAccessHelper để thao tác với tệp "Data/DayPhong.txt
        DataAccessHelper dah = new DataAccessHelper("Data/DayPhong.txt");
        public string O2S(DayPhong d) // chuyển đối tượng DayPhong thành một chuỗi ký tự 
        {
            return d.Maday + "#" + d.Tenday + "#" + d.Vitri; // Chuỗi kết quả chứa các thuộc tính DayPhong, ngăn cách bởi ký tự '#'
        }
        public DayPhong S2O(string s) // Chuyển đổi một chuỗi ký tự thành đối tượng DayPhong
        {
            s = CongCu.CatXau(s); // Loại bỏ các ký tự không cần thiết hoặc khoảng trắng trong chuỗi 
            string[] tmp = s.Split('#'); // Tách chuỗi thành mang các chuỗi con bằng ký tự '#'
            DayPhong tmpObj = new DayPhong(int.Parse(tmp[0]), tmp[1], tmp[2]); // Tạo đối tượng DayPhong bằng cách sử dụng các giá trị trong mảng chuỗi 
            return tmpObj; 
        }
        public void Write(string fileName, DayPhong d) // Phương thức Write ghi đối tượng DayPhong vào tệp với chế độ Append (thêm vào cuối tệp)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write); // Mở tệp để ghi, thêm nội dung mới vào cuối tệp mà không ghi đè
            StreamWriter sw = new StreamWriter(fs); // Tạo StreamWriter để ghi dữ liệu vào tệp
            sw.WriteLine(O2S(d)); // ghi chuỗi đại diện của đối tượng DayPhong vào tệp
            sw.Close(); // Đóng StreamWriter và FileStream để giải phóng tài nguyên
            fs.Close();
        }
        public DayPhong Read(string fileName) // Phương thức Read đọc dòng đầu tiên từ tệp và chuyển đổi nó thành đối tượng DayPhong
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read); // Mở tệp để đọc dữ liệu
            StreamReader sr = new StreamReader(fs); // Tạo StreamReader để đọc dữ liệu từ tệp
            string kq = sr.ReadLine(); // Đọc dòng đầu tiên từ tệp
            return S2O(kq); //Chuyển đổi chuỗi đã đọc thành đối tượng DayPhong
        }
        public void WriteList(string fileName,List<DayPhong> dp) // Phương thức WriteList ghi danh sách các đối tượng DayPhong vào tệp 
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);  // Mở tệp để ghi, tạo mới hoặc ghi đè nội dung tệp hiện tại.
            StreamWriter sw = new StreamWriter(fs);// Tạo StreamWriter để ghi dữ liệu vào tệp.
            Node<DayPhong> tg=dp.Head; // Duyệt qua từng phần tử trong danh sách và ghi chúng vào tệp.
            while (tg != null)
            {
                sw.WriteLine((O2S(tg.Data)));  // Ghi đối tượng DayPhong dưới dạng chuỗi vào tệp.
                tg =tg.Link ;
            }
            sw.Close(); // Đóng StreamWriter và FileStream để giải phóng tài nguyên.
            fs.Close();
        }
        public List<DayPhong> ReadList(string fileName)  // Phương thức ReadList đọc toàn bộ nội dung tệp và chuyển đổi thành danh sách các đối tượng DayPhong.
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);  // Mở tệp để đọc dữ liệu.
            StreamReader sr = new StreamReader(fs);  // Tạo StreamReader để đọc dữ liệu từ tệp.
            List<DayPhong> list = new List<DayPhong>();  // Tạo một danh sách mới để lưu trữ các đối tượng DayPhong.
            string s = sr.ReadLine(); // Đọc từng dòng trong tệp, chuyển đổi thành đối tượng DayPhong và thêm vào danh sách.
            while (s !=null)
            {
                if (s != "") // Thêm đối tượng DayPhong vào danh sách.
                {
                    list.AddTail(S2O(s));
                }
                s = sr.ReadLine();
            }
            sr.Close(); // Đóng StreamReader và FileStream để giải phóng tài nguyên.
            fs.Close();
            return list; // Trả về danh sách các đối tượng DayPhong đã đọc từ tệp.
        }
    }
}
