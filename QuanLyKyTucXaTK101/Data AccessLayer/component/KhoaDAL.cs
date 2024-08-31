using System;
using System.Linq;
using System.Text;
using System.IO;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class KhoaDAL
    {
        // Khởi tạo đối tượng DataAccessHelper để làm việc với tệp "Khoa.txt"
        DataAccessHelper dah = new DataAccessHelper("Data/Khoa.txt");

        // Chuyển đổi đối tượng Khoa thành chuỗi để lưu vào tệp
        public string O2S(Khoa k)
        {
            // Ghép các thuộc tính của đối tượng Khoa thành một chuỗi, phân cách bằng dấu '#'
            return k.Makhoa + "#" + k.Tenkhoa + "#" + k.Email + "#" + k.Sodienthoai;
        }

        // Chuyển đổi chuỗi thành đối tượng Khoa
        public Khoa S2O(string s)
        {
            // Cắt chuỗi để loại bỏ khoảng trắng không cần thiết
            s = CongCu.CatXau(s);

            // Tách chuỗi thành mảng các giá trị, phân cách bằng dấu '#'
            string[] tmp = s.Split('#');

            // Tạo đối tượng Khoa từ các giá trị trong mảng
            Khoa tmpObj = new Khoa(int.Parse(tmp[0]), tmp[1], tmp[2], tmp[3]);
            return tmpObj;
        }

        // Ghi thông tin của đối tượng Khoa vào tệp
        public void Write(string fileName, Khoa k)
        {
            // Mở tệp ở chế độ thêm mới, ghi và sau đó đóng tệp
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(k)); // Ghi chuỗi đã chuyển đổi từ đối tượng Khoa vào tệp
            sw.Close();
            fs.Close();
        }

        // Đọc thông tin từ tệp và chuyển đổi thành đối tượng Khoa
        public Khoa Read(string fileName)
        {
            // Mở tệp ở chế độ đọc, đọc dòng đầu tiên và sau đó đóng tệp
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine(); // Đọc dòng đầu tiên của tệp
            return S2O(kq); // Chuyển đổi dòng đã đọc thành đối tượng Khoa
        }

        // Ghi danh sách các đối tượng Khoa vào tệp
        public void WriteList(string fileName, List<Khoa> k)
        {
            // Mở tệp ở chế độ tạo mới, ghi và sau đó đóng tệp
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Khoa> tg = k.Head; // Lấy phần tử đầu tiên trong danh sách
            while (tg != null)
            {
                sw.WriteLine(O2S(tg.Data)); // Ghi chuỗi đã chuyển đổi từ đối tượng Khoa vào tệp
                tg = tg.Link; // Di chuyển đến phần tử tiếp theo trong danh sách
            }
            sw.Close();
            fs.Close();
        }

        // Đọc danh sách các đối tượng Khoa từ tệp
        public List<Khoa> ReadList(string fileName)
        {
            // Mở tệp ở chế độ đọc, đọc từng dòng và sau đó đóng tệp
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Khoa> list = new List<Khoa>(); // Tạo danh sách để lưu các đối tượng Khoa
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    list.AddTail(S2O(s)); // Chuyển đổi dòng đã đọc thành đối tượng Khoa và thêm vào danh sách
                }
                s = sr.ReadLine(); // Đọc dòng tiếp theo
            }
            sr.Close();
            fs.Close();
            return list; // Trả về danh sách các đối tượng Khoa đã đọc từ tệp
        }
    }
}
