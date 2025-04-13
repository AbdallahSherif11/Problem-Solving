public class Solution 
{
    public bool AreOccurrencesEqual(string s) 
    {
        Dictionary<char,int> result = new Dictionary<char,int>();
        for(int i = 0; i < s.Length; i++)
        {
            if (result.ContainsKey(s[i]))
            {
                result[s[i]]++;
            }
            else
            {
                result.Add(s[i], 1);
            }
        }
        int Temp = result.Values.FirstOrDefault();
        foreach(var x in result.Values)
        {
            if(x != Temp)
                return false;
        }
        return true;
    }
}