/*
Runtime: 139 ms, faster than 57.20% of C# online submissions for Linked List Cycle.
Memory Usage: 42.7 MB, less than 24.67% of C# online submissions for Linked List Cycle.
Uploaded: 03/09/2022 08:21
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null) return false;

        HashSet<ListNode> exist = new HashSet<ListNode>();
        ListNode current = head;
        while(current.next!=null && !exist.Contains(current)){
            exist.Add(current);
            current = current.next;
        }
        if(exist.Contains(current)) return true;

        return false;

    }
}

