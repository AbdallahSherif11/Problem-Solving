1public class Solution 
2{
3    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) 
4    {
5        int[] Result = new int[2];
6        int aliceSum = aliceSizes.Sum();
7        int bobSum = bobSizes.Sum();
8
9
10        for(int i = 0; i < bobSizes.Length; i++)
11        {
12            for(int j = 0; j < aliceSizes.Length; j++)
13            {
14                if(bobSum > aliceSum)
15                {
16                    if((bobSum - bobSizes[i] + aliceSizes[j]) == (aliceSum + bobSizes[i] - aliceSizes[j]))
17                    {
18                        Result[0] = aliceSizes[j];
19                        Result[1] = bobSizes[i];
20                        return Result;
21                    }
22                }
23                else
24                {
25                    if ((aliceSum - aliceSizes[j] + bobSizes[i]) == (bobSum - bobSizes[i] + aliceSizes[j]))
26                    {
27                        Result[0] = aliceSizes[j];
28                        Result[1] = bobSizes[i];
29                        return Result;
30                    }
31                }
32            }
33        }
34
35        return Result;
36    }
37}