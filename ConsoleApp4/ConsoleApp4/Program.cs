using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите вероятность события в процентах (от 0 до 100):");
        double probability = Convert.ToDouble(Console.ReadLine());

        if (probability < 0 || probability > 100)
        {
            Console.WriteLine("Вероятность должна быть в диапазоне от 0 до 100.");
            return;
        }

        bool eventOccurred = CheckEvent(probability);

        if (eventOccurred)
        {
            Console.WriteLine("Событие произошло!");
        }
        else
        {
            Console.WriteLine("Событие не произошло.");
        }
    }

    static bool CheckEvent(double probability)
    {
        Random random = new Random();
        double randomValue = random.NextDouble() * 100;

        return randomValue <= probability;
    }
}