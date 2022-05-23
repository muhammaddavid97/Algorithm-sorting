using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort.Latihan
{
    public class Lat_1
    {
        public static void main()
        {
            foreach(var item in Lat_1.sortingData())
            {
               Console.WriteLine(item);
            }
        }

        public static List<Person> sortingData()
        {
            List<Person> students = new List<Person>() {
                new Student("david", 21, "cirebon"),
                new Student("eko", 12, "makassar"),
                new Student("ida", 11, "cirebon")
            };

            for (int i = 0; i < students.Count - 1; i++)
            {

                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[j].Age < students[i].Age)
                    {
                        int swapp = students[i].Age;
                        students[i].Age = students[j].Age;
                        students[j].Age = swapp;
                    }
                }
            }

            return students;
        }
    }

    public class Person
    {
        private string name; 
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() : this("Muhammad david", 22)
        {

        }
    }

    public class Student : Person
    {
        private string address;
        public Student(string name, int age, string address) : base(name, age)
        {
            this.address = address;
        }

        public string Address { get => address; set => address = value; }
    }
}
