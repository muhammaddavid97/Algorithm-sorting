using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Optimizitation
    {

        /*
            Optimalisasi didalam bubble sort dapat dilakukan ketika didalam loop dalam 
            tidak ada lagi proses pertukaran dua elemen.
         */
        public static void main()
        {
            int[] nums = new int[] { 3, 1, 5, 4, 2 };
            int n = nums.Length;

            int[] list = Optimizitation.BubbleSortOptimization(nums, n);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] BubbleSortOptimization(int[] arr, int n)
        {

            bool swapp;
            for (int i = 0; i < n - 1; i++)
            {
                swapp = false;

                for (int j = i + 1; j < n; j++)
                {
                    // proses swapp value
                    if (arr[j] < arr[i])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                        swapp = true;
                    }
                }

                // jika tidak ada dua elemen yang ditukar didalam inner loop
                // maka hentikan looping 

                if (swapp == false)
                {
                    break;
                }
            }

            return arr;
        }
    }
}
