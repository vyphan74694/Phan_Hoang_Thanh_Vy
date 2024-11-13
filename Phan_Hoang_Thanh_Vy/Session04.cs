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
