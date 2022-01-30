using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fail1 = new StreamWriter("D:\\FailRandom.txt");
            Random r = new Random();
            for (int i = 0; i < 10; i++) fail1.WriteLine(r.Next(0, 100));
            fail1.Close();
            StreamReader fr = new StreamReader("D:\\FailRandom.txt");
            string s = "";
            int result = Int32.Parse(fr.ReadLine()), num = 0;
            do
            {
                s = fr.ReadLine();
                if (int.TryParse(s, out num)) result = result + num;
               
            } while (s != null);
            fr.Close();
            StreamWriter fail2 = new StreamWriter("D:\\FailResult.txt");
            fail2.WriteLine(result);
            fail2.Close();
        }
    }
}
