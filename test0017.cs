/*Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.
*/

  public static bool XO (string input)
  {
    return (input.ToLower().Count(letter1 => letter1 =='x') == input.ToLower().Count(letter1 => letter1 =='o'));
  }
  
