1public class Solution 
2{
3    public IList<string> RemoveAnagrams(string[] words) 
4    {
5        IList<string> list = new List<string>();
6        list = words.ToList();
7        List<string> chars = new List<string>();
8
9        foreach (string word in words)
10        {
11            char[] Temp = word.ToCharArray();
12            Array.Sort(Temp);
13            chars.Add(string.Concat(Temp));
14        }
15
16        for(int i = 1; i < chars.Count; i++)
17        {
18            if (chars[i] == chars[i - 1])
19            {
20                chars.RemoveAt(i);
21                list.RemoveAt(i);
22                i--;
23            }
24        }
25
26        return list;
27    }
28}
