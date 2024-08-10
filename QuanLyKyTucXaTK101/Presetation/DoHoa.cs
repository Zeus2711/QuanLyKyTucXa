using System;
using System.Linq;
using System.Text;

namespace QuanLyKyTucXaTK101.Presetation
{
   public class DoHoa
    {
       public DoHoa(int a, int b)
       {
           Console.SetWindowSize(a, b);
       }
       public  void ve(string s, int x, int y)
       {
           Console.SetWindowSize(100, 55);
           Console.SetCursorPosition(x, y);
           Console.Write(s);
       }
       public void ve1(string s, int x, int y)
       {
           Console.SetWindowSize(137, 55);
           Console.SetCursorPosition(x, y);
           Console.Write(s);
       }
    }
}
