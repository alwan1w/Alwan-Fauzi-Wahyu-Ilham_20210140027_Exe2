﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe2
{
    class Program
    {
        private int[] arr = new int[5];
        private int cmp_count = 0; 
        private int mov_count = 0; 
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n==================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n==================");

            
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
            
            void swap(int x, int y)
            {
                int temp;

                temp = arr[x];
                arr[x] = arr[y];
                arr[y] = temp;
            }
            public void alwan(int low, int high)
            {
                int pivot, i, al;
                if (low > high)
                    return;

                i = low + 1;
                al = high;

                pivot = arr[low];

                while (i <= al)
                {
                  
                    while ((arr[1] <= pivot) && (i <= high))
                    {
                        i++;
                        cmp_count++;
                    }
                    cmp_count++;

                    while ((arr[al] > pivot) && (al >= low))
                    {
                        al--;
                        cmp_count++;
                    }
                    cmp_count++;
                }
            }
        }
    }
}
