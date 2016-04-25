using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConvertToUTF7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\HaxLogs.txt");
            StreamWriter sw = new StreamWriter(@"D:\HaxLogs-utf7.txt", false, Encoding.UTF7);

            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();
        }
    }
}
