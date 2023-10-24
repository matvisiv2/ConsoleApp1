using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public sealed class Manager : Employee, IMartialArts
    {
        public int SubordinatesCount { get; set; } = 0;

        public string[] ArtsEnum { get; set; }

        public sealed override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Subordinates count: {SubordinatesCount}");
        }

        public Manager() : this("", "Manager", "Manager", 0)
        {
            //Console.WriteLine("Manager std ctor");
        }
        public Manager(string birthday = "", string firstName = "Manager", string lastName = "Manager", int sc = 0)
            : base(birthday, firstName, lastName)
        {
            //Console.WriteLine("Manager special ctor");
            SubordinatesCount = sc;
        }
    }
}