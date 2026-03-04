1public class Solution 
2{
3    public int NumSpecial(int[][] mat) 
4    {
5        int Result = 0;
6        bool Temp = true;
7
8        for(int i = 0; i < mat.Length;i++)
9        {
10            for (int j = 0; j< mat[i].Length; j++)
11            {
12                Temp = true;
13                if(mat[i][j] == 1)
14                {
15                    for(int k = 0; k < mat[i].Length; k++)
16                    {
17                        if(k == j)
18                        {
19                            continue;
20                        }
21                        else
22                        {
23                            if (mat[i][k] == 1)
24                            {
25                                Temp = false;
26                                break;
27                            }
28                        }
29                    }
30                    if(Temp == false)
31                    {
32                        break;
33                    }
34                    else
35                    {
36                        for (int k = 0; k < mat.Length; k++)
37                        {
38                            if (k == i)
39                            {
40                                continue;
41                            }
42                            else
43                            {
44                                if (mat[k][j] == 1)
45                                {
46                                    Temp = false;
47                                    break;
48                                }
49                            }
50                        }
51                    }
52                }
53                else
54                {
55                    continue;
56                }
57
58                if (Temp)
59                {
60                    Result++;
61                }
62            }
63        }
64
65        return Result;
66    }
67}
