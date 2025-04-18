public class Solution 
{
    public int[] MinOperations(string boxes) 
    {
        int[] Answers = new int[boxes.Length];

        for (int i = 0; i < boxes.Length; i++)
        {
            for (int j = 0; j < boxes.Length; j++)
            {
                if (j == i)
                    continue;
                if (boxes[j] == '1')
                    Answers[i] += Math.Abs(j-i);
            }
        }

        return Answers;
    }
}
