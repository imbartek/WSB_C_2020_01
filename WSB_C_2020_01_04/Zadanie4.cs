using System;

namespace WSB_C_2020_Z1_03
{
    class Zadanie4
    {
        static void Main()
        {
            string character;
            string str;
            float score = 0;
            float number = 0;
            string[] arr = { "+", "-", "*", "/" }; 
            Console.WriteLine("Wpisuj liczby i znaki. Aby zobaczyc wynik wpisz 'n' ");
            do
            {
                Console.WriteLine("Aktualna liczba to: " + score);
                SelectCharacter:
                Console.WriteLine("Podaj znak");
                character = Console.ReadLine();
                foreach(string sign in arr)
                {
                    int poz = Array.IndexOf(arr, character);
                    if (character == "n")
                    {
                        goto Final;
                    }
                    else if(poz < 0)
                    {
                        Console.WriteLine("Nieprawidlowy znak. Sprobuj jeszcze raz");
                        goto SelectCharacter;
                    }
                }
                SelectNumber:
                Console.WriteLine("Podaj liczbe");
                str = Console.ReadLine();
                try
                {
                    number = float.Parse(str);
                }
                catch (FormatException)
                {
                    if(str == "n")
                    {
                        Console.WriteLine("Wpisales 'n'");
                    }
                    else
                    {
                        Console.WriteLine("Nie podales liczby");
                        goto SelectNumber;
                    }
                }

                if(character == "+")
                {
                    score += number;
                }
                else if(character == "-")
                {
                    score -= number;
                }
                else if(character == "*")
                {
                    score *= number;
                }
                else if(character == "/")
                {
                    if(number == 0)
                    {
                        Console.WriteLine("Nie dzielimy przez 0!");
                        goto SelectNumber;
                    }
                    else
                    {
                        score /= number;
                    }
                }
                else
                {
                    Console.Write("Podales zly znak. Sprobuj ponownie.");
                }
            } while (str != "n");
        Final:
            Console.WriteLine("Wynik to: " + score);
            
        }
    }
}
