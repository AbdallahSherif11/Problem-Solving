public class Solution 
{
    public int NumberOfPoints(IList<IList<int>> nums) 
    {
        List<int> Result = new List<int>();

        foreach (var X in nums)
        {
            for(int i = X[0]; i <= X[1]; i++)
            {
                if(!Result.Contains(i))
                {
                    Result.Add(i);
                }
            }
        }

        return Result.Count;
    }
}
