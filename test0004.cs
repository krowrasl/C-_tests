using System;

/*
Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.
Note: a and b are not ordered!
*/
namespace test0003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int b= 0;
            var outPut = 0;
            if (a == b){ outPut = a;Console.WriteLine(outPut); return;}
            if ( a> b){
                var c = a;
                a = b;
                b = c;
            }
            for(var i = a; i <= b; i++)
            {
                outPut+=i;
            }
            Console.WriteLine(outPut);
        }
    }
}

/* best practice
using System;

public class Sum
{
  public int GetSum(int a, int b)
  {
    return (a + b) * (Math.Abs(a - b) + 1) / 2;
  }
}
*/
