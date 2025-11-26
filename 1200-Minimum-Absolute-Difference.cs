1public class Solution 
2{
3    public IList<IList<int>> MinimumAbsDifference(int[] arr) 
4    {
5        int min = int.MaxValue;
6        int Temp = 0;
7        List<List<int>> X = new List<List<int>>();
8        Array.Sort(arr);
9        for(int i  = 0; i < arr.Length - 1; i++)
10        {
11            Temp = Math.Abs(arr[i] - arr[i+1]);
12            if (Temp < min)
13            {
14                min = Temp;
15            }
16        }
17        for (int i = 0; i < arr.Length - 1; i++)
18        {
19            if(Math.Abs(arr[i] - arr[i+1]) ==  min)
20            {
21                X.Add([arr[i], arr[i + 1]]);
22            }
23        }
24        return X.ToArray();
25    }
26}
