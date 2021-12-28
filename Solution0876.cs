/*
Approach 1: Brute Force with List
Uploaded: 12/28/2021 16:27
Runtime: 72 ms, faster than 97.65% of C# online submissions for Middle of the Linked List.
Memory Usage: 37.1 MB, less than 60.18% of C# online submissions for Middle of the Linked List.

Approach 2: Fast and Slow Pointer
Uploaded: 12/28/2021 16:32
Runtime: 80 ms, faster than 78.71% of C# online submissions for Middle of the Linked List.
Memory Usage: 37.1 MB, less than 60.18% of C# online submissions for Middle of the Linked List.
*/

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        // Approach 1: Brute Force with List
        /*
        List<ListNode> list = new List<ListNode>();
        while(head != null){
            list.Add(head);
            head = head.next;
        }
        return list[list.Count/2];
        */
        // Approach 2: Fast and Slow Pointer
        ListNode slow = head, fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;

    }
}

