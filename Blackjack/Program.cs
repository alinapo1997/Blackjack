using System;

namespace Blackjack
{
    /// <summary>
    /// Программа подсчёта суммы карт в игре «21»
    /// </summary>
    internal class Program
    {
        static int StaticWeight = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую! Давайте сыграем в игру \"Blackjack\"!\nСколько у вас карт на руках?");
            int cardCount = int.Parse(Console.ReadLine());
            int resultSum = 0;
            for (int i = 0; i < cardCount; i++)
            {
                Console.WriteLine($"Введите номинал {i + 1} карты: ");
                string stringNominal = Console.ReadLine();
                bool isInt = int.TryParse(stringNominal, out int intNominal);
                if (isInt)
                {
                    resultSum += intNominal;
                    Console.WriteLine($"+ {intNominal} очка/ов");
                }
                else
                {
                    switch (stringNominal)
                    {
                        case ("Q"):
                        case ("T"):
                        case ("J"):
                        case ("K"):
                            Console.WriteLine($"+ {StaticWeight} очков");
                            resultSum += StaticWeight;
                            break;
                        default:
                            Console.WriteLine("+ 0 очков");
                            break;
                    }
                }
            }
            Console.WriteLine($"\nИтого: {resultSum} очков.");
            Console.WriteLine("Спасибо за игру!");
            Console.ReadKey();
        }


    }
}
