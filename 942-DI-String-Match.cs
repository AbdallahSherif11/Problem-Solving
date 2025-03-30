public class Solution 
{
    public int[] DiStringMatch(string s) 
    {
        LinkedList<int> L2 = new LinkedList<int>(Enumerable.Range(0, s.Length + 1));

        int[] Result = new int[L2.Count];
        for (int j = 0; j < s.Length; j++)
        {
            if (s[j] == 'I')
            {
                Result[j] = L2.First.Value;
                L2.RemoveFirst();
            }
            else
            {
                Result[j] = L2.Last.Value;
                L2.RemoveLast();
            }
        }

        Result[Result.Length - 1] = L2.Last.Value;

        return Result;
    }
}
