/*
May 16, 2023 23:03
Runtime 77 ms Beats 96.30%
Memory 38.6 MB Beats 12.50%
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (head == null || left == right) return head;

        ListNode cur = head, prev = null;
        while(left > 1)
        {
            prev = cur;
            cur = cur.next;
            left--;
            right--;
        }

        ListNode con = prev, tail = cur;

        ListNode third = null;
        while(right > 0)
        {
            third = cur.next;
            cur.next = prev;
            prev = cur;
            cur = third;
            right--;
        }

        if (con != null)
            con.next = prev;
        else
            head = prev;

        tail.next = cur;
        return head;
    }
}
