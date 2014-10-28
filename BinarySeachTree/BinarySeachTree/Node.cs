using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySeachTree
{
    public class Node
    {
        public String Key;
        public int Val;
        public Node left, right;
        public Node(String Key, int val)
        {
            this.Key = Key;
            this.Val = val;
        }

    }
}
