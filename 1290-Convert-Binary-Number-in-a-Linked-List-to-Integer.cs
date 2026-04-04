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
14    public int GetDecimalValue(ListNode head) 
15    {
16        string Num = $"{head.val}";
17        while(head.next != null)
18        {
19            head = head.next;
20            Num = $"{Num}{head.val}";
21        }
22        return Convert.ToInt32(Num, 2);
23    }
24}
