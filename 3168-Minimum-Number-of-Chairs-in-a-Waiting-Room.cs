public class Solution {
    public int MinimumChairs(string s) 
    {
        int AvailableChairs = 0;
        int AllChairs = 0;
        int Max = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'E')
            {

                if (AvailableChairs > 0)
                {
                    AvailableChairs--;
                }
                else if (AvailableChairs == 0)
                {
                    AllChairs++;
                }
                if (AllChairs > Max)
                {
                    Max = AllChairs;
                }
            }
            else if (s[i] == 'L')
            {
                AvailableChairs++;
            }
        }
        return Max;
    }
}
