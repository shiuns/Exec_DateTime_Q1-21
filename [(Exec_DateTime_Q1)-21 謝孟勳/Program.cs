using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Exec_DateTime_Q1__21_謝孟勳
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DVD借閱時間 : ");
            string input = Console.ReadLine();
            int input1 = int.Parse(input);
            
            DateTime dt = DateTime.Now.AddDays(input1);

            string threeDaysAfter = dt.ToString("yyyy/MM/dd");
            Console.WriteLine(threeDaysAfter);

            Console.Read();
        }
    }
}
