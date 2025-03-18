public class Solution 
{
    public int MinMovesToSeat(int[] seats, int[] students) 
    {
        int moves = 0;

        Array.Sort(seats);
        Array.Sort(students);

        for (int i = 0; i < seats.Length; i++)
        {
            int temp = Math.Abs(students[i] -  seats[i]);
            moves += temp;
        }

        return moves;
        }
}
