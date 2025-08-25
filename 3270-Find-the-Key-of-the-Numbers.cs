public class Solution 
{
    public int GenerateKey(int num1, int num2, int num3) 
    {
        string Number1 = num1.ToString();
        string Number2 = num2.ToString();
        string Number3 = num3.ToString();
        string Result = "";
        while(Number1.Length < 4)
        {
            Number1 = "0" + Number1;
        }
        while (Number2.Length < 4)
        {
            Number2 = "0" + Number2;
        }
        while (Number3.Length < 4)
        {
            Number3 = "0" + Number3;
        }
        for(int i = 0; i < 4; i++)
        {
        var Temp =  Math.Min(int.Parse(Number1[i].ToString()), int.Parse(Number2[i].ToString()));
        var X = Math.Min(Temp, int.Parse(Number3[i].ToString()));
        Result += X.ToString();
        }


        return int.Parse(Result);
    }
}
