1public class Solution 
2{
3    public int MinTimeToVisitAllPoints(int[][] points) 
4    {
5        int Result = 0;
6        int[] Pointer = [points[0][0], points[0][1]];
7
8        for (int i = 1; i < points.Length; i++)
9        {
10            if (Pointer[0] > points[i][0] && Pointer[1] > points[i][1])
11            {
12                Pointer[0]--;
13                Pointer[1]--;
14                Result++;
15            }
16            else if (Pointer[0] < points[i][0] && Pointer[1] < points[i][1])
17            {
18                Pointer[0]++;
19                Pointer[1]++;
20                Result++;
21            }
22            else if (Pointer[0] < points[i][0] && Pointer[1] > points[i][1])
23            {
24                Pointer[0]++;
25                Pointer[1]--;
26                Result++;
27            }
28            else if (Pointer[0] > points[i][0] && Pointer[1] < points[i][1])
29            {
30                Pointer[0]--;
31                Pointer[1]++;
32                Result++;
33            }
34            else if (Pointer[0] < points[i][0] && Pointer[1] == points[i][1])
35            {
36                Pointer[0]++;
37                Result++;
38            }
39            else if (Pointer[0] > points[i][0] && Pointer[1] == points[i][1])
40            {
41                Pointer[0]--;
42                Result++;
43            }
44            else if (Pointer[1] < points[i][1] && Pointer[0] == points[i][0])
45            {
46                Pointer[1]++;
47                Result++;
48            }
49            else if (Pointer[1] > points[i][1] && Pointer[0] == points[i][0])
50            {
51                Pointer[1]--;
52                Result++;
53            }
54
55            if (Pointer[0] != points[i][0] || Pointer[1] != points[i][1])
56            {
57                i--;
58            }
59        }
60
61        return Result;
62    }
63}
