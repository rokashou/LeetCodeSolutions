/*
Url: https://leetcode.com/problems/reorder-list/
Uploaded: 12/22/2021 21:32
Runtime: 84 ms, faster than 98.72% of C# online submissions for Reorder List.
Memory Usage: 42 MB, less than 30.77% of C# online submissions for Reorder List.

ref: Two pointer approach[referred as Tortoise and hare method]
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
    public void ReorderList(ListNode head) {
        // base case : linkedlist is empty
        if(head == null) return;

        // finding the middle with the help of two pointer approach
        ListNode tmp = head, half = head, prev = null;
        while(tmp.next != null && tmp.next.next != null){
            tmp = tmp.next.next;
            half = half.next;
        }

        // adding one bit in case of lists with even length
        if(tmp.next != null) half = half.next;

        // now reverse the second half
        while(half != null){
            tmp = half.next;
            half.next = prev;
            prev = half;
            half = tmp;
        }
        half = prev;

        // After eversing the second half, let's merge both the halfes
        while(head != null && half != null){
            tmp = head.next;
            prev = half.next;
            head.next = half;
            half.next = tmp;
            head = tmp;
            half = prev;
        }

        // Base case : closing when we had even length arrays
        if(head != null && head.next != null){
            head.next.next = null;
        }
    }
}
