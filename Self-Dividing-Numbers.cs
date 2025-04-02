public class Solution 
{
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        IList<int> result = new List<int>();
        bool self = false;
        for(int i = left; i <= right; i++)
        {
            self = false;
            char[] Temp = i.ToString().ToCharArray();
            if (Temp.Contains('0'))
            {
                continue;
            }
            else
            {
                for (int j = 0; j < Temp.Length; j++)
                {
                    if (i % char.GetNumericValue(Temp[j]) == 0)
                    {
                        self = true;
                    }
                    else
                    {
                        self = false;
                        break;
                    }
                }
                if (self)
                {
                    result.Add(i);
                }
            }
        }

        return result;
    }
}