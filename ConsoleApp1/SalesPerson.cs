using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class SalesPerson : Employee
    {
        public int SalesCount { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Sales count : {SalesCount}");
        }
    }
}