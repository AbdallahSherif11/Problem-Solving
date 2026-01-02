1public class Solution 
2{
3    public string ReformatDate(string date) 
4    {
5        string Result = "";
6        int i = 1;
7        string[] Months = [ "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" ];
8        Dictionary<string,string> MonthsNum = new Dictionary<string, string>();
9        for (i = 1; i <= 12; i++)
10        {
11            if(i < 10)
12            {
13                MonthsNum.Add(Months[i - 1], $"0{i.ToString()}");
14            }
15            else
16            {
17                MonthsNum.Add(Months[i - 1], i.ToString());
18            }
19        }
20
21        if (char.IsDigit(date[1]))
22        {
23            Result = $"{date[9]}{date[10]}{date[11]}{date[12]}-{MonthsNum[$"{date[5]}{date[6]}{date[7]}"]}-{date[0]}{date[1]}";
24        }
25        else
26        {
27            Result = $"{date[8]}{date[9]}{date[10]}{date[11]}-{MonthsNum[$"{date[4]}{date[5]}{date[6]}"]}-0{date[0]}";
28        }
29
30        return Result;
31    }
32}