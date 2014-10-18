using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomList
    {
        private Element Root;

        public void AddFront(int value)
        {
            Element newElement = new Element();
            newElement.Value = value;

            //move list
            Element OldRoot = Root;
            Root = newElement;
            newElement.Next = OldRoot;
        }

        public void AddBack(int value)
        {
            Element newElement = new Element();
            newElement.Value = value;

            if (Root == null)
            {
                Root = newElement;
            }
            else
            {


                //loop through list until not null
                Element Temp = Root;
                while (Temp.Next != null)
                {
                    Temp = Temp.Next;
                }
                //Assign the new val
                Temp.Next = newElement;

            }
        }
        public void DeleteFront()
        {
            Element NewRoot = new Element();
            Element SecondNode = new Element();
           
            //Grab the second element and make it the root
            SecondNode = Root.Next;
            Root = SecondNode;
            
        }

        public void DeleteBack()
        {

        }
       
        public void DeleteN(int value)
        {

        }

        public void PrintList()
        {
            Element Temp = Root;
            while (Temp != null)
            {
                System.Console.WriteLine(Temp.Value);
                Temp = Temp.Next;
            }
            
        }
    }

    public class Element
    {
        public int Value;
        public Element Next;
    }

   
}
