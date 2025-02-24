public class Solution 
{
    public int Maximum69Number (int num) 
    {
        char[] x = num.ToString().ToCharArray();

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == '6')
            {
                x[i] = '9';
                break;
            }
        }
        
        return int.Parse(string.Concat(x));
    }
}