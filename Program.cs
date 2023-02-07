using System;
using TestTasks1.TasksMethods;

namespace TestTasks1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание (1,2,3)");
            int task = Convert.ToInt32(Console.ReadLine());

            if (task == 1)
            {
                //Задание 1
                Console.WriteLine("Введите целое число");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сумма простых чисел не превышающих заданного числа = " + Task1.GetSumOfPrimeNumbers(number));
                Console.ReadLine();
            }
            else if (task == 2)
            {
                //Задание 2
                Console.WriteLine("Введите цену");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите оплату");
                int pay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сдача состоит из " + Task2.CountChange(price, pay));
                Console.ReadLine();
            }
            else if (task == 3)
            {
                //Задание 3
                Console.WriteLine("Сколько циклопов");
                int cyclopsCount = Convert.ToInt32(Console.ReadLine());
                int[] eyesightValues = new int[cyclopsCount];
                Random rand = new Random();
                for (int i = 0; i < eyesightValues.Length; i++)
                { eyesightValues[i] = rand.Next(-100, 100); }
                int pairsNeededCount = Task3.CountNeededLensPairs(eyesightValues);
                Console.WriteLine($"Для {cyclopsCount} циклопов нужно купить минимум {pairsNeededCount} пар линз");
                Console.ReadLine();
            }
            else 
            { Console.WriteLine("Такого задания нет");
                    Console.ReadLine();}
        }
    }
}
