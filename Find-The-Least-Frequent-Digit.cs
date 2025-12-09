1public class Solution 
2{
3    public int GetLeastFrequentDigit(int n) 
4    {
5        int Result = int.MaxValue;
6        int Number = int.MaxValue;
7        string Temp = n.ToString();
8        int Y = 0;
9        Dictionary<int,int> Frequency = new Dictionary<int,int>();
10        foreach(char c in Temp)
11        {
12            Y = (int)char.GetNumericValue(c);
13            if (Frequency.ContainsKey(Y))
14            {
15                Frequency[Y]++;
16            }
17            else
18            {
19                Frequency.Add(Y, 1);
20            }
21        }
22        foreach(var X in Frequency)
23        {
24            if(X.Value == Result && X.Key < Number)
25            {
26                Result = X.Value;
27                Number = X.Key;
28            }
29            else if(X.Value < Result)
30            {
31                Result = X.Value;
32                Number = X.Key;
33            }
34        }
35
36        return Number;
37    }
38}