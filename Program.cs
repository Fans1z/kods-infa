using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите вероятность события в процентах (от 0 до 100):");
        int probability = int.Parse(Console.ReadLine());

        if (CheckEvent(probability))
        {
            Console.WriteLine("Событие произошло!");
        }
        else
        {
            Console.WriteLine("Событие не произошло.");
        }
    }

    static bool CheckEvent(int probability)
    {
        if (probability < 0 || probability > 100)
        {
            Console.WriteLine("Ошибка: вероятность должна быть от 0 до 100.");
            return false;
        }

        Random random = new Random();
        int randomValue = random.Next(0, 101);

        return randomValue <= probability;
    }
}