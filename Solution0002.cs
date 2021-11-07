/**
 Uploaded: 10/03/2021 16:14
 Runtime: 100 ms, 74.10%
 Memory Usage: 28.3 MB, 79.99%
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int[] resultValue = new int[100];

        int count = 0;

        ListNode result = null;

        while (true)
        {
            if (l1 != null)
            {
                resultValue[count] += l1.val;
                l1 = l1.next;
            }
            if (l2 != null) { 
                resultValue[count] += l2.val;
                l2 = l2.next;
            }

            if (resultValue[count] > 9)
            {
                resultValue[count + 1] = resultValue[count] / 10;
                resultValue[count] = resultValue[count] % 10;
            }

            count++;

            if (l1 == null && l2 == null)
            {
                if(resultValue[count] > 0) count++;
                break;
            }
        }

        for(int index = count-1; index >= 0; index--)
        {
            result = new ListNode(resultValue[index], result);
        }

        return result;
    }
}
