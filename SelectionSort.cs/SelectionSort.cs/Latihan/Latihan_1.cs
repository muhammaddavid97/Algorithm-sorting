using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort.cs.Latihan
{
    public class Latihan_1
    {
        public static void main()
        {
            List<Students> lists = new List<Students>()
            {
                new Dosen(new List<int>(){21,4,55,1,2,11}),
                new Dosen(new List<int>(){1,14,55,1,2,3}),
                new Dosen(new List<int>(){21,4,15,1,2,10})
            };

            for (int i = 0; i < lists.Count; i++)
            {
                Console.WriteLine(lists[i].sortingData());
            }
        }
    }

    public class Students
    {
        public List<int> dataNums;

        public Students(List<int> dataNums)
        {
            this.dataNums = dataNums;
        }

        // method virtual
        public virtual int[] sortingData() {
            int n = dataNums.Count;

            for (int i = 0; i < n - 1; i++) {

                int min_idx = i; // elemen minimum

                for (int j = 1; j < n; j++) {
                    
                    if (dataNums[j] < dataNums[min_idx]) {
                        min_idx = j;    
                    }
                }

                int swapp = dataNums[i];
                dataNums[i] = dataNums[min_idx];
                dataNums[min_idx] = swapp;
            }

            return this.dataNums.ToArray();
        }
    }

    public class Dosen : Students
    {
       public Dosen(List<int> nums) : base(nums)
        {
        }

        public override int[] sortingData() { 
           return base.sortingData();
        }
    }
}
