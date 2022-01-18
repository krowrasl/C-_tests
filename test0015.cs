/* Isogram testing */

using System;

public class Kata
{
        public static bool IsIsogram(string str) 
        {
            str = str.ToLower();
            foreach(var letter in str)
            {
                if ( str.IndexOf(letter) != str.LastIndexOf(letter)) 
                    return false;
            }
            return true;
        }
}

/* Best practice
using System;
using System.Linq;
public class Kata
{
  public static bool IsIsogram(string str) 
  {
    return str.ToLower().Distinct().Count()==str.Length;
  }
}
*/
