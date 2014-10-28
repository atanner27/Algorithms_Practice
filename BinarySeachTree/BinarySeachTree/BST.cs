using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySeachTree
{
    class BST
    {
        //http://www.cs.princeton.edu/~rs/AlgsDS07/08BinarySearchTrees.pdf
        private Node root;
        
        public int Search(String Key)
        {
            Node x = root;
            //int val = 0;
            while(x != null)
            {
                int cmp = Key.CompareTo(x.Key);
                if(cmp ==0)
                {
                    return x.Val;
                }
                else if(cmp < 0)
                {
                    x = x.left;
                }
                else if(cmp > 0)
                {
                    x = x.right;
                }

            }

            return Int32.Parse(null);
        }

       
        /// <summary>
        /// This is the public interface to the insertion, sets up the new root
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Val"></param>
        public void Insert(String Key, int Val)
        {
            root = Put(root, Key, Val);
        }

        /// <summary>
        /// recursive code that is hidden,this does the real work behind insertion
        /// </summary>
        /// <param name="x"></param>
        /// <param name="Key"></param>
        /// <param name="Val"></param>
        /// <returns></returns>
        private Node Put(Node x,String Key, int Val)
        {
            //If there is nothing there, make a new node
            if(x == null)
            {
                return new Node(Key, Val);
            }

            int cmp = Key.CompareTo(x.Key);
            if(cmp ==0)
            {
                x.Val = Val;
            }
            else if (cmp < 0)
            {
                x.left = Put(x.left, Key, Val);
            }
            else if(cmp > 0 )
            {
                x.right = Put(x.right, Key, Val);
            }
     
            return x;
        }

    }
}
