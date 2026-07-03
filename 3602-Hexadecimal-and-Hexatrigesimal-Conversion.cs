public class Solution 
{
    public string ConcatHex36(int n)
    {
        string result = "";

        //string HexaDecimalN = Convert.ToString(n*n, 16).ToUpper();
        string HexaDecimalN = ToBase(n *n, 16);
        //string HexatrigesimalN = Convert.ToString(n*n*n, 36);
        string HexatrigesimalN = ToBase(n*n*n, 36);

        result = $"{HexaDecimalN}{HexatrigesimalN}";

        return result;
    }
    public static string ToBase(int n , int Mybase)
    {
        string Result = "";
        string Alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        while (n > 0)
        {
            int Temp = n % Mybase;
            Result = $"{Alphabet[Temp]}{Result}";
            n /= Mybase;
        }

        return Result;
    }
}