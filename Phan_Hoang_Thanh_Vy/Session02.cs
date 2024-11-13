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
            public static void Question_05()
        { }


    
    }
}
