1public class Solution 
2{
3    public int MinimumBoxes(int[] apple, int[] capacity) 
4    {
5        int Result = 0;
6        int Temp = 0;
7
8        Array.Sort(capacity);
9        Array.Reverse(capacity);
10
11        int TotalApples = apple.Sum();
12        for(int i = 0; i < capacity.Length; i++)
13        {
14            Temp += capacity[i];
15            Result++;
16            if(Temp >= TotalApples)
17            {
18                break;
19            }
20        }
21
22        return Result;
23    }
24}
