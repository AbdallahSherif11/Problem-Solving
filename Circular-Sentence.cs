1public class Solution 
2{
3    public bool IsCircularSentence(string sentence) 
4    {
5        bool Result = true;
6        string[] X = sentence.Split(' ');
7        int i = 0;
8        if(X.Length == 1)
9        {
10            return X[0][X[0].Length - 1] == X[0][0];
11        }
12
13        for(i = 0; i < X.Length - 1; i++)
14        {
15            if (X[i][X[i].Length-1] != X[i+1][0])
16            {
17                Result = false;
18                break;
19            }
20        }
21        if(Result && X[i][X[i].Length-1] != X[0][0])
22        {
23            Result = false;
24        }
25
26        return Result;
27    }
28}