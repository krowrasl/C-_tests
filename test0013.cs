/*Complete the solution so that the function will break up camel casing, using a space between words.*/

for(var letterNo = 0; letterNo < str.Length; letterNo++)
{
    if(char.IsUpper(str[letterNo]))
    {
        str = str.Insert(letterNo, " ");
        letterNo++;
    }
}
return str.Trim();

/*Best practice
public static string BreakCamelCase(string str) =>
    new Regex("([A-Z])").Replace(str, " $1");
    */
