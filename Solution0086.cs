/*
May 10, 2023 15:34
Runtime 87 ms Beats 50.94%
Memory 39.4 MB Beats 13.21%
*/

public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode dummyHead = new ListNode();
        ListNode greaterHead = new ListNode();
        ListNode mainListNode=dummyHead, grListNode = greaterHead ;
        ListNode tmp = head;
        while(tmp != null)
        {
            if(tmp.val >= x)
            {
                grListNode.next = tmp;
                grListNode = grListNode.next;
            }
            else { 
                mainListNode.next = tmp;
                mainListNode = mainListNode.next;
            }
            tmp = tmp.next;
        }
        grListNode.next = null;
        mainListNode.next = greaterHead.next;
        return dummyHead.next;
   
    }
}
