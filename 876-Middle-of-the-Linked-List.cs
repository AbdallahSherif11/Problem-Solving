/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode MiddleNode(ListNode head) 
    {
        int TotalCount = 0;
        int CurrentCount = 0;
        ListNode node = head;
        while (node.next != null)
        {
            TotalCount++;
            node = node.next;
        }
        TotalCount++;

        if((TotalCount + 1) % 2 == 0)
        {
            CurrentCount++;
        }

        while (CurrentCount != ((TotalCount + 1) / 2))
        {
            head = head.next;
            CurrentCount++;
        }
        return head;
    }
}