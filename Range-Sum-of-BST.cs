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
16    public int RangeSumBST(TreeNode root, int low, int high) 
17    {
18        int Result = 0;
19        Stack<TreeNode> ToVisit = new Stack<TreeNode>();
20        ToVisit.Push(root);
21        TreeNode Temp;
22        int X = 0;
23        while (ToVisit.Count > 0)
24        {
25            X = ToVisit.Peek().val;
26            if (X >= low && X <= high)
27            {
28                Result += X;
29            }
30            Temp = ToVisit.Pop();
31            if(Temp.left != null)
32            {
33                ToVisit.Push(Temp.left);
34            }
35            if (Temp.right != null)
36            {
37                ToVisit.Push(Temp.right);
38            }
39        }
40
41        return Result;
42    }
43}