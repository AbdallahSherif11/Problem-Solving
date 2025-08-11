public class Solution 
{
    public string SortString(string s)
    {
        string Result = "";
        List<char> Temp = new List<char>();
        char Y;
        char Z;
        while(s.Length > 0)
        {
            Temp = s.ToList();
            while (Temp.Count > 0)
            {
                Y = Temp.Min();
                Result += Y;
                s = s.Remove(s.IndexOf(Y), 1);
                Temp = Temp.Where(X => X != Y).ToList();
            }
            Temp = s.ToList();
            while (Temp.Count > 0)
            {
                Z = Temp.Max();
                Result += Z;
                s = s.Remove(s.IndexOf(Z), 1);
                Temp = Temp.Where(X => X != Z).ToList();
            }
        }
        

        return Result;
    }
}