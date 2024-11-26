using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Hoang_Thanh_Vy
{
    internal class Session04
    {
        
            public static void Main4()
            {
                Session_04_Exercise_game();
            }
            public static void Question_01()
             {
                 // Taking two numbers as input
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        // Taking the operation choice
        Console.Write("Enter an operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();  // To move to the next line

        double result = 0;

        // Perform the chosen operation
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation!");
                return;
        }

        // Display the result
        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
     public static void Question_02()
     {
         Console.WriteLine
        ("Displaying values of the function x = y² + 2y + 1 for y ranging from -5 to 5:");
        
        for (int y = -5; y <= 5; y++)
        {
            int x = (y * y) + (2 * y) + 1;  // x = y² + 2y + 1
            Console.WriteLine($"For y = {y}, x = {x}");
        }
      }
      public static void Question_03()
    {
                // Taking input for distance in kilometers and time
        Console.Write("Enter the distance in kilometers: ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter the time in hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Enter the time in minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the time in seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        // Convert the time to total hours
        double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);

        // Calculate speed in kilometers per hour (km/h)
        double speedKmH = distance / totalHours;

        // Convert kilometers to miles (1 km = 0.621371 miles)
        double speedMilesH = speedKmH * 0.621371;

        // Display the results
        Console.WriteLine($"Speed: {speedKmH} km/h or {speedMilesH} miles/h");
    }
    public static void Question_04()
    {
        // Taking radius as input
        Console.Write("Enter the radius of the sphere: ");
        double radius = double.Parse(Console.ReadLine());

        // Calculate surface area and volume
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);

        // Display the results
        Console.WriteLine($"Surface Area of the sphere: {surfaceArea} square units");
        Console.WriteLine($"Volume of the sphere: {volume} cubic units");
    }
    public static void Question_05()
    {
        {
        // Taking character input
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();  // To move to the next line

        // Check if the character is a vowel, digit, or symbol
        if ("aeiouAEIOU".IndexOf(ch) >= 0)
        {
            Console.WriteLine($"{ch} is a vowel.");
        }
        else if (char.IsDigit(ch))
        {
            Console.WriteLine($"{ch} is a digit.");
        }
        else
        {
            Console.WriteLine($"{ch} is a symbol or other character.");
        }
        }
    }

    
      


            public static void Session_04_Exercise_game()
            {
                do
                {
                    Random rnd = new Random();
                    int comp_num = rnd.Next(0, 10) + 1;
                    int count = 0;
                    bool iscontinue = true;
                    do
                    {
                        count++;
                        Console.Write(" Ban doan so may? <1..10>");
                        int user_num = int.Parse(Console.ReadLine());
                        if (user_num == comp_num)
                        {
                            Console.WriteLine($"Ban doan trung sau {count} lan");
                            iscontinue = false;
                        }
                        else
                        {
                            if (user_num > comp_num)
                                Console.WriteLine("So ban doan lon hon so may nghi");
                            else
                                Console.WriteLine(" So ban doan nho hon so may nghi");
                        }
                    } while (iscontinue);
                    Console.WriteLine("Ban doan dung roi");

                    Console.Write("Choi nua khong? <c/k>: ");
                    string tl = Console.ReadLine();
                    if (tl.ToUpper().Equals("K"))
                    {
                        Console.WriteLine("Thang ma khong cho go. Lan sau khong choi nua!");
                        return;
                    }
                } while (true);

                static int Main()
                {
                    Session_04_Exercise_game();
                    return 1;
                }
            }


            public static void Session_04_Exercise_01()
            {
                Console.Write("Nhap mot so a:");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine($"a la so chan");
                }
                else Console.Write($"a la so le");

            }
        
    }

}
