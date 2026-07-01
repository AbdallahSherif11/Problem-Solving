1/**
2 * Definition for singly-linked list.
3 * public class ListNode {
4 *     public int val;
5 *     public ListNode next;
6 *     public ListNode(int val=0, ListNode next=null) {
7 *         this.val = val;
8 *         this.next = next;
9 *     }
10 * }
11 */
12public class Solution 
13{
14    public ListNode InsertGreatestCommonDivisors(ListNode head) 
15    {
16        ListNode Result = new ListNode(head.val);
17        ListNode tempnode = Result;
18        int temp = 1;
19        while(head?.next != null)
20        {
21            if (head.val >= head.next.val)
22            {
23                temp = head.next.val;
24                while (temp >= 1)
25                {
26                    if(head.next.val % temp == 0 && head.val % temp == 0)
27                    {
28                        tempnode.next = new ListNode(temp);
29                        tempnode.next.next = new ListNode(head.next.val);
30                        break;
31                    }
32                    temp--;
33                }
34                
35            }
36            else
37            {
38                temp = head.val;
39                while (temp >= 1)
40                {
41                    if (head.next.val % temp == 0 && head.val % temp == 0)
42                    {
43                        tempnode.next = new ListNode(temp);
44                        tempnode.next.next = new ListNode(head.next.val);
45                        break;
46                    }
47                    temp--;
48                }
49            }
50
51            head = head.next;
52            tempnode = tempnode.next;
53            tempnode = tempnode.next;
54        }
55
56
57        return Result;
58    }
59}
