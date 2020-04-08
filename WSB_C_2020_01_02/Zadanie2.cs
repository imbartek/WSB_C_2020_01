using System;

namespace WSB_C_2020_Z1_02
{
    class Zadanie2
    {
        static void Main()
        {
            static void Silnia(int n)
            {
                long strong = 1;
                for (int i = 1; i <= n; i++)
                {
                    strong *= i;
                }
                if (strong > 0)
                {
                    Console.WriteLine("Silnia z " + n + " wynosi: " + strong);
                }
                else
                {
                    Console.WriteLine("Silnia z " + n + " wynosi: Infinity");
                }

            }

            int a = 9, b = 20, c = 243, d;

            Silnia(a);
            Silnia(b);
            Silnia(c);

            Console.WriteLine("Podaj swoją liczbę");
            string str = Console.ReadLine();
            d = Convert.ToInt32(str);
            Silnia(d);
        }
    }
}
