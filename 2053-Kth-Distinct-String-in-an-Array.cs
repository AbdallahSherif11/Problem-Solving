public class Solution 
{
    public string KthDistinct(string[] arr, int k) 
    {
        List<string> listDistinct = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            List<string> Temp = arr.ToList();
            string holdBeforeRemoving = arr[i];
            Temp.RemoveAt(i);
            if (Temp.Contains(holdBeforeRemoving))
            {
                continue;
            }
            else
            {
                listDistinct.Add(arr[i]);
            }
        }
        if (k > listDistinct.Count)
        {
            return "";
        }
        return listDistinct[k-1];
    }
}