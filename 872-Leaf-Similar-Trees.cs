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
16    public bool LeafSimilar(TreeNode root1, TreeNode root2) 
17    {
18        bool Result = false;
19        //string First = "";
20        //string Second = "";
21        List<int> First = new List<int>();
22        List<int> Second = new List<int>();
23
24        Stack<TreeNode> ToBeVisited1 = new Stack<TreeNode>();
25        TreeNode Temp1 = new TreeNode();
26        ToBeVisited1.Push(root1);
27
28        Stack<TreeNode> ToBeVisited2 = new Stack<TreeNode>();
29        TreeNode Temp2 = new TreeNode();
30        ToBeVisited2.Push(root2);
31
32        while (ToBeVisited1.Count > 0)
33        {
34            Temp1 = ToBeVisited1.Pop();
35            if(Temp1.left == null && Temp1.right == null)
36            {
37                First.Add(Temp1.val);
38            }
39            else
40            {
41                if(Temp1.right != null)
42                {
43                    ToBeVisited1.Push(Temp1.right);
44                }
45                if (Temp1.left != null)
46                {
47                    ToBeVisited1.Push(Temp1.left);
48                }
49            }
50        }
51        while (ToBeVisited2.Count > 0)
52        {
53            Temp2 = ToBeVisited2.Pop();
54            if (Temp2.left == null && Temp2.right == null)
55            {
56                Second.Add(Temp2.val);
57            }
58            else
59            {
60                if (Temp2.right != null)
61                {
62                    ToBeVisited2.Push(Temp2.right);
63                }
64                if (Temp2.left != null)
65                {
66                    ToBeVisited2.Push(Temp2.left);
67                }
68            }
69        }
70        if(string.Join(',',First.ToArray()) == string.Join(',', Second.ToArray()))
71        {
72            Result = true;
73        }
74
75        return Result;
76    }
77}
