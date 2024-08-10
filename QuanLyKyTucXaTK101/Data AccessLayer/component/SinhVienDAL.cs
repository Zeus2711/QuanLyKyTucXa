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
        DataAccessHelper dah = new DataAccessHelper("Data/SinhVien.txt");
        public string O2S(SinhVien sv)
        {
            return sv.Masinhvien + "#" + sv.Hoten + "#" + sv.Gioitinh + "#" + sv.Ngaysinh + "#" + sv.Diachi + "#" + sv.Sodienthoai + "#" + sv.Email + "#" + sv.SoCMT + "#" + sv.Makhoa;
        }
        public SinhVien S2O(string s)
        {
            s = CongCu.CatXau(s);
            string[] tmp = s.Split('#');
            SinhVien tmpObj = new SinhVien(int.Parse(tmp[0]), tmp[1], tmp[2],DateTime.Parse(tmp[3]), tmp[4], tmp[5], tmp[6],tmp[7],int.Parse(tmp[8]));
            return tmpObj;
        }
        public void Write(string fileName, SinhVien sv)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(sv));
            sw.Close();
            fs.Close();
        }
        public SinhVien Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine();
            return S2O(kq);
        }
        public void WriteList(string fileName, List<SinhVien> d)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<SinhVien> tg = d.Head;
            while (tg != null)
            {
                sw.WriteLine((O2S(tg.Data)));
                tg = tg.Link;
            }
            sw.Close();
            fs.Close();
        }
        public List<SinhVien> ReadList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<SinhVien> list = new List<SinhVien>();
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

