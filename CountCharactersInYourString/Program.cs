/* 
DESCRIPTION:

The main idea is to count all the occurring characters in a string. 
If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

What if the string is empty? Then the result should be empty object literal, {}.
 
 */

static Dictionary<char, int> Count(string str)
{
    Dictionary<char, int> dictionary = new Dictionary<char, int>();
    char[] chars = str.ToCharArray();

    foreach (char c in chars)
    {
        if (dictionary.ContainsKey(c))
        {
            dictionary[c]++;
        }
        else { dictionary.Add(c, 1); }
    }
    return dictionary;
}