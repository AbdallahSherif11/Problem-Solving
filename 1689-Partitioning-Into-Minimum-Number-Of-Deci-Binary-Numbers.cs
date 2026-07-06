public class Solution 
{
    public int MinPartitions(string n) 
    {
        int Result = 0;

        var X = n.Max();

        return (int)char.GetNumericValue(X);
    }
}