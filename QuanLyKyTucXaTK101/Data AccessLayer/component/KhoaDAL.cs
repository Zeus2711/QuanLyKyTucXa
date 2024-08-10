using System;
using System.Linq;
using System.Text;
using System.IO;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
    class KhoaDAL
    {
            DataAccessHelper dah = new DataAccessHelper("Data/Khoa.txt");
            public string O2S(Khoa k)
            {
                return k.Makhoa + "#" +k.Tenkhoa + "#" +k.Email+ "#" +k.Sodienthoai;
            }
            public Khoa S2O(string s)
            {
                s = CongCu.CatXau(s);
                string[] tmp = s.Split('#');
                Khoa tmpObj = new Khoa(int.Parse(tmp[0]), tmp[1], tmp[2],tmp[3]);
                return tmpObj;
            }
            public void Write(string fileName, Khoa k)
            {
                FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(O2S(k));
                sw.Close();
                fs.Close();
            }
            public Khoa Read(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string kq = sr.ReadLine();
                return S2O(kq);
            }
            public void WriteList(string fileName, List<Khoa> k)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Node<Khoa> tg =k.Head;
                while (tg != null)
                {
                    sw.WriteLine((O2S(tg.Data)));
                    tg = tg.Link;
                }
                sw.Close();
                fs.Close();
            }
            public List<Khoa> ReadList(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                List<Khoa> list = new List<Khoa>();
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
