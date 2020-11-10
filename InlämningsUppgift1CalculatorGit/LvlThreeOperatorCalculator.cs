using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift1CalculatorGit
{
    class LvlThreeOperatorCalculator
    {
        char Operator1, Operator2;
        int Term1, Term2, Term3;

        public void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public void FirstInput()
        {
            Console.WriteLine("Enter first operator.");
            Operator1 = Convert.ToChar(Console.ReadLine());
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Enter second operator.");
            Operator2 = Convert.ToChar(Console.ReadLine());
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first term.");
                    Term1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    ClearCurrentConsoleLine();
                    Console.WriteLine("Enter second term. ");
                    Term2 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    ClearCurrentConsoleLine();
                    Console.WriteLine("Enter third term. ");
                    Term3 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    ClearCurrentConsoleLine();
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("<Number was invalid. Press enter and enter a valid number.>");
                    Console.ReadLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 3);
                    ClearCurrentConsoleLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    continue;
                }
            }
        }

        public string HandleOperator()
        {
            int result;

            if (Operator2 == '*')
            {
                result = Term2 * Term3;
                if (Operator1 == '*')
                {
                    result = Term1 * result;
                    return Convert.ToString(result);
                }
                else if (Operator1 == '/')
                {
                    result = Term1 / result;
                    return Convert.ToString(result);
                }
                else if (Operator1 == '+')
                {
                    result = Term1 + result;
                    return Convert.ToString(result);
                }
                else if (Operator1 == '-')
                {
                    result = Term1 - result;
                    return Convert.ToString(result);
                }
                else
                {
                    return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
                }
            }
            else if (Operator2 == '/')
            {
                result = Term2 / Term3;
                if (Operator1 == '*')
                {
                    result = Term1 * result;
                    return Convert.ToString(result);
                }
                else if (Operator1 == '/')
                {
                    result = Term1 / result;
                    return Convert.ToString(result);
                }
                else if (Operator1 == '+')
                {
                    result = Term1 + result;
                    return Convert.ToString(result);
                }
                else if (Operator1 == '-')
                {
                    result = Term1 - result;
                    return Convert.ToString(result);
                }
                else
                {
                    return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
                }
            }
            else if (Operator1 == '*')
            {
                result = Term1 * Term2;
                if (Operator2 == '*')
                {
                    result *= Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '/')
                {
                    result /= Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '+')
                {
                    result += Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '-')
                {
                    result -= Term3;
                    return Convert.ToString(result);
                }
                else
                {
                    return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
                }
            }
            else if (Operator1 == '/')
            {
                result = Term1 / Term2;
                if (Operator2 == '*')
                {
                    result *= Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '/')
                {
                    result /= Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '+')
                {
                    result += Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '-')
                {
                    result -= Term3;
                    return Convert.ToString(result);
                }
                else
                {
                    return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
                }
            }
            else if (Operator1 == '+')
            {
                result = Term1 + Term2;
                if (Operator2 == '+')
                {
                    result += Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '-')
                {
                    result -= Term3;
                    return Convert.ToString(result);
                }
                else
                {
                    return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
                }
            }
            else if (Operator1 == '-')
            {
                result = Term1 - Term2;
                if (Operator2 == '+')
                {
                    result += Term3;
                    return Convert.ToString(result);
                }
                else if (Operator2 == '-')
                {
                    result -= Term3;
                    return Convert.ToString(result);
                }
                else
                {
                    return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
                }
            }
            else
            {
                return "Något gick snett. Var säker på att du skriver in korrekta operatorer och termer.";
            }
        }
    }
}