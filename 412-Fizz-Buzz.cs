public class Solution 
{
    public IList<string> FizzBuzz(int n) 
    {
        IList<string> ArrFizzBuzz = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 != 0)
            {
                ArrFizzBuzz.Add("Fizz");
            }
            else if(i % 5 == 0 && i % 3 != 0)
            {
                ArrFizzBuzz.Add("Buzz");
            }
            else if (i % 5 == 0 && i % 3 == 0)
            {
                ArrFizzBuzz.Add("FizzBuzz");
            }
            else
            {
                ArrFizzBuzz.Add($"{i}");
            }
        }
        return ArrFizzBuzz;
        }
}