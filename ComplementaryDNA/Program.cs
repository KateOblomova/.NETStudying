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

using System.Text.RegularExpressions;

static string MakeComplement(string dna)
{
    if (string.IsNullOrEmpty(dna)) return string.Empty;

    string pattern = @"(T|A|G|C)";
    string antiPattern = @"[^ATCG]+";

    if (Regex.IsMatch(dna, antiPattern)) return string.Empty;

    if (!Regex.IsMatch(dna, pattern)) return string.Empty;

    var matches = Regex.Replace(dna, pattern, r =>
    {
        if (r.Value == "A")
            return "T";
        if (r.Value == "T")
            return "A";
        if (r.Value == "C")
            return "G";
        if (r.Value == "G")
            return "C";
        else r.NextMatch(); return string.Empty;
    });

    return matches;
}