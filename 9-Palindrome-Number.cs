public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        if(x < 0)
        {
            return false;
        }
        else
        {
            int Temp = x;
            int Reverse = 0;
            while(Temp != 0)
            {
                Reverse = Reverse * 10 + Temp % 10;
                Temp /= 10;
            }
            return (Reverse == x);
        }
    }
}