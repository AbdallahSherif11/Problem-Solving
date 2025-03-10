public class Solution 
{
    public int MaximumNumberOfStringPairs(string[] words) 
    {
        int Count = 0;

        for (int i = 0; i < words.Length - 1; i++)
        {
            char[] Temp = words[i].ToCharArray();
            Array.Reverse(Temp);
            string Temp2 = string.Concat(Temp);

            for(int j = i+1; j < words.Length; j++)
            {
                if(Temp2 == words[j])
                {
                    Count++;
                }
            }
        }

        return Count;
    }
}
