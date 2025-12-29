1public class Solution 
2{
3    public int CountValidSelections(int[] nums) 
4    {
5        int Result = 0;
6        int Count = nums.Length;
7        int[] Temp = (int[])nums.Clone();
8        int x = 0;
9        bool Direction = true; // true going left, false going right
10
11        for(int i = 0; i < nums.Length; i++)
12        {
13            if (nums[i] == 0)
14            {
15                x = i;
16                Temp = (int[])nums.Clone();
17                Direction = true;
18                while (true)
19                {
20                    if(Direction == true)
21                    {
22                        x--;
23                    }
24                    else
25                    {
26                        x++;
27                    }
28                    if(x < 0 || x >= Temp.Length)
29                    {
30                        break;
31                    }
32                    if (Temp[x] > 0)
33                    {
34                        Temp[x]--;
35                        if(Direction== true)
36                        {
37                            Direction = false;
38                        }
39                        else
40                        {
41                            Direction= true;
42                        }
43                    }
44                }
45                if(Temp.Where(X=> X == 0).Count() == Count)
46                {
47                    Result++;
48                }
49                /////////////////////
50                x = i;
51                Temp = (int[])nums.Clone();
52                Direction = false;
53                while (true)
54                {
55                    if (Direction == true)
56                    {
57                        x--;
58                    }
59                    else
60                    {
61                        x++;
62                    }
63                    if (x < 0 || x >= Temp.Length)
64                    {
65                        break;
66                    }
67                    if (Temp[x] > 0)
68                    {
69                        Temp[x]--;
70                        if (Direction == true)
71                        {
72                            Direction = false;
73                        }
74                        else
75                        {
76                            Direction = true;
77                        }
78                    }
79                }
80                if (Temp.Where(X => X == 0).Count() == Count)
81                {
82                    Result++;
83                }
84            }
85        }
86
87        return Result;
88    }
89}