using System;
using System.Linq;
using System.Text;
using System.IO;
namespace QuanLyKyTucXaTK101.Data_AccessLayer.component
{
  public class DataAccessHelper
    {
        private string filename;
        public string FileName
        {
            get
            {
                return filename;
            }
            set
            {
                if (value != "")
                    filename = value;
            }
        }
        public DataAccessHelper() { }
        public DataAccessHelper(string filename)
        {
            this.filename = filename;
        }
        public void WriteData(string ọbj)
        {
            StreamWriter s = new StreamWriter(FileName);
            s.WriteLine(ọbj);
            s.Dispose();
        }
        public void RemoveAll()
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.Write("");
            sw.Dispose();
        }
    }
}
