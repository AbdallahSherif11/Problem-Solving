public class Solution 
{
    public int MinCostToMoveChips(int[] position) 
    {
        int Even = position.Where(X => X % 2  == 0).Count();
        int Odd = position.Where(X => X % 2 != 0).Count();

        return Math.Min(Even,Odd);
    }
}
