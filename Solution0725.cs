/*
Sep 06, 2023 21:00
Runtime 128 ms Beats 61.54%
Memory 44.2 MB Beats 7.69%
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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var result = new ListNode[k];
        var countList = new int[k];
        int i = 0;
        var node = head;
        while(node != null)
        {
            node = node.next;
            countList[i]++;
            i = (i + 1) % k;
        }

        node = head;
        for (i = 0; i < k; i++)
        {
            ListNode lst = result[i];
            while (countList[i] > 0)
            {
                
                if (lst == null)
                {
                    result[i] = new ListNode(node.val);
                    lst = result[i];
                }
                else
                {
                    lst.next = new ListNode(node.val);
                    lst = lst.next;
                }
                countList[i]--;
                node = node.next;

            }
        }

        return result;
    }
}
