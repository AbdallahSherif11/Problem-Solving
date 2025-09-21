public class Solution 
{
    public IList<string> CommonChars(string[] words) 
    {
        List<string> Result = new List<string>();
        List<string> Words = words.ToList();

        List<List<char>> Chars = new List<List<char>>();
        
        foreach (string word in Words)
        {
            Chars.Add(word.ToList());
        }

        if(Chars.Count > 1)
        {
            for (int z = 0; z < Chars[0].Count; z++)
            {
                for (int i = 1; i < Chars.Count; i++)
                {
                    if (!Chars[i].Contains(Chars[0][z]))
                    {
                        foreach(List<char> w in Chars)
                        {
                            char Temp = Chars[0][z];
                            var j = w.FindIndex(X => X == Temp);
                            if(j >= 0)
                            {
                                w[j] = '0';
                            }
                        }
                    }
                    else
                    {
                        if (i == Chars.Count - 1)
                        {
                            if (Chars[0][z] != '0')
                            {
                                Result.Add(Chars[0][z].ToString());
                                char Temp = Chars[0][z];
                                foreach (List<char> w in Chars)
                                {
                                    var j = w.FindIndex(X => X == Temp);
                                    if (j >= 0)
                                    {
                                        w[j] = '0';
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            foreach (char C in Chars[0])
            Result.Add(C.ToString());
        }


        return Result;
    }
}
