/*
Runtime: 842 ms, faster than 5.11% of C# online submissions for Merge Nodes in Between Zeros.
Memory Usage: 61.8 MB, less than 30.68% of C# online submissions for Merge Nodes in Between Zeros.
Uploaded: 05/28/2022 21:09
*/

public class Solution {
    public ListNode MergeNodes(ListNode head) {
        ListNode newHead = new ListNode();
        ListNode currNode = newHead;

        ListNode node = head;
        while(node != null)
        {
            if(node.val == 0 && node.next != null && currNode.val != 0)
            {
                currNode.next = new ListNode();
                currNode = currNode.next;
            }
            else
            {
                currNode.val += node.val;
            }
            node = node.next;
        }

        return newHead;
    }
}
