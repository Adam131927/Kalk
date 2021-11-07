using System;

namespace Kalkulator 
    //Calc github
{
    class Program
    {
        public static double Sum(double first, double second)
        {
            double result;
            result = first + second;
            return result;
        }

        public static double Minus(double first, double second)
        {
            double result;
            result = first - second;
            return result;
        }
        public static double Mult(double first, double second)
        {
            double result;
            result = first * second;
            return result;
        }

        public static double Div(double first, double second)
        {

                double result;
                result = first / second;
                return result;
        }
        public static double Sqrt(double first)
        {
            double result;

            result = Math.Sqrt(first);

            return result;
        }

        public static double Step(double first, double second)
        {
            double result;

            result = Math.Pow(first, second);

            return result;
        }
        static void Main(string[] args)
        {

            double a;
            double b;
            double result;
            double result2;
            char operation;

            Console.WriteLine("Wpisz pierwszą liczbę:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wpisz drugą liczbę:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz działanie: + - * / ^ <");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                result = Sum(a, b);
                Console.WriteLine("Suma wynosi " + result + ".");
            }

            else if (operation == '-')
            {
                result = Minus(a, b);
                Console.WriteLine("Różnica wynosi " + result + ".");
            }

            else if (operation == '*')
            {
                result = Mult(a, b);
                Console.WriteLine("Wynik mnożenia to " + result + ".");
            }

            else if (operation == '/')
            {
                if (b != 0)
                {
                    result = Div(a, b);
                    Console.WriteLine("Wynik dzielenia to " + result + ".");
                }
                else
                {
                    Console.WriteLine("Nie dziel przez zero!");
                }
            }

            else if (operation == '^')
            {
                result = Step(a, b);
                Console.WriteLine("Wynik podniesienia liczby " + a + " do stopnia " + b + " wynosi " + result + ".");
            }


            else if (operation == '<')
            {
                result = Sqrt(a);
                result2 = Sqrt(b);

                Console.WriteLine("Pierwiastek kwadratowy z pierwszej liczby " + result + ".");
                Console.WriteLine("Pierwiastek kwadratowy z drugiej liczby " + result2 + ".");
            }
            else
            {
                Console.WriteLine("Nieznane działanie.");
            }
            Console.ReadKey();
        }
    }
}