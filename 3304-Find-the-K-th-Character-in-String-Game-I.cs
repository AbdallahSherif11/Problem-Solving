1public class Solution 
2{
3    public char KthCharacter(int k) 
4    {
5        string word = "a";
6        string Temp = "";
7
8        while (word.Length < k)
9        {
10            foreach(char c in word)
11            {
12                if(c == 'z')
13                {
14                    Temp += 'a';
15                }
16                else
17                {
18                    char X = (char)(c + 1);
19                    Temp += X;
20                }
21            }
22            word += Temp;
23            Temp = "";
24        }
25
26        return word[k-1];
27    }
28}
