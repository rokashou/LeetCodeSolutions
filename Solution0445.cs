



/*
My Solution
Jul 17, 2023 22:36
Runtime 99 ms Beats 61.32%
Memory 49.7 MB Beats 74.53%
*/

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1.val == 0) return l2;
        if (l2.val == 0) return l1;

        int n1 = LengthOfListNode(l1);
        int n2 = LengthOfListNode(l2);

        int maxLen = Math.Max(n1, n2);
        var nList = new int[maxLen + 2];
        Array.Fill(nList, 0);

        for(int i = 0; i <= maxLen; i++) {
            if(l1 != null) { 
                nList[n1 - i - 1] += l1.val;
                l1 = l1.next;
            }
            if(l2 != null) { 
                nList[n2 - i - 1] += l2.val;
                l2 = l2.next;
            }
        }

        ListNode node=null;
        for (int i = 0; i <= maxLen; i++) {
            if (nList[i] > 9) {
                nList[i + 1] += 1;
                nList[i] -= 10;
            }
            if (node != null)
                node = new ListNode(nList[i], node);
            else
                node = new ListNode(nList[i]);
        }

        if (nList[maxLen + 1] != 0)
            node = new ListNode(nList[maxLen + 1], node);

        // trim leading 0
        while(node.val == 0) {
            node = node.next;
        }

        return node;
    }

    private int LengthOfListNode(ListNode ln) {
        int len = 0;
        var node = ln;
        while(node != null) {
            len++;
            node = node.next;
        }
        return len;
    }
}
