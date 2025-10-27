public class Solution 
{
    public int SplitNum(int num) 
    {
        int Result = 0;

        char[] Number = num.ToString().ToArray();
        string Num1 = "";
        string Num2 = "";

        Array.Sort(Number);
        for(int i = 0; i < Number.Length;i++)
        {
            if (i % 2 == 0)
            {
                Num1 += Number[i];
            }
            else
            {
                Num2 += Number[i];
            }
        }
        Result = int.Parse(Num1) + int.Parse(Num2);

        return Result;
    }
}
