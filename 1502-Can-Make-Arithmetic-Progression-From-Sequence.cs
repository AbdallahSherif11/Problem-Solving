1public class Solution 
2{
3    public bool CanMakeArithmeticProgression(int[] arr) 
4    {
5        Array.Sort(arr);
6        int Temp = arr[1] - arr[0];
7
8        for(int i = 0; i < arr.Length - 1; i++)
9        {
10            if (arr[i+1] - arr[i] != Temp)
11            {
12                return false;
13            }
14        }
15
16        return true;
17    }
18}
