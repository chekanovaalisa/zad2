using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете нужную функцию \n 1. Наибольшее из двух числе");
            //int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберете нужную функцию \n 2. Умножение чисел");
            //int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберете нужную функцию \n 3. Сумма чисел");
            // int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберете нужную функцию \n 4. Разность чисел");
            //int d = int.Parse(Console.ReadLine());

            string vbr = Console.ReadLine();

            switch (vbr)
            {
                case "1":
                    Console.WriteLine("Введите число a");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число b");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(naibol(a, b));
                    break;
                case "2":
                    Console.WriteLine("Введите число x");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число z");
                    int z = int.Parse(Console.ReadLine());
                    Console.WriteLine(ymnojenie(x, z));
                    break;
                case "+":
                    Console.WriteLine();
                    break;
                case "-":
                    Console.WriteLine();
                    break;
            }
        }
        static int naibol(int x, int z)
        {
            if (x > z)
            {
                Console.Write("Наибольшее число a: ");
                return x;
            }
            else
            {
                Console.Write("Наибольшее число b: ");
                return z;
            }

        }

        static int ymnojenie(int x, int z)
        {
            Console.Write("Результат: ");
            return x * z;
        }



    }
}

