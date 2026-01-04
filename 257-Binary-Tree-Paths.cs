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
16    public IList<string> BinaryTreePaths(TreeNode root) 
17    {
18        List<string> Result = new List<string>();
19        if (root == null) return Result;
20
21        Stack<(TreeNode node, List<int> path)> ToBeVisited = new Stack<(TreeNode, List<int>)>();
22
23        ToBeVisited.Push((root, new List<int> { root.val }));
24
25        while (ToBeVisited.Count > 0)
26        {
27            var current = ToBeVisited.Pop();
28            TreeNode Temp1 = current.node;
29            List<int> PreviousBranch = current.path;
30
31            if (Temp1.left == null && Temp1.right == null)
32            {
33                Result.Add(string.Join("->", PreviousBranch));
34            }
35            else
36            {
37                if (Temp1.right != null)
38                {
39                    var rightPath = new List<int>(PreviousBranch); 
40                    rightPath.Add(Temp1.right.val);
41                    ToBeVisited.Push((Temp1.right, rightPath));
42                }
43                if (Temp1.left != null)
44                {
45                    var leftPath = new List<int>(PreviousBranch); 
46                    leftPath.Add(Temp1.left.val);
47                    ToBeVisited.Push((Temp1.left, leftPath));
48                }
49            }
50        }
51
52        return Result;
53    }
54}
