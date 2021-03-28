using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Current("Alif", "1234", 5000);
            acc1.showInfo();
            //acc1.Deposit(2000);
            

        }
    }
}
