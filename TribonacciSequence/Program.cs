/* DESCRIPTION:

 it works basically like a Fibonacci, but summing the last 3
(instead of 2) numbers of the sequence to generate the next.

So, if we are to start our Tribonacci sequence with [1, 1, 1] 
as a starting input (AKA signature), we have this sequence:

[1, 1 ,1, 3, 5, 9, 17, 31, ...]

But what if we started with [0, 0, 1] as a signature? 
As starting with [0, 1] instead of [1, 1] basically shifts 
the common Fibonacci sequence by once place, you may be 
tempted to think that we would get the same sequence shifted by 2 places, 
but that is not the case and we would get:

[0, 0, 1, 1, 2, 4, 7, 13, 24, ...]

Need to create a fibonacci function that given a signature array/list, 
returns the first n elements - signature included of the so seeded sequence.

Signature will always contain 3 numbers; n will always be a non-negative number; 
if n == 0, then return an empty array (except in C return NULL) 

 */

static double[] Tribonacci(double[] signature, int n)
{
    double[] newSignature = new double[n];

    if (signature.Length == 2 || signature.Length == 1)
    {
        return signature;
    }

    switch (n)
    {
        case 0: return newSignature;

        case 1:
            newSignature[0] = signature[0];
            break;
        case 2:
            newSignature[0] = signature[0];
            newSignature[1] = signature[1];
            break;
        default:
            for (int i = 0; i < signature.Length; i++)
            {
                newSignature[i] = signature[i];
            }

            for (int i = 3; i < n; i++)
            {
                newSignature[i] = newSignature[i - 1] + newSignature[i - 2] + newSignature[i - 3];
            }
            break;
    }
    return newSignature;
}