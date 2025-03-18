public class Solution 
{
    public int CountKConstraintSubstrings(string s, int k) 
    {
        int Count = 0;
        int Count0 = 0;
        int Count1 = 0;

        for (int i = 0; i < s.Length; i++)
        {
            string Temp = s[i].ToString();

            for (int j = i + 1; j < s.Length + 1; j++)
            {
                Count0 = Temp.Where(c => c == '0').Count();
                Count1 = Temp.Where(c => c == '1').Count();

                if (Count0 <= k || Count1 <= k)
                {
                    Count++;
                }
                if (j == s.Length) 
                    break;

                Temp += s[j].ToString();
            }
        }

        return Count;
    }
}