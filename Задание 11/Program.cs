using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Решим уравнение kx + b = 0");
                try
                {
                    Console.Write("Введите значение коэффициента k = ");
                    double k = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите значение коэффициента b = ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    if (k != 0)
                    {
                        Equation result = new Equation(k, b);
                        double x = result.Root();
                        Console.WriteLine("Корень уравнения x = {0}", x);
                    }
                    else if (k == 0 && b == 0)
                    {
                        Console.WriteLine("Корень уравнения x = любое число");
                    }
                    else if (k == 0 && b != 0)
                    {
                        Console.WriteLine("Нет решения");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
                    Console.ReadKey();
                }
            }
        }
        struct Equation
        {
            double k;
            double b;

            public Equation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            public double Root()
            {
                double x = -b / k;
                return x;
            }
        }
    }