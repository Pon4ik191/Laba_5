using System;

namespace Laba_5
{
    enum SoftwareProduct
    {
        Accounting_System_1,
        Accounting_System_2,
        Accounting_System_3,
        Logistics_System_1,
        Logistics_System_2,
        Logistics_System_3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Номер - Назва програмного продукту");

            Console.WriteLine();

            Console.WriteLine("Системи автоматизації обліку:");
            Console.WriteLine("1 - Система автоматизації обліку 1");
            Console.WriteLine("2 - Система автоматизації обліку 2");
            Console.WriteLine("3 - Система автоматизації обліку 3");

            Console.WriteLine();

            Console.WriteLine("Системи управління логістикою:");
            Console.WriteLine("4 - Система управління логістикою 1");
            Console.WriteLine("5 - Система управління логістикою 2");
            Console.WriteLine("6 - Система управління логістикою 3");

            Console.WriteLine();

            Console.Write("Введіть номери програмних продуктів, які ви бажаєте придбати, розділяючи їх комами: ");
            string input = Console.ReadLine();

            Console.WriteLine();

            try
            {
                string[] numbers = input.Split(',');
                SoftwareProduct[] products = new SoftwareProduct[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    int number = int.Parse(numbers[i]);
                    products[i] = (SoftwareProduct)(number - 1);
                }

                string author = "Бікмаєв А.А.";

                Console.WriteLine("Програмні продукти для автоматизації обліку:");

                bool anyAccountingSystemSelected = false;

                foreach (SoftwareProduct product in products)
                {
                    if (product == SoftwareProduct.Accounting_System_1 || product == SoftwareProduct.Accounting_System_2 || product == SoftwareProduct.Accounting_System_3)
                    {
                        Console.WriteLine(product.ToString());
                        anyAccountingSystemSelected = true;
                    }
                }

                if (!anyAccountingSystemSelected)
                {
                    Console.WriteLine("Не вибрано жодного продукту для автоматизації обліку.");
                }


                Console.WriteLine();

                Console.WriteLine("Програмні продукти для управління логістикою:");

                bool anyLogisticsSystemSelected = false;

                foreach (SoftwareProduct product in products)
                {
                    if (product == SoftwareProduct.Logistics_System_1 || product == SoftwareProduct.Logistics_System_2 || product == SoftwareProduct.Logistics_System_3)
                    {
                        Console.WriteLine(product.ToString());
                        anyLogisticsSystemSelected = true;
                    }
                }

                if (!anyLogisticsSystemSelected)
                {
                    Console.WriteLine("Не вибрано жодного продукту для управління логістикою.");
                }

                Console.WriteLine();
                Console.WriteLine($"Автор програми: {author}");
            }

            catch (FormatException)
            {
                Console.WriteLine("Ви ввели неправильний формат номеру продукту.");
            }
        }
    }
}
