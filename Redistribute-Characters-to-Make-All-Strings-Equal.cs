1public class Solution 
2{
3    public bool MakeEqual(string[] words) 
4    {
5        string Temp = string.Join("", words);
6
7        if(Temp.Length % words.Length != 0 )
8        {
9            return false;
10        }
11
12        foreach (char  c in Temp)
13        {
14            if(Temp.Count(X => X == c) % words.Length != 0)
15            {
16                return false;
17            }
18        }
19
20        return true;
21    }
22}