public class Solution 
{
    public string MaximumOddBinaryNumber(string s) 
    {
        string Result = "";
        char[] c = s.ToCharArray();
        Array.Sort(c);
        Array.Reverse(c);

        string x = string.Concat(c) + '1';
        Result = x.Substring(1);
        return Result;
    }
}