/*
Approach: 2 pointers
Written by @wingkwong

Runtime 90 ms, Beats 64.27%
Memory 39 MB, Beats 25.21%
Accepted: Jan 27, 2023 18:00
*/
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode slow = head;
        ListNode fast = head;
        // move fast pointer to the n+1 element
        // not the distance between slow and fast point is n nodes
        for (int i = 0; i < n; i++) fast = fast.next;
        // if fast reached the end, we need to remove the first element
        // e.g. head = [1], n=1
        if (fast == null) return head.next;
        // move both points at the same time until
        // the fast point reaches the end
        while(fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        // slow pointer will be pointing to the node before the one of be remove
        // then we update the next node of the the slow pointer
        slow.next = slow.next.next;
        return head;
    }
}


/*
My Solution

Runtime 85 ms, Beats 78.83%
Memory 39 MB, Beats 12.83%
Accepted: Jan 27, 2023 17:51
*/

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode result = null;
        ListNode next = null;
        var queue = new Queue<ListNode>();

        ListNode node = head;

        while(node != null)
        {
            queue.Enqueue(node);
            if(queue.Count > n)
            {
                if(result == null)
                {
                    result = queue.Dequeue();
                    next = result;
                }
                else
                {
                    next.next = queue.Dequeue();
                    next = next.next;
                }
            }
            node = node.next;

        }
        if (next != null) next.next = null;

        if (queue.Count > 0) queue.Dequeue();
        if (queue.Count > 0) {
            if(result == null)
                result = queue.Dequeue();
            else
                next.next = queue.Dequeue();
        }

        return result;
    }
}

