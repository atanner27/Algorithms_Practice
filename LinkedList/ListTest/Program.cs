using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListTest;
using LinkedList;
namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList List = new CustomList();

            

            List.PrintList();
            Console.ReadLine();
        }

        static void TestAddBack(CustomList List)
        {
            List.AddBack(1);
            List.AddBack(2);
            List.AddBack(3);
            List.AddBack(4);
            List.AddBack(5);
        }

        static void TestAddFront(CustomList List)
        {
            List.AddFront(1);
            List.AddFront(2);
            List.AddFront(3);
            List.AddFront(4);
            List.AddFront(5);
        }

    }
}
