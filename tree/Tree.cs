using System;
using System.Collections.Generic;
using System.Linq;
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
       public void printInOrder()
        {
            InOrder(root);
        } 


        public void InOrder(Node n)
        {
            if( n == null ) return;
            if (n.left!=null) InOrder(n.left);
            Console.WriteLine(n.name + n.subject + n.grades);
           if (n.right != null) InOrder(n.right);
           

        }


        public void add(string name, string subjects, string grades)
        {
            Node head = new Node();
            Node nextnodetovisit = root;
            Node previousnodevisited = root;
            bool isLeft = false;
            head.left = null;
            head.right = null;
            head.name = name +" : ";
            head.subject = subjects+" : ";
            head.grades = grades;

            if (root == null)
            {
                root = head;
            }
            else
            {
                while (nextnodetovisit != null)
                {
                    if (name.CompareTo(nextnodetovisit.name) < 0)
                    {
                        previousnodevisited = nextnodetovisit;
                        nextnodetovisit = nextnodetovisit.left;
                        isLeft = true;
                    }
                    else if (name.CompareTo(nextnodetovisit.name) > 0)
                    {
                        previousnodevisited = nextnodetovisit;
                        nextnodetovisit = nextnodetovisit.right;
                        isLeft = false;
                    }
                    else
                    {
                        return;
                    }
                }
                if (isLeft == true)
                {
                    previousnodevisited.left = head;
                }
                else
                {
                    previousnodevisited.right = head;
                }
            }
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
