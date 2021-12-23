/*
Well met with Fibonacci bigger brother, AKA Tribonacci.
As the name may already reveal, it works basically like a Fibonacci, but summing the last 3 (instead of 2) numbers of the sequence to generate the next. 
Signature will always contain 3 numbers; n will always be a non-negative number; if n == 0, then return an empty array (except in C return NULL)
*/

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if (n <=0) return  new double[0];
    var output = new double[n];
    for(var i = 0; i < (3<n?3:n); i++)
        output[i] = signature[i];
    var j = 3;
    while(j<n){
        output[j] = output[j-1] + output[j-2] + output[j-3];
        j++;
    }
    return output;
  }
}

/* best practice

    double[] Tribonacci(double[] signature, int n)
    {
        var output = new double[n];
        for(var i = 0; i < n; i++)
            output[i] = (i<3)?signature[i]: output[i-1] + output[i-2] + output[i-3];
        return output;
    }

*/
