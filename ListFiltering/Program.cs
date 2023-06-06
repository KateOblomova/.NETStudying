/*
DESCRIPTION:

Creates a function that takes a list of non-negative integers 
and strings and returns a new list with the strings filtered out.

Example

ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
 
 */

static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
{
    List<int> ints = new List<int>();
    foreach (var obj in listOfItems)
    {
        if (obj.GetType() == typeof(int))
            ints.Add((int)obj);
    }
    return ints;
}