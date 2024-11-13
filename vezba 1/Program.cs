using System;

namespace vezba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();
            int brojUnetihImena = 0;

            Console.WriteLine("Unos imena na listu.\n");

            while (brojUnetihImena < 10)
            {
                Console.Write($"Unesite ime {brojUnetihImena + 1}: ");
                string ime = Console.ReadLine();

                if (imena.Count >= 0)
                {
                    brojUnetihImena = imena.Count;

                    if (ime.ToLower() == "kraj")
                    {
                        Console.WriteLine("Uneta je komanda KRAJ. Obustavlja se prikupljanje imena.");
                        break;
                    }

                }
                imena.Add(ime);
                brojUnetihImena++;
            }
            do
            {


                if (brojUnetihImena == 10)
                {
                    Console.WriteLine("\nLISTA JE POPUNJENA.\n");

                    Console.WriteLine("Potvrdite jedno ime za stampu.\n(unesite odgovarajuci redni broj imena) ");
                    Console.WriteLine();

                    Console.Write("Ime za stampu: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 10)
                    {
                        n -= 1;
                        brojUnetihImena = brojUnetihImena + n - 10;
                        Console.WriteLine();
                        Console.WriteLine(imena[brojUnetihImena].ToUpper());
                    }
                    else
                    {
                        Console.WriteLine("Molimo da unesete validan broj.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPotvrdite jedno ime za stampu.\n(unesite odgovarajuci redni broj imena) ");
                    Console.WriteLine();

                    Console.Write("Ime za stampu: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= brojUnetihImena)
                    {
                        n -= 1;
                        brojUnetihImena = brojUnetihImena + n - brojUnetihImena;
                        Console.WriteLine();
                        Console.WriteLine(imena[brojUnetihImena].ToUpper());

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Molimo da unesete validan broj.");
                    }
                }
            }
            while (true);
        }
    }
}