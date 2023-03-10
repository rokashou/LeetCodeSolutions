/*
Mar 10, 2023 20:08
Runtime 131 ms, Beats 72.73%
Memory 49.8 MB, Beats 9.9%
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
    ListNode head;
    int size;

    public Solution(ListNode head) {
        this.head = head;
        int i = 0;
        ListNode p = head;
        while (p!=null)
        {
            p = p.next;
            i++;
        }

        size = i;
    }
    
    public int GetRandom() {
        Random rand = new Random();
        int index = rand.Next(0, size);
        ListNode p = head;
        while (index>0)
        {
            index--;
            p=p.next;
        }
        return p.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */
 
 
