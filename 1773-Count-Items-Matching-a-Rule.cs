public class Solution 
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) 
    {
        int Count = 0;
        int index = 0;

        if (ruleKey == "type")
            index = 0;
        else if (ruleKey == "color")
            index = 1;
        else if (ruleKey == "name")
            index = 2;

        foreach (var item in items)
        {
            if (item[index] == ruleValue)
            {
                Count++;
            }
        }

        return Count;
    }
}
