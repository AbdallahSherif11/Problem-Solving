1public class Solution 
2{
3    public int FurthestDistanceFromOrigin(string moves) 
4    {
5        int Result = 0;
6        int CountR = moves.Count(X => X == 'R');
7        int CountL = moves.Count(X => X == 'L');
8        int Count_ = moves.Count(X => X == '_');
9
10        if(CountR >= CountL)
11        {
12            Result = CountR + Count_ - CountL;
13        }
14        else
15        {
16            Result = CountL + Count_ - CountR;
17        }
18
19        return Result;
20    }
21}
