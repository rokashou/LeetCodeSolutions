/*
Runtime: 142 ms, faster than 18.85% of C# online submissions for Remove Duplicates from Sorted List.
Memory Usage: 38.2 MB, less than 55.78% of C# online submissions for Remove Duplicates from Sorted List.
Uploaded: 05/08/2022 23:11
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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        ListNode node = head;

        while(node.next != null)
        {
            if(node.next.val != node.val)
            {
                node = node.next;
            }
            else
            {
                node.next = node.next.next;
            }
        }

        return head;
    }
}
