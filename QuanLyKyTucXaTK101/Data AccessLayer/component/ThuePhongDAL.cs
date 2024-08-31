using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using System.IO;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class ThuePhongDAL
    {
        // Khởi tạo đối tượng DataAccessHelper để làm việc với tập tin "ThuePhong.txt"
        DataAccessHelper dah = new DataAccessHelper("Data/ThuePhong.txt");

        // Phương thức chuyển đổi đối tượng ThuePhong thành chuỗi
        public string O2S(ThuePhong ThuePH)
        {
            // Trả về chuỗi bao gồm các thuộc tính của ThuePhong, cách nhau bởi dấu '#'
            return ThuePH.Id + "#" + ThuePH.Masv + "#" + ThuePH.Maphong + "#" + ThuePH.Ngaythue;
        }

        // Phương thức chuyển đổi chuỗi thành đối tượng ThuePhong
        public ThuePhong S2O(string s)
        {
            // Xử lý chuỗi để loại bỏ khoảng trắng dư thừa
            s = CongCu.CatXau(s);
            // Tách chuỗi theo dấu '#' để lấy các thuộc tính
            string[] tmp = s.Split('#');
            // Tạo đối tượng ThuePhong từ các thuộc tính đã tách
            ThuePhong tmpObj = new ThuePhong(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2]), DateTime.Parse(tmp[3]));
            return tmpObj;
        }

        // Phương thức đọc danh sách các đối tượng ThuePhong từ tập tin
        public List<ThuePhong> ReadList(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<ThuePhong> list = new List<ThuePhong>();
            // Đọc từng dòng từ tập tin và chuyển đổi thành đối tượng ThuePhong
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
            // Trả về danh sách các đối tượng ThuePhong đã đọc
            return list;
        }

        // Phương thức đọc một đối tượng ThuePhong từ tập tin
        public ThuePhong Read(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            // Đọc dòng đầu tiên từ tập tin và chuyển đổi thành đối tượng ThuePhong
            string kq = sr.ReadLine();
            return S2O(kq);
        }

        // Phương thức ghi danh sách các đối tượng ThuePhong vào tập tin
        public void WriteList(string fileName, List<ThuePhong> ThuePH)
        {
            // Mở tập tin để ghi dữ liệu, ghi đè nếu tập tin đã tồn tại
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Bắt đầu từ nút đầu của danh sách
            Node<ThuePhong> tg = ThuePH.Head;
            // Duyệt qua từng phần tử trong danh sách và ghi vào tập tin
            while (tg != null)
            {
                sw.WriteLine(O2S(tg.Data));
                tg = tg.Link;
            }
            sw.Close();
            fs.Close();
        }

        // Phương thức ghi một đối tượng ThuePhong vào tập tin
        public void Write(string fileName, ThuePhong ThuePH)
        {
            // Mở tập tin để ghi thêm dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Ghi đối tượng ThuePhong dưới dạng chuỗi vào tập tin
            sw.WriteLine(O2S(ThuePH));
            sw.Close();
            fs.Close();
        }
    }

}


