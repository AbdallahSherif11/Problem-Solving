public class Solution 
{
    public string FirstPalindrome(string[] words) 
    {
        string Result = "";

        for (int i = 0; i < words.Length; i++)
        {
            string Temp = "";
            for(int j = words[i].Length - 1; j >= 0; j--)
            {
                Temp += words[i][j];
            }
            if (Temp == words[i])
            {
                Result = Temp;
                break;
            }
        }

        return Result;
    }
}
