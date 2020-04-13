using System;

namespace WSB_C_2020_Z1_05
{
    class Zadanie5
    {
        public class Calculator
        {
            private float addition;
            private float subtraction;
            private float multiplication;
            private float split;
            public Calculator(float a, float b)
            {
                addition = a + b;
                subtraction = a - b;
                multiplication = a * b;
                split = a / b;
            }
            public void Sum()
            {
                Console.WriteLine("Wynik to: " + addition);
            }
            public void Difference()
            {
                Console.WriteLine("Wynik to: " + subtraction);
            }
            public void Product()
            {
                Console.WriteLine("Wynik to: " + multiplication);
            }
            public void Quotient()
            {
                Console.WriteLine("Wynik to: " + split);
            }
        }
        class main
        {
            static void Main()
            {
                Console.WriteLine("Podaj pierwsza liczbe");
                string firstNumber = Console.ReadLine();
                float a = float.Parse(firstNumber);

                Console.WriteLine("Podaj druga liczbe");
                string secondNumber = Console.ReadLine();
                float b = float.Parse(secondNumber);

                Calculator Calc = new Calculator(a, b);

                Console.WriteLine("Wybierz jaka operacje chcesz wykonac wpisujac odpowiedni znak");
                Console.WriteLine("+: dodawanie, -: odejmowanie, *: mnozenie, /:dzielenie");
                string character = Console.ReadLine();

                if (character == "+")
                {
                    Calc.Sum();
                }
                else if (character == "-")
                {
                    Calc.Difference();
                }
                switch (character)
                {
                    case "*":
                        Calc.Product();
                        break;

                    case "/":
                        if (a != 0 && b != 0)
                        {
                            Calc.Quotient();
                        }
                        else
                        {
                            Console.WriteLine("Nie dzielimy przez 0!");
                        }
                        break;
                }
            }
        }
    }
}