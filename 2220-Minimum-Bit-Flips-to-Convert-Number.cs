public class Solution 
{
    public int MinBitFlips(int start, int goal) 
    {
        int CountFlips = 0;
        string StartString = Convert.ToString(start, 2);
        string GoalString = Convert.ToString(goal, 2);
        if(start > goal)
        {
            while(StartString.Length != GoalString.Length)
            {
                GoalString = "0" + GoalString;
            }
        }
        else if (goal > start) 
        {
            while (StartString.Length != GoalString.Length)
            {
                StartString = "0" + StartString;
            }
        }
        for (int i = 0; i < StartString.Length; i++)
        {
            if(StartString[i] != GoalString[i])
            {
                CountFlips++;
            }
        }

        return CountFlips;
    }
}
