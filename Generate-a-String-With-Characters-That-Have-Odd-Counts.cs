public class Solution 
{
    public string GenerateTheString(int n) 
    {
        string Result = "";
        if (n % 2 == 1)
        {
            Result = new string('a', n);
            return Result;
        }
        else
        {
            Result = new string('a', n-1);
            return Result + 'b';
        }
    }
}