public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        StringBuilder result = new StringBuilder();
        
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        int carry = 0;
        
        while (i >= 0 || j >= 0 || carry > 0)
        {
            int bitA = (i >= 0) ? a[i] - '0' : 0;
            int bitB = (j >= 0) ? b[j] - '0' : 0;
            
            int sum = bitA + bitB + carry;
            
            carry = sum / 2;
            
            result.Insert(0, sum % 2);
            
            i--;
            j--;
        }
        
        // Return the result as a string
        return result.ToString();
    }
}