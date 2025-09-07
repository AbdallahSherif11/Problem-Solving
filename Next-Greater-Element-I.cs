public class Solution 
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        int[] Result = new int[nums1.Length];
        bool Temp = false;
        int Count = 0;
        foreach (int i in nums1)
        {
            int X = Array.IndexOf(nums2, i) + 1;
            Temp = false;
            if (X < nums2.Length)
            {
                for (int j = X; j < nums2.Length; j++)
                {
                    if (nums2[j] > i)
                    {
                        Temp = true;
                        Result[Count] = nums2[j];
                        break;
                    }
                }
            }
            if (!Temp)
            {
                Result[Count] = -1;
            }
            Count++;
        }

        return Result;
    }
}