using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Data_AccessLayer.component;
using QuanLyKyTucXaTK101.Utility;
namespace QuanLyKyTucXaTK101.Business.component
{
    class DanhNhapBLL
    {
        DangNhapDAL login = new DangNhapDAL();
        public bool KiemTraNick(string user, string pass)
        {
            DangNhap t = login.Read("Data/Login.txt");
            bool kt = false;
            if ((t.Urser == user) && (t.Pass == pass))
            { kt = true; }
            return kt;
        }
    }
}

