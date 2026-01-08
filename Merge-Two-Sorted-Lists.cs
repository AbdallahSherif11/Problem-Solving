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
14    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
15    {
16        if(list1 == null)
17        {
18            return list2;
19        }
20        if(list2 == null)
21        {
22            return list1;
23        }
24
25        List<int> AllValues = new List<int>();
26        ListNode Temp = new ListNode(-1);
27        ListNode Current = Temp;
28
29
30        //AllValues.Add(list1.val);
31        //AllValues.Add(list2.val);
32
33        while (list1 != null)
34        {
35            AllValues.Add(list1.val);
36            list1 = list1.next;
37        }
38        while (list2 != null)
39        {
40            AllValues.Add(list2.val);
41            list2 = list2.next;
42        }
43        AllValues.Sort();
44        foreach(int i in AllValues)
45        {
46            Current.next = new ListNode(i);
47            Current = Current.next;
48        }
49
50
51        return Temp.next;
52    }
53}