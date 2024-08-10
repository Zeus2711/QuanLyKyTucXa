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
        DataAccessHelper dah = new DataAccessHelper("Data/TraPhong.txt");
            public string O2S(TraPhong TraPH)
            {
                return TraPH.Id + "#" + TraPH.Masv + "#" + TraPH.Maphong + "#" + TraPH.Ngaytra;
            }
            public TraPhong S2O(string s)
            {
                s = CongCu.CatXau(s);
                string[] tmp = s.Split('#');
                TraPhong tmpObj = new TraPhong(int.Parse(tmp[0]), int.Parse(tmp[1]), int.Parse(tmp[2]),DateTime.Parse(tmp[3]));
                return tmpObj;
            }
            public List<TraPhong> ReadList(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                List<TraPhong> list = new List<TraPhong>();
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
            public TraPhong Read(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string kq = sr.ReadLine();
                return S2O(kq);
            }
            public void Write(string fileName, TraPhong TraPH)
            {
                FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(O2S(TraPH));
                sw.Close();
                fs.Close();
            }
            public void WriteList(string fileName, List<TraPhong> TraPH)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Node<TraPhong > tg =TraPH.Head;
                while (tg != null)
                {
                    sw.WriteLine((O2S(tg.Data)));
                    tg = tg.Link;
                }
                sw.Close();
                fs.Close();
            }
        }
    }

