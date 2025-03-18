public class Solution 
{
    public int CountKConstraintSubstrings(string s, int k) 
    {
        int Count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            string Temp = s[i].ToString();

            var Count0 = Temp.Where(c => c == '0').Count();
            var Count1 = Temp.Where(c => c == '1').Count();

            if(Count0 <= k || Count1 <= k)
            {
                Count++;
            }

            for (int j = i+1; j < s.Length; j++)
            {
                Temp += s[j].ToString();

                Count0 = Temp.Where(c => c == '0').Count();
                Count1 = Temp.Where(c => c == '1').Count();

                if (Count0 <= k || Count1 <= k)
                {
                    Count++;
                }
            }
        }

        return Count;
    }
}