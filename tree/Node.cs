using System;
using System.Collections.Generic;
using System.Text;

namespace tree
{
    class Node
    { 
    
        public string name;
        public string subject;
        public string grades;
        public Node left;
        public Node right;


        public IEnumerable<Node> Children { get; internal set; }
        public string Name { get; internal set; }
    }
}
