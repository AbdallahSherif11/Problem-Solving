public class Solution 
{
    public bool IsSameAfterReversals(int num) 
    {
        string numString = num.ToString();
        char[] numArr = numString.ToCharArray();
        Array.Reverse(numArr);

        string numtemp = string.Concat(numArr);
        int num2 = int.Parse(numtemp);
        string num2string = num2.ToString();
        char[] num2Arr = num2string.ToCharArray();
        Array.Reverse(num2Arr);
        string numtemp2 = string.Concat(num2Arr);
        int last = int.Parse(numtemp2);

        if (last == num)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}