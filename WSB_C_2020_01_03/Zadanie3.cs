using System;

namespace WSB_C_2020_Z1_03
{
    class Zadanie3
    {
        static void Main()
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            string first = Console.ReadLine();
            float a = float.Parse(first);

            Console.WriteLine("Podaj druga liczbe");
            string second = Console.ReadLine();
            float b = float.Parse(second);

            static void Calc(float x, float y)
            {
                float c = x * y;
                Console.WriteLine("Iloczyn liczb podanych przez Ciebie to: " + c);

            }

            static void CalcB(float x, float y)
            {
                Console.WriteLine("Wybierz jaka operacje chcesz wykonac wpisujac odpowiedni znak");
                Console.WriteLine("+: dodawanie, -: odejmowanie, *: mnozenie, /:dzielenie");
                string character = Console.ReadLine();

                float sum;
                if (character == "+")
                {
                    sum = x + y;
                    Console.WriteLine("Suma wynosi: " + sum);
                }
                else if (character == "-")
                {
                    sum = x - y;
                    Console.WriteLine("Różnica wynosi: " + sum);
                }
                switch (character)
                {
                    case "*":
                        sum = x * y;
                        Console.WriteLine("Iloczyn wynosi: " + sum);
                        break;
                    case "/":
                        if (y != 0)
                        {
                            sum = x / y;
                            Console.WriteLine("Iloraz wynosi: " + sum);
                        }
                        else
                        {
                            Console.WriteLine("Nie dzielimy przez 0!");
                        }

                        break;
                }
            }

            Calc(a, b);
            CalcB(a, b);

        }
    }
}
