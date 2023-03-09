/*
Mar 09, 2023 19:51
Runtime 88 ms, Beats 82.98%
Memory 41.4 MB, Beats 33.30%
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
    public ListNode DetectCycle(ListNode head) {
        HashSet<ListNode> set = new HashSet<ListNode>();
        var node = head;
        while (node != null)
        {
            if (set.Contains(node)) return node;
            set.Add(node);
            node=node.next;
        }
        return null;

    }
}

