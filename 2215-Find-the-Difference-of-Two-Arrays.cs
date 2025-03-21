public class Solution 
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) 
    {
        List<int> Left = new List<int>();
        List<int> Right = new List<int>();

        List<List<int>> Result = new List<List<int>>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (!nums2.ToList().Contains(nums1[i]) && !Left.Contains(nums1[i]))
            {
                Left.Add(nums1[i]);
            }
        }

        for (int j = 0; j < nums2.Length; j++)
        {
            if (!nums1.ToList().Contains(nums2[j]) && !Right.Contains(nums2[j]))
            {
                Right.Add(nums2[j]);
            }
        }
        Result.Add(Left);
        Result.Add(Right);

        return Result.Cast<IList<int>>().ToList();
    }
}
