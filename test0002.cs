using System;
using System.Linq;
using System.Collections.Generic;

namespace test0002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("output = ");
            var list = new List <Action>();
            foreach(var i in Enumerable.Range(0,5))
            {
                list.Add(()=> Console.WriteLine(i));
            }
            foreach(var func in list)
            {
                func();
            }
        }
    }
}

/*
output = 
0
1
2
3
4
*/
