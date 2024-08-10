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
       DataAccessHelper dah = new DataAccessHelper("Data/Phong.txt");
        public string O2S(Phong p)
        {
            return p.Maphong + "#" + p.Tenphong + "#" + p.Loaiphong+"#" + p.Tinhtrang+"#" + p.Giaphong+"#" + p.Succhua+"#" + p.Sosinhvienhientai+"#" + p.Maday;
        }
        public Phong S2O(string s)
        {
            s = CongCu.CatXau(s);
            string[] tmp = s.Split('#');
         Phong tmpObj = new Phong(int.Parse(tmp[0]), tmp[1], tmp[2],tmp[3],double.Parse(tmp[4]),int.Parse(tmp[5]),int.Parse(tmp[6]),int.Parse(tmp[7]));
         return tmpObj;
        }
        public void Write(string fileName, Phong p)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(p));
            sw.Close();
            fs.Close();
        }
        public Phong Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine();
            return S2O(kq);
        }
        public void WriteList(string fileName,List<Phong> p)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Phong> tg=p.Head;
            while (tg != null)
            {
                sw.WriteLine((O2S(tg.Data)));
                tg=tg.Link ;
            }
            sw.Close();
            fs.Close();
        }
        public List<Phong> ReadList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Phong> list = new List<Phong>();
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

  
