using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift1CalculatorGit
{
    class Program
    {
        static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void Main(string[] args)
        {
            LvlThreeOperatorCalculator MyCalc = new LvlThreeOperatorCalculator();
            Console.WriteLine("---------------LvlThreeOperatorCalculator---------------");
            while (true)
            {
                MyCalc.FirstInput();
                Console.Write("Resultatet är: ");
                Console.Write(MyCalc.HandleOperator());
                Console.WriteLine("\nTryck Enter för att fortsätta, vill du avsluta skriv stop");
                
                string stop = Console.ReadLine();
                if (stop == "stop")
                {
                    Environment.Exit(0);
                }
                Console.SetCursorPosition(0, Console.CursorTop - 3);
                ClearCurrentConsoleLine();
            }
        }
    }
}