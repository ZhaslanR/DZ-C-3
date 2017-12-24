using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            Console.ReadLine();
        }

        private static void task5()
        {
            string numbers;
            char[] number;
            Console.WriteLine("Введите целое число");
            numbers = Console.ReadLine();
            Console.WriteLine("Ваше число : " + numbers);
            number = numbers.ToCharArray();
            Array.Reverse(number);
            numbers = new string(number);
            Console.WriteLine("В перевернутам виде: " + numbers);
        }

        private static void task4()
        {
            int a, b;
            Console.WriteLine("Ведите числа А и В(A<B)");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int i = a; i < b + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        private static void task3()
        {
            string word;
            Console.WriteLine("Ведите желаемое слово");
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 65 || word[i] <= 90)
                {
                    Console.Write((char)(word[i] + 32));
                }
                else if (word[i] >= 97 || word[i] <= 122)
                {
                    Console.Write((char)(word[i] - 32));
                }
            }
        }

        private static void task2()
        {
            int number;
            int[] numbers = new int[6];

            Console.WriteLine("Вдите 6 значное число");
            number = int.Parse(Console.ReadLine());
            numbers[0] = number / 100000;
            numbers[1] = number / 10000 % 10;
            numbers[2] = number / 1000 % 10;
            numbers[3] = number / 100 % 10;
            numbers[4] = number / 10 % 10;
            numbers[5] = number % 10;

            if (numbers[0] == numbers[5] && numbers[1] == numbers[4] && numbers[2] == numbers[3])
            {
                Console.WriteLine("У вас счастливое число");
            }
            else
            {
                Console.WriteLine("У вас не счастливое число");
            }

        }

        private static void task1()
        {
            int count = 0;
            string word;
            Console.WriteLine("Напишите предложение с проблема и точками : ");
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    count++;
                }

                Console.Write(word[i]);

                if (word[i] == '.')
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Вы ввели " + count + " пробела");
        }
    }
}


