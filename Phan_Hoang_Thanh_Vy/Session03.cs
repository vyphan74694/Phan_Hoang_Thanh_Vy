﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Hoang_Thanh_Vy
{
    internal class Session03
    {
       
            private static void Main3(string[] args)
            {
                Question_04();
                Console.ReadKey();
            }
            public static void Question_01()
            {
                Console.Write("Nhap do C:");
                double c = double.Parse(Console.ReadLine());
                double f = c * 18 / 10 + 32;
                double k = c + 273;
                Console.Write($"f= {f}, k= {k}");
            }
            public static void Question_02()
            {
                Console.Write("Nhap ban kinh r:");
                float r = float.Parse(Console.ReadLine());
                double s = Math.Pow(r, 2) * 4 * Math.PI;
                double v = Math.Pow(r, 3) * Math.PI * 4 / 3;
                Console.Write($"s={s}, v= {v}");
            }
            public static void Question_03()
            {
                Console.Write("Nhap so thu nhat: ");
                 double num1 = double.Parse(Console.ReadLine());
                Console.Write("Nhap so thu hai");
                 double num2 = double.Parse(Console.ReadLine());
                 double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;
        double remainder = num1 % num2;
       

        // Output the results
        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {difference}");
        Console.WriteLine($"{num1} x {num2} = {product}");
        Console.WriteLine($"{num1} / {num2} = {quotient}");
        Console.WriteLine($"{num1} mod {num2} = {remainder}");
    }


            

            public static void Question_04()
            {
                Console.Write("Nhap y:");
                double y = double.Parse(Console.ReadLine());
                double x = Math.Pow(y, 2) + 2 * y + 1;
                Console.Write($"x ={x}");
            }
            
        
    }
}
