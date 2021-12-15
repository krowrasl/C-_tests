using System;
using System.Linq;
using System.Collections.Generic;

namespace test0002_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("output = ");
            var list = new List <Action>();
            for(var i = 0; i< 5; i++)
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
5
*/
