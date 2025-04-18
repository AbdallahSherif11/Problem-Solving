public class Solution 
{
    public int XorAllNums(int[] nums1, int[] nums2) 
    {
        int Result = 0;
        int Xor1 = 0;
        int Xor2 = 0;

        foreach (int x in nums1)
        {
            Xor1 ^= x;
        }

        foreach (int x in nums2)
        {
            Xor2 ^= x;
        }

        if (nums2.Length % 2 != 0) 
            Result ^= Xor1; 
        if (nums1.Length % 2 != 0)
            Result ^= Xor2;

        return Result;
    }
}