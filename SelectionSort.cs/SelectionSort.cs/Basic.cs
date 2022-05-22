using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort.cs
{
    public class Basic
    {
        /*
         * Selection sort => Algoritma sorting yang bekerja dengan mencari elemen terkecil didalam array
         * dari bagian yang tidak terurut kemudian elemen tersebut ditukar dan pindahkan di posisi awal.
         * 
         * misc : Arr [64, 25, 12, 22, 11]
         * 
         * first pass : lakukan perulangan dari indeks ke 0 sampai 4
         * maka array saat ini menjadi => Arr [11,25,12,22,64]
         * 
         * second pass : lakukan perulangan dari indeks ke 1 sampai 4
         * maka array saat ini menjadi => Arr [11,12,25,22,64]
         * 
         * third pass : lakukan perulangan dari indeks ke 2 sampai 4
         * maka array saat ini menjadi => Arr [11,12,22,25,64]
         * 
         * fourth pass : lakukan perulangan dari indeks ke 3 sampai 4
         * maka array saat ini menjadi => Arr [11,12,22,25,64]
         * 
         * Algorithm : 
         *  1. lakukan iterasi untuk semua elemen didalam array
         *  2. inisialisasi nilai minimum (min_ix) ke lokasi 0
         *  3. saat looping jika ada elemen yang lebih kecil dari min_idx tukar nilainya
         *  4. Kemudian, tambahkan min_idx untuk menunjuk ke elemen berikutnya
         *  5. Ulangi sampai array diurutkan
         */

        public static void selectionSortTest()
        {
            int[] nums = new int[5];
            nums[0] = 34;
            nums[1] = 12;
            nums[2] = 21;
            nums[3] = 13;
            nums[4] = 2;

            Basic basic = new Basic();
            int[] data = basic.selectionSorting(nums);

            foreach(int i in data)
            {
                Console.WriteLine(i);
            }
        }

        public int[] selectionSorting(int[] arr)
        {
            // perulangan pertama berfungsi untuk mengambil elemen didalam array
            // perulangan tidak sampai elemen terakhir sebab elemen terakhir sudah
            // dipastikan elemen terbesar.

            for (int i = 0; i < arr.Length - 1; i++)
            {
                // min_idx => menampung elemen terkecil dari array yang tidak terurut
                int min_idx = i;

                // perulangan kedua berfungsi untuk membandingkan elemen didalam array
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //  membandingkan dua buah elemen 
                    // jika elemen saat ini lebih besar dari elemen selanjutnya maka tukarkan posisi elemen.
                    // sebaliknya maka posisi elemen tetap.
                    if (arr[min_idx] > arr[j])
                    {
                        min_idx = j; // elemen minimum
                    }
                }

                // tukarkan elemen minimum dengan elemen pertama 
                int swapp = arr[i];
                arr[i] = arr[min_idx];
                arr[min_idx] = swapp;
            }

            return arr;
        }
    }
}
