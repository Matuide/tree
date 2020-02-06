using System;
using System.Collections.Generic;
using System.Text;

namespace tree
{
    class Tree
    { 
        private Node root;
        public Tree()
        {
            root = null;
        }
        public void add(string name,string subjects,string grades)
        {
            Node head = new Node();
            head.left = null;
            head.right = null;
            head.name = name;
            head.subject = subjects;
            head.grades = grades;
            if (root ==null)
            {
                root = head;
            }
            else
            {

            }
              
            Console.WriteLine("Adding " + name + "'s grade");
        }
        public void delete()
        {

        }
        public void replace()
        {

        }

    }

}
