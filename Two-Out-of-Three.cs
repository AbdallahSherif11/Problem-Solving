public class Solution 
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        Dictionary<int, int> Result = new Dictionary<int, int>();
        nums1 = nums1.Distinct().ToArray();
        nums2 = nums2.Distinct().ToArray();
        nums3 = nums3.Distinct().ToArray();
        foreach (int num in nums1)
        {
            if (!Result.ContainsKey(num))
            {
                Result.Add(num, 1);
            }
        }
        foreach (int num in nums2)
        {
            if (!Result.ContainsKey(num))
            {
                Result.Add(num, 1);
            }
            else
            {
                Result[num]++;
            }
        }
        foreach (int num in nums3)
        {
            if (!Result.ContainsKey(num))
            {
                Result.Add(num, 1);
            }
            else
            {
                Result[num]++;
            }
        }

        List<int> result = Result.Where(X => X.Value >= 2).Select(X => X.Key).ToList();
        return result;
    }
}