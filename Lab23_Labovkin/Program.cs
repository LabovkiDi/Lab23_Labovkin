using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);

            Console.ReadKey();
        }
        //метод вычмсления факториала числа
        static int Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                //задержка
                Thread.Sleep(150);
            }
            return (s);
        }
        // определение асинхронного метода
        static async void FactorialAsync(int n)
        {
            //присваиваем результат асинхронной оаперации в переменную
            int x = await Task.Run(() => Factorial(n));
            Console.WriteLine($"Факториал равен {x}");
        }
    }
}
