/*
Uploaded: 11/12/2021 23:47
Runtime: 84 ms, faster than 97.80% of C# online submissions for Remove Linked List Elements.
Memory Usage: 41.1 MB, less than 14.43% of C# online submissions for Remove Linked List Elements.
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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null) return head;
        ListNode nhead = head;
        while(nhead != null && nhead.val == val){
            nhead = nhead.next;
        }
        ListNode nc = nhead;
        // find first 
        while(nc != null){
            while(nc.next != null && nc.next.val == val){
                nc.next = nc.next.next;
            }
            nc = nc.next;
        }
        return nhead;
    }

}
