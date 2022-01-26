/*
Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
It should remove all values from list a, which are present in list b keeping their order.
*/
        public static int[] ArrayDiff(int[] a, int[] b)
        {
        
            var returnValues = new int[a.Length];
            var outLength = 0;
            for( var i = 0; i < a.Length; i++)
            {
                if (Contains(a[i], b)) continue;
                returnValues[outLength++] = a[i];
            }
            bool Contains(int a, int[] b)
            {
                foreach(var item in b)
                    if (a == item) return true;
                return false;
            }
            var retVal = new int [outLength];
            System.Array.Copy(returnValues, retVal, outLength);
            return retVal;
        }
        
/* best practice
using System;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)
    
    int [] c=new int [0];
    int f;
    for(int d=0;d<a.Length;d++){
      f=Array.IndexOf(b,a[d]);
        if(f<0){
        Array.Resize(ref c, c.Length+1);
        c[c.Length-1]=a[d];
      }
    }
    return c;
  }
}
*/
