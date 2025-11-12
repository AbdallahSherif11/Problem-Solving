public class Solution 
{
    public int[] NumberOfLines(int[] widths, string s) 
    {
        int[] Result = new int[2];
        char letter = 'a';
        Dictionary<char,int> ink = new Dictionary<char,int>();

        foreach (int i in widths)
        {
            ink.Add(letter, i);
            letter++;
        }
        int Temp = 0;
        foreach(char X in s)
        {
            if(Temp + ink[X] > 100)
            {
                // Result[1] = ink[X];
                Result[0]++;
                Temp = ink[X];
            }
            else
            {
                Temp += ink[X];
            }
        }
        Result[1] = Temp;
        Result[0]++;


        return Result;
    }
}
