1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int x) { val = x; }
8 * }
9 */
10
11public class Solution 
12{
13    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) 
14    {
15        Stack<TreeNode> ToVisit = new Stack<TreeNode>();
16        ToVisit.Push(cloned);
17        while(ToVisit.Count > 0)
18        {
19            if(ToVisit.Peek().val == target.val)
20            {
21                return ToVisit.Pop();
22            }
23            TreeNode X = ToVisit.Pop();
24            if (X.right != null)
25            {
26                ToVisit.Push(X.right);
27            }
28            if (X.left != null)
29            {
30                ToVisit.Push(X.left);
31            }
32        }
33        return ToVisit.Pop();
34    }
35}