using System;

namespace ЛБ7_ЗД2
{
        class Program
        {
            static long Factorial(long x) // функция факториала, нужная для упрощения расчетов
            {
                long Fac = 1;
                for (long i = 1; i <= x; i++)
                {
                    Fac *= i;
                }
                x = Fac;
                return x;
            }

            static double Function1(double x) // первоначальная заданная функция
            {
                double Y;
                double p=3.1415926;
                Y = Math.Exp(Math.Cos(p/4)*x) * Math.Cos(Math.Sin(p/4)*x);
                return Y;
            }

            static double Goes(double x = 0.1) // рекурсивный метод задания функции, разложенной в числовой ряд
            {
            double p = 3.1415926;
            if (x < 1)
                {
                    Goes(x + 0.09); // вызов методом самого себя для подсчетов, аналогичных с циклом
                    double S;
                    S = 1;
                    for (int n = 1; n < 26; n++)
                    {
                        S += (Math.Cos(n * p) / Factorial(n))*Math.Pow(x,n);
                    }
                    Console.WriteLine("Шаг, равный : " + x);
                    Console.WriteLine("Полученное значение данного шага " + S);
                    Console.WriteLine();
                }
                return x;
            }


            static void Main(string[] args)
            {

                double x = 0.1;//определение базового значения с которого будут вестись расчеты

                Console.WriteLine("\t\t Результаты, полученные при вычислении функции в диапазоне вариантов");
                Console.WriteLine("\t\t\t от 0.1 до 1 с шагом в 0.09");
                Goes(x);//вызов рекурсивного метода задания функции для подсчета данных;
                do
                {
                    Console.WriteLine("\t Введите X равное любому шагу от 0.1 до 1 в основную функцию для проверки");
                    Console.WriteLine("\t\tправильности с методом разложения этой функции в числовой ряд");

                    x = double.Parse(Console.ReadLine());
                    double Y = Function1(x);//вызов метода подсчета функции

                    Console.WriteLine();
                    Console.WriteLine(Y + "\t Вывод функции");
                    Console.WriteLine();
                } while (true);
            }
        }
    }

