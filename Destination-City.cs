public class Solution 
{
    public string DestCity(IList<IList<string>> paths) 
    {
        bool c = false;
        for(int i = 0; i < paths.Count; i++)
        {
            for (int j = 0; j < paths.Count; j++)
            {
                if (paths[i][1] == paths[j][0])
                {
                    c = false;
                    break;
                }
                else
                {
                    c = true;
                }
            }
            if (c)
            {
                return paths[i][1];
            }
        }
        return "";
    }
}