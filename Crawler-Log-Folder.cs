public class Solution 
{
    public int MinOperations(string[] logs) 
    {
        int Result = 0;
        for(int i = 0; i < logs.Length; i++)
        {
            if(logs[i] == "../" && Result > 0)
            {
                Result--;
            }
            else if (logs[i] == "./")
            {

            }
            else
            {
                if((i == 0 && logs[i][1] != '.') || (i > 0 && logs[i][1] != '.'))
                {
                    Result++;
                }
            }
        }
        return Result;
    }
}