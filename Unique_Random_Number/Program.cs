﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int currentRandom;
            IEnumerable<int> check;
            Random rd = new Random();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("-----");
                do
                {
                    currentRandom = rd.Next(1, 7);
                    check = arr.Where(item => item == currentRandom);
                    Console.WriteLine("Random Number from Thread {0}: {1}", i, currentRandom);
                } while (check.Count() != 0);

                arr[i] = currentRandom;
                Console.WriteLine();
            }

            Console.WriteLine("\n6 Uniuque Random Number:\n-----");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
