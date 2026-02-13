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
16    public bool IsSameTree(TreeNode p, TreeNode q) 
17    {
18        if(p == null && q == null)
19        {
20            return true;
21        }
22        else if(p == null && q != null)
23        {
24            return false;
25        }
26        else if (q == null && p != null)
27        {
28            return false;
29        }
30        Stack<TreeNode> ToBeVisited1 = new Stack<TreeNode>();
31        ToBeVisited1.Push(p);
32        Stack<TreeNode> ToBeVisited2 = new Stack<TreeNode>();
33        ToBeVisited2.Push(q);
34
35        List<string> Path1 = new List<string>();
36        List<string> Path2 = new List<string>();
37        Path1.Add($"R{p.val}");
38        Path2.Add($"R{q.val}");
39
40        TreeNode Temp1;
41        TreeNode Temp2;
42        int i = 0;
43        int j = 0;
44
45        while(ToBeVisited1.Count > 0)
46        {
47            Temp1 = ToBeVisited1.Pop();
48
49            if(Temp1.left != null)
50            {
51                ToBeVisited1.Push(Temp1.left);
52                Path1.Add($"L{i}{Temp1.left.val}");
53            }
54            if (Temp1.right != null)
55            {
56                ToBeVisited1.Push(Temp1.right);
57                Path1.Add($"R{i}{Temp1.right.val}");
58            }
59            i++;
60        }
61
62        while (ToBeVisited2.Count > 0)
63        {
64            Temp2 = ToBeVisited2.Pop();
65
66            if (Temp2.left != null)
67            {
68                ToBeVisited2.Push(Temp2.left);
69                Path2.Add($"L{j}{Temp2.left.val}");
70            }
71            if (Temp2.right != null)
72            {
73                ToBeVisited2.Push(Temp2.right);
74                Path2.Add($"R{j}{Temp2.right.val}");
75            }
76            j++;
77        }
78        string conc1 = string.Join("",Path1);
79        string conc2 = string.Join("",Path2);
80
81        return conc1 == conc2;
82    }
83}