/*
replace any vowel letters in the given string 
*/

using System;

namespace test0009
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "This website is for losers LOL!";
            char[] chrVowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O','U' };
            
            foreach(char ch in chrVowels)
                str = str.Replace(ch.ToString(), "");

            Console.Write(str);
        }

    }       
}
