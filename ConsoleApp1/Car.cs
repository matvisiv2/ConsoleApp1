using System;

namespace ConsoleApp1
{
    internal class Car
    {
        private readonly int serialNumber;
        public double SerialNumber
        {
            get { return serialNumber; }
        }
        private int currSpeed = 0;
        public static int CarsCount { get; set; } = 0;
        public string PetName { get; set; } = "Anonymous";

        public int CurrSpeed
        {
            get { return currSpeed; }
            set
            {
                try
                {
                    currSpeed = value;
                    if (value > 30)
                    {
                        Console.Beep();
                        Console.WriteLine("Warning! You are speeding!");
                        throw new Exception("speeding");
                    }
                }
                catch (Exception e)
                {
                    Console.Beep(400, 1000);
                    Console.WriteLine("=================Runtime error was detected.=================");
                    Console.WriteLine($"TargetSite: {e.TargetSite}.");
                    Console.WriteLine($"TargetSite.DeclaringType: {e.TargetSite.DeclaringType}.");
                    Console.WriteLine($"TargetSite.MemberType: {e.TargetSite.MemberType}.");
                    Console.WriteLine($"Message: {e.Message}.");
                    Console.WriteLine($"Source: {e.Source}.");
                    Console.WriteLine("=============================================================");

                }
            }
        }

        public void PrintState() => Console.WriteLine($"{PetName} (serial number: {SerialNumber}) is going {CurrSpeed} MPH");
        public void SpeedUp(int delta) => CurrSpeed += delta;

        public Car(string pn = "blank", int cs = 0)
        {
            CarsCount++;
            serialNumber = new Random(CarsCount).Next();
            PetName = pn;
            CurrSpeed = cs;
        }

        static Car()
        {
            //CarsCount = 0;
        }
    }
}
