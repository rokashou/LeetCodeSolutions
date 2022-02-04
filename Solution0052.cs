/*
Runtime: 101 ms, faster than 53.72% of C# online submissions for Merge Two Sorted Lists.
Memory Usage: 37.7 MB, less than 51.93% of C# online submissions for Merge Two Sorted Lists.
Uploaded: 02/04/2022 23:15
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = null;
        ListNode nd=head;
        while(list1 != null || list2 != null){
            if(list1 == null){
                if(head == null){
                    head = new ListNode(list2.val,null);
                    nd = head;
                    list2 = list2.next;
                    continue;
                }
                nd.next = list2;
                break;
            }
            if(list2 == null){
                if(head == null){
                    head = new ListNode(list1.val,null);
                    nd = head;
                    list1 = list1.next;
                    continue;
                }
                nd.next = list1;
                break;
            }

            if(list1.val <= list2.val){
                if(head == null){
                    head = new ListNode(list1.val,null);
                    nd = head;
                    list1 = list1.next;
                    continue;
                }
                nd.next = list1;
                list1 = list1.next;

            }else{
                if(head == null){
                    head = new ListNode(list2.val,null);
                    nd = head;
                    list2 = list2.next;
                    continue;
                }
                nd.next = list2;
                list2 = list2.next;
            }

            nd = nd.next;
        }
        return head;


    }
}
