1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
8 *         this.val = val;
9 *         this.left = left;
10 *         this.right = right;
11 *     }
12 * }
13 */
14public class Solution 
15{
16    public int SumRootToLeaf(TreeNode root) 
17    {
18        int Result = 0;
19
20        Stack<(TreeNode node, string path)> ToBeVisited = new Stack<(TreeNode , string)>();
21        ToBeVisited.Push((root, $"{root.val}"));
22        (TreeNode node, string path) Temp = ToBeVisited.Peek();
23        string TempPath = "";
24        List<string> AllRootToLeafsPath = new List<string>();
25
26        //List<(int x, char c)> Y = new List<(int, char)>();
27
28        while(ToBeVisited.Count > 0)
29        {
30            Temp = ToBeVisited.Pop();
31            TempPath = Temp.path;
32            if (Temp.node.right == null && Temp.node.left == null)
33            {
34                AllRootToLeafsPath.Add(TempPath);
35            }
36            else
37            {
38                if(Temp.node.left != null)
39                {
40                    ToBeVisited.Push((Temp.node.left, $"{TempPath}{Temp.node.left.val}"));
41                }
42                if(Temp.node.right != null)
43                {
44                    ToBeVisited.Push((Temp.node.right, $"{TempPath}{Temp.node.right.val}"));
45                }
46            }
47        }
48        foreach(string X in AllRootToLeafsPath)
49        {
50            Result += Convert.ToInt32(X, 2);
51        }
52
53        return Result;
54    }
55}