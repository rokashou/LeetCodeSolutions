/*
    Runtime: 92 ms, faster than 95.77% of C# online submissions for Merge k Sorted Lists.
    Memory Usage: 42.8 MB, less than 7.69% of C# online submissions for Merge k Sorted Lists.
    Uploaded: 02/05/2022 20:12
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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if(lists.Length == 0) return null;

        var amount = lists.Length;
        int interval = 1;
        while(interval < amount){
            for (int i = 0; i < amount - interval; i+=interval*2){
                lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
            }
            interval *= 2;
        }

        return lists[0];
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;
        ListNode nd = head;
        while (list1 != null || list2 != null)
        {
            if (list1 == null)
            {
                if (head == null)
                {
                    head = new ListNode(list2.val, null);
                    nd = head;
                    list2 = list2.next;
                    continue;
                }
                nd.next = list2;
                break;
            }
            if (list2 == null)
            {
                if (head == null)
                {
                    head = new ListNode(list1.val, null);
                    nd = head;
                    list1 = list1.next;
                    continue;
                }
                nd.next = list1;
                break;
            }

            if (list1.val <= list2.val)
            {
                if (head == null)
                {
                    head = new ListNode(list1.val, null);
                    nd = head;
                    list1 = list1.next;
                    continue;
                }
                nd.next = list1;
                list1 = list1.next;

            }
            else
            {
                if (head == null)
                {
                    head = new ListNode(list2.val, null);
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

