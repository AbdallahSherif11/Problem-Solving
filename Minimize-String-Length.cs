public class Solution 
{
    public int MinimizedStringLength(string s)
    {
        var Result = s.Distinct();
        return Result.ToArray().Length;
    }
}