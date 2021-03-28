﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public int balance { get; set; }

        public Account(string accName, string accNo, int balance)
        {
            this.AccName = accName;
            this.AccNo = accNo;
            this.balance = balance;
        }


        public void showInfo()
        {
            Console.WriteLine("Account name: " + AccName);
            Console.WriteLine("Account no: " + AccNo);
            Console.WriteLine("Balance: " + balance);
        }
    }
}
