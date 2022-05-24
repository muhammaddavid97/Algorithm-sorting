using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Recursive
    {
        // recursive => proses memanggil dirinya sendiri secara langsung atau tidak langsung.
        // fungsi yang mengandung rekursi disebut fungsi rekursif.

        /*
         * Base case in Recursion : 

            Dalam program rekursif, solusi untuk kasus dasar disediakan dan solusi dari masalah 
            yang lebih besar dinyatakan dalam bentuk masalah yang lebih kecil. 

            jika base case tidak disertakan maka akan menimbulkan stack overflow atau infinite loop.

         */

        public static void recursionTesting(int test)
        {
            if (test < 1 || test == 0)
            {
                // recursif berhenti
                return;
            }
            else
            {
                Console.WriteLine(test + " ");

                // memanggil rekursif
                recursionTesting(test - 1);
                
/*                Console.WriteLine(test + " ");
*/
                return;
            }
        }

        public static void printNumbers(int nums)
        {
            // base case
            if (nums == 0)
            {
                return;
            }

            Console.WriteLine(nums + " ");
            printNumbers(nums - 1);

        }

        public static void printOddNumbers(int nums)
        {
            //base case
            if (nums == 0)
            {
                return;
            }

            printOddNumbers(nums - 1);

            if (nums % 2 == 0)
            {
                Console.WriteLine(nums + " ");
            }
        }

        public static int fibonacci(int nums)
        {
            // base case
            if (nums == 0)
            {
                return 0;
            }

            // proses fibonacci 
            if (nums == 1 || nums == 2)
            {
                return 1;
            }
            else
            {
                return (fibonacci(nums - 1) + fibonacci(nums - 2));
            }
        }

        public static int factorial(int bil)
        {
            // mencari bilangan factorial menggunakan recursive

            if (bil == 0 || bil == 1)
            {
                return 1;
            }
            else
            {
                return bil * factorial(bil - 1);
            }
        }
    }
}
