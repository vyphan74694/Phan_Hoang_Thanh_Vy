using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Hoang_Thanh_Vy
{
    internal class Session02
    {
        
        
            public static void Main2()
            {
                //Question_01();
                //Question_02();
                Question_04();
                Console.ReadKey();
            }
            public static void Question_01()
            {
                Console.Write("Nhap so a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap so b: ");
                int b = int.Parse(Console.ReadLine());
                int c = a + b;
                Console.WriteLine($"{a} + {b} = {c}");

            }
            public static void Question_02()
            {
                Console.Write("Nhap so a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap so b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Truoc khi hoan doi: a = {a}, b = {b}");
                int c = a;
                a = b;
                b = c;
                Console.WriteLine($"Sau khi hoan doi: a = {a}, b = {b}");
            }
            public static void Question_03()
            {
                Console.Write("Nhap so a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Nhap so b: ");
                float b = float.Parse(Console.ReadLine());
                float c = a * b;
                Console.WriteLine($" {a} * {b} = {c}");
            }
            public static void Question_04()
            {
                Console.Write("Nhap so feet ");
                float feet = float.Parse(Console.ReadLine());
                double m = feet * 0.3048;
                Console.WriteLine($"{feet} ft = {m} m ");
            }
            public static void Question_05_01()
           // ConvertCelsiusToFahrenheit()
         {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} Celsius = {fahrenheit} Fahrenheit");
         }
        public static void Question_05_02()
        {
            //ConvertFahrenheitToCelsius
    
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} Fahrenheit = {celsius} Celsius");
        }

    public static void Question_06()
    {
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        Console.WriteLine($"Size of char: {sizeof(char)} bytes");
        Console.WriteLine($"Size of float: {sizeof(float)} bytes");
        Console.WriteLine($"Size of long: {sizeof(long)} bytes");
        Console.WriteLine($"Size of short: {sizeof(short)} bytes");
        Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
    }
    public static void Question_07()
    {
         Console.Write("Enter a character: ");
        char character = Console.ReadKey().KeyChar;  // Read a single character
        Console.WriteLine($"\nThe ASCII value of '{character}' is {(int)character}");
    }
     public static void Question_08()
     {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of the circle with radius {radius} is {area}");
     }
    public static void Question_09()
    {
        Console.Write("Enter the side length of the square: ");
        double side = double.Parse(Console.ReadLine());
        double area = side * side;
        Console.WriteLine($"Area of the square with side {side} is {area}");
    }
    public static void Question_10()
    {
    Console.Write("Enter the number of days: ");
        int days = int.Parse(Console.ReadLine());

        int years = days / 365;
        int remainingDays = days % 365;
        int weeks = remainingDays / 7;
        remainingDays = remainingDays % 7;

        Console.WriteLine($"{days} days is approximately {years} years, {weeks}");
}
    }

  
}
