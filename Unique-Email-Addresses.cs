1public class Solution 
2{
3    public int NumUniqueEmails(string[] emails) 
4    {
5        int AtIndex = 0;
6        int PlusIndex = 0;
7        string Local = "";
8        string Domain = "";
9        string ActualEmail = "";
10
11        List<string> ActualEmails = new List<string>();
12        foreach (string email in emails)
13        {
14            AtIndex = email.IndexOf("@");
15            Local = email.Substring(0, AtIndex);
16            Domain = email.Substring(AtIndex + 1, email.Length - AtIndex - 1);
17
18            PlusIndex = Local.IndexOf("+");
19            if( PlusIndex != -1 )
20            {
21                Local = Local.Substring(0, PlusIndex);
22            }
23            Local = Local.Replace(".", "");
24            
25            ActualEmail = $"{Local}@{Domain}";
26            ActualEmails.Add(ActualEmail);
27
28        }
29
30        return ActualEmails.Distinct().Count();
31    }
32}