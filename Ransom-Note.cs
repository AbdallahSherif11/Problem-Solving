1public class Solution 
2{
3    public bool CanConstruct(string ransomNote, string magazine) 
4    {
5        char[] ransomNoteArr = ransomNote.ToCharArray();
6        char[] magazineArr = magazine.ToCharArray();
7
8        Array.Sort(ransomNoteArr);
9
10        for(int i = 0; i < ransomNoteArr.Length; i++)
11        {
12            if(ransomNoteArr.Count(X=> X == ransomNoteArr[i]) > magazineArr.Count(X => X == ransomNoteArr[i]))
13            {
14                return false;
15            }
16        }
17        
18
19        return true;
20    }
21}