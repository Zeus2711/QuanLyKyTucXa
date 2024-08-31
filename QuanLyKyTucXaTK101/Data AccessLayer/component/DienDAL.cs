using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
using System.IO;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class DienDAL
    {
        // Tạo một đối tượng DataAccessHelper để thao tác với tệp "Data/TienDien.txt".
        DataAccessHelper dah = new DataAccessHelper("Data/TienDien.txt");
        public string O2S(Dien Tiendien) // Phương thức O2S chuyển đối tượng Dien thành một chuỗi ký tự.
        {
            // Chuỗi kết quả chứa các thuộc tính của đối tượng Dien, ngăn cách bởi ký tự '#'.
            return Tiendien.Iddien + "#" + Tiendien.Thang + "#" + Tiendien.Nam + "#" + Tiendien.Maphong +"#" + Tiendien.Socngtothangnay+ "#" + Tiendien.Sodiendadung;
        }
        public Dien S2O(string s) // Phương thức S2O chuyển đổi một chuỗi ký tự thành đối tượng Dien.
        {
            s = CongCu.CatXau(s);   // Loại bỏ các ký tự không cần thiết hoặc khoảng trắng trong chuỗi.
            string[] tmp = s.Split('#'); // Tách chuỗi thành mảng các chuỗi con bằng ký tự '#'.
            // Tạo đối tượng Dien mới bằng cách sử dụng các giá trị trong mảng chuỗi.
            Dien tmpObj = new Dien(int.Parse(tmp[0]),int.Parse(tmp[1]),int.Parse(tmp[2]),int.Parse(tmp[3]),int.Parse(tmp[4]),int.Parse(tmp[5]));
            return tmpObj;
        }
        // Phương thức Write ghi đối tượng Dien vào tệp với chế độ Append (thêm vào cuối tệp).
        public void Write(string fileName, Dien tiendien)
        {
            // Mở tệp để ghi, thêm nội dung mới vào cuối tệp mà không ghi đè.
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            // Tạo StreamWriter để ghi dữ liệu vào tệp.
            StreamWriter sw = new StreamWriter(fs);
            // Ghi chuỗi đại diện của đối tượng Dien vào tệp.
            sw.WriteLine(O2S(tiendien));
            sw.Close();     // Đóng StreamWriter và FileStream để giải phóng tài nguyên.
            fs.Close();
        }
        public Dien Read(string fileName) // Phương thức Read đọc dòng đầu tiên từ tệp và chuyển đổi nó thành đối tượng Dien
        {
            // Mở tệp để đọc dữ liệu 
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            // Tạo StreamReader để đọc dữ liệu từ tệp
            StreamReader sr = new StreamReader(fs);
            // Đọc dòng đàu tiên từ tệp
            string kq = sr.ReadLine();
            // Chuyển đổi chuỗi đã đọc thành đối tượng Dien
            return S2O(kq);
        }
        public void WriteList(string fileName,List<Dien> ListTiendien) //     // Phương thức WriteList ghi danh sách các đối tượng Dien vào tệp,

        {
            // Mở tệp để ghi, tạo mới hoặc ghi đè nội dung tệp hiện tại.
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            // Tạo StreamWriter để ghi dữ liệu vào tệp.
            StreamWriter sw = new StreamWriter(fs);
            // Duyệt qua từng phần tử trong danh sách và ghi chúng vào tệp.
            Node<Dien> tg = ListTiendien.Head;
            while (tg != null)
            {
                // Ghi đối tượng Dien dưới dạng chuỗi vào tệp
                sw.WriteLine((O2S(tg.Data)));
                tg=tg.Link ;
            }
            sw.Close();
            fs.Close();
        }
        public List<Dien> ReadList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Dien> list = new List<Dien>();
            string s = sr.ReadLine();
            while (s !=null)
            {
                if (s != "")
                {
                    list.AddTail(S2O(s));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return list;
        }
    
    }
}
