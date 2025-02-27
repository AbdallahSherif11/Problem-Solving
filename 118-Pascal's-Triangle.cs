public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        IList < IList<int> > Triangle1 = new List<IList<int>>();
        for (int n = 0; n < numRows; n++)
        {
            List<int> Row = new List<int>();

            for (int i = 0; i < n+1; i++)
            {
                if ((i == 0) || (i == ((n+1) - 1)))
                {
                    Row.Add(1);
                }
                else
                {
                    //Triangle1[n - 1][i-1] + Triangle1[n - 1][i]
                    Row.Add(Triangle1[n - 1][i - 1] + Triangle1[n - 1][i]);
                }
            }
            Triangle1.Add(Row);
        }

        return Triangle1;
    }
}