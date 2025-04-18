public class Solution 
{
    public string ReverseWords(string s) 
    {
        string[] Arr = s.Split(' ');
        for (int i = 0; i < Arr.Length; i++)
        {
            char[] Temp = Arr[i].ToCharArray();
            Array.Reverse(Temp);
            Arr[i] = string.Concat(Temp);
        }
        return string.Join(" ", Arr);
    }
}
