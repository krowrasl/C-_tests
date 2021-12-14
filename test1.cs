/* Task 01
create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

Example
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}

*/

using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      foreach(var item in listOfItems)
      {
        if ( item is int )
          yield return (int)item;
      }
   }
}


/* Best practice
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     return listOfItems.OfType<int>();
   }
}
*/
