/*
Uploaded: 12/07/2021 22:11	
Runtime: 136 ms, faster than 13.43% of C# online submissions for Convert Binary Number in a Linked List to Integer.
Memory Usage: 36.1 MB, less than 79.10% of C# online submissions for Convert Binary Number in a Linked List to Integer.
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
    public int GetDecimalValue(ListNode head) {
        int result = head.val;
        while(head.next != null){
            head = head.next;
            result = (result << 1) | head.val;
        }
        return result;
    }
}
