using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Процент: ");
            float P = float.Parse(Console.ReadLine());
            int K = 1;
            float S = 1000;
            while (S <= 1100) {
                ++K;
                S += S * P / 100;
            }
            Console.WriteLine($"Количество месяцев: {K}\nИтоговый размер вклада: {Math.Round(S,2)}");
        }
    }
}
