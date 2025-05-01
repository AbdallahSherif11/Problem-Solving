public class Solution 
{
    public bool UniqueOccurrences(int[] arr) 
    {
        Dictionary<int,int> dic = new Dictionary<int,int>();

        for(int i = 0; i < arr.Length; i++)
        {
            if (!dic.ContainsKey(arr[i]))
            {
                dic.Add(arr[i], 1);
            }
            else
            {
                dic[arr[i]]++;
            }
        }

        int x = dic.Values.Distinct().Count();
        if(x == dic.Count)
            return true;

        return false;
    }
}
