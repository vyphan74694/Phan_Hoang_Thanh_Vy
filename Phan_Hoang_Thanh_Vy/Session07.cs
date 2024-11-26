using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Hoang_Thanh_Vy
{
    internal class Session07
    {
       
        static void NhapMangNgauNhien(int[,] a, int rows, int columns) 
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
                Console.WriteLine( );
            }    
        }
        static void InMang(int[,] a)
        {
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }    
        }
        static void InGiaTri(int[,] a, int value)
        {
            for(int i = 0;i < a.GetLength(0);i++)
            {
                for (int j =0;j < a.GetLength(1);j++)
                {
                    if (a[i,j] == value)
                    {
                        Console.WriteLine($"(value) xuat hien tai dong { i} cot { j}\n");
                    }    
                }    
            }    
        }
        static void TimGiaTriLonNhat(int[,] a)
        {
            int max = a[0,0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
        }
        static void TimGiaTriNhoNhatCuaDong(int[,] a)
        {
            for (int i = 0; i<a.GetLength(0); i++)
            {
                int min = a[i,0];
                for (int j = 0; j < a.GetLength(1);j++)
                {
                    if (a[i,j] < min)
                    {     
                }   
            }   
        }
        static void Main(string[]args)
        {
            int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int columns = int.Parse(Console.ReadLine());
            a = new int[rows, columns];
            NhapMangNgauNhien(a, rows, columns);
            InMang(a);
             Console.Write("Nhap so can tim: " );
            int val = int.Parse(Console.ReadLine());
            InGiaTri(a, val);
        }

    }
}
}
