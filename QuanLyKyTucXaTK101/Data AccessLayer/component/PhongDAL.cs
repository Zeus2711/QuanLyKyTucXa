using System;
using System.Linq;
using System.Text;
using System.IO;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class PhongDAL
    {
        // Khởi tạo một đối tượng DataAccessHelper để quản lý tập tin "Phong.txt"
        DataAccessHelper dah = new DataAccessHelper("Data/Phong.txt");

        // Phương thức chuyển đối tượng Phong thành chuỗi
        public string O2S(Phong p)
        {
            // Trả về chuỗi bao gồm các thuộc tính của Phong, ngăn cách bởi dấu '#'
            return p.Maphong + "#" + p.Tenphong + "#" + p.Loaiphong + "#" + p.Tinhtrang + "#" + p.Giaphong + "#" + p.Succhua + "#" + p.Sosinhvienhientai + "#" + p.Maday;
        }

        // Phương thức chuyển chuỗi thành đối tượng Phong
        public Phong S2O(string s)
        {
            // Xử lý chuỗi đầu vào, loại bỏ các khoảng trắng dư thừa
            s = CongCu.CatXau(s);
            // Tách chuỗi theo dấu '#' để lấy từng thuộc tính
            string[] tmp = s.Split('#');
            // Tạo đối tượng Phong từ các thuộc tính đã tách
            Phong tmpObj = new Phong(int.Parse(tmp[0]), tmp[1], tmp[2], tmp[3], double.Parse(tmp[4]), int.Parse(tmp[5]), int.Parse(tmp[6]), int.Parse(tmp[7]));
            return tmpObj;
        }

        // Phương thức ghi đối tượng Phong vào tập tin
        public void Write(string fileName, Phong p)
        {
            // Mở tập tin để ghi thêm dữ liệu (Append)
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Ghi đối tượng Phong dưới dạng chuỗi vào tập tin
            sw.WriteLine(O2S(p));
            sw.Close();
            fs.Close();
        }

        // Phương thức đọc một đối tượng Phong từ tập tin
        public Phong Read(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            // Đọc dòng đầu tiên từ tập tin và chuyển đổi nó thành đối tượng Phong
            string kq = sr.ReadLine();
            return S2O(kq);
        }

        // Phương thức ghi danh sách các đối tượng Phong vào tập tin
        public void WriteList(string fileName, List<Phong> p)
        {
            // Mở tập tin để ghi đè (Create)
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Bắt đầu từ nút đầu của danh sách
            Node<Phong> tg = p.Head;
            // Duyệt qua từng phần tử trong danh sách và ghi vào tập tin
            while (tg != null)
            {
                sw.WriteLine(O2S(tg.Data));
                tg = tg.Link;
            }
            sw.Close();
            fs.Close();
        }

        // Phương thức đọc danh sách các đối tượng Phong từ tập tin
        public List<Phong> ReadList(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Phong> list = new List<Phong>();
            // Đọc từng dòng từ tập tin và chuyển đổi nó thành đối tượng Phong
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    list.AddTail(S2O(s));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            // Trả về danh sách các đối tượng Phong đã đọc
            return list;
        }
    }

}


