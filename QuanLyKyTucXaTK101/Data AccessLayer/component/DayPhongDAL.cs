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
        DataAccessHelper dah = new DataAccessHelper("Data/DayPhong.txt");
        public string O2S(DayPhong d)
        {
            return d.Maday + "#" + d.Tenday + "#" + d.Vitri;
        }
        public DayPhong S2O(string s)
        {
            s = CongCu.CatXau(s);
            string[] tmp = s.Split('#');
            DayPhong tmpObj = new DayPhong(int.Parse(tmp[0]), tmp[1], tmp[2]);
            return tmpObj;
        }
        public void Write(string fileName, DayPhong d)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(d));
            sw.Close();
            fs.Close();
        }
        public DayPhong Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine();
            return S2O(kq);
        }
        public void WriteList(string fileName,List<DayPhong> dp)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<DayPhong> tg=dp.Head;
            while (tg != null)
            {
                sw.WriteLine((O2S(tg.Data)));
                tg=tg.Link ;
            }
            sw.Close();
            fs.Close();
        }
        public List<DayPhong> ReadList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<DayPhong> list = new List<DayPhong>();
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
