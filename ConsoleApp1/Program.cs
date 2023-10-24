using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //MessageProgram();
                //TuplesPresent();
                //ClassPresent();
                //InheritancePresent();
                //RandomPresent();
                //PolimorphismPresent();
                //InterfacesPresent();
                InterfacesPresent2();
            }
            catch (Exception e)
            {
                Console.Beep(500, 1000);
                Console.WriteLine("Runtime error was detected.");
                Console.WriteLine($"TargetSite: {e.TargetSite}.");
                Console.WriteLine($"TargetSite.DeclaringType: {e.TargetSite.DeclaringType}.");
                Console.WriteLine($"TargetSite.MemberType: {e.TargetSite.MemberType}.");
                Console.WriteLine($"Message: {e.Message}.");
                Console.WriteLine($"Source: {e.Source}.");
                Console.WriteLine("Exit...");
            }

            Console.ReadLine();
            return;
        }

        static void InterfacesPresent2()
        {
            Console.WriteLine("=====================Interfaces=====================");
            //Rectangle rectangle = new Rectangle(100, 10);
            //rectangle.Draw();

            //Circle circle = new Circle(53);
            //circle.Draw();

            //Square square = new Square(53);
            //square.Draw();

            //Shape[] shapes = { new Rectangle(41, 13), new Circle(15), new Square(10) };
            //foreach(Shape shape in shapes) {
            //    shape.Draw();
            //}

            Shape[] shapes = { new Rectangle(41, 13), new Circle(15), new Square(10) };
            foreach (Shape shape in shapes)
            {
                if(shape is IPointy ip) ip.ShowPointCount();
            }

            Console.WriteLine($"Shapes count: {Shape.Count}");
        }

        static void InterfacesPresent()
        {
            Console.WriteLine("=====================Interfaces=====================");
            Manager emp = new Manager();
            Console.WriteLine(emp);

            emp.ArtsEnum = new string[2] { "Taekwondo", "Karate" };

            foreach (string i in emp.ArtsEnum)
                Console.WriteLine(i);
        }

        static void PolimorphismPresent()
        {
            Console.WriteLine("=====================Polimorphism=====================");
            Object[] arr = { 1, "1str", new Manager(sc: 2), new SalesPerson(), "2str", new Manager() };

            // Show only Employees
            foreach (object obj in arr)
            {
                // First approach
                //Employee h = i as Employee;
                //if (h != null)   // Check if i "is-a" Employee
                //{
                //    Console.WriteLine($"{i}");
                //}

                // Second approach
                //if (i is Employee e)
                //{
                //    Console.WriteLine($"{e}");
                //}

                // Some type checking
                //switch (obj.GetType().Name)
                //{
                //    case nameof(Employee): Console.WriteLine(nameof(Employee)); break;
                //    case nameof(Manager): Console.WriteLine(nameof(Manager)); break;
                //    case nameof(SalesPerson): Console.WriteLine(nameof(SalesPerson)); break;
                //}

                // Third approach
                //switch (obj)
                //{
                //    case Manager m when m.SubordinatesCount > 0: Console.WriteLine($"Manager(!): {m}"); break;
                //    case Manager m: Console.WriteLine($"Manager: {m}"); break;
                //    case Employee e: Console.WriteLine($"Employee: {e}"); break;
                //    //case SalesPerson sp: Console.WriteLine($"SalesPerson: {sp}"); break;
                //    default: Console.WriteLine("No an employee."); break;
                //}

                // Show System.Object virtual methods
                Console.WriteLine($"ToString   : {obj.ToString()}");
                //Console.WriteLine($"GetHashCode: {obj.GetHashCode()}");
                //Console.WriteLine($"GetType    : {obj.GetType()}");

                // Show true when obj2 reference points to same object (same instance) 
                //Object obj2 = obj;
                //Console.WriteLine($"Is obj2 equals obj: {obj2.Equals(obj)}");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void InheritancePresent()
        {
            Console.WriteLine("=====================Inheritance=====================");
            //Employee emp = new Employee("1990-01-01", "Jack", "Kivlend");
            //SalesPerson emp = new SalesPerson();
            //Employee emp = new Employee();
            Employee emp = new SalesPerson();
            emp.ShowInfo();

            Console.WriteLine();

            //Manager man = new Manager("2001-11-27");
            Manager man = new Manager(firstName: "Klon");
            man.ShowInfo();

        }

        static void RandomPresent()
        {
            var rn = new Random();
            Console.WriteLine(new Random().Next());
            Console.WriteLine(new Random().Next());
        }

        static void ClassPresent()
        {
            Car myCar = new Car();
            myCar.PrintState();
            Console.WriteLine();

            Console.WriteLine($"We have already {Car.CarsCount} cars");
            Console.WriteLine();


            Car myCar2 = new Car("Mersedes");
            myCar2.PrintState();
            Console.WriteLine();

            Console.WriteLine($"We have already {Car.CarsCount} cars");
            Console.WriteLine();

            //Car myCar3 = new Car("Tesla", 120);
            //myCar3.PrintState();
            //Console.WriteLine();

            Console.WriteLine($"We have already {Car.CarsCount} cars");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
                //if (myCar.CurrSpeed > 30) throw new Exception("You are speeding!");
            }

        }

        static void TuplesPresent()
        {
            Console.WriteLine("================Fun with Tuples================");
            //(string, int, bool) a = ("text", 5, false);
            var a = (text: "text", num: 5, isIt: false);
            var b = (a.text, a.num, a.isIt);

            Console.WriteLine($"b       = {b}");
            Console.WriteLine($"b.text  = {b.text}");
            Console.WriteLine($"b.num   = {b.num}");
            Console.WriteLine($"b.isIt  = {b.isIt}");

            Console.WriteLine();
        }

        static void MessageProgram()
        {
            byte menu = 0;

            do
            {
                Console.WriteLine("1. Message with beep;");
                Console.WriteLine("2. Color message;");
                Console.WriteLine("3. Color message with beep;");
                Console.WriteLine("4. Color message without beep;");
                Console.WriteLine("8. Clear console;");
                Console.WriteLine("9. Exit;");

                Console.Write("Choose action: ");
                if (!Byte.TryParse(Console.ReadLine(), out menu))
                {
                    Console.WriteLine("Bad input");
                    Console.WriteLine();
                    continue;
                }

                switch (menu)
                {
                    case 1:
                        ShowMessage("Slava Ukraini!");
                        break;
                    case 2:
                        ShowMessage("Slava Ukraini!", false, ConsoleColor.Blue, ConsoleColor.Yellow);
                        break;
                    case 3:
                        ShowMessage("Slava Ukraini!", backgroundColor: ConsoleColor.Blue, textColor: ConsoleColor.Yellow);
                        break;
                    case 4:
                        ShowMessage(backgroundColor: ConsoleColor.Red, textColor: ConsoleColor.Black, beep: false, message: "Pizda rosii!");
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    case 9:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Bad input");
                        break;
                }

                Console.WriteLine();
            } while (menu != 9);
        }

        static void ShowMessage(string message, bool beep = true, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            if (beep)
            {
                Console.Beep();
            }
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}
