using System;
using System.Linq;
using System.Text;
using System.IO;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;

namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class SinhVienDAL
    {
        // Khởi tạo một đối tượng DataAccessHelper để quản lý tập tin "SinhVien.txt"
        DataAccessHelper dah = new DataAccessHelper("Data/SinhVien.txt");

        // Phương thức chuyển đối tượng SinhVien thành chuỗi
        public string O2S(SinhVien sv)
        {
            // Trả về chuỗi bao gồm các thuộc tính của SinhVien, ngăn cách bởi dấu '#'
            return sv.Masinhvien + "#" + sv.Hoten + "#" + sv.Gioitinh + "#" + sv.Ngaysinh + "#" + sv.Diachi + "#" + sv.Sodienthoai + "#" + sv.Email + "#" + sv.SoCMT + "#" + sv.Makhoa;
        }

        // Phương thức chuyển chuỗi thành đối tượng SinhVien
        public SinhVien S2O(string s)
        {
            // Xử lý chuỗi đầu vào, loại bỏ các khoảng trắng dư thừa
            s = CongCu.CatXau(s);
            // Tách chuỗi theo dấu '#' để lấy từng thuộc tính
            string[] tmp = s.Split('#');
            // Tạo đối tượng SinhVien từ các thuộc tính đã tách
            SinhVien tmpObj = new SinhVien(int.Parse(tmp[0]), tmp[1], tmp[2], DateTime.Parse(tmp[3]), tmp[4], tmp[5], tmp[6], tmp[7], int.Parse(tmp[8]));
            return tmpObj;
        }

        // Phương thức ghi đối tượng SinhVien vào tập tin
        public void Write(string fileName, SinhVien sv)
        {
            // Mở tập tin để ghi thêm dữ liệu (Append)
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Ghi đối tượng SinhVien dưới dạng chuỗi vào tập tin
            sw.WriteLine(O2S(sv));
            sw.Close();
            fs.Close();
        }

        // Phương thức đọc một đối tượng SinhVien từ tập tin
        public SinhVien Read(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            // Đọc dòng đầu tiên từ tập tin và chuyển đổi nó thành đối tượng SinhVien
            string kq = sr.ReadLine();
            return S2O(kq);
        }

        // Phương thức ghi danh sách các đối tượng SinhVien vào tập tin
        public void WriteList(string fileName, List<SinhVien> d)
        {
            // Mở tập tin để ghi đè (Create)
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Bắt đầu từ nút đầu của danh sách
            Node<SinhVien> tg = d.Head;
            // Duyệt qua từng phần tử trong danh sách và ghi vào tập tin
            while (tg != null)
            {
                sw.WriteLine(O2S(tg.Data));
                tg = tg.Link;
            }
            sw.Close();
            fs.Close();
        }

        // Phương thức đọc danh sách các đối tượng SinhVien từ tập tin
        public List<SinhVien> ReadList(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<SinhVien> list = new List<SinhVien>();
            // Đọc từng dòng từ tập tin và chuyển đổi nó thành đối tượng SinhVien
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
            // Trả về danh sách các đối tượng SinhVien đã đọc
            return list;
        }
    }

}

