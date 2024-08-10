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
         DataAccessHelper dah = new DataAccessHelper("Data/TienDien.txt");
        public string O2S(Dien Tiendien)
        {
            return Tiendien.Iddien + "#" + Tiendien.Thang + "#" + Tiendien.Nam + "#" + Tiendien.Maphong +"#" + Tiendien.Socngtothangnay+ "#" + Tiendien.Sodiendadung;
        }
        public Dien S2O(string s)
        {
            s = CongCu.CatXau(s);
            string[] tmp = s.Split('#');
            Dien tmpObj = new Dien(int.Parse(tmp[0]),int.Parse(tmp[1]),int.Parse(tmp[2]),int.Parse(tmp[3]),int.Parse(tmp[4]),int.Parse(tmp[5]));
            return tmpObj;
        }
        public void Write(string fileName, Dien tiendien)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(O2S(tiendien));
            sw.Close();
            fs.Close();
        }
        public Dien Read(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string kq = sr.ReadLine();
            return S2O(kq);
        }
        public void WriteList(string fileName,List<Dien> ListTiendien)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Dien> tg = ListTiendien.Head;
            while (tg != null)
            {
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
