using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class KhoaBLL
    {
        KhoaDAL KDAL = new KhoaDAL();
        public List<Khoa> ListKhoa()
        {
            List<Khoa> ds= KDAL.ReadList("Data/Khoa.txt");
            return ds;
        }
        public bool KiemTraMaKhoa(int makhoa)
        {
            List<Khoa> ds = KDAL.ReadList("Data/Khoa.txt");
            bool kt = false;
            Node<Khoa> tg = ds.Head;
            while (tg != null)
            {
                if (tg.Data.Makhoa == makhoa)
                {
                    kt = true;
                    break;
                }
                else
                {
                    tg = tg.Link;
                }
            }
            return kt;
        }
    }
}
