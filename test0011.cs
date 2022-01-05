/* Count the letters only in the string
*/
using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    var output = new Dictionary<char, int>();
    foreach(char letter in str){
      if(!Char.IsLetter(letter))continue;
      if(!output.ContainsKey(letter)) 
        output.Add(letter,1);
      else
        output[letter] += 1;
    }
    return output;
  }
}

/* best practice
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str) => str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
}
*/
