/*
Runtime 86 ms, Beats 89.52%
Memory 41.2 MB, Beats 8.38%
Accepted: Feb 03, 2023 20:37
*/

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummyHead = new ListNode();
        ListNode node = head;
        var st = new Stack<ListNode>();
        for(int i = 0; i < k; i++)
        {
            if (node == null) return head;
            st.Push(node);
            node = node.next;
        }
        dummyHead.next = st.Pop();
        ListNode nextTmp = dummyHead.next;
        while(st.Count > 0)
        {
            nextTmp.next = st.Pop();
            nextTmp = nextTmp.next;
        }
        nextTmp.next = ReverseKGroup(node, k);
        return dummyHead.next;
    }
}
