1public class Solution 
2{
3    public string LargestGoodInteger(string num) 
4    {
5        string Result = "";
6
7        string[] arr = ["999", "888", "777", "666", "555", "444", "333", "222", "111", "000"];
8
9        for(int i  = 0; i < arr.Length; i++)
10        {
11            if (num.Contains(arr[i]))
12            {
13                Result = arr[i];
14                break;
15            }
16        }
17
18        return Result;
19    }
20}