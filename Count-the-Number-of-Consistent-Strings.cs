public class Solution 
{
    public int CountConsistentStrings(string allowed, string[] words) 
    {
        int CorrectWords = 0;
        bool Condition = true;

        for (int i = 0; i < words.Length; i++)
        {
            Condition = true;
            for (int j = 0; j < words[i].Length; j++)
            {
                for (int k = 0; k < allowed.Length; k++)
                {
                    if (words[i][j] != allowed[k])
                    {
                        Condition = false;
                    }
                    else
                    {
                        Condition = true;
                        break;
                    }
                }
                if (Condition == false)
                {
                    break;
                }
            }
            if (Condition == true)
            {
                CorrectWords++;
            }
        }

        return CorrectWords;
    }
}