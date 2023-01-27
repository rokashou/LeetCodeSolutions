/*
Runtime 114 ms, Beats 33.3%
Memory 36.7 MB, Beats 90.2%
Accepted: Jan 27, 2023 20:59
*/


public class Solution {
    public ListNode SwapPairs(ListNode head)
    {
        ListNode lead = new ListNode();
        lead.next = head;
        ListNode n0 = lead;
        while(n0.next != null && n0.next.next != null)
        {
            var n1 = n0.next;
            var n2 = n1.next;
            n0.next = n2;
            n1.next = n2.next;
            n2.next = n1;

            n0 = n1;
        }
        return lead.next;
    }
}

