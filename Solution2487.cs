/*
Runtime 471 ms Beats 15.49% of users with C#
Memory 102.64 MB Beats 77.46% of users with C#
*/

public class Solution2487_1 { // Stack
    public ListNode RemoveNodes(ListNode head)
    {
        Stack<ListNode> stack = new();
        ListNode current = head;
        while(current != null){
            stack.Push(current);
            current = current.next;
        }
        current = stack.Pop();
        int maximum = current.val;
        ListNode resultList = new ListNode(maximum);
        while(stack.Count > 0){
            current = stack.Pop();
            if (current.val < maximum) continue;

            ListNode newNode = new ListNode(current.val);
            newNode.next = resultList;
            resultList = newNode;
            maximum = current.val;
        }
        return resultList;
    }
}

/*
Runtime 455 ms Beats 40.84% of users with C#
Memory 108.06 MB Beats 46.48% of users with C#
*/

public class Solution2487_2{ // Recursion
    public ListNode RemoveNodes(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode nextNode = RemoveNodes(head.next);
        if (head.val < nextNode.val)
            return nextNode;
        head.next = nextNode;
        return head;
    }
}

/*
Runtime 427 ms Beats 90.14% of users with C#
Memory 102.47 MB Beats 77.46% of users with C#
*/

public class Solution2487_3{ // Reverse List
    private ListNode ReverseList(ListNode head) {
        ListNode prev = null, current = head, nextTemp = null;
        while(current != null){
            nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }
        return prev;
    }

    public ListNode RemoveNodes(ListNode head)
    {
        ListNode newHead = ReverseList(head);
        head = newHead;
        int maximum = 0;
        ListNode prev = null, current = head;
        while(current != null){
            maximum = Math.Max(maximum, current.val);
            if(current.val < maximum){
                prev.next = current.next;
                ListNode deleted = current;
                current = current.next;
                deleted.next = null;
            }
            else{
                prev = current;
                current = current.next;
            }
        }
        return ReverseList(head);
    }
}
