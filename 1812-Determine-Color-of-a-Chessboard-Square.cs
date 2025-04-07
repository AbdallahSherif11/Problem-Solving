public class Solution 
{
    public bool SquareIsWhite(string coordinates) 
    {
        if ((("aceg".Contains(coordinates[0])) && (char.GetNumericValue(coordinates[1]) % 2 != 0)) 
            || 
            (("bdfh".Contains(coordinates[0])) && (char.GetNumericValue(coordinates[1]) % 2 == 0)))
        {
            return false;
        }
        return true;
    }
}
