using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using System.IO;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class DangNhapDAL
    {
        DataAccessHelper dah = new DataAccessHelper("Data/Login.txt");
        public string O2S(DangNhap d)
        {
            return d.Urser+ "#" + d.Pass;
        }
        public DangNhap S2O(string s)
        {
            s = CongCu.CatXau(s);
            string[] tmp = s.Split('#');
            DangNhap tmpObj = new DangNhap(tmp[0], tmp[1]);
            return tmpObj;
        }
        public void Write(string fileName, DangNhap d)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(d));
            sw.Close();
            fs.Close();
        }
        public DangNhap Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine();
            return S2O(kq);
        }
        //public void Insert(DangNhap t)
        //{

        //    FileStream fs = new FileStream("Data/Login.txt", FileMode.Create, FileAccess.Write);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.WriteLine(t.Urser + "#" + t.Pass);
        //    sw.Close();
        //}
    }
}
