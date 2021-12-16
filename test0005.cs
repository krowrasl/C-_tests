/*
ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
If the function is passed a valid PIN string, return true, else return false.
*/
using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    
    return (new Regex(@"^\d{4}$").IsMatch(pin)&& pin.Length==4) ||  (new Regex(@"^\d{6}$").IsMatch(pin)&& pin.Length==6) ;
  }
}

/* better practice
using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
  }
}
*/
