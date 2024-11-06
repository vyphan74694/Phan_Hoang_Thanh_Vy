using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Hoang_Thanh_Vy
{
    internal class Session05
    {
        internal class Session_05()
        {
            /*public static void swap(ref int a, ref int b)
            {
                int tempt = a;
                a = b; b = tempt;
            }
            public static void Main()
            {
                int a = 6, b = 7;
                Console.WriteLine($"Before call a={a}, b={b}");
                swap(ref a, ref b);
                Console.WriteLine($"After call a={a}, b={b}");
                Console.ReadKey();
            }*/

            static int maxofthreenumbers(int a, int b, int c)
            {
                return Math.Max(Math.Max(a, b), c);
            }
            static bool isPrime(int Number)
            {
                if (Number < 2) return false;
                for (int i = 2; i < Number; i++)
                    if (Number % i == 0)
                        return false;
                return true;

            }
            static void printPrimeNumberUnderN(int n)
            {
                for (int i = 2; i <= n; i++) ;
                if (isPrime(i))
                    Console.WriteLine(i);
            }
            static void printFirstprime(int n)
            {
                int so = 2;
                int dem = 0;
                while (dem < n)
                {
                    if (isPrime(so))
                    {
                        Console.Write(so + ",");
                        dem++;
                    }
                    so++;
                }
            }




            /*class game_taixiu()
                {
                    static int rollDice()
                    {
                        Random rnd=new Random();
                        int die_1 = rnd.Next(6)+1;
                        int die_2 = rnd.Next(6) + 1;
                        int die_3 = rnd.Next(6) + 1;
                        int sum_of_dice= die_1+ die_2+die_3;
                        return sum_of_dice;

                    }
                    public static void PlayOneround()
                    {
                        int com_dice = rollDice();
                        Console.WriteLine( "ban doan tai hay xiu <t/x>");
                        string user_guessing = Console.ReadLine();
                        if (user_guessing.ToUpper().Equals("T")) 
                        {
                            if (com_dice >= 10)
                                Console.WriteLine("ban thang");
                            else
                                Console.WriteLine("ban thua");
                        }
                        else if ( user_guessing.ToUpper().Equals("X")) 
                        {
                            if (com_dice < 10)
                                Console.WriteLine("ban thang");
                            else
                                Console.WriteLine( "ban thua");
                        }
                        else
                        {
                            Console.WriteLine( "vui long chon dung");
                        }

                    }
                    public static void game_engine()
                    {
                        do
                        {
                            PlayOneround();
                            Console.WriteLine("ban choi nua khong? <c/k>");
                            string choice = Console.ReadLine();
                            if (choice.ToUpper().Equals("K"))
                                break;
                        } while (true);
                        Console.WriteLine("mai choi nua nhe!");
                    }*/
            public static void Main()
            {
                //game_engine();
                //int m = maxofthreenumbers(7, 8, 9);
                //Console.WriteLine(m);
                isPrime(1000);
                Console.ReadKey();
            }

        }
    }
}
