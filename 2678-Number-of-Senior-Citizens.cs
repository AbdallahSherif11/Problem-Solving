public class Solution 
{
    public int CountSeniors(string[] details) 
    {
        int Count = 0;
        for(int i = 0; i < details.Length; i++)
        {
            //string tempAge = $"{details[i][11]}{details[i][12]}";
            //if (int.Parse(tempAge) > 60)
            double temp = char.GetNumericValue(details[i][11]) * 10 + char.GetNumericValue(details[i][12]);
            if ( temp > 60)
            {
                Count++;
            }
        }

        return Count;
    }
}
