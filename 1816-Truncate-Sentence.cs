public class Solution 
{
    public string TruncateSentence(string s, int k) 
    {
        string Result = "";

        string[] TempArr = s.Split(' ');
        string[] SmallArr = new string[k];

        Array.Copy(TempArr, SmallArr, k);

        Result = String.Join(" ", SmallArr);

        return Result;
    }
}
