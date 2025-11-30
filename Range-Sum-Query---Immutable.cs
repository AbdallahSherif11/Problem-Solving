1public class NumArray
2{
3    int[] Nums;
4
5    public NumArray(int[] nums)
6    {
7        Nums = nums;
8    }
9
10    public int SumRange(int left, int right)
11    {
12        int Result = 0;
13        for(int i = left; i <= right; i++)
14        {
15            Result += Nums[i];
16        }
17        return Result;
18    }
19}
20
21/**
22 * Your NumArray object will be instantiated and called as such:
23 * NumArray obj = new NumArray(nums);
24 * int param_1 = obj.SumRange(left,right);
25 */