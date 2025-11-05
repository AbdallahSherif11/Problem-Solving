public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        List<char> list = new List<char>();
        list = s.ToList();
        for(int i = 0; i < list.Count() - 1; i++)
        {
            if (list[i] == list[i + 1])
            {
                list.RemoveAt(i + 1);
                list.RemoveAt(i);
                if(i - 2 >= 0)
                {
                    i-=2;
                } 
                else
                {
                    i = -1;
                }
                // i = -1;
            }
        }
        // char[] X = list.ToArray();
        string Result = string.Concat(list);
        return Result;
    }
}