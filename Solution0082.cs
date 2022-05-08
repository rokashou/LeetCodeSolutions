/*
Runtime: 88 ms, faster than 83.26% of C# online submissions for Remove Duplicates from Sorted List II.
Memory Usage: 39.9 MB, less than 17.25% of C# online submissions for Remove Duplicates from Sorted List II.
Uploaded: 05/09/2022 01:04
*/


public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        // sentinel
        ListNode sentinel = new ListNode(0, head);

        // predecessor = the last node
        // before the sublist of duplicates
        ListNode pred = sentinel;

        while(head != null) {
            // if it's beginning of duplicates sublist
            // skip all duplicates
            if(head.next != null && head.val == head.next.val)
            {
                // move till the end of duplicates sublist
                while(head.next != null && head.val == head.next.val)
                {
                    head = head.next;
                }
                // skip all duplicates
                pred.next = head.next;
            }
            else
            {
                // otherwise, move predecessor
                pred = pred.next;
            }

            // move forward
            head = head.next;

        }
        return sentinel.next;
    }
}


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
 
