public class Solution 
{
    public int PercentageLetter(string s, char letter) 
    {
        var x = s.Where(x => x == letter).Count();
        double Result = (double)x / (double)s.Length * 100;

        return (int)Result;
    }
}