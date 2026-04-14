1public class Solution 
2{
3    public string TrafficSignal(int timer) 
4    {
5        if(timer == 0)
6        {
7            return "Green";
8        }
9        else if (timer == 30)
10        {
11            return "Orange";
12        }
13        else if (timer > 30 && timer <= 90)
14        {
15            return "Red";
16        }
17
18        return "Invalid";
19    }
20}
