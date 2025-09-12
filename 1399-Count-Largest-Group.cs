public class Solution 
{
    public int CountLargestGroup(int n) 
    {
        Dictionary<int,List<int>> Groups = new Dictionary<int,List<int>>();
        for(int i = 1; i <= n; i++)
        {
            int Temp = i;
            int Sum = 0;
            while (Temp > 0)
            {
                int Digit = Temp % 10;
                Sum += Digit;
                Temp /= 10;
            }
            if (Groups.ContainsKey(Sum))
            {
                Groups[Sum].Add(i);
            }
            else
            {
                Groups.Add(Sum, new List<int>());
                Groups[Sum].Add(i);
            }
        }
        int Max = 0;
        int Count = 0;

        foreach (var X in Groups)
        {
            if (X.Value.Count > Max) 
            {
                Max = X.Value.Count;
                Count = 1;
            }
            else if (X.Value.Count == Max)
            {
                Count++;
            }

        }

        return Count;
    }
}
