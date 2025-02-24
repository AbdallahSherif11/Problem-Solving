public class Solution 
{
    public string ClearDigits(string s) 
    {
        List<char> x = s.ToList();
        for (int i = 0; i < x.Count; i++)
        {
            if (char.IsDigit(x[i]))
            {
                x.RemoveAt(i);
                x.RemoveAt(i-1);
                i -= 2;
            }
        }

        return string.Concat(x.ToArray());
    }
}