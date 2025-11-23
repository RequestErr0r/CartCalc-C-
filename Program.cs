using System;

namespace CartCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal VAT_RATE = 0.20m;

            // Ввод и валидация цены
            decimal price;
            while (true)
            {
                Console.Write("Enter price: ");
                if (decimal.TryParse(Console.ReadLine(), out price) && price >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            // Ввод и валидация количества
            int quantity;
            while (true)
            {
                Console.Write("Enter quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }

            // Расчеты
            decimal subtotal = price * quantity;
            decimal vat = subtotal * VAT_RATE;
            decimal total = subtotal + vat;

            // Вывод результатов
            Console.WriteLine();
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"VAT ({VAT_RATE * 100}%): {vat:F2}");
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}