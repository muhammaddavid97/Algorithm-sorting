using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Basic
    {
        /*
            Bubble Sort => Algoritma yang bekerja secara sederhana dimana proses pengurutan
            dimulai dari elemen sebelahnya jika urutannya salah maka tukarkan elemen tersebut
            Algoritma ini tidak cocok untuk proses pengurutan data dalam jumlah banyak karena
            space complexcity dan time complexcity yang cukup tinggi.

            misc Arr = [5,1,4,2,8]

            First Pass : 
                - Bubble sort dimulai dari dua elemen pertama kemudian bandingkan untuk di periksa
                  mana yang lebih besar
                
                - (5,1,4,2,8) -> (1,5,4,2,8), disini 5 > 1 swapp value
                - (1,5,4,2,8) -> (1,4,5,2,8), disini 5 > 4 swapp value
                - (1,4,5,2,8) -> (1,4,2,5,8), disini 5 > 2 swapp value
                - (1,4,2,5,8) -> (1,4,2,5,8), disini 8 > 5 no swapp value

            SEcond Pass : 
                -  perulangan kedua akan dilakukan seperti proses pada perulangan pertama

                - (1,4,2,5,8) -> (1,4,2,5,8), disini 1 < 4 no swapp value
                - (1,4,2,5,8) -> (1,2,4,5,8), disini 4 > 2 swapp value
                - (1,2,4,5,8) -> (1,2,4,5,8), disini 4 < 5 no swapp value
                - (1,2,4,5,8) -> (1,2,,4,5,8) disini 5 < 8 no swapp value

           Third Pass : 
                - perulangan ketiga akan dilakukan seperti proses pada perulangan sebelumnya

                - (1,2,4,5,8) -> (1,2,4,5,8) disini 1 < 2 no swapp value
                - (1,2,4,5,8) -> (1,2,4,5,8) disini 2 < 4 no swapp value 
                - (1,2,4,5,8) -> (1,2,4,5,8) disini 4 < 5 no swapp value
                - (1,2,4,5,8) -> (1,2,4,5,8) disini 5 < 8 no swapp value
           
         */

        public static void main()
        {
            int[] arr = new int[] { 5, 1, 4, 2, 8};
            int n = arr.Length;

            int[] data = Basic.bubbleSort(arr, n);

            foreach(int item in data)
            {
                Console.Write(item + " ");
            }
        }

        public static int[] bubbleSort(int[] arr, int n)
        {

            // loop pertama berfungsi untuk mendapatkan elemen array 
            for (int i = 0; i < n - 1; i++)
            {
                // loop kedua berfungsi untuk membandingkan masing-masing elemen
               for (int j = i + 1; j < n; j++)
                {
                   if (arr[j] < arr[i])
                    {
                        int swapp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swapp;
                    }
                }
            }

            return arr;
        }
    }
}
