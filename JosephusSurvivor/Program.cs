/* DESCRIPTION:
 
you have to correctly return who is the "survivor", 
ie: the last element of a Josephus permutation.

Basically you have to assume that n people are put into 
a circle and that they are eliminated in steps of k elements, like this:

n=7, k=3 => means 7 people in a circle
one every 3 is eliminated until one remains
[1,2,3,4,5,6,7] - initial sequence
[1,2,4,5,6,7] => 3 is counted out
[1,2,4,5,7] => 6 is counted out
[1,4,5,7] => 2 is counted out
[1,4,5] => 7 is counted out
[1,4] => 5 is counted out
[4] => 1 counted out, 4 is the last element - the survivor!
 
 */

static int JosSurvivor(int n, int k)
{
    List<int> input = new List<int>();

    int count = n;
    int index = 0;

    for (int i = 1; i <= n; i++)
    {
        input.Add(i);
    }
    while (count > 1)
    {
        index = (index + (k - 1)) % count;
        input.RemoveAt(index);
        count--;
    }

    int[] result = input.ToArray();
    return result[0];
}
