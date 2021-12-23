/*
Let set of int not sorted.
Return values that are divisible by 5 without a remainder in sorted order.
*/

using System;
using System.Collections.Generic;

namespace test0003
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>(){3,7,9,2,8,0,4,5,6,1};
            var output = new List<int>();
            foreach(var element in input)
            {
                if(element % 5 == 0)
                    output.Add(element);
            }
            output.Sort();
            foreach(var el in output)
                Console.WriteLine(el);
        }
    }
}
