using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int A;
            int B;
            string C;

            Console.WriteLine("First Number Entry");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("select the suitable symbol +, -, *, /,^,% ");
            C = (Console.ReadLine());

            Console.WriteLine("Second Number Entry");
            B = int.Parse(Console.ReadLine());
            

            switch (C)
            {
                case "+" :
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine((A + B));
                    break;

                case "-":
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine((A - B));
                    break;

                case "*":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine((A * B));
                    break;

                case "/":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine((A / B));
                    break;

                case "%":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine((A % B));
                    break;

                case "^":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Returning answer is = " + Math.Pow(A, B));
                    break;

                default :
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Unknown Factor, Try again !!");
                    break;


            }

        }
            
            
            
            
            
            
    }




 
}
