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
        //  public HoaDonThanhToan(int id, int masv, int maphong, DateTime ngaythanhtoan, int tienphong, double tiendien, double tongtien)
        DataAccessHelper dah = new DataAccessHelper("Data/HoaDonThanhToan.txt");
        public string O2S(HoaDonThanhToan hd)
        {
            return hd.Id+ "#" + hd.Masv + "#" + hd.Maphong + "#" +hd.Ngaythanhtoan + "#" + hd.Tienphong+ "#" + hd.Tiendien + "#" + hd.Tongtien;
        }
        public HoaDonThanhToan S2O(string s)
        {
            s = CongCu.CatXau(s);
            string[] tmp = s.Split('#');
            HoaDonThanhToan tmpObj = new HoaDonThanhToan(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2]), DateTime.Parse(tmp[3]),double.Parse(tmp[4]),double.Parse(tmp[5]),double.Parse(tmp[6]));
            return tmpObj;
        }
        public void Write(string fileName, HoaDonThanhToan hd)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(hd));
            sw.Close();
            fs.Close();
        }
        public HoaDonThanhToan Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine();
            return S2O(kq);
        }
        public void WriteList(string fileName, List<HoaDonThanhToan> Listhd)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<HoaDonThanhToan> tg = Listhd.Head;
            while (tg != null)
            {
                sw.WriteLine((O2S(tg.Data)));
                tg = tg.Link;
            }
            sw.Close();
            fs.Close();
        }
        public List<HoaDonThanhToan> ReadList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<HoaDonThanhToan> list = new List<HoaDonThanhToan>();
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
            return list;
        }
    }
}
