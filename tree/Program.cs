using System;

namespace tree
{


    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("your name is: ");
            string name = Console.ReadLine();
            Console.WriteLine("subjects:  ");
            string subject = Console.ReadLine();
            Console.WriteLine("grades:  ");
            string grade = Console.ReadLine();
            Tree grades = new Tree();
            grades.add(name, subject, grade);

        }
    }
}
