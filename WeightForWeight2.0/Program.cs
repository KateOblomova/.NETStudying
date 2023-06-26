/* 
 My friend John and I are members of the "Fat to Fit Club (FFC)". 
John is worried because each month a list with the weights of members 
is published and each month he is the last on the list 
which means he is the heaviest.

I am the one who establishes the list so I told him: 
"Don't worry any more, I will modify the order of the list". 
It was decided to attribute a "weight" to numbers. 
The weight of a number will be from now on the sum of its digits.

For example 99 will have "weight" 18, 100 will have "weight" 1 
so in the list 100 will come before 99.

Given a string with the weights of FFC members in normal 
order can you give this string ordered by "weights" of these numbers?

When two numbers have the same "weight", let us class them as if they were 
strings (alphabetical ordering) and not numbers:

180 is before 90 since, having the same "weight" (9), it comes before as a string.

All numbers in the list are positive numbers and the list can be empty.
 
 */

static string OrderWeight(string strng)
{
	if(string.IsNullOrEmpty(strng)) return string.Empty;

	var output = new Queue<int>();
	var strings = strng.Select(x => x.ToString()).ToArray();
	var array = strng.Split(" ");
	var dictionary = new Dictionary<int, List<string>>();
	var values = new int[strings.Length];

	for (var j = 0; j < strings.Length; j++)
	{
		int.TryParse(strings[j], out values[j]);
		if (strings[j].Equals(" ") || j == strings.Length - 1)
		{
			output.Enqueue(values.Sum());

			for (int v = 0; v < values.Length; v++)
			{
				values[v] = 0;
			}
		}
	}	
	for (int i = 0; i < array.Length; i++)
		{
		var resultOfDequeue = output.Dequeue();

		if (dictionary.ContainsKey(resultOfDequeue))
		{
			dictionary[resultOfDequeue].Add(array[i]);
		}
		else
		{
			var valuesList = new List<string> { array[i] };
			dictionary.Add(resultOfDequeue, valuesList);
		}
	}
		
	var sortList = dictionary.ToList();
	sortList.Sort((x, y) => x.Key.CompareTo(y.Key));
	var outputList = new List<string>();
	foreach(var pair in sortList)
    {
		if (pair.Value.Count > 1)
		{
			for(int i = 0; i < pair.Value.Min().Length; i++)
            {
				var x = pair.Value.First()[i];
				var y = pair.Value.Last()[i];
				if (x == y)
				{ pair.Value.Sort((x, y) => x[i + 1].CompareTo(y[i + 1])); }
				else { pair.Value.Sort((x, y) => x.CompareTo(y)); break; }
			}
			
			foreach (var value in pair.Value)
			{
				outputList.Add(value);
			}
		}
		else { outputList.Add(pair.Value.First()); }
    }
	var result = string.Join(" ", outputList.Select(x => x)).ToString();

	return result;
}