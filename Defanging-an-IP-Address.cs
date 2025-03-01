public class Solution 
{
    public string DefangIPaddr(string address) 
    {
        string DefangedIP;
        List<string> list = new List<string>();
        for(int i = 0; i < address.Length; i++)
        {
            if (address[i] == '.')
            {
                list.Add("[.]");
            }
            else
            {
                list.Add($"{address[i]}");
            }
        }
        DefangedIP = string.Concat(list.ToArray());

        return DefangedIP;
    }
}