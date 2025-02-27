public class Solution 
{
    public int HammingWeight(int n) 
    {
    int Countones = 0;
    string NumberInBinarystring = Convert.ToString(n, 2);
       
    foreach (char c in NumberInBinarystring)
    {
        if(c == '1')
        {
            Countones++;
        }
    }
    return Countones;
    }
}