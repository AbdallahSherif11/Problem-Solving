public class Solution 
{
    public string RestoreString(string s, int[] indices) 
    {
        string Result = "";
        SortedDictionary<int,char> dic = new SortedDictionary<int, char>();
        for (int i = 0; i < indices.Length; i++)
        {
            dic.Add(indices[i], s[i]);
        }
        foreach(var x in dic)
        {
            Result += x.Value;
        }

        return Result;
    }
}
