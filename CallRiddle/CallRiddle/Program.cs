using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallRiddle
{
    class Call
    {
        public DateTime Begin;
        public DateTime End;

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Call> Calls = new List<Call>();
            //Setup some calls
            
            //Create a date
            Call newCall = new Call();
            newCall.Begin = new DateTime(2014, 10, 24, 12, 49, 45);
            newCall.End = new DateTime(2014, 10, 24, 13 , 45, 45);
            Calls.Add(newCall);
            
            Call newCall2 = new Call();
            newCall2.Begin = new DateTime(2014, 10, 24, 13, 20, 45);
            newCall2.End = new DateTime(2014, 10, 24, 14, 49, 45);
            Calls.Add(newCall2);

            Call newCall3 = new Call();
            newCall3.Begin = new DateTime(2014, 10, 25, 12, 49, 45);
            newCall3.End = new DateTime(2014, 10, 25, 12, 50, 45);
            Calls.Add(newCall3);

            //Call newCall4 = new Call();
            //newCall4.Begin = new DateTime(2014, 10, 26, 12, 49, 45);
            //newCall4.End = new DateTime(2014, 10, 26, 13, 49, 45);
            //Calls.Add(newCall4);

            //Call newCall5 = new Call();
            //newCall5.Begin = new DateTime(2014, 10, 27, 12, 49, 45);
            //newCall5.End = new DateTime(2014, 10, 27, 13, 49, 45);
            //Calls.Add(newCall5);


            //detect number of dates
            Console.WriteLine(numOverlap(Calls));
        }

        static int numOverlap(List<Call> callList)
        {
            int number = 0;



            return number;
        }
    }
   





}
