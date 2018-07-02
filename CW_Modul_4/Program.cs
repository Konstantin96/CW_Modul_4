using CW_Modul_4.MODUL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Modul_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Service_REQUEST sr = new Service_REQUEST();
            sr.Get_REQUEST_data().PrintInfo();
            
        }
        //
       
    }
}
