/*
May 15, 2023 21:07
Runtime 262 ms Beats 73.26%
Memory 60.3 MB Beats 73.26%
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
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode n1 = head;
        ListNode n2 = head;
        int count = 0;
        int swapCount = 0;
        int m = k - 1;

        // find the first node and count the length
        while (n2 != null)
        {
            count++;
            n2 = n2.next;
            if (m > 0)
            {
                n1 = n1.next;
                m--;
            }
        }

        // calculate and loops to the 2nd node
        n2 = head;
        swapCount = count - k;
        while(swapCount > 0)
        {
            n2 = n2.next;
            swapCount--;
        }

        // swap val between 2 nodes
        int tmpValue = n2.val;
        n2.val = n1.val;
        n1.val = tmpValue;

        return head;   
    }
}
