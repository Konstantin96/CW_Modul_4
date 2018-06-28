using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Modul_4.MODUL
{
    public enum status
    {
        good,error
    }
    public class Respose
    {
        public status status { get; set; }
        public string Error { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine(status);
            if (status == status.good)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(Error);
        }
    }
}
