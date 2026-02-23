1public class Solution 
2{
3    public int RomanToInt(string s) 
4    {
5        int Result = 0;
6        int LastChar = s.Length;
7
8        for (int i = 0; i < s.Length; i++)
9        {
10            if(s[i] == 'M') // 1000
11            {
12                if ((i + 1) < LastChar && s[i + 1] == 'M')
13                {
14                    if ((i + 2) < LastChar && s[i + 2] == 'M')
15                    {
16                        Result += 3000;
17                        i += 2;
18                    }
19                    else
20                    {
21                        Result += 2000;
22                        i += 1;
23                    }
24                }
25                else
26                {
27                    Result += 1000;
28                }
29            }
30            else if (s[i] == 'D') // 500
31            {
32                Result += 500;
33            }
34            else if (s[i] == 'C') // 100
35            {
36                if ((i + 1) < LastChar && s[i + 1] == 'M')
37                {
38                    Result += 900;
39                    i += 1;
40                }
41                else if ((i + 1) < LastChar && s[i + 1] == 'D')
42                {
43                    Result += 400;
44                    i += 1;
45                }
46                else if ((i + 1) < LastChar && s[i + 1] == 'C')
47                {
48                    if ((i + 2) < LastChar && s[i + 2] == 'C')
49                    {
50                        Result += 300;
51                        i += 2;
52                    }
53                    else
54                    {
55                        Result += 200;
56                        i += 1;
57                    }
58                }
59                else
60                {
61                    Result += 100;
62                }
63            }
64            else if (s[i] == 'L') // 50
65            {
66                Result += 50;
67            }
68            else if (s[i] == 'X') // 10
69            {
70                if ((i + 1) < LastChar && s[i+1] == 'L')
71                {
72                    Result += 40;
73                    i += 1;
74                }
75                else if ((i + 1) < LastChar && s[i+1] == 'C')
76                {
77                    Result += 90;
78                    i += 1;
79                }
80                else if ((i + 1) < LastChar && s[i + 1] == 'X')
81                {
82                    if ((i + 2) < LastChar && s[i + 2] == 'X')
83                    {
84                        Result += 30;
85                        i += 2;
86                    }
87                    else
88                    {
89                        Result += 20;
90                        i += 1;
91                    }
92                }
93                else
94                {
95                    Result += 10;
96                }
97            }
98            else if (s[i] == 'V') // 5
99            {
100                Result += 5;
101            }
102            else if (s[i] == 'I') // 1
103            {
104                if ((i + 1) < LastChar && s[i+1] == 'V')
105                {
106                    Result += 4;
107                    i += 1;
108                }
109                else if ((i + 1) < LastChar && s[i+1] == 'X')
110                {
111                    Result += 9;
112                    i += 1;
113                }
114                else if ((i + 1) < LastChar && s[i + 1] == 'I')
115                {
116                    if ((i + 2) < LastChar && s[i + 2] == 'I')
117                    {
118                        Result += 3;
119                        i += 2;
120                    }
121                    else
122                    {
123                        Result += 2;
124                        i += 2;
125                    }
126                }
127                else
128                {
129                    Result += 1;
130                }
131            }
132        }
133
134        return Result;
135    }
136}
