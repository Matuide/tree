using System;

namespace tree
{


    class Program
    {

        static void Main(string[] args)
        {
            Tree grades = new Tree();
            bool Continue = true;
            do
            {
                Console.WriteLine("your initials are: ");
                string name = Console.ReadLine();
                Console.WriteLine("subject:  ");
                string subject = Console.ReadLine();
                Console.WriteLine("grades:  ");
                string grade = Console.ReadLine();
                
                grades.add(name, subject, grade);
                Console.WriteLine("add more? ");
                string a = Console.ReadLine();
                if (a.ToLower() == "yes") Continue = true;
                else Continue = false;
            } while (Continue);
           

            grades.printInOrder();

        }
    }
}
