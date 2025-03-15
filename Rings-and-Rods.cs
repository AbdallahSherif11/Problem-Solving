public class Solution 
{
    public int CountPoints(string rings) 
    {
        int Count = 0;
        Dictionary<int, bool[]>  Rods = new Dictionary<int, bool[]>();
        for(int j = 0; j < 10; j++)
        {
            Rods.Add(j, [false, false, false]);
        }

        for(int i = 1; i < rings.Length; i += 2)
        {
            if (rings[i-1] == 'R')
            {
                Rods[(int)char.GetNumericValue(rings[i])][0] = true;
            }
            else if (rings[i-1] == 'G')
            {
                Rods[(int)char.GetNumericValue(rings[i])][1] = true;
            }
            else if (rings[i - 1] == 'B')
            {
                Rods[(int)char.GetNumericValue(rings[i])][2] = true;
            }
        }

        foreach(var x in Rods)
        {
            if (!x.Value.Contains(false))
            {
                Count++;
            }
        }

        return Count;
    }
}