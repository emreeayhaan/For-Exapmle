﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı asal sayı girene kadar girdiği tüm sayıları toplayan program
            int toplam = 0;
            while (true)
            {
                int syc = 0;
                int gs1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= gs1; i++)
                {
                    if (gs1 % i == 0)
                        syc++;
                }
                if (syc < 3)
                    break;
                else
                    toplam = toplam + gs1;
            }
            Console.WriteLine(toplam);
        }
    }
}
