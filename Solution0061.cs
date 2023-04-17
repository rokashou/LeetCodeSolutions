/*
Apr 17, 2023 22:01
Runtime 90 ms Beats 45.66%
Memory 39.3 MB Beats 61.56%
*/


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
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null) return head;
        var dummy = new ListNode(0);
        dummy.next = head;
        ListNode fast = dummy, slow = dummy;

        // Get the total length
        int len;
        for (len = 0; fast.next != null; len++) fast = fast.next;

        // Get the (len - k%len) node
        for (int j = len - k % len; j > 0; j--)
            slow = slow.next;

        fast.next = dummy.next;
        dummy.next = slow.next;
        slow.next = null;

        return dummy.next;     
    }
}
