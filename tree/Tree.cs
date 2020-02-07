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
        public void Print()
        {

            
        }
        public void add(string name,string subjects,string grades)
        {
            Node head = new Node();
            head.left = null;
            head.right = null;
            head.name = name;
            head.subject = subjects;
            head.grades = grades;
            char a = name[0];
            char c = name[1];
            if (root ==null)
            {
                root = head;
            }
            else
            {
                do
                {
                    char b = head.name[0];
                    char d = head.name[1];

                    bool LeftOrright = LeftOrRight(a, b,c,d);

                    if (LeftOrright) 
                    {
                        head = head.left;
                    }
                    else
                    {
                        head = head.right;
                    }
                    
                    
                } while(head != null);
            }
              
            Console.WriteLine("Adding " + name + "'s grade");
        }
        public bool LeftOrRight(char a , char b , char c ,char d)
        {
            bool LeftRight = false ;
            if (Convert.ToInt32(a) < Convert.ToInt32(b))
            {
                LeftRight = true;
            }else if(Convert.ToInt32(a) > Convert.ToInt32(b))
            {
                LeftRight = false;
            }else if (Convert.ToInt32(a) == Convert.ToInt32(b))
            {
                if (Convert.ToInt32(c) < Convert.ToInt32(d))
                {
                    LeftRight = true;
                }
                else if (Convert.ToInt32(c) > Convert.ToInt32(d))
                {
                    LeftRight = false;
                }
            }
            return LeftRight;
        }
        public void delete()
        {

        }
        public void replace()
        {

        }
        public int count()
        {
            int count = 0;
            return count;
        }

    }

}
