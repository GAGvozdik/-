using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _05_func
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите координаты центра:");
            float x_center = float.Parse(Console.ReadLine());
            float y_center = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус:");
            float R = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки:");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            double center_circle(float x_center,float y_center,float x, float y,float R)
            {
                if (Math.Pow((x - x_center), 2) + Math.Pow((y - y_center), 2) <= Math.Pow(R, 2))
                {
                    Console.WriteLine("Точка лежит внутри круга");
                }
                else
                {
                    Console.WriteLine("Точка лежит вне круга");

                }
                return x;
            }


                center_circle(x_center, y_center, x, y, R);

            }
    }
}
