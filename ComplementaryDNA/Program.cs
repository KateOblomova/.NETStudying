/* 
DESCRIPTION:

Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries 
the "instructions" for the development and functioning of living organisms.
 
 In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". 
Your function receives one side of the DNA (string, except for Haskell); 
you need to return the other complementary side. DNA strand is never empty or there is no DNA at all 
(again, except for Haskell).

Example: (input --> output)

"ATTGC" --> "TAACG"
"GTAT" --> "CATA"

 */

static string MakeComplement(string dna)
{
    char[] newDna = dna.ToCharArray();
    for (int i = 0; i < newDna.Length; i++)
    {
        if (newDna[i] == 'A')
        {
            newDna[i] = 'T';
        }
        else
        {
            if (newDna[i] == 'T')
            {
                newDna[i] = 'A';
            }
        }

        if (newDna[i] == 'C')
        {
            newDna[i] = 'G';
        }

        else
        {
            if (newDna[i] == 'G')
            {
                newDna[i] = 'C';
            }
        }
    }

    var output = new string(newDna);

    return output;
}