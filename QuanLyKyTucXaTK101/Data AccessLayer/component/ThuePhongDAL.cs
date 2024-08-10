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
         DataAccessHelper dah = new DataAccessHelper("Data/ThuePhong.txt");
            public string O2S(ThuePhong ThuePH)
            {
                return ThuePH.Id + "#" + ThuePH.Masv + "#" + ThuePH.Maphong + "#" + ThuePH.Ngaythue;
            }
            public ThuePhong S2O(string s)
            {
                s = CongCu.CatXau(s);
                string[] tmp = s.Split('#');
                ThuePhong tmpObj = new ThuePhong(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2]),DateTime.Parse(tmp[3]));
                return tmpObj;
            }
      
        public List<ThuePhong> ReadList(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                List<ThuePhong> list = new List<ThuePhong>();
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
            public ThuePhong Read(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string kq = sr.ReadLine();
                return S2O(kq);
            }
            public void WriteList(string fileName, List<ThuePhong> ThuePH)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Node<ThuePhong > tg =ThuePH.Head;
                while (tg != null)
                {
                    sw.WriteLine((O2S(tg.Data)));
                    tg = tg.Link;
                }
                sw.Close();
                fs.Close();
            }
            public void Write(string fileName, ThuePhong ThuePH)
            {
                FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(O2S(ThuePH));
                sw.Close();
                fs.Close();
            }
        }
    }


