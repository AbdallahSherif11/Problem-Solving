public class Solution 
{
    public int SubsetXORSum(int[] nums) 
    {
        int totalXORSum = 0;
        
        int n = nums.Length;
        
        int totalSubsets = 1 << n; // 2^n subsets
        
        for (int subsetMask = 0; subsetMask < totalSubsets; subsetMask++) {
            int currentXOR = 0;
            
            for (int i = 0; i < n; i++) {
                if ((subsetMask & (1 << i)) != 0) {
                    currentXOR ^= nums[i];  
                }
            }
            
            totalXORSum += currentXOR;
        }
        
        return totalXORSum;
    }
}