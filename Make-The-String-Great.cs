1public class Solution 
2{
3    public string MakeGood(string s) 
4    {
5        char Small = 'a';
6        char Capital = 'A';
7        Dictionary<char,char> LettersSmallToCapital = new Dictionary<char,char>();
8        Dictionary<char,char> LettersCapitalToSmall = new Dictionary<char,char>();
9        List<char> Temp = s.ToList();
10        for(int i  = 0; i < 26; i++)
11        {
12            LettersSmallToCapital.Add(Small, Capital);
13            LettersCapitalToSmall.Add(Capital, Small);
14            Small++;
15            Capital++;
16        }
17
18        int j = 0;
19        while(j <= Temp.Count - 2)
20        {
21            if (LettersSmallToCapital.ContainsKey(Temp[j]) && LettersCapitalToSmall.ContainsKey(Temp[j+1]))
22            {
23                if (LettersSmallToCapital[Temp[j]] == Temp[j + 1])
24                {
25                    Temp.RemoveAt(j);
26                    Temp.RemoveAt(j);
27                    j = -1;
28                }
29            }
30            else if(LettersCapitalToSmall.ContainsKey(Temp[j]) && LettersSmallToCapital.ContainsKey(Temp[j + 1]))
31            {
32                if (LettersCapitalToSmall[Temp[j]] == Temp[j + 1])
33                {
34                    Temp.RemoveAt(j);
35                    Temp.RemoveAt(j);
36                    j = -1;
37                }
38            }
39            j++;
40        }
41        if(Temp.Count == 2)
42        {
43            if (LettersSmallToCapital.ContainsKey(Temp[0]) && LettersCapitalToSmall.ContainsKey(Temp[1]))
44            {
45                if (LettersSmallToCapital[Temp[0]] == Temp[1])
46                {
47                    Temp.Clear();
48                }
49            }
50            else if (LettersCapitalToSmall.ContainsKey(Temp[0]) && LettersSmallToCapital.ContainsKey(Temp[1]))
51            {
52                if (LettersCapitalToSmall[Temp[0]] == Temp[1])
53                {
54                    Temp.Clear();
55                }
56            }
57        }
58
59        string Result = new string(Temp.ToArray());
60
61        return Result;
62    }
63}