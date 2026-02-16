1public class Solution 
2{
3    public string MapWordWeights(string[] words, int[] weights) 
4    {
5        string Result = "";
6        char[] chars = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
7        Dictionary<char,int> CharsWeights = new Dictionary<char,int>();
8        Dictionary<int, char> CharsReverseWeights = new Dictionary<int, char>();
9        int j = 25;
10
11        for(int i  = 0; i < chars.Length; i++)
12        {
13            CharsWeights.Add(chars[i], weights[i]);
14            CharsReverseWeights.Add(j, chars[i]);
15            j--;
16        }
17
18        int Temp = 0;
19
20        foreach(string word in words)
21        {
22            Temp = 0;
23            foreach(char c in word)
24            {
25                Temp += CharsWeights[c];
26            }
27            Temp %= 26;
28            Result = $"{Result}{CharsReverseWeights[Temp]}";
29
30        }
31
32        return Result;
33    }
34}