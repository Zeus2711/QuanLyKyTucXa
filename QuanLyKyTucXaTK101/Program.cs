using System;
using System.Linq;
using System.Text;
using QuanLyKyTucXaTK101.Business.component;
using QuanLyKyTucXaTK101.Entities;
using QuanLyKyTucXaTK101.Presetation;
namespace QuanLyKyTucXaTK101
{
    class Program
    {
        static void Main(string[] args)
        {
            FormDangNhap frm = new FormDangNhap();
            frm.KhoiDong();
            Console.ReadKey();
        }
    }
}
