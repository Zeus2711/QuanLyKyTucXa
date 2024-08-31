using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities ;
using System.IO;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class TraPhongDAL
    {
        // Khởi tạo đối tượng DataAccessHelper để làm việc với tập tin "TraPhong.txt"
        DataAccessHelper dah = new DataAccessHelper("Data/TraPhong.txt");

        // Phương thức chuyển đổi đối tượng TraPhong thành chuỗi
        public string O2S(TraPhong TraPH)
        {
            // Trả về chuỗi bao gồm các thuộc tính của TraPhong, cách nhau bởi dấu '#'
            return TraPH.Id + "#" + TraPH.Masv + "#" + TraPH.Maphong + "#" + TraPH.Ngaytra;
        }

        // Phương thức chuyển đổi chuỗi thành đối tượng TraPhong
        public TraPhong S2O(string s)
        {
            // Xử lý chuỗi để loại bỏ khoảng trắng dư thừa
            s = CongCu.CatXau(s);
            // Tách chuỗi theo dấu '#' để lấy các thuộc tính
            string[] tmp = s.Split('#');
            // Tạo đối tượng TraPhong từ các thuộc tính đã tách
            TraPhong tmpObj = new TraPhong(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2]), DateTime.Parse(tmp[3]));
            return tmpObj;
        }

        // Phương thức đọc danh sách các đối tượng TraPhong từ tập tin
        public List<TraPhong> ReadList(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<TraPhong> list = new List<TraPhong>();
            // Đọc từng dòng từ tập tin và chuyển đổi thành đối tượng TraPhong
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
            // Trả về danh sách các đối tượng TraPhong đã đọc
            return list;
        }

        // Phương thức đọc một đối tượng TraPhong từ tập tin
        public TraPhong Read(string fileName)
        {
            // Mở tập tin để đọc dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            // Đọc dòng đầu tiên từ tập tin và chuyển đổi thành đối tượng TraPhong
            string kq = sr.ReadLine();
            return S2O(kq);
        }

        // Phương thức ghi một đối tượng TraPhong vào tập tin
        public void Write(string fileName, TraPhong TraPH)
        {
            // Mở tập tin để ghi thêm dữ liệu
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Ghi đối tượng TraPhong dưới dạng chuỗi vào tập tin
            sw.WriteLine(O2S(TraPH));
            sw.Close();
            fs.Close();
        }

        // Phương thức ghi danh sách các đối tượng TraPhong vào tập tin
        public void WriteList(string fileName, List<TraPhong> TraPH)
        {
            // Mở tập tin để ghi dữ liệu, ghi đè nếu tập tin đã tồn tại
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // Bắt đầu từ nút đầu của danh sách
            Node<TraPhong> tg = TraPH.Head;
            // Duyệt qua từng phần tử trong danh sách và ghi vào tập tin
            while (tg != null)
            {
                sw.WriteLine(O2S(tg.Data));
                tg = tg.Link;
            }
            sw.Close();
            fs.Close();
        }
    }

}

