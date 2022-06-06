/*
Runtime: 130 ms, faster than 78.80% of C# online submissions for Intersection of Two Linked Lists.
Memory Usage: 51.8 MB, less than 16.67% of C# online submissions for Intersection of Two Linked Lists.
Uploaded: 06/06/2022 21:46
*/

public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int lenA = length(headA), lenB = length(headB);
        while(lenA > lenB)
        {
            headA = headA.next;
            lenA--;
        }
        while(lenA < lenB)
        {
            headB = headB.next;
            lenB--;
        }
        while(headA != headB)
        {
            headA = headA.next;
            headB = headB.next;
        }
        return headA;
    }

    private int length(ListNode node) {
        int length = 0;
        while(node != null)
        {
            node = node.next;
            length++;
        }
        return length;
    }
}
