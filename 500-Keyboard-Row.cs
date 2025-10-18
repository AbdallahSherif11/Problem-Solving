public class Solution 
{
    public string[] FindWords(string[] words) 
    {
        List<string> Result = new List<string>();
        List<string> Keyboard = new List<string>();
        Keyboard.Add("qwertyuiopQWERTYUIOP");
        Keyboard.Add("asdfghjklASDFGHJKL");
        Keyboard.Add("zxcvbnmZXCVBNM");

        foreach(var word in words)
        {
            bool Flag = false;
            foreach (var Temp in Keyboard)
            {
                Flag = false;
                for(int i = 0; i < word.Length; i++)
                {
                    if (!Temp.Contains(word[i]))
                    {
                        Flag = true;
                        break;
                    }
                }
                if (Flag == false)
                {
                    Result.Add(word);
                    break;
                }
            }
        }

        return Result.ToArray();
    }
}
