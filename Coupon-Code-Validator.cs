1public class Solution 
2{
3    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) 
4    {
5        List<string[]> MyList = new List<string[]>();
6        string[] categories = ["electronics", "grocery", "pharmacy", "restaurant"];
7        char[] ValidChars = 
8        [
9            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
10            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
11            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
12            '_'
13        ];
14        for(int i = 0; i < code.Length; i++)
15        {
16            if (isActive[i])
17            {
18                if (categories.Contains(businessLine[i]))
19                {
20                    if (code[i].Length > 0 && code[i].Except(ValidChars).Count() == 0)
21                    {
22                        MyList.Add([code[i], businessLine[i]]);
23                    }
24                }
25            }
26        }
27        // List<string> Result = MyList.OrderBy(X => X[1]).OrderBy(X => X[0]).Select(X => X[0]).ToList();
28        // List<string> Result = MyList.OrderBy(X => X[1]).ThenBy(X => X[0]).Select(X => X[0]).ToList();
29        List<string> Result = MyList.OrderBy(X => X[1]).ThenBy(X => X[0], StringComparer.Ordinal).Select(X => X[0]).ToList();
30
31        return Result;
32    }
33}