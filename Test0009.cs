/*
Given an integral number, determine if it's a square number
*/
using System;

namespace test0009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsSquare(26));
        }
        public static bool IsSquare(int n)
        {
            var sqrt = Math.Sqrt(n);
            return (sqrt != double.NaN && (sqrt-(int)sqrt == 0))? true : false;
        }
    }       
}

/* best practice
  public static bool IsSquare(int n)
  {
    return Math.Sqrt(n) % 1 == 0;
  }
*/
